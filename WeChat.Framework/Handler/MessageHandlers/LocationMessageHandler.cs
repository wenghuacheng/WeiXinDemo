using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeChat.Framework.Model.Message;

namespace WeChat.Framework.Handler.MessageHandlers
{
    public class LocationMessageHandler : BaseMessageHandler<LocationMessage>
    {
        public LocationMessageHandler(string xmlString)
            : base(xmlString)
        {
        }

        protected override BaseMessage MessageHandler(LocationMessage model)
        {
            throw new NotImplementedException();
        }
    }
}
