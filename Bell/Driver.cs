using System;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace Quantum.Bell
{
    class Driver
    {
        static void Main(string[] args)
        {

            var qsim = new ResourcesEstimator();
            BellTest.Run(qsim, 1000, Result.Zero).Wait();
            System.Console.WriteLine(qsim.ToTSV());

            //using (var qsim = new QuantumSimulator())
            //{
            //    //Try initial values
            //    Result[] initials = new Result[] { Result.Zero, Result.One };
            //    foreach (Result initial in initials)
            //    {
            //        var res = BellTest.Run(qsim, 1000, initial).Result;
            //        var (numZeroes, numOnes, agree) = res;
            //        System.Console.WriteLine($"Init:{initial,-4} 0s={numZeroes,-4} 1s={numOnes,-4} agree={agree, -4}");
            //    }
            //}

            System.Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}