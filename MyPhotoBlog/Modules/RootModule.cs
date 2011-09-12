using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;

namespace MyPhotoBlog.Modules
{
    public class RootModule : PhotoBlogModule
    {
        public RootModule(): base()
        {
            Get["/"] = parameters =>
            {
                return View["photodetail"];
            };
        }
    }
}