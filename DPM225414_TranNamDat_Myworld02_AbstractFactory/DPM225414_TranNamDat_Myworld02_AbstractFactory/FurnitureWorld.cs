using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TranNamDat_Myworld02_AbstractFactory
{
    public class FurnitureWorld
    {
        private Chair _chair;
        private Table _table;
        private Lamp _lamp;
        public FurnitureWorld(FurnitureFactory factory)
        {
            _chair = factory.CreateChair();
            _table = factory.CreateTable();
            _lamp = factory.CreateLamp();
        }
        public void UseFurniture()
        {
            _chair.SitOn();
            _table.UseTable();
            _lamp.TurnOn();
        }
    }
}
