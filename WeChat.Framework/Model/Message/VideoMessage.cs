using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeChat.Framework.Model.Message
{
    /// <summary>
    /// 视频消息
    /// </summary>
    public class VideoMessage : BaseMessage
    {
        /// <summary>
        /// 视频消息媒体id，可以调用多媒体文件下载接口拉取数据。
        /// </summary>
        public string MediaId { get; set; }

        /// <summary>
        /// 视频消息缩略图的媒体id，可以调用多媒体文件下载接口拉取数据
        /// </summary>
        public string ThumbMediaId { get; set; }
            
        public override MsgType MsgType
        {
            get
            {
                return MsgType.VIDEO;
            }
        }
    }
}
