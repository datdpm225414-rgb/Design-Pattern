using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TranNamDat_Myworld02_AbstractFactory
{
    public class AsiaFurnitureFactory : FurnitureFactory
    {
        public override Chair CreateChair()
        {
            return new AsianChair();
        }

        public override Table CreateTable()
        {
            return new AsianTable();
        }

        public override Lamp CreateLamp()
        {
            return new AsianLamp();
        }
    }
}
