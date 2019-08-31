using System;
using System.Collections.Generic;
using System.Text;

namespace OperationsBasic
{
    class SumNumbers : Operations
    {
        //PARAMETHERS INSIDE THIS CLASS
        int a;
        int b;
        string name;

        //THIS IS THE CONSTRUCTOR THAT DEFINES THE PARMETHERS
        public SumNumbers(){

            name = "luca;";
            a = 6;
            b = 5;
            }

        //THIS IS JUST A CLASS OF THE CHILDREN
        public void writeNames()
        {
            //DO SOMETHING
        }


        //THE PARENT METHOD
        //OVERWRITING THE CLASS IN THE PARENT OPERATION
        public override void OperationWithChildren()
        {
            Console.WriteLine("this is x " + a);
            Console.WriteLine("this is y " + b);
            int c = a + b;
            Console.WriteLine("this is the sum from children: " + c);
        }



    }
}
