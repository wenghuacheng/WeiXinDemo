using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeChat.Framework.Model.Message;

namespace WeChat.Framework.Handler.MessageHandlers
{
    public class VoiceMessageHandler : BaseMessageHandler<VoiceMessage>
    {
        public VoiceMessageHandler(string xmlString)
            : base(xmlString)
        {
        }

        protected override BaseMessage MessageHandler(VoiceMessage model)
        {
            throw new NotImplementedException();
        }
    }
}
