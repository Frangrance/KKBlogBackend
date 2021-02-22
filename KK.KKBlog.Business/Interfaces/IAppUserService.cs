using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using KK.KKBlog.DTO.DTOs.AppUserDtos;
using KK.KKBlog.Entities.Concrete;

namespace KK.KKBlog.Business.Interfaces
{
    public interface IAppUserService : IGenericService<AppUser >
    {
        Task<AppUser> CheckUserAsync(AppUserLoginDto appUserLoginDto);
        Task<AppUser> FindByNameAsync(string userName);
        Task<List<AppUser>> GetAllUsersAsync();
    }
}
