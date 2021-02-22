using System;
using System.Collections.Generic;
using System.Text;
using KK.KKBlog.Entities.Concrete;

namespace KK.KKBlog.Business.Tools.JWTTool
{
    public interface IJwtService
    {
        JwtToken GenerateJwt(AppUser appUser);
    }
}
