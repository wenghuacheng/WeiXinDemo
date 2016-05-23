using WeChat.Framework.Model.Message;

namespace WeChat.Framework.Handler.MessageHandlers
{
    public interface IMessageHandler
    {
        BaseMessage Handler();
    }
}
