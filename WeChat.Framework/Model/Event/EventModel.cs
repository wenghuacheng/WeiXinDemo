using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace WeChat.Framework.Model.Event
{
    public class EventModel : XmlModel
    {
        public EventModel()
        {
            MsgType = "event";
        }

        #region Properties
        /// <summary>
        /// 开发者微信号
        /// </summary>
        public string ToUserName { get; set; }

        /// <summary>
        /// 发送方帐号（一个OpenID）
        /// </summary>
        public string FromUserName { get; set; }

        /// <summary>
        /// 消息创建时间 （整型）
        /// </summary>
        public long CreateTime { get; set; }

        /// <summary>
        /// 消息类型
        /// </summary>
        public string MsgType { get; private set; }
        
        /// <summary>
        /// 事件类型，subscribe(订阅)、unsubscribe(取消订阅)
        /// </summary>
        public EventType Event { get; set; }

        /// <summary>
        /// 事件KEY值，与自定义菜单接口中KEY值对应
        /// </summary>
        public string EventKey { get; set; }
        #endregion

        public XElement ToModel(string xmlString)
        {
            var doc1 = XDocument.Parse(xmlString);
            var xml = doc1.Element("xml");

            this.ToUserName = xml.Element("ToUserName").Value;
            this.FromUserName = xml.Element("FromUserName").Value;
            this.CreateTime = Convert.ToInt64(xml.Element("CreateTime").Value);
            this.Event = (EventType)Enum.Parse(typeof(EventType), xml.Element("Event").Value);
            this.EventKey = xml.Element("EventKey").Value;

            return xml;
        }

    }
}
