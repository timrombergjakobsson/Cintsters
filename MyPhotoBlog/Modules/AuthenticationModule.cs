using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;

namespace MyPhotoBlog.Modules
{
    public class AuthenticationModule : PhotoBlogModule
    {
        public AuthenticationModule() : base()
        {
            Get["/login"] = parameters =>
            {
                return "Display the loginform";
            };

            Post["/login"] = parameters =>
            {
                // Perform validation then redirect
                return Response.AsRedirect("/admin/photos");

            };

            Post["/logout"] = parameters =>
            {
                // logout and redirect
                return Response.AsRedirect("/login");
            };
 
        }
    }
}