using System;
using System.Collections.Generic;
using System.Text;
using KK.KKBlog.DataAccess.Interfaces;
using KK.KKBlog.Entities.Concrete;

namespace KK.KKBlog.DataAccess.Concrete.EntityFrameworkCore.Repository
{
    public class EfAppUserRepository: EfGenericRepository<AppUser>,IAppUserDal
    {

    }
}
