using Microsoft.AspNetCore.Mvc;
using SimulatorFlights.Services;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimulatorFlights.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SimulatorController : ControllerBase
    {
        private readonly ISimulatorService ISimulatorService;
        //private readonly ILogger<SimulatorController> _logger;

        public SimulatorController(ISimulatorService SimulatorService)
        {
            ISimulatorService = SimulatorService;
        }

        [HttpGet("JsonContent")]
        public async Task<ActionResult<string>> GetJsonContent()
        {
            await ISimulatorService.FetchDataFromICD();
            return Ok(new { message = "Got" });
        }
    }
}
