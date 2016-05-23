using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeChat.Framework.Model.Event;
using WeChat.Framework.Model.Message;

namespace WeChat.Framework.Handler.EventHandlers
{
    public abstract class BaseEventHandler<T> : IEventHandler where T : EventModel, new()
    {
        protected string xmlString;

        public BaseEventHandler(string xmlString)
        {
            this.xmlString = xmlString;
        }

        public BaseMessage Handler()
        {
            T model = new T();
            model.ToModel(xmlString);
            return EventHandler(model);
        }

        protected abstract BaseMessage EventHandler(T model);
        
        #region 获取回复消息(主要是对发件人和收件人的封装，之后可以封装为单独类)

        private void FillMessage(T model, BaseMessage message)
        {
            //注意回复的收发人与收到的相反
            message.FromUserName = model.ToUserName;
            message.ToUserName = model.FromUserName;
            message.CreateTime = DateTime.Now.Ticks;
        }

        protected TextResponseMessage GetTextResponseMessage(T model, string content)
        {
            TextResponseMessage message = new TextResponseMessage();
            FillMessage(model, message);

            message.Content = content;
            return message;
        }

        protected NewsResponseMessage GetNewsResponseMessage(T model, List<Tuple<string, string, string, string>> items)
        {
            NewsResponseMessage message = new NewsResponseMessage();
            FillMessage(model, message);

            foreach (var item in items)
            {
                NewsResponseMessage.ArticlesModel articlesModel = new NewsResponseMessage.ArticlesModel();

                articlesModel.Title = item.Item1;
                articlesModel.Description = item.Item2;
                articlesModel.Url = item.Item3;
                articlesModel.PicUrl = item.Item4;

                message.Articles.Add(articlesModel);
            }
            return message;
        }
        #endregion

    }
}
