using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeChat.Framework.Model.Message;

namespace WeChat.Framework.Handler.MessageHandlers
{
    public class ImageMessageHandler : BaseMessageHandler<ImageMessage>
    {
        public ImageMessageHandler(string xmlString)
            : base(xmlString)
        {
        }

        protected override BaseMessage MessageHandler(ImageMessage model)
        {
            throw new NotImplementedException();
        }
    }
}
