using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TranNamDat_Myworld02_AbstractFactory
{
    public abstract class FurnitureFactory
    {
        public abstract Chair CreateChair();
        public abstract Table CreateTable();
        public abstract Lamp CreateLamp();
    }
}
