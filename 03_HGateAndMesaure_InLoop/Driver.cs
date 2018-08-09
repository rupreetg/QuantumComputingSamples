using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;
using System;

namespace Quantum._03_HGateAndMesaure_InLoop
{
    class Driver
    {
        static void Main(string[] args)
        {
            using (var simulator = new QuantumSimulator())
            {
                var result = HGateAndMesaureInLoopOperation.Run(simulator).Result;
            }

            Console.ReadLine();
        }
    }
}