using CleanArchitecture.Sample.Application.Contracts.Logics;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Sample.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        private readonly IGadgetLogic _gadgetLogic;
        public TestController(IGadgetLogic gadgetLogic)
        {
            _gadgetLogic = gadgetLogic;
        }
        [HttpGet]
        [Route("all-gadgets")]
        public IActionResult GetGadgets()
        {
            return Ok(_gadgetLogic.GetAll());
        }
    }
}