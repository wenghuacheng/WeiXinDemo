using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace WeChat.Framework.Model.Token
{
    public class AccessTokenModel : JsonModel
    {
        public string access_token { get; set; }

        public int expires_in { get; set; }

    }
}
