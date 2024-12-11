using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Povedenceskie_patterni
{
    public class ConcreteHandlerC : HandlerBase
    {
        public override void HandleRequest(string request)
        {
            if (request == "TypeC")
            {
                Console.WriteLine("ConcreteHandlerC обработал запрос типа C.");
            }
            else
            {
                base.HandleRequest(request);
            }
        }
    }
}
