﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyPhotoBlog.Models
{
    public class PhotoDetail
    {
        public Photo Photo { get; set; }

        public string NextSlug { get; set; }
        public bool HasNext { get { return !String.IsNullOrWhiteSpace(this.NextSlug);  } }

        public string PreviousSlug { get; set; }
        public bool HasPrevious { get { return !String.IsNullOrEmpty(this.PreviousSlug); } }
        
        public string ErrorMessage { get; set; }
        public bool HasErrorMessage { get { return !String.IsNullOrEmpty(this.ErrorMessage); } }

        public List<Comment> Comments { get; set; }

        public PhotoDetail()
        {
            Comments = new List<Comment>();
        }

    }
}