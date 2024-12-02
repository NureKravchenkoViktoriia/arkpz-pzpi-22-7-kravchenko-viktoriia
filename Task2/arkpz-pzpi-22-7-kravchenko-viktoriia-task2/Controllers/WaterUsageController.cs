using System.Web.Http;
using AquaTrack.Services;

namespace AquaTrack.Controllers
{
    [RoutePrefix("api/water-usage")]
    public class WaterUsageController : ApiController
    {
        private readonly WaterUsageService _service;

        public WaterUsageController(WaterUsageService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("current")]
        public IHttpActionResult GetCurrentUsage()
        {
            var currentUsage = _service.GetCurrentUsage();
            return Ok(currentUsage);
        }

        [HttpGet]
        [Route("history")]
        public IHttpActionResult GetHistory()
        {
            var history = _service.GetUsageHistory();
            return Ok(history);
        }
    }
}

