using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;
using System;

namespace Quantum.QuantumComputingSamples
{
    class Driver
    {
        static void Main(string[] args)
        {
            using (var simulator = new QuantumSimulator())
            {
                var result = Operation.Run(simulator).Result;
            }

            Console.ReadLine();
        }
    }
}