using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeChat.Framework.Model.Message
{
    public class VoiceResponseMessage : BaseMessage
    {
        public VoiceResponseMessage()
        {
            Voice = new List<string>();
        }

        public List<string> Voice { get; set; }//MediaId集合

        /// <summary>
        /// 视频消息的标题
        /// </summary>
        public string Title { get; set; }
        
        /// <summary>
        /// 视频消息的描述
        /// </summary>
        public string Description { get; set; }

        public override MsgType MsgType
        {
            get
            {
                return MsgType.VOICE;
            }
        }
    }
}
