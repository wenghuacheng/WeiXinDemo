using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace WeChat.Framework.Model.Message
{
    [XmlRoot("xml")]
    public class NewsResponseMessage : BaseMessage
    {
        public NewsResponseMessage()
        {
            Articles = new List<ArticlesModel>();
        }

        /// <summary>
        /// 图文消息个数，限制为10条以内
        /// </summary>
        [XmlElement("ArticleCount")]
        public int ArticleCount
        {
            get { return Articles.Count; }
            set { ; }
        }

        [XmlArrayItem("item")]
        public List<ArticlesModel> Articles { get; set; }

        public override MsgType MsgType
        {
            get
            {
                return MsgType.NEWS;
            }
        }

        public class ArticlesModel
        {
            protected XmlDocument doc = new XmlDocument();

            #region Properties
            /// <summary>
            /// 图文消息标题
            /// </summary>
            [XmlIgnore]
            public string Title { get; set; }

            /// <summary>
            /// 图文消息描述
            /// </summary>
            [XmlIgnore]
            public string Description { get; set; }

            /// <summary>
            /// 图片链接，支持JPG、PNG格式，较好的效果为大图360*200，小图200*200
            /// </summary>
            [XmlIgnore]
            public string PicUrl { get; set; }

            /// <summary>
            /// 点击图文消息跳转链接
            /// </summary>
            [XmlIgnore]
            public string Url { get; set; }
            #endregion

            #region Serialize Properties
            [XmlElement("Title")]
            public XmlCDataSection CTitle
            {
                get
                {
                    return doc.CreateCDataSection(Title);
                }
                set
                {
                    Title = value.Value;
                }
            }

            [XmlElement("Description")]
            public XmlCDataSection CDescription
            {
                get
                {
                    return doc.CreateCDataSection(Description);
                }
                set
                {
                    Description = value.Value;
                }
            }

            [XmlElement("PicUrl")]
            public XmlCDataSection CPicUrl
            {
                get
                {
                    return doc.CreateCDataSection(PicUrl);
                }
                set
                {
                    PicUrl = value.Value;
                }
            }

            [XmlElement("Url")]
            public XmlCDataSection CUrl
            {
                get
                {
                    return doc.CreateCDataSection(Url);
                }
                set
                {
                    Url = value.Value;
                }
            }
            #endregion
        }
    }
}
