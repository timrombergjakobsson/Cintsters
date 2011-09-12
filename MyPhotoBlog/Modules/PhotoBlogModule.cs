using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;

namespace MyPhotoBlog.Modules
{
    public class PhotoBlogModule : NancyModule
    {
        public PhotoBlogModule() : base()
        {
            
        }
        public PhotoBlogModule( string modulePath) : base(modulePath)
        {

        }
    }
}