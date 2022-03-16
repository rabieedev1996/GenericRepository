using CodeFirst.DBContext;
using CodeFirst.Infrastructure.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst.Controller
{
    [Route("Home")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        UnitOfWork _Context;
        IUserRepository _userRepository;
        public HomeController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
            _Context = new UnitOfWork();
        }
        [HttpGet]
        [Route("Sample")]
        public async Task<IActionResult> Sample()
        {  
            //
            var users =(await _Context.Users.GetAsync(a=>a.Username=="Rabiee")).FirstOrDefault();
            users =(await _userRepository.GetAsync(a=>a.Username=="Rabiee")).FirstOrDefault();
            return Ok();
        }
    }
}
