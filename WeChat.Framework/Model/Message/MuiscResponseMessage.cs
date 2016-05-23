﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeChat.Framework.Model.Message
{
    public class MuiscResponseMessage : BaseMessage
    {
        public MusicModel Music { get; set; }

        public override MsgType MsgType
        {
            get
            {
                return MsgType.MUSIC;
            }
        }

        public class MusicModel
        {
            /// <summary>
            /// 音乐标题
            /// </summary>
            public string Title { get; set; }

            /// <summary>
            /// 音乐描述
            /// </summary>
            public string Description { get; set; }

            /// <summary>
            /// 音乐链接
            /// </summary>
            public string MusicUrl { get; set; }

            /// <summary>
            /// 高质量音乐链接，WIFI环境优先使用该链接播放音乐
            /// </summary>
            public string HQMusicUrl { get; set; }

            /// <summary>
            /// 缩略图的媒体id，通过素材管理中的接口上传多媒体文件，得到的id
            /// </summary>
            public string ThumbMediaId { get; set; }
        }
    }
}
