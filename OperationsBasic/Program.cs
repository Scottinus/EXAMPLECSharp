using System;

namespace OperationsBasic
{
    class Program
    {

        //THIS METHOD "MAIN" RUN THE PROGRAM WITH ALL THE INSTRUCTION INSIDE OF IT
        static void Main(string[] args)
        {

            //WE ARE CALLLING THE STANDARD METHOD IN THE OPERATIONS CLASS
            var sum = new Operations();

            int result = sum.SumNumber(5, 6);
            Console.WriteLine("Result of the standard method inside Operations" + result);

            //HERE WE ARE CALLING THE METHOD TO BE OVERWRITED TO SHOW THAT IT HAS HIS INSTRUCTIONS IF WE DON'T CALL FROM THE CHILDREN
            sum.OperationWithChildren();

            //WE ARE CALLING THE METHOD OVERWRITED FROM THE CHILDREN
            var sumChildren = new SumNumbers();
            sumChildren.OperationWithChildren();

            //WE ARE CALLING THE METHOD OVERWRITED FROM THE CHILDREN
            var difChildren = new DiffNumbers();
            difChildren.OperationWithChildren();
        }
    }
}
