using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using KK.KKBlog.Business.Interfaces;
using KK.KKBlog.DataAccess.Interfaces;
using KK.KKBlog.DTO.DTOs.AppUserDtos;
using KK.KKBlog.Entities.Concrete;

namespace KK.KKBlog.Business.Concrete
{
    public class AppUserManager : GenericManager<AppUser>, IAppUserService
    {
        private readonly IGenericDal<AppUser> _genericDal;
        public AppUserManager(IGenericDal<AppUser> genericDal) : base(genericDal)
        {
            _genericDal = genericDal;
        }
        public async Task<List<AppUser>> GetAllUsersAsync()
        {
            return await _genericDal.GetAllAsync(I=>I.Id);
        }

        public async Task<AppUser> CheckUserAsync(AppUserLoginDto appUserLoginDto)
        {
            return await _genericDal.GetAsync(I =>
                I.UserName == appUserLoginDto.UserName && I.Password == appUserLoginDto.Password);
        }

        public async Task<AppUser> FindByNameAsync(string userName)
        {
            return await _genericDal.GetAsync(I => I.UserName == userName);
        }
    }
}
