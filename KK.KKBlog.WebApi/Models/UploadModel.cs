using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KK.KKBlog.WebApi.Enums;

namespace KK.KKBlog.WebApi.Models
{
    public class UploadModel
    {
        public string NewName { get; set; }
        public string ErrorMessage { get; set; }
        public UploadState UploadState { get; set; }

    }
}
