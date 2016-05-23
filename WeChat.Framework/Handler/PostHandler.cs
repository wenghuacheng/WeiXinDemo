using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using WeChat.Framework.Handler.EventHandlers;
using WeChat.Framework.Handler.MessageHandlers;
using WeChat.Framework.Model.Event;
using WeChat.Framework.Model.Message;

namespace WeChat.Framework.Handler
{
    public class PostHandler
    {
        public string Execute(string postString)
        {
            var doc = XDocument.Parse(postString);
            var xml = doc.Element("xml");
            var xmlString = xml.ToString();

            MsgType msgType = (MsgType)Enum.Parse(typeof(MsgType), xml.Element("MsgType").Value.ToUpper());

            if (msgType != MsgType.EVENT)
            {
                #region 消息处理

                IMessageHandler messageHandler = null;
                switch (msgType)
                {
                    case MsgType.TEXT:
                        messageHandler = new TextMessageHandler(xmlString);
                        break;
                    case MsgType.LINK:
                        messageHandler = new LinkMessageHandler(xmlString);
                        break;
                    case MsgType.IMAGE:
                        messageHandler = new ImageMessageHandler(xmlString);
                        break;
                    case MsgType.LOCATION:
                        messageHandler = new LocationMessageHandler(xmlString);
                        break;
                    //case MsgType.SHORTVIDEO:
                    //    messageHandler = new VideoMessageHandler(xmlString);
                    //    break;
                    case MsgType.VIDEO:
                        messageHandler = new VideoMessageHandler(xmlString);
                        break;
                    case MsgType.VOICE:
                        messageHandler = new VoiceMessageHandler(xmlString);
                        break;
                    default:
                        messageHandler = new DefaultMessageHandler(xmlString);
                        break;
                }

                #endregion

                return messageHandler.Handler().ToXml();
            }
            else
            {
                EventType eventType = (EventType)Enum.Parse(typeof(EventType), xml.Element("Event").Value);

                #region 事件处理

                IEventHandler eventHandler;

                switch (eventType)
                {
                    case EventType.subscribe:
                        eventHandler = new SubscribeEventHandler(xmlString);
                        break;
                    case EventType.unsubscribe:
                        eventHandler = new UnsubscribeEventHandler(xmlString);
                        break;
                    case EventType.CLICK:
                        eventHandler = new ClickEventHandler(xmlString);
                        break;
                    default:
                        eventHandler = new DefaultEventHandler(xmlString);
                        break;
                }
                #endregion
                //事件处理
                return eventHandler.Handler().ToXml();
            }
        }
    }
}
