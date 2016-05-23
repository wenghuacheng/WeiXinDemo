using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeChat.Framework.Model.Message;

namespace WeChat.Framework.Handler.MessageHandlers
{
    public class VideoMessageHandler : BaseMessageHandler<VideoMessage>
    {
        public VideoMessageHandler(string xmlString)
            : base(xmlString)
        {
        }

        protected override BaseMessage MessageHandler(VideoMessage model)
        {
            throw new NotImplementedException();
        }
    }
}
