using LogApi.Dto;
using LogApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Collections.Generic;

namespace LogApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LogsController : ControllerBase
    {
        private readonly ServiceFactory _serviceFactory;
        private readonly IService _service;

        public LogsController(IOptions<LoggerOptions> options)
        {
            _serviceFactory = new ServiceFactory(options.Value.Destination);
            _service = _serviceFactory.GetService();
        }

        [HttpGet]
        public ActionResult<IEnumerable<LogDto>> GetLog()
        {
            if (!_service.ReadsAllowed())
            {
                Response.Headers.Add("Allow", "POST");
                return StatusCode(StatusCodes.Status405MethodNotAllowed);
            }
            
            return Ok(_service.ReadAll());

        }
        
        [HttpGet("{id}")]
        public ActionResult<LogDto> GetLogByKey(int id)
        {
            if (!_service.ReadsAllowed())
            {
                Response.Headers.Add("Allow", "POST");
                return StatusCode(StatusCodes.Status405MethodNotAllowed);
            }

            if (!_service.Exists(id))
                return NotFound();

            return Ok(_service.Read(id));
        }

        [HttpPost(Name = nameof(PostLog))]
        public ActionResult<LogDto> PostLog([FromBody]LogDto request)
        {
            _service.Create(request);
            return CreatedAtRoute(nameof(PostLog), request);
        }
    }
}
