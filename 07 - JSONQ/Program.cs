using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07___JSONQ
{
    class Name
    {
        public int[] Values { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public static Name ConvertToName(string json)
        {
            var ser = new JavaScriptSerializer();

            return ser.Deserialize<Name>(json);
        }

        static void Main(string[] args)
        {

        }
    }
}
