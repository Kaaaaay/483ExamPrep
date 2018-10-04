using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___Interfaces
{
    public interface IOutputFormatter<T>
    {
        string GetOutput(IEnumerator<T> iterator, int recordSize);
    }
}
