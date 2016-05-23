using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeChat.Framework.Model.Event;
using WeChat.Framework.Model.Message;

namespace WeChat.Framework.Handler.EventHandlers
{
    public class UnsubscribeEventHandler : BaseEventHandler<EventModel>
    {
        public UnsubscribeEventHandler(string xmlString)
            : base(xmlString)
        {
        }

        protected override BaseMessage EventHandler(EventModel model)
        {
            return GetTextResponseMessage(model, "走好");
        }
    }
}
