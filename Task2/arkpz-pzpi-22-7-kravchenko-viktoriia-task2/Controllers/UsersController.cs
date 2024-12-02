using System.Linq;
using System.Net;
using System.Web.Http;
using AquaTrack.Data.Models;
using AquaTrack.Services;

namespace AquaTrack.Controllers
{
    [RoutePrefix("api/users")]
    public class UsersController : ApiController
    {
        private readonly UserService _service;

        public UsersController(UserService service)
        {
            _service = service;
        }

        [HttpPost]
        [Route("register")]
        public IHttpActionResult Register(User user)
        {
            _service.RegisterUser(user);
            return Ok(user);
        }

        [HttpPost]
        [Route("login")]
        public IHttpActionResult Login(string email, string passwordHash)
        {
            var user = _service.Authenticate(email, passwordHash);
            if (user == null) return Unauthorized();

            return Ok(user);
        }

        [HttpPut]
        [Route("update-profile")]
        public IHttpActionResult UpdateProfile(User updatedUser)
        {
            var user = _service.GetUserById(updatedUser.UserId);
            if (user == null) return NotFound();

            updatedUser.UserId = user.UserId;
            _service.UpdateUser(updatedUser);
            return Ok(updatedUser);
        }

        [HttpGet]
        [Route("list")]
        public IHttpActionResult GetUsers()
        {
            // Симуляція перевірки ролі
            var currentUserRole = "Admin"; // Замінити на реальну перевірку ролі

            if (currentUserRole != "Admin")
            {
                return Content(HttpStatusCode.Forbidden, "Доступ дозволений тільки адміністраторам.");
            }

            var users = _service.GetAllUsers();
            return Ok(users);
        }
    }
}

