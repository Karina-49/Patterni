using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Povedenceskie_patterni
{
    public interface IIterator
    {
        bool HasNext();  
        int Next();      
    }
}
