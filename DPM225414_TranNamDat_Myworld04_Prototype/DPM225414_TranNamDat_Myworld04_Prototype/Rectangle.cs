using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TranNamDat_Myworld04_Prototype
{
    public class Rectangle : Shape
    {
        public override Shape Clone()
        {
            return (Shape)this.MemberwiseClone();
        }

    }
}
