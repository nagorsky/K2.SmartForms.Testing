using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace K2Smartforms.TestingLibrary

{
    class SFControl

    {
        public string ID { get; set; }
        public SFControlType type { get; set; }
        public XmlNode xmlDefinition { get; set; }
        public string DOMControlID { get; set; }


        public SFControl(XmlNode xmlNode)
        {
            xmlDefinition = xmlNode;

            if (xmlNode.OuterXml.Contains("SourceCode.Forms.Controls.Web.LookupBehavior"))
            {
                type = SFControlType.Lookup;
                ID = xmlNode.SelectSingleNode("@ID").InnerText;
                DOMControlID = String.Format("{0}_LookupLink", ID);

            }
            else if (xmlNode.OuterXml.Contains("SourceCode.Forms.Controls.Web.TextAreaBehavior"))
            {
                type = SFControlType.TextArea;
                ID = xmlNode.SelectSingleNode("@ID").InnerText;
                DOMControlID = String.Format("{0}_TextArea", ID);
            }
            else if (xmlNode.OuterXml.Contains("SourceCode.Forms.Controls.Web.Button"))
            {
                ID = DOMControlID = xmlNode.SelectSingleNode("@ID").InnerText;
                type = SFControlType.Button;

            }
            else if (xmlNode.OuterXml.Contains("SourceCode.Forms.Controls.Web.DropDownBehavior"))
            {
                ID = DOMControlID = xmlNode.SelectSingleNode("@ID").InnerText;
                type = SFControlType.DropDownList;

            }
            else if (xmlNode.OuterXml.Contains("SourceCode.Forms.Controls.Web.FilePostBackBehaviour"))
            {
                type = SFControlType.FileUpload;
                ID = xmlNode.SelectSingleNode("@ID").InnerText;
                DOMControlID = String.Format("{0}_file-inputId", ID);
            }
            else if (xmlNode.OuterXml.Contains("SourceCode.Forms.Controls.Web.Picker"))
            {
                type = SFControlType.Picker;
                ID = xmlNode.SelectSingleNode("@ID").InnerText;
                DOMControlID = String.Format("{0}_Primary", ID);
            }
            else if (xmlNode.OuterXml.Contains("SourceCode.Forms.Controls.Web.PictureBehavior"))
            {
                type = SFControlType.Picture;
                ID = xmlNode.SelectSingleNode("@ID").InnerText;
                DOMControlID = String.Format("{0}_Picture", ID);
            }
                        
            else
            {
                ID = DOMControlID = xmlNode.SelectSingleNode("@ID").InnerText;
            }
           

        


        }
    }

   


    public enum SFControlType
    {
        Lookup = 1,
        DropDownList = 2,
        TextArea = 3,
        Button = 4,
        FileUpload = 5,
        Picker = 6,
        Picture = 7,
    }
}
