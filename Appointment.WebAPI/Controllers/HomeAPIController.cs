using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Appointment.ModelView;
using Appointment.BusinessLayer;

namespace Appointment.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HomeAPIController : ControllerBase
    {
        private IBusiness _business;

        public HomeAPIController(IBusiness business)
        {
            _business = business;
        }

        [HttpPost]
        public IActionResult Register([FromBody] SignUpModel newUser)
        {
            return Ok(_business.Register(newUser));

        }

        [HttpPost]
        public IActionResult IsValidUser(LogInModel user)
        {
            int userid = _business.IsValidUser(user);
            return Ok(userid);
        }

        [HttpGet]
        public IActionResult IsEmailExists(string email)
        {
            return Ok(_business.IsEmailExists(email));
        }

    }
}
