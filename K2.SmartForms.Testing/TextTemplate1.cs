






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





        [Test]
        [AllureTitle("CreateRequestAndAllApprove")]
        [AllureDescription("Создание заявки и согласование всеми участниками без отклонений", descriptiontype.text)]
        [AllureSeverity(severitylevel.critical)]
        [AllureStories("story", "story2")]
        [AllureFeatures("feature", "feature2")]
        [DeploymentItemAttribute("../../../Test")]
        public void CreateRequestAndAllApprove()
        {


            testSuite testInst = new testSuite("MDM.IT.SoftwareChange");

            testInst.Run("CreateRequestAndAllApprove");
            

        }


     }
}