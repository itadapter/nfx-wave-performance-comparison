using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NFX.ApplicationModel;
using NFX.Wave;
using NFX;

namespace WavePerformanceComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
               Data.Persons.ARandomOne();

                using (new ServiceBaseApplication(args, null))
                using (var ws = new WaveServer())
                {
                    ws.Configure(null);
                    ws.Start();
                    Console.WriteLine("Web server started. Press <ENTER> to terminate...");
                    Console.ReadLine();
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Exception");
                Console.WriteLine("----------------");
                Console.WriteLine(error.ToMessageWithType());
                System.Environment.ExitCode = -1;
            }
        }
    }
}
