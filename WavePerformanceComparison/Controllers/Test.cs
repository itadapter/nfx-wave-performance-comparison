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
        
        /// <summary>
        /// Echoes an JSON data packed into the new JSON message
        /// </summary>
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
        
        /// <summary>
        /// Simple string echo - receives a plain text data and returns it to the caller with dynamic content added
        /// </summary>
        [Action]
        public object Echo(String data)
        {
            return "Echo response: " + data + " at " + DateTime.Now;
            
        }

        /// <summary>
        /// Returns a Dictionary (to be encoded as JSON to send it to the caller) with a random Person object
        /// </summary>
        [Action]
        public object RandomPerson()
        {
            return new 
            {
                ServerDateTime = DateTime.Now,
                person = Persons.ARandomOne()
            };
        }

        /// <summary>
        /// Returns a random string of specified length
        /// </summary>
        [Action]
        public object RandomPayload(int length)
        {
            return
                WavePerformanceComparison.Data.RandomPayload.generate(length);
           
        }
    }
}
