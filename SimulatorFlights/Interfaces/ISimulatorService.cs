using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimulatorFlights.Services
{
    public interface ISimulatorService
    {
        public Task<string> FetchDataFromICD();
    }
}
