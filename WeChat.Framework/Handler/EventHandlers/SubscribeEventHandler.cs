using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeChat.Framework.Model.Event;
using WeChat.Framework.Model.Message;

namespace WeChat.Framework.Handler.EventHandlers
{
    public class SubscribeEventHandler : BaseEventHandler<EventModel>
    {
        public SubscribeEventHandler(string xmlString)
            : base(xmlString)
        {
        }

        protected override BaseMessage EventHandler(EventModel model)
        {
            return GetTextResponseMessage(model, "欢迎光临");
        }
    }
}
