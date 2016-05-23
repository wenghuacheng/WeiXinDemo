using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeChat.Framework.Model.Event;
using WeChat.Framework.Model.Message;

namespace WeChat.Framework.Handler.EventHandlers
{
    public class ClickEventHandler : BaseEventHandler<EventModel>
    {
        public ClickEventHandler(string xmlString)
            : base(xmlString)
        {
        }

        protected override BaseMessage EventHandler(EventModel model)
        {
            switch (model.EventKey)
            {
                case "World_of_Tank_001":
                    List<Tuple<string, string, string, string>> ztsj = new List<Tuple<string, string, string, string>>();
                    ztsj.Add(new Tuple<string, string, string, string>("坦克世界", "坦克世界官网", "http://wot.kongzhong.com/", "http://wot.kongzhong.com/style/guide/images/f_logo.png"));
                    return GetNewsResponseMessage(model, ztsj);
                default:
                    return GetTextResponseMessage(model, "没有相关操作");
            }
        }
    }
}
