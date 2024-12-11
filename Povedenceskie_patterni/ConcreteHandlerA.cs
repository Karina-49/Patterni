using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Povedenceskie_patterni
{
    public class ConcreteHandlerA : HandlerBase
    {
        public override void HandleRequest(string request)
        {
            if (request == "TypeA")
            {
                Console.WriteLine("ConcreteHandlerA обработал запрос типа A.");
            }
            else
            {
                base.HandleRequest(request);
            }
        }
    }
}
