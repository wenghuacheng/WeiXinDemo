using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace WeChat.Framework.Model.Message
{
    [Serializable]
    [XmlRoot(ElementName = "xml")]
    public abstract class BaseMessage : XmlModel
    {
        protected XmlDocument doc = new XmlDocument();

        #region Properties
        /// <summary>
        /// 开发者微信号
        /// </summary>
        [XmlIgnore]
        public string ToUserName { get; set; }

        /// <summary>
        /// 发送方帐号（一个OpenID）
        /// </summary>
        [XmlIgnore]
        public string FromUserName { get; set; }

        /// <summary>
        /// 消息创建时间 （整型）
        /// </summary>
        [XmlElement("CreateTime")]
        public long CreateTime { get; set; }

        /// <summary>
        /// 消息类型
        /// </summary>
        [XmlIgnore]
        public abstract MsgType MsgType { get; }

        /// <summary>
        /// 消息id，64位整型
        /// </summary>
        [XmlIgnore]
        public long MsgId { get; set; }
        #endregion

        #region Serialize Model

        [XmlElement("ToUserName")]
        public XmlCDataSection ToCdUserName
        {
            get { return doc.CreateCDataSection(ToUserName); }
            set { ToUserName = value.Value; }
        }

        [XmlElement("FromUserName")]
        public XmlCDataSection ToCdFromUserName
        {
            get { return doc.CreateCDataSection(FromUserName); }
            set { FromUserName = value.Value; }
        }

        [XmlElement("MsgType")]
        public XmlCDataSection ToCdMsgType
        {
            get
            {
                return doc.CreateCDataSection(MsgType.ToString().ToLower());
            }
            set { ; }//不能去掉set属性否则无法序列化
        }
        #endregion

        public virtual XElement ToModel(string xmlString)
        {
            var doc1 = XDocument.Parse(xmlString);
            var xml = doc1.Element("xml");

            this.ToUserName = xml.Element("ToUserName").Value;
            this.FromUserName = xml.Element("FromUserName").Value;
            this.CreateTime = Convert.ToInt64(xml.Element("CreateTime").Value);
            this.MsgId = Convert.ToInt64(xml.Element("MsgId").Value);

            return xml;
        }

        public string ToXml()
        {
            var stringWriter = new StringWriter();
            XmlSerializer serializer = new XmlSerializer(this.GetType());
            var ns = new XmlSerializerNamespaces();
            ns.Add("", "");//去掉默认的命名空间
            serializer.Serialize(stringWriter, this, ns);

            return stringWriter.ToString();
        }
    }
}
