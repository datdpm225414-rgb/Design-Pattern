using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TranNamDat_Myworld02_AbstractFactory
{
    public class EuropeFurnitureFactory : FurnitureFactory
    {
        public override Chair CreateChair()
        {
            return new EuropeanChair();
        }

        public override Table CreateTable()
        {
            return new EuropeanTable();
        }

        public override Lamp CreateLamp()
        {
            return new EuropeanLamp();
        }
    }
}
