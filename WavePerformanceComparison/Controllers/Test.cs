using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NFX.Wave.MVC;
using NFX.Serialization.JSON;

using WavePerformanceComparison.Data;

namespace WavePerformanceComparison.Controllers
{
    public class Test : Controller
    {
        [Action]
        public object EchoJson(JSONDataMap data)
        {    
            return new 
            {
              ServerMessage = "Echo response",
              ServerDateTime = DateTime.Now,
              RequestedData = data
            };
        }
        
        [Action]
        public object Echo(String data)
        {
            return "Echo response: " + data + " at " + DateTime.Now;
            
        }

        [Action]
        public object RandomPerson()
        {
            return Persons.ARandomOne();
        }
    }
}
