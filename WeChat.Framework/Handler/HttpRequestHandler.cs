using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace WeChat.Framework.Handler
{
    public class HttpRequestHandler
    {
        HttpRequest Request = null;
        HttpResponse Response = null;

        PostHandler handler = new PostHandler();

        public HttpRequestHandler(HttpRequest Request, HttpResponse Response)
        {
            this.Request = Request;
            this.Response = Response;
        }

        public void ProcessRequest()
        {
            string postString = string.Empty;
            if (Request.HttpMethod.ToUpper() == "POST")
            {
                using (Stream stream = Request.InputStream)
                {
                    Byte[] postBytes = new Byte[stream.Length];
                    stream.Read(postBytes, 0, (Int32)stream.Length);
                    postString = Encoding.UTF8.GetString(postBytes);
                }

                if (!string.IsNullOrEmpty(postString))
                {
                    var response = handler.Execute(postString);

                    if (!string.IsNullOrEmpty(response))
                    {
                        Response.Write(response);                       
                    }
                }
            }
            else
            {
                Auth();
            }
        }

        private void Auth()
        {
            string echoString = Request.QueryString["echoStr"];
            string signature = Request.QueryString["signature"];
            string timestamp = Request.QueryString["timestamp"];
            string nonce = Request.QueryString["nonce"];

            if (!string.IsNullOrEmpty(echoString))
            {
                Response.Write(echoString);
                Response.End();
            }
        }
    }
}
