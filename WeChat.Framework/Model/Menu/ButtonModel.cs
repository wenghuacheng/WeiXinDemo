using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace WeChat.Framework.Model.Menu
{
    public class ButtonModel : JsonModel
    {
        public ButtonModel()
        {
            sub_button = new List<ButtonModel>();
        }

        /// <summary>
        /// 菜单的响应动作类型
        /// 当枚举类型为默认时,json序列化忽略此字段
        /// </summary>
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public ButtonType type { get; set; }

        /// <summary>
        /// 菜单标题，不超过16个字节，子菜单不超过40个字节
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string name { get; set; }

        /// <summary>
        /// 菜单KEY值
        /// </summary>
        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string key { get; set; }

        /// <summary>
        /// 网页链接
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string url { get; set; }

        /// <summary>
        /// 调用新增永久素材接口返回的合法media_id(即素材的接口)
        /// </summary>
        [JsonProperty("media_id", NullValueHandling = NullValueHandling.Ignore)]
        public string media_id { get; set; }

        /// <summary>
        /// 二级菜单数组
        /// </summary>
        public List<ButtonModel> sub_button { get; set; }
    }


    public enum ButtonType
    {
        none,
        click,
        view,//微信客户端将会打开开发者在按钮中填写的网页URL
        scancode_waitmsg,   //扫码推事件
        scancode_push,  //扫码推事件且弹出“消息接收中”提示框
        pic_sysphoto,   //弹出系统拍照发图
        pic_photo_or_album, //弹出拍照或者相册发图
        pic_weixin, //  弹出微信相册发图器
        location_select     //弹出地理位置选择器
    }
}
