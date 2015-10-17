using System;
using System.IO;
using System.Web;
using WSMarket.Core;

namespace DocumentService
{
    /// <summary>
    /// Summary description for GetDocument
    /// </summary>
    public class GetDocument : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            SetHTTPResponseAttributes(context);

            DocumentTypes type = (DocumentTypes)Enum.Parse(typeof(DocumentTypes), context.Request.QueryString["type"]);
            string filename = context.Request.QueryString["filename"];
            string path = Path.GetFullPath(System.Web.Hosting.HostingEnvironment.ApplicationPhysicalPath + "/DocumentStore/" + type.ToString());
            
            context.Response.Clear();
            context.Response.ContentType = "image/JPEG";

            context.Response.WriteFile(path + "/" + filename);
            context.Response.End();
            
        }

        private void SetHTTPResponseAttributes(HttpContext context)
        {
            TimeSpan timeToCache = new TimeSpan(1, 0, 0, 0);

            context.Response.Cache.SetExpires(DateTime.Now.Add(timeToCache));
            context.Response.Cache.SetMaxAge(timeToCache);
            context.Response.Cache.SetCacheability(HttpCacheability.Public);
            context.Response.Cache.SetValidUntilExpires(true);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}