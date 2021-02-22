using System;
using System.Collections.Generic;
using System.Text;
using KK.KKBlog.Entities.Interfaces;

namespace KK.KKBlog.Entities.Concrete
{
    public class AppUser:ITable
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}
