using System;
using System.Collections.Generic;
using System.Text;

namespace OperationsBasic
{
     class Operations
    {

        //METHOD THAT CAN BE EXECTUED IN THIS CLASS
        //IF THIS IS NOT VOID, YOU HAVE TO RETURN SOME VALUE BASED ON WHAT U ARE DECLARING ON THE METHOD:
        // FOR EXAMPLE HERE WE WANT TO RETURN AN INT ("public int") AND SO WE HAVE TO RETURN AN INTEGER AS VALUE INSIDE THE METHOD
        public int SumNumber(int x, int y)
        {       
            int z = x + y;
            return z;
        }

        //METHOD THAT WE WANT TO BE OVEWRTIED FROM HIS CHILDREN (SumNumbers - DiffNumbers)
        virtual public void OperationWithChildren()
        {
                 int a = 1;
                int b = 4;
            int c = a + b;
            Console.WriteLine("this is the sum from parent: " + c);
        }


    }
}
