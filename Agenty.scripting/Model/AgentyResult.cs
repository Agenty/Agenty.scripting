using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentyScripting
{
    class AgentyResponse
    {
        public long? total { get; set; }
        public int? limit { get; set; }
        public int? offset { get; set; }
        public int? returned { get; set; }
        public List<dynamic> result { get; set; }
    }
}
