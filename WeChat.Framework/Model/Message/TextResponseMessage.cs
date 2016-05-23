using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace WeChat.Framework.Model.Message
{
    [XmlRoot("xml")]
    public class TextResponseMessage : TextMessage
    {
        [XmlElement("Content")]
        public XmlCDataSection ToCdContent
        {
            get { return doc.CreateCDataSection(Content); }
            set { Content = value.Value; }
        }
    }
}
