using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___Interfaces
{

    public class TabDelimitedFormatter : IOutputFormatter<string>
    {
        readonly Func<int, char> suffix = col => col % 2 == 0 ? '\n' : '\t';
        public string GetOutput(IEnumerator<string> iterator, int recordSize)
        {
            var output = new StringBuilder();
            for (int i = 1; iterator.MoveNext(); i++)
            {
                output.Append(iterator.Current);
                output.Append(suffix(i));
            }
            return output.ToString();
        }
        static void Main(string[] args)
        {
            string karabo = "Billionaire";
            
           
            Console.ReadLine();
        }
    }
}
