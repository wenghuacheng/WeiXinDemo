using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeChat.Framework.Model.Menu
{
    public class MenuModel : JsonModel
    {
        public MenuModel()
        {
            button = new List<ButtonModel>();
        }

        public List<ButtonModel> button { get; set; }
    }
}
