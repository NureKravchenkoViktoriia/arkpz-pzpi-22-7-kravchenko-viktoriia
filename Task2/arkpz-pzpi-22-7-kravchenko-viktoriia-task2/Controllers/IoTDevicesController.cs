using System.Web.Http;
using AquaTrack.Data.Models;
using AquaTrack.Services;

namespace AquaTrack.Controllers
{
    [RoutePrefix("api/iot-devices")]
    public class IoTDevicesController : ApiController
    {
        private readonly IoTDeviceService _service;

        public IoTDevicesController(IoTDeviceService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("list")]
        public IHttpActionResult GetDevices()
        {
            var devices = _service.GetAllDevices();
            return Ok(devices);
        }

        [HttpPost]
        [Route("register")]
        public IHttpActionResult RegisterDevice(IoTDevice device)
        {
            _service.AddDevice(device);
            return Ok(device);
        }

        [HttpDelete]
        [Route("delete/{deviceId}")]
        public IHttpActionResult DeleteDevice(int deviceId)
        {
            var device = _service.GetDeviceById(deviceId);
            if (device == null) return NotFound();

            _service.DeleteDevice(deviceId);
            return Ok();
        }
    }
}

