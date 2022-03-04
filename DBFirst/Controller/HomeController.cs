using CodeFirst.DBContext;
using CodeFirst.Repositories.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst.Controller
{
    [Route("Home")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        IUserRepository _userRepository;
        UnitOfWork _Context;
        public HomeController(IUserRepository userRepository)
        {
            _Context = new UnitOfWork();
            _userRepository = userRepository;
        }
        [HttpGet]
        [Route("Sample")]
        public async Task<IActionResult> Sample()
        {
           
            var users =await _Context.users.GetAllAsync();
            users=await _userRepository.GetAllAsync();
            return Ok();
        }
    }
}
