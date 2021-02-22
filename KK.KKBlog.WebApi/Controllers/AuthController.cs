using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using KK.KKBlog.Business.Interfaces;
using KK.KKBlog.Business.Tools.JWTTool;
using KK.KKBlog.DTO.DTOs.AppUserDtos;
using KK.KKBlog.Entities.Concrete;
using KK.KKBlog.WebApi.CustomFilters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KK.KKBlog.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAppUserService _appUserService;
        private readonly IJwtService _jwtService;
        private readonly IMapper _mapper;

        public AuthController(IAppUserService appUserService, IJwtService jwtService, IMapper mapper)
        {
            _appUserService = appUserService;
            _jwtService = jwtService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(_mapper.Map<List<AppUserDto>>(await _appUserService.GetAllUsersAsync()));
        }

        [HttpPost("[action]")]
        [ValidModel]
        public async Task<IActionResult> SignIn(AppUserLoginDto appUserLoginDto)
        {
            var user = await _appUserService.CheckUserAsync(appUserLoginDto);
            if (user != null)
            {
                return Created("", _jwtService.GenerateJwt(user));
            }

            return BadRequest("Kullanıcı adı veya şifre hatalı");
        }
        [HttpGet("[action]")]
        [Authorize]
        public async Task<IActionResult> ActiveUser()
        {
            var user = await _appUserService.FindByNameAsync(User.Identity.Name);

            return Ok(new AppUserDto
            {
                Id = user.Id,
                Name = user.FirstName,
                Surname = user.LastName
            });
        }
        [HttpPost]
        [Authorize]
        [ValidModel]
        public async Task<IActionResult> Create(AppUserAddDto appUserAddDto)
        {
            await _appUserService.AddAsync((_mapper.Map<AppUser>(appUserAddDto)));
            return Created("", appUserAddDto);
        }
    }

}
