using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Povedenceskie_patterni
{
    public class ConcreteHandlerB : HandlerBase
    {
        public override void HandleRequest(string request)
        {
            if (request == "TypeB")
            {
                Console.WriteLine("ConcreteHandlerB обработал запрос типа B.");
            }
            else
            {
                base.HandleRequest(request);
            }
        }
    }
}
