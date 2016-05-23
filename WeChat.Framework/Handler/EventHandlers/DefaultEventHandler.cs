using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeChat.Framework.Model.Event;
using WeChat.Framework.Model.Message;

namespace WeChat.Framework.Handler.EventHandlers
{
    public class DefaultEventHandler : BaseEventHandler<EventModel>
    {
        public DefaultEventHandler(string xmlString)
            : base(xmlString)
        {
        }

        protected override BaseMessage EventHandler(EventModel model)
        {
            return GetTextResponseMessage(model, "目前不支持事件");
        }
    }
}
