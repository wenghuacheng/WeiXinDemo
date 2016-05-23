using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeChat.Framework.Model.Message
{
    public class VideoResponseMessage : BaseMessage
    {
        public VideoResponseMessage()
        {
            Voice = new List<string>();
        }

        public List<string> Voice { get; set; }//MediaId集合

        public override MsgType MsgType
        {
            get
            {
                return MsgType.VIDEO;
            }
        }
    }
}
