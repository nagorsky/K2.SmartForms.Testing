namespace K2Smartforms.TestingLibrary
{


    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class Tests
    {

        private TestsTest[] testField;

        private TestsSettings settingsField;

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
        public TestsSettings Settings
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
        public string TestEnabled
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
    public partial class TestsSettings
    {

        private TestsSettingsBaseUrl baseUrlField;

        private TestsSettingsSpeed speedField;

        private TestsSettingsScreenshotMode screenshotModeField;

        private TestsSettingsScreenshotFolder screenshotFolderField;

        private TestsSettingsIgnoreErrorMode ignoreErrorModeField;

        private TestsSettingsDelayBetweenStepsSec delayBetweenStepsSecField;

        /// <remarks/>
        public TestsSettingsBaseUrl BaseUrl
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
        public TestsSettingsSpeed Speed
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
        public TestsSettingsScreenshotMode ScreenshotMode
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
        public TestsSettingsScreenshotFolder ScreenshotFolder
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
        public TestsSettingsIgnoreErrorMode IgnoreErrorMode
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
        public TestsSettingsDelayBetweenStepsSec DelayBetweenStepsSec
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class TestsSettingsBaseUrl
    {

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class TestsSettingsSpeed
    {

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class TestsSettingsScreenshotMode
    {

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class TestsSettingsScreenshotFolder
    {

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class TestsSettingsIgnoreErrorMode
    {

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class TestsSettingsDelayBetweenStepsSec
    {

        private byte valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }



}