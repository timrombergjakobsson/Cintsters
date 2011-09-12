using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;
using MyPhotoBlog.Services;

namespace MyPhotoBlog.Modules
{
    public abstract class PhotoBlogModule : NancyModule
    {
        protected dynamic DB;
        
        public PhotoBlogModule(IDBFactory dbFactory) : base()
        {
            DB = dbFactory.DB();
            
        }
        public PhotoBlogModule(IDBFactory dbFactory, string modulePath) : base(modulePath)
        {
            DB = dbFactory.DB();

        }
    }
}