using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05___Using_Assertions_to_Find_Bugs_Faster
{
    class Program
    {
    
        static bool Contains (decimal[] values, decimal value)
        {
            if (values == null)
            {
                throw new ArgumentNullException("values", "Array must not be null");
            }
            foreach (var item in values)
            {
                if (item == value)
                {
                    return true;
                }
                return false;
            }
        }
        
    }
}

