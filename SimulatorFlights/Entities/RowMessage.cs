using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimulatorFlights.Entities
{
    public class RowMessage
    {
        public string Id { get; set; }
        public string Location { get; set; }
        public string Name { get; set; }
        public string Mask { get; set; }
        public string StartBit { get; set; }
        public string Bit { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
    }
}
