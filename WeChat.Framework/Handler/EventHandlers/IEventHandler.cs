using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeChat.Framework.Model.Message;

namespace WeChat.Framework.Handler.EventHandlers
{
    public interface IEventHandler
    {
        BaseMessage Handler();
    }
}
