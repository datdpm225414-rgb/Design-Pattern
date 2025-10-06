using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TranNamDat_Pattern04_PrototypePattern
{
    public class ConcretePrototype2 : Prototype
    {
        public ConcretePrototype2(string id)
    : base(id)
        {
        }
        // Returns a shallow copy
        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }

    }
}
