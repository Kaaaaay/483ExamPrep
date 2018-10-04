using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02___StringFormatting
{
    class Program
    {
        static void Main(string[] args)
        {
            GetValidEmailAddresses("karabo.mtimkulu@smollan.com","abc@def.com");


            Console.ReadLine();
        }

        private static List<String> GetValidEmailAddresses(string input, string pattern)
        {
            var regex   = new Regex(pattern);
            var matches = regex.Matches(input);
            return (from Match match in matches where match.Success select match.Value).ToList();
        }

        private static List<String> GetValidEmailAddressesTwo(string input, string pattern)
        {
            var regex = new Regex(pattern);
            var matches = regex.Matches(input);
            var validEmailAddresses = new List<String>();

            foreach (Match match in matches)
            {
                if (match.Success)
                {
                    validEmailAddresses.Add(match.Value);
                }
            }
            return validEmailAddresses;
        }

    }
}
