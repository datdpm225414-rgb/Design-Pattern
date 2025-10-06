using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225452_DoanTrongNhan_MyWorld22_Template
{
    public class ConcreteClassB : AbstractClass
    {
        public override void PrimitiveOperation1()
        {
            Console.WriteLine("B.B1()");
        }
        public override void PrimitiveOperation2()
        {
            Console.WriteLine("B.B2()");
        }
    }
}
