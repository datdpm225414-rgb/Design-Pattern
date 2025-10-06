using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TranNamDat_Real16_Iterator
{
    public interface IAbstractCollection
    {
        Iterator CreateIterator();

    }
}
