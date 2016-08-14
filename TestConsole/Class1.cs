using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
   
        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class TestsDef
        {

            private TestsTest[] testField;

            private TestsSetting[] settingsField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Test")]
            public TestsTest[] Test
            {
                get
                {
                    return this.testField;
                }
                set
                {
                    this.testField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("Setting", IsNullable = false)]
            public TestsSetting[] Settings
            {
                get
                {
                    return this.settingsField;
                }
                set
                {
                    this.settingsField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class TestsTest
        {

            private string fileNameField;

            private string descriptionField;

            private string testEnabledField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string fileName
            {
                get
                {
                    return this.fileNameField;
                }
                set
                {
                    this.fileNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string testEnabled
            {
                get
                {
                    return this.testEnabledField;
                }
                set
                {
                    this.testEnabledField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class TestsSetting
        {

            private string baseUrlField;

            private string speedField;

            private string screenshotModeField;

            private string screenshotFolderField;

            private string ignoreErrorModeField;

            private byte delayBetweenStepsSecField;

            private bool delayBetweenStepsSecFieldSpecified;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string BaseUrl
            {
                get
                {
                    return this.baseUrlField;
                }
                set
                {
                    this.baseUrlField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Speed
            {
                get
                {
                    return this.speedField;
                }
                set
                {
                    this.speedField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string ScreenshotMode
            {
                get
                {
                    return this.screenshotModeField;
                }
                set
                {
                    this.screenshotModeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string ScreenshotFolder
            {
                get
                {
                    return this.screenshotFolderField;
                }
                set
                {
                    this.screenshotFolderField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string IgnoreErrorMode
            {
                get
                {
                    return this.ignoreErrorModeField;
                }
                set
                {
                    this.ignoreErrorModeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte DelayBetweenStepsSec
            {
                get
                {
                    return this.delayBetweenStepsSecField;
                }
                set
                {
                    this.delayBetweenStepsSecField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool DelayBetweenStepsSecSpecified
            {
                get
                {
                    return this.delayBetweenStepsSecFieldSpecified;
                }
                set
                {
                    this.delayBetweenStepsSecFieldSpecified = value;
                }
            }
        }


}
