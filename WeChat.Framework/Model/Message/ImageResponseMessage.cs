using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeChat.Framework.Model.Message
{
    public class ImageResponseMessage : BaseMessage
    {
        public ImageResponseMessage()
        {
            Image = new List<string>();
        }

        public List<string> Image { get; set; }//media_id的集合

        public override MsgType MsgType
        {
            get
            {
                return MsgType.IMAGE;
            }
        }
    }
}
