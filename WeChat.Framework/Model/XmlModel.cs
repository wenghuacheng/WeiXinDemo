using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace WeChat.Framework.Model
{
    [Serializable]
    [XmlRoot(ElementName = "xml")]
    public abstract class XmlModel
    {
    }
}
