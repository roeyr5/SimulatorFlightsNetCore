using System;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimulatorFlights.Files;
using SimulatorFlights.Entities;
namespace SimulatorFlights.Services
{
    public class SimulatorService : ISimulatorService
    {
        public SimulatorService()
        {
 
        }
        public async Task<string> FetchDataFromICD()
        {
            string JsonContent =  File.ReadAllText(ICD.FirstFilePath);
            List<RowMessage> DataList = JsonConvert.DeserializeObject<List<RowMessage>>(JsonContent);
            
            for(int i = 0; i < DataList.Count(); i++)
            {
                Random rnd = new Random();
                int random = rnd.Next(DataList[i].Min, DataList[i].Max +1);
                string binary = Convert.ToString(random, 2);

                // add to here the startbit / bit 
            }


            return await Task.FromResult("done");
        }

    }   
}
