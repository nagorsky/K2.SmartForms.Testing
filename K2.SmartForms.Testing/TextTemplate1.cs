






using AllureCSharpCommons.AllureModel;
using AllureCSharpCommons.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using K2Smartforms.TestingLibrary;
using System.Reflection;

namespace K2.SmartForms.Testing
{
    [TestFixture]
	public class Main2
     {



/// <summary>
        /// Use as first line in ad hoc tests (needed by XNA specifically)
        /// </summary>
        public static void SetEntryAssembly()
        {
            SetEntryAssembly(Assembly.GetCallingAssembly());
        }

        /// <summary>
        /// Allows setting the Entry Assembly when needed. 
        /// Use AssemblyUtilities.SetEntryAssembly() as first line in XNA ad hoc tests
        /// </summary>
        /// <param name="assembly">Assembly to set as entry assembly</param>
        public static void SetEntryAssembly(Assembly assembly)
        {
            AppDomainManager manager = new AppDomainManager();
            FieldInfo entryAssemblyfield = manager.GetType().GetField("m_entryAssembly", BindingFlags.Instance | BindingFlags.NonPublic);
            entryAssemblyfield.SetValue(manager, assembly);

            AppDomain domain = AppDomain.CurrentDomain;
            FieldInfo domainManagerField = domain.GetType().GetField("_domainManager", BindingFlags.Instance | BindingFlags.NonPublic);
            domainManagerField.SetValue(domain, manager);
        }



        [Test]
        [AllureTitle("CreateRequestAndAllApprove")]
        [AllureDescription("Создание заявки и согласование всеми участниками без отклонений", descriptiontype.text)]
        [AllureSeverity(severitylevel.critical)]
        [AllureStories("story", "story2")]
        [AllureFeatures("feature", "feature2")]
        public void CreateRequestAndAllApprove()
        {

            SetEntryAssembly();

            testSuite testInst = new testSuite("MDM.IT.SoftwareChange");

            testInst.Run("CreateRequestAndAllApprove");
            

        }



        [Test]
        [AllureTitle("CreateRequestAndAllApproveWithRework")]
        [AllureDescription("Создание заявки, доработка, согласование всеми участниками", descriptiontype.text)]
        [AllureSeverity(severitylevel.critical)]
        [AllureStories("story", "story2")]
        [AllureFeatures("feature", "feature2")]
        public void CreateRequestAndAllApproveWithRework()
        {

            SetEntryAssembly();

            testSuite testInst = new testSuite("MDM.IT.SoftwareChange");

            testInst.Run("CreateRequestAndAllApproveWithRework");
            

        }


     }
}