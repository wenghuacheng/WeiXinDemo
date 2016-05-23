using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeChat.Framework.Model.Message
{
 
    /// <summary>
    /// 地理位置消息
    /// </summary>
    public class LocationMessage : BaseMessage
    {
        /// <summary>
        /// 地理位置维度
        /// </summary>
        public double Location_X { get; set; }

        /// <summary>
        /// 地理位置经度
        /// </summary>
        public double Location_Y { get; set; }

        /// <summary>
        /// 地图缩放大小
        /// </summary>
        public double Scale { get; set; }

        /// <summary>
        /// 地理位置信息
        /// </summary>
        public string Label { get; set; }

   
        public override MsgType MsgType
        {
            get
            {
                return MsgType.LOCATION;
            }
        }

    }
}
