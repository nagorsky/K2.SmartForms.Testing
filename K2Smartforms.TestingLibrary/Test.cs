using Excel;
using log4net;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.Text.RegularExpressions;

namespace K2Smartforms.TestingLibrary
{
    public class testSuite
    {

        public static FirefoxProfileManager profileManager = new FirefoxProfileManager();
        public static FirefoxProfile profile; //profileManager.GetProfile("selenium");
        //public static FirefoxProfile profile = profileManager.GetProfile("spsadmin2010");

        public static FirefoxDriver driver;  //= new FirefoxDriver(profile);

        //public static InternetExplorerDriver driver = new InternetExplorerDriver();

        private static readonly ILog logger = LogManager.GetLogger("K2Smartforms.TestingLibrary");


        public static Dictionary<string, string> scanarioOutputBuffer = new Dictionary<string, string>();

        public testSuite(string config)
        {



            this.config = config;

            XmlSerializer serializer = new XmlSerializer(typeof(Tests));

            // Declare an object variable of the type to be deserialized.
            Tests i;

            using (Stream reader = new FileStream(String.Format(@"{0}\..\..\..\Test\{1}\Main.xml", Helper.getCurrFolderPath(), config), FileMode.Open))
            {
                // Call the Deserialize method to restore the object's state.
                i = (Tests)serializer.Deserialize(reader);
            }


            tests = i;

            foreach (var test in tests.Test)
            {

                XmlSerializer serializer1 = new XmlSerializer(typeof(TestDef));

                // Declare an object variable of the type to be deserialized.
                TestDef b;

                using (Stream reader = new FileStream(String.Format(@"{0}\..\..\..\Test\{1}\{2}.xml", Helper.getCurrFolderPath(), config, test.fileName), FileMode.Open))
                {
                    // Call the Deserialize method to restore the object's state.
                    b = (TestDef)serializer1.Deserialize(reader);
                    testCollection.Add(test.fileName, b);

                }


            }



        }


        private static string replaceBufferPlaceholder(string input)
        {

            if (!input.Contains("{Buffer")) return input;

            string pattern = "{Buffer:(.+?)}";

            var matchCollection = Regex.Matches(input, pattern);

            foreach (Match m in Regex.Matches(input, pattern))
            {
                input = input.Replace(m.Value, scanarioOutputBuffer[m.Groups[1].Value]);
            }


            return input;

        }


        public void Run(string testName)
        {

            var testArray = from x in tests.Test where x.fileName == testName && x.testEnabled == "True" select x;

            foreach (var test in testArray)
            {
                RunTest(test.fileName);
            }


        }

        public void RunActivity(TestDefActivity activity)
        {
            profile = profileManager.GetProfile(activity.runAsUser.Split(new Char[] { '\\' })[1]);  // corp\nagorskiy берем nagorskiy
            driver = new FirefoxDriver(profile);

            DataSet mainDS = loadDataSetFromExcelFile(String.Format(@"{0}\..\..\..\Test\{1}\Activities\{2}.xlsx", Helper.getCurrFolderPath(), config, activity.fileName));
            settings.dictionary.Clear();

            foreach (DataRow dr in mainDS.Tables["Settings"].Rows)
            {
                if ((String.IsNullOrEmpty(dr[0].ToString()))) continue;

                if (dr[0].ToString() == "BaseUrl") settings.baseUrl = dr[1].ToString();
                if (dr[0].ToString() == "ScreenshotMode") settings.screenshotMode = dr[1].ToString();
                if (dr[0].ToString() == "ScreenshotFolder") settings.screenshotFolder = dr[1].ToString();
                if (dr[0].ToString() == "IgnoreErrorMode") settings.ignoreErrorMode = dr[1].ToString();
                if (dr[0].ToString() == "Speed") settings.speed = dr[1].ToString();
                if (dr[0].ToString() == "DelayBetweenStepsSec") settings.delayBetweenStepsSec = Int32.Parse(dr[1].ToString());

                settings.dictionary.Add(dr[0].ToString().Trim(), dr[1].ToString().Trim());
            }

            List<ScenarioStep> scenario = new List<ScenarioStep>();
            scenario = loadScenarionSteps(String.Format(@"{0}\..\..\..\Test\{1}\Activities\{2}.xlsx", Helper.getCurrFolderPath(), config, activity.fileName), scenario, settings);




            foreach (ScenarioStep scenStep in scenario)
            {

                try
                {
                    System.Threading.Thread.Sleep(settings.delayBetweenStepsSec * 1000);
                    string res = runTestStep(scenStep, settings);

                    //if (settings.screenshotMode == "Fullscreen") createFullScreenshot(Helper.AppFolderCreator(settings.screenshotFolder));
                    if (settings.screenshotMode == "BrowserWindow") createBrowserScreenshot(driver, Helper.AppFolderCreator(settings.screenshotFolder));




                }
                catch (Exception ex)
                {
                    logger.Error(ex);

                    string element = findMyElement("css", "html").GetAttribute("innerHTML");


                    Console.WriteLine(ex.ToString());
                    throw ex;
                }
            }

        }
        public void RunTest(string testName)
        {



            TestDefActivity[] testDefActivity = testCollection[testName].Activity;
            testDefActivity = (from act in testDefActivity
                              where act.enabled == "True"
                              select act).ToArray();

            foreach (var activity in testDefActivity)
            {
                RunActivity(activity);
            }



        }


        // TODO:  Переделать открытие браузера. Не при запуске консоли, а отдельным шагом OpenBrowser из сценария тестирования
        // TODO:  Возможность управлять типом браузера - IE, FF, Chrome
        // TODO:  При работе в FF нужно отключить запрос пароля на Смартформсах
        // TODO:  Логирование действий и ошибок.  
        // TODO:  Отчет о прохождении теста
        // TODO:  Возможность управлять воспроизведением теста - пауза, начать с X шага и т.д.





        public static void WaitForAjaxIndicatorDisappeared(IWebDriver driver, int timeoutSecs = 30, bool throwException = false)
        {
            logger.Debug("WaitForAjax begin");

            var jQueryIsLoaded = (bool)(driver as IJavaScriptExecutor).ExecuteScript("return (typeof jQuery != \'undefined\')  ");
            if (!jQueryIsLoaded) return;


            for (var i = 0; i < timeoutSecs; i++)
            {
                var ajaxIsComplete = (bool)(driver as IJavaScriptExecutor).ExecuteScript("return ( $(\".ajaxLoader\" ).size() == 0) ");
                if (ajaxIsComplete) return;
                logger.Debug("WaitForAjax sleep");
                Thread.Sleep(1000);
            }
            if (throwException)
            {
                throw new Exception("WebDriver timed out waiting for AJAX call to complete");
            }
        }



        public static void setAttributeValue(IWebElement elem, String attribute, String value)
        {
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;

            String scriptSetAttrValue = "arguments[0].setAttribute(arguments[1],arguments[2])";

            js.ExecuteScript(scriptSetAttrValue, elem, attribute, value);

        }

        public static IWebElement findMyElement(String attribute, String attrval)
        {


            switch (attribute.ToLower())
            {
                case "id":
                    return driver.FindElement(By.Id(attrval));
                case "name":
                    return driver.FindElement(By.Name(attrval));
                case "xpath":
                    return driver.FindElement(By.XPath(attrval));
                case "css":
                    return driver.FindElement(By.CssSelector(attrval));
                case "link":
                    return driver.FindElement(By.LinkText(attrval));

                case "jquery":
                    {
                        IJavaScriptExecutor js = driver as IJavaScriptExecutor;
                        //string title = (string)js.ExecuteScript("return document.title");

                        //return (IWebElement)js.ExecuteScript("return jQuery.find(\"" + attrval + "\");");

                        IEnumerable<object> matchedItems =
               (IEnumerable<object>)js.ExecuteScript("return jQuery.find(\"" + attrval + "\");");

                        return (IWebElement)(matchedItems.Cast<IWebElement>().ToList().First());

                    }
                case "jqueryx":
                    {
                        IJavaScriptExecutor js = driver as IJavaScriptExecutor;
                        //string title = (string)js.ExecuteScript("return document.title");

                        //return (IWebElement)js.ExecuteScript("return jQuery.find(\"" + attrval + "\");");

                        IEnumerable<object> matchedItems =
               (IEnumerable<object>)js.ExecuteScript("return jQuery.find(\"" + attrval + "\");");

                        return (IWebElement)(matchedItems.Cast<IWebElement>().ToList().First());

                    }
                case "sfcontrolname":
                    {

                        IJavaScriptExecutor js = driver as IJavaScriptExecutor;

                        //var xx = js.ExecuteScript("return viewControllerDefinition.selectSingleNode(\"//Controls/Control[@Name='" + attrval + "']\");");

                        string xml = (string)js.ExecuteScript("return viewControllerDefinition.xml");
                        XmlDocument xmlDoc = new XmlDocument();
                        xmlDoc.LoadXml(xml);
                        //@TODO: доработать выбор элемента. Если на форме 2 контроли с одинаковым имением - возьмет первый попавшийся.  Нужно сужать выборку.
                        XmlNode itemNodes = xmlDoc.SelectSingleNode("//Controls/Control[@Name='" + attrval + "']");
                        SFControl control = new SFControl(itemNodes);

                        return driver.FindElement(By.Id(control.DOMControlID));

                    }
                default:
                    throw new Exception("Unknown selector type " + attribute);
            }



        }

        public static List<IWebElement> findMyElements(String attribute, String attrval)
        {


            switch (attribute.ToLower())
            {
                case "id":
                    return driver.FindElements(By.Id(attrval)).ToList();
                case "name":
                    return driver.FindElements(By.Name(attrval)).ToList();
                case "xpath":
                    return driver.FindElements(By.XPath(attrval)).ToList();
                case "css":
                    return driver.FindElements(By.CssSelector(attrval)).ToList();
                case "link":
                    return driver.FindElements(By.LinkText(attrval)).ToList();

                case "jquery":
                    {
                        IJavaScriptExecutor js = driver as IJavaScriptExecutor;
                        //string title = (string)js.ExecuteScript("return document.title");

                        //return (IWebElement)js.ExecuteScript("return jQuery.find(\"" + attrval + "\");");

                        IEnumerable<object> matchedItems =
               (IEnumerable<object>)js.ExecuteScript("return jQuery.find(\"" + attrval + "\");");

                        return matchedItems.Cast<IWebElement>().ToList();

                    }
                case "jqueryx":
                    {
                        IJavaScriptExecutor js = driver as IJavaScriptExecutor;
                        //string title = (string)js.ExecuteScript("return document.title");

                        //return (IWebElement)js.ExecuteScript("return jQuery.find(\"" + attrval + "\");");

                        IEnumerable<object> matchedItems =
               (IEnumerable<object>)js.ExecuteScript("return jQuery.find(\"" + attrval + "\");");

                        return matchedItems.Cast<IWebElement>().ToList();

                    }

                default:
                    throw new Exception("Unknown selector type " + attribute);
            }
        }

        

        public static void createBrowserScreenshot(IWebDriver driver, string destPath)
        {
            if (driver != null)
            {
                Screenshot screen = ((ITakesScreenshot)driver).GetScreenshot();

                string screenshot = screen.AsBase64EncodedString;
                byte[] screenshotAsByteArray = screen.AsByteArray;
                screen.SaveAsFile(Path.Combine(destPath, string.Format("{0:yyyy_MM_dd_HH_mm_ss}.png", DateTime.Now)), System.Drawing.Imaging.ImageFormat.Png);

            }
            else
            {
                logger.Warn("Скриншот не создан. Инстанс driver не найден (возможно окно браузера закрыто)");
            }
        }



        public static void createFullScreenshot(string destPath)
        {
            //using (Bitmap bmpScreenCapture = new Bitmap(Screen.PrimaryScreen.Bounds.Width,
            //                                Screen.PrimaryScreen.Bounds.Height))
            //{
            //    using (Graphics g = Graphics.FromImage(bmpScreenCapture))
            //    {
            //        g.CopyFromScreen(Screen.PrimaryScreen.Bounds.X,
            //                         Screen.PrimaryScreen.Bounds.Y,
            //                         0, 0,
            //                         bmpScreenCapture.Size,
            //                         CopyPixelOperation.SourceCopy);

            //        bmpScreenCapture.Save(Path.Combine(destPath, string.Format("screen_{0:yyyy_MM_dd_HH_mm_ss}.png", DateTime.Now)), System.Drawing.Imaging.ImageFormat.Png);
            //    }
            //}
        }

        private static string runTestStep(ScenarioStep step, Settings settings)
        {
            step.value = replaceBufferPlaceholder(step.value);
            step.attributeValue = replaceBufferPlaceholder(step.attributeValue);

            logger.Info(String.Format("Выполнение шага. Действие - {0} Атрибут - {2} Параметр - {1}  Знач. атрибута - {3} ", step.action, step.value, step.attribute, step.attributeValue));



            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(13));


            if (isEmptyPage())
            {
                driver.SwitchTo().ParentFrame(); // если страница пустая, переключаемся на родительский фрейм (@TODO: разобраться с этим и убрать костыль)
            }
            //без этого при закрытии сабформы через кнопку на сабформе, при попытке переключиться на родительский фрейм - происходит ошибка в WaitForAjaxIndicatorDisappeared. 
            ///Теряется закрытый фрейм, поэтому мы принидительно переключаемся на родительский фрейм
            if (step.action == "SwitchToParent")
            {
                driver.SwitchTo().ParentFrame();
            }
            if (!isEmptyPage())
            {
                WaitForAjaxIndicatorDisappeared(driver);
            }
            //driver.Manage().Window.Maximize();

            var act = step.action.ToLower();
            if (act.Equals("openbrowser"))
            {



                switch (step.value.ToLower())
                {
                    case "firefox":
                        //driver.manage().timeouts().implicitlyWait(10, TimeUnit.SECONDS);
                        break;
                    case "htmlunit":
                        // driver = new HtmlUnitDriver();
                        // driver.manage().timeouts().implicitlyWait(10, TimeUnit.SECONDS);
                        break;

                    default:
                        break;

                }

            }




            else if (act.Equals("navigate"))
            {
                driver.Navigate().GoToUrl(step.value);

            }

            else if (act.Equals("switchto"))
            {
                var frame = driver.FindElement(By.CssSelector(step.attributeValue));
                driver.SwitchTo().Frame(frame);

            }

            else if (act.Equals("switchtoparent"))
            {
                SwitchToParent();

            }

            else if (act.Equals("wait"))
            {
                System.Threading.Thread.Sleep(Int32.Parse(step.value));


            }

            else if (string.Equals(act, "WaitForElemPresentWithPageRefresh", StringComparison.CurrentCultureIgnoreCase))
            {
                var attribValue = replaceBufferPlaceholder(step.attributeValue);

                var findElemCounter = findMyElements(step.attribute, attribValue).Count;

                if (findElemCounter > 0) return "";

                logger.Debug("Элемент не найден. Начинаем ожидающий цикл с перезагрузками страницы");


                for (int i = 0; i < 20; i++)
                {
                    logger.Debug(String.Format("Перезагрузка страницы. Попытка {0}", i));

                    driver.Navigate().Refresh();
                    findElemCounter = Convert.ToInt32(findMyElements(step.attribute, attribValue).Count);

                    if (findElemCounter > 0)
                    {
                        logger.Debug(String.Format("Элемент найден после {0} перезагрузок страницы", i));
                        return "";

                    }

                }

                throw new Exception(String.Format("Cant find at page control - {0}, {1} after 20 page refresh", step.attribute, step.attributeValue));


            }



            else if (act.Equals("type"))
            {
                findMyElement(step.attribute, step.attributeValue).SendKeys(step.value);
            }

            else if (act.Equals("click"))
            {
                Click(step);

            }


            else if (act.Equals("clicktwice"))
            {

                findMyElement(step.attribute, step.attributeValue).Click();
                findMyElement(step.attribute, step.attributeValue).Click();


            }

            else if (string.Equals(act, "FillSFControl", StringComparison.CurrentCultureIgnoreCase))
            {


                IJavaScriptExecutor js = driver as IJavaScriptExecutor;
                string xml = (string)js.ExecuteScript("return viewControllerDefinition.xml");

                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(xml);

                //XmlSerializer serializer = new XmlSerializer(typeof(Controllers));
                //Controllers i;

                //using (XmlReader reader = XmlReader.Create(new StringReader(xml)))
                //{
                //    i = (Controllers)serializer.Deserialize(reader);
                //}


                XmlNode itemNodes = xmlDoc.SelectSingleNode("//Controls/Control[@Name='" + step.attributeValue + "']");
                if (itemNodes == null) throw new Exception(String.Format("Cant find in SF Definition Control with name - {0}", step.attributeValue));


                SFControl control = new SFControl(itemNodes);

                if (control.type == SFControlType.Lookup)
                {

                    Click(step);
                    var frame = driver.FindElement(By.CssSelector("iframe.runtime-popup"));
                    driver.SwitchTo().Frame(frame);

                    findMyElement("xpath", String.Format("//span[text()[contains(., '{0}')]]", step.value)).Click();

                    SwitchToParent();
                }


                else if (control.type == SFControlType.DropDownList)
                {

                    Click(step);
                    findMyElement("xpath", String.Format("//span[text()[contains(., '{0}')]]", step.value)).Click();

                }

                else if (control.type == SFControlType.Picker)
                {

                    driver.FindElement(By.CssSelector("a.picker-search")).Click();

                    findMyElement("css", "input.input-control").SendKeys(step.value);
                    findMyElement("jquery", "#rtSearchConfig_FindValueButton_00000000-0000-0000-0000-000000000000_29030336-6097-d00e-186b-3f917770ff7c").Click();
                    //WaitForAjaxIndicatorDisappeared(driver);
                    System.Threading.Thread.Sleep(7000);
                    //findMyElement("jquery", "a.close").Click();
                    //System.Threading.Thread.Sleep(7000);

                    //findMyElement("jquery", "a.close").Click();

                    //IJavaScriptExecutor js = driver as IJavaScriptExecutor;
                    js.ExecuteScript(String.Format("$('div#rtSearchConfig_grdResults_00000000-0000-0000-0000-000000000000_29030336-6097-d00e-186b-3f917770ff7c_Primary td.first').click();", ""));

                    js.ExecuteScript("$('a.SourceCode-Forms-Controls-Web-Button').filter(function(index) { return $(this).text() === 'OK'; }).click()");

                    //driver.SwitchTo().DefaultContent();


                    //SwitchToParent();
                    //var pickerElem = driver.FindElement(By.CssSelector("div[id='00000000-0000-0000-0000-000000000000_29030336-6097-d00e-186b-3f917770ff7c_Primary']  div.editable-area"));
                    //setAttributeValue(pickerElem, "innerHTML", "xxxx");
                }


                else if (control.type == SFControlType.FileUpload)
                {

                    findMyElement(step.attribute, step.attributeValue).SendKeys(step.value);
                    //Ждать не требуется, так как браузер вернет урпавление в код как только файл загружится (по крайней мере в FF такое поведение)
                    //var xxx2 = driver.FindElement(By.XPath(String.Format("//div[@id='{0}_FilePanel']", control.ID))).Text;
                    //if (xxx2.Contains("Uploading")) { 
                    //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                    //wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException)); // ignore stale exception issues
                    //wait.Until(d => d.FindElement(By.XPath(String.Format("//div[@id='{0}_FilePanel']", control.ID))).Text.Contains("Uploading"));
                    //}
                    SwitchToParent();
                }

                else if (control.type == SFControlType.AutoComplete)
                {

                    findMyElement("jquery", String.Format("#{0} input.ui-autocomplete-input", control.ID)).SendKeys(step.value);
                    driver.FindElement(By.CssSelector(".ui-menu-item  a.ui-corner-all"), 10).Click();


                    //findMyElement("jquery", "").Click();
                    
                }
            }



            else if (string.Equals(act, "AddToBufferFromElemValue", StringComparison.CurrentCultureIgnoreCase))
            {

                //scanarioOutputDict.Add()
                var element = findMyElement(step.attribute, step.attributeValue);

                scanarioOutputBuffer[step.value] = element.Text;



            }

            else if (string.Equals(act, "AddToBufferFromElemInnerHTML", StringComparison.CurrentCultureIgnoreCase))
            {

                //scanarioOutputDict.Add()
                var element = findMyElement(step.attribute, step.attributeValue);
                scanarioOutputBuffer[step.value] = element.GetAttribute("innerHTML");



            }

            else if (string.Equals(act, "SwitchToOpenedWindow", StringComparison.CurrentCultureIgnoreCase))
            {

                foreach (var window in driver.WindowHandles)
                {
                    if (driver.CurrentWindowHandle != window)
                    {
                        driver.SwitchTo().Window(window); // switch focus of WebDriver to the next found window handle (that's your newly opened window)
                        break;
                    }
                }

            }


            else if (string.Equals(act, "validateContains", StringComparison.CurrentCultureIgnoreCase))
            {

                var element = findMyElement(step.attribute, step.attributeValue);
                if (element.Text.Contains(step.value))
                {
                    return "OK";
                }
                else
                {
                    Console.WriteLine("Actual value: " + element.Text + ", expected value: " + step.value);
                    return "NOK";
                }

            }

            else if (string.Equals(act, "validateEquals", StringComparison.CurrentCultureIgnoreCase))
            {

                var element = findMyElement(step.attribute, step.attributeValue);
                if (element.Text.Equals(step.value))
                {
                    return "OK";
                }
                else
                {
                    Console.WriteLine("Actual value: " + element.Text + ", expected value: " + step.value);
                    return "NOK";
                }

            }

            else if (act.Equals("closebrowser"))
            {
                if (driver != null)
                {
                    driver.Quit();
                    driver = null;
                }
            }


            else if (act.Equals("scroll"))
            {
                IJavaScriptExecutor js = driver as IJavaScriptExecutor;
                js.ExecuteScript(String.Format("scroll({0})", step.value));

            }


            else if (settings.screenshotMode == "Fullscreen")
            {
                //createFullScreenshot(Helper.AppFolderCreator(settings.screenshotFolder));

            }

            else if (settings.screenshotMode == "BrowserWindow")
            {
                createBrowserScreenshot(driver, Helper.AppFolderCreator(settings.screenshotFolder));

            }

            return "";


        }

        private static bool isEmptyPage()
        {
            if (driver.PageSource == "<html xmlns=\"http://www.w3.org/1999/xhtml\"><head></head><body></body></html>") return true;
            return false;
        }

        private static void SwitchToParent()
        {
            driver.SwitchTo().ParentFrame();
        }

        private static void Click(ScenarioStep step)
        {
            try
            {
                findMyElement(step.attribute, step.attributeValue).Click();
            }
            catch (Exception ex)
            {
                //TODO: Вместо кода ниже реализовать обработку и логирование ошибок. Возможность повторных попыток при ошибках.
                var frames = driver.FindElements(By.CssSelector("iframe")).ToList();
                foreach (var frame in frames)
                {

                    try
                    {
                        driver.SwitchTo().Frame(frame.GetAttribute("name"));
                        findMyElement(step.attribute, step.attributeValue).Click();
                        break;
                    }
                    catch (Exception ex1)
                    {

                        //driver.SwitchTo().DefaultContent();
                    }

                }

            }
        }





        private static List<ScenarioStep> loadScenarionSteps(string fileName, List<ScenarioStep> scenario, Settings settings)
        {
            DataSet mainDS = loadDataSetFromExcelFile(fileName);

            foreach (DataRow dr in mainDS.Tables["Scenario"].Rows)
            {
                if (!dr[0].ToString().Equals("1")) continue; // если шаг не выключен (enabled)

                if (dr[1].ToString() == "CallSubScenario")
                {
                    loadScenarionSteps(dr[2].ToString(), scenario, settings);  // подгружаем подсценарии
                    continue;
                }


                scenario.Add(new ScenarioStep
                {
                    step = scenario.Count(),
                    action = dr[1].ToString().Trim(),
                    value = replaceSettingsPlaceholder(dr[2].ToString().Trim(), settings),
                    attribute = dr[3].ToString().Trim(),
                    attributeValue = dr[4].ToString().Trim()
                });
            }

            return scenario;

        }

        private static string replaceSettingsPlaceholder(string v, Settings settings)
        {

            string replacedPlaceholder = v;

            foreach (var item in settings.dictionary)
            {
                var placeHolder = String.Format("{{{0}}}", item.Key);

                if (replacedPlaceholder.Contains(placeHolder))
                {
                    replacedPlaceholder = replacedPlaceholder.Replace(placeHolder, item.Value);
                }

            }

            return replacedPlaceholder;

        }

        private static DataSet loadDataSetFromExcelFile(string fileName)
        {
            FileStream stream = File.Open(Path.Combine(Helper.getCurrFolderPath(), fileName), FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            //2. Reading from a OpenXml Excel file (2007 format; *.xlsx)
            IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
            //3. DataSet - The result of each spreadsheet will be created in the result.Tables
            DataSet result = excelReader.AsDataSet();

            //4. DataSet - Create column names from first row
            excelReader.IsFirstRowAsColumnNames = true;
            var res = excelReader.AsDataSet();
            excelReader.Close();
            return res;

        }

        public Settings settings = new Settings();
        public Tests tests { get; set; }
        public string config { get; set; }

        public Dictionary<string, TestDef> testCollection = new Dictionary<string, TestDef>();
    }
}
