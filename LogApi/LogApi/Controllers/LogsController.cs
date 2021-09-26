using LogApi.Dto;
using LogApi.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace LogApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LogsController : ControllerBase
    {
        private readonly ServiceFactory _serviceFactory;
        private readonly IService _service;

        public LogsController(IOptions<LoggerOptions> options)
        {
            _serviceFactory = new ServiceFactory(options.Value.Destination);
            _service = _serviceFactory.GetService();
        }

        [HttpPost]
        public ActionResult<LogDto> PostLog([FromBody] LogDto request)
        {
            _service.Create(request);
            return Ok(); // TODO: Change to CreatedAtRoute or similar
        }
    }
}
