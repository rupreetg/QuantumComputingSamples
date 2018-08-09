namespace Quantum._02_HGateAndMeasure
{
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
	open Microsoft.Quantum.Extensions.Convert;

    operation HGateAndMeasureOperation () : ()
    {
        body
        {
			//Create one QuBit. By default, the value is Zero. [1] defines how many Qubit do we need, its an array of 1
            using(qubits = Qubit[1])
			{
				//accessing first qubit using array notation [0]
				let initialValue = M(qubits[0]);
				if(initialValue == Zero)
				{
					Message("Initial Value is Zero");
				}

				if(initialValue == One)
				{
					Message("Initial Value is One");
				}
					
				//use Hadamard gate on the first qubit to put it in superposition
				H(qubits[0]);

				//Measure again now ..
				let value = M(qubits[0]);

				if(value == Zero)
				{
					Message("Qubit Value post superposition is Zero");
				}

				if(value == One)
				{
					Message("Qubit Value post superposition is One");
				}

				ResetAll(qubits);
			}
		}
    }
}
