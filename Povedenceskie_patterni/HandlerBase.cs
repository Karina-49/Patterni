using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Povedenceskie_patterni
{
    public abstract class HandlerBase : Handler
    {
        private Handler _nextHandler;

        public void SetNext(Handler handler)
        {
            _nextHandler = handler;
        }

        public virtual void HandleRequest(string request)
        {
            if (_nextHandler != null)
            {
                _nextHandler.HandleRequest(request);
            }
            else
            {
                Console.WriteLine("Запрос не обработан.");
            }
        }
    }
}
