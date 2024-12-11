using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Povedenceskie_patterni
{
    internal class Request
    {
        public RequestType Type { get; set; }
        public string Description { get; set; }

        public Request(RequestType type, string description)
        {
            Type = type;
            Description = description;
        }
    }
}
