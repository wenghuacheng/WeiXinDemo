﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeChat.Framework.Model.Message
{
    /// <summary>
    /// 链接消息
    /// </summary>
    public class LinkMessage : BaseMessage
    {
        /// <summary>
        /// 消息标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 消息描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 消息链接
        /// </summary>
        public string Url { get; set; }           

        public override MsgType MsgType
        {
            get
            {
                return MsgType.LINK;
            }
        }

    }
}
