using System.Web.Http;
using AquaTrack.Data.Models;
using AquaTrack.Services;

namespace AquaTrack.Controllers
{
    [RoutePrefix("api/limits")]
    public class LimitsController : ApiController
    {
        private readonly LimitService _service;

        public LimitsController(LimitService service)
        {
            _service = service;
        }

        [HttpPost]
        [Route("create")]
        public IHttpActionResult CreateLimit(Limit limit)
        {
            _service.CreateLimit(limit);
            return Ok(limit);
        }

        [HttpPut]
        [Route("update/{limitId}")]
        public IHttpActionResult UpdateLimit(int limitId, Limit updatedLimit)
        {
            var limit = _service.GetLimitById(limitId);
            if (limit == null) return NotFound();

            updatedLimit.LimitId = limitId;
            _service.UpdateLimit(updatedLimit);
            return Ok(updatedLimit);
        }

        [HttpDelete]
        [Route("delete/{limitId}")]
        public IHttpActionResult DeleteLimit(int limitId)
        {
            var limit = _service.GetLimitById(limitId);
            if (limit == null) return NotFound();

            _service.DeleteLimit(limitId);
            return Ok();
        }
    }
}

