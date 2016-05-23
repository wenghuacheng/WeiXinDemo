using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace WeChat.Framework.Model.Message
{
    /// <summary>
    /// 文本消息
    /// </summary>
    [XmlRoot("xml")]
    public class TextMessage : BaseMessage
    {
        /// <summary>
        /// 文本消息内容
        /// </summary>
        [XmlIgnore]
        public string Content { get; set; }

        public override MsgType MsgType
        {
            get
            {
                return MsgType.TEXT;
            }
        }

        public override XElement ToModel(string xmlString)
        {
            var xml = base.ToModel(xmlString);
            this.Content = xml.Element("Content").Value;
            return xml;
        }
    }
}
