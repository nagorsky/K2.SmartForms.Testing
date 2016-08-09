using AllureCSharpCommons.AllureModel;
using AllureCSharpCommons.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K2.SmartForms.Testing
{

    [TestFixture]
    public class Main
    {

        [Test]
        [AllureTitle("asd")]
        [AllureDescription("123", descriptiontype.text)]
        [AllureSeverity(severitylevel.critical)]
        [AllureStories("story", "story2")]
        [AllureFeatures("feature", "feature2")]
        public void Test()
        {

        }

        [Test]
        [AllureTitle("Broken Test")]
        [AllureDescription("Broken test bla bla bla", descriptiontype.text)]
        [AllureSeverity(severitylevel.critical)]
        [AllureStories("story", "story2")]
        [AllureFeatures("feature", "feature2")]
        public void TestBroken()
        {

        }
    }
}
