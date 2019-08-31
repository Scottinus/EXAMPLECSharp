using System;
using System.Collections.Generic;
using System.Text;

namespace OperationsBasic
{
    class DiffNumbers : Operations
    {




        //OVERWRITING THE CLASS IN THE PARENT OPERATION
        public override void OperationWithChildren()
        {
            int a = 10;
            int b = 5;
            Console.WriteLine("this is x " + a);
            Console.WriteLine("this is y " + b);
            int c = a - b;
            Console.WriteLine("this is the difference from children: " + c);
        }
    }
}
