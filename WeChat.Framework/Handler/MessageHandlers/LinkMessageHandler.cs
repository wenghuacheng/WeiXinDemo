using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeChat.Framework.Model.Message;

namespace WeChat.Framework.Handler.MessageHandlers
{
    public class LinkMessageHandler : BaseMessageHandler<LinkMessage>
    {
        public LinkMessageHandler(string xmlString)
            : base(xmlString)
        {
        }

        protected override BaseMessage MessageHandler(LinkMessage model)
        {
            throw new NotImplementedException();
        }
    }
}
