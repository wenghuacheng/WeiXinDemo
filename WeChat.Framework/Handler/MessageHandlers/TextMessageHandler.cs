using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeChat.Framework.Model.Message;

namespace WeChat.Framework.Handler.MessageHandlers
{
    public class TextMessageHandler : BaseMessageHandler<TextMessage>
    {
        public TextMessageHandler(string xmlString)
            : base(xmlString)
        {
        }

        protected override BaseMessage MessageHandler(TextMessage model)
        {
            switch (model.Content)
            {
                case "战争雷霆":
                    List<Tuple<string, string, string, string>> zzlt = new List<Tuple<string, string, string, string>>();
                    zzlt.Add(new Tuple<string, string, string, string>("战争雷霆", "战争雷霆官网", "http://wt.qq.com/?ADTAG=media.buy.baidubrand.title", "http://game.gtimg.cn//upload/adw/IMAGE/201605/1463947359478200544.jpg"));
                    zzlt.Add(new Tuple<string, string, string, string>("5月28号预约", "", "http://wt.qq.com/cp/a20160516thunder/index.html?atm_cl=ad&atm_pos=13162&e_code=233268", "http://game.gtimg.cn//upload/adw/IMAGE/201605/1463945757178999636.jpg"));
                    zzlt.Add(new Tuple<string, string, string, string>("战争雷霆充值", "", "http://wt.qq.com/cp/a20150105sclb/index.htm?atm_cl=ad&atm_pos=13163&e_code=231994", "http://game.gtimg.cn//upload/adw/IMAGE/201605/1463526203156476172.jpg"));
                    zzlt.Add(new Tuple<string, string, string, string>("每日签到", "", "http://wt.qq.com/cp/a20160428maybxh/index.htm?atm_cl=ad&atm_pos=13161&e_code=231993", "http://game.gtimg.cn//upload/adw/IMAGE/201605/1463525940527596646.jpg"));
                    return GetNewsResponseMessage(model, zzlt);
                case "坦克世界":
                    List<Tuple<string, string, string, string>> ztsj = new List<Tuple<string, string, string, string>>();
                    ztsj.Add(new Tuple<string, string, string, string>("坦克世界", "坦克世界官网", "http://wot.kongzhong.com/", "http://wot.kongzhong.com/style/guide/images/f_logo.png"));
                    return GetNewsResponseMessage(model, ztsj);
                case "战舰世界":
                    return GetTextResponseMessage(model, "建设中.....");
                default:
                    return GetTextResponseMessage(model, "没有相关服务~啦啦啦");
            }
        }
    }
}
