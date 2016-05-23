using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeChat.Framework.Model.Event
{
    public enum EventType
    {
        subscribe,//订阅
        unsubscribe,//取消订阅
        SCAN,//扫描带参数二维码事件
        LOCATION,//上报地理位置事件
        CLICK,//自定义菜单事件
        VIEW//点击菜单跳转链接时的事件推送
    }
}
