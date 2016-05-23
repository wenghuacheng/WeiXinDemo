using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeChat.Framework.Model.Message
{
    public enum MsgType
    {
        TEXT,//文本消息
        IMAGE,//图片消息
        VOICE,//语音消息
        VIDEO,//视频消息
        SHORTVIDEO,//小视频消息
        LOCATION,//地理位置消息
        LINK,//链接消息
        MUSIC,//音乐回复消息
        NEWS,//图文消息
        EVENT//事件
    }
}
