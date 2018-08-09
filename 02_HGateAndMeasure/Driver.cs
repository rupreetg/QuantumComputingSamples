using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;
using System;

namespace Quantum._02_HGateAndMeasure
{
    class Driver
    {
        static void Main(string[] args)
        {
            using (var simulator = new QuantumSimulator())
            {
                var result = HGateAndMeasureOperation.Run(simulator).Result;
            }

            Console.ReadLine();
        }
    }
}