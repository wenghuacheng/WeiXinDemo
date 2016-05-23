using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeChat.Framework.Model.Message;

namespace WeChat.Framework.Handler.MessageHandlers
{
    public class DefaultMessageHandler : TextMessageHandler
    {
        public DefaultMessageHandler(string xmlString)
            : base(xmlString)
        {
        }

        protected override BaseMessage MessageHandler(TextMessage model)
        {
            return GetTextResponseMessage(model, "没有此服务");
        }
    }
}
