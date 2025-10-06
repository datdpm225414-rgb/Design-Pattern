using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TranNamDat_Pattern01_BuiderPattern
{

        abstract class Builder
        {
            public abstract void BuildPartA();
            public abstract void BuildPartB();
            public abstract Product GetResult();
        }
    


}
