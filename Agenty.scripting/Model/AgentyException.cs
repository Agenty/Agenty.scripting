using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentyScripting
{
    class AgentyException : Exception
    {
        public AgentyException(string message) : base(message) { }
    }
}
