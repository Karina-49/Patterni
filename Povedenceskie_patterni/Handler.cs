using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Povedenceskie_patterni
{
    public interface Handler
    {
        void SetNext(Handler handler);
        void HandleRequest(string request);
    }
}
