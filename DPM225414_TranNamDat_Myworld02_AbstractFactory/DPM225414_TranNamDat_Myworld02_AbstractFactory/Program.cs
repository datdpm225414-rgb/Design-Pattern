using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TranNamDat_Myworld02_AbstractFactory
{
    public class Program
    {
        public static void Main()
        {
            FurnitureFactory asiaFactory = new AsiaFurnitureFactory();
            FurnitureWorld asiaWorld = new FurnitureWorld(asiaFactory);
            asiaWorld.UseFurniture();

            Console.WriteLine();

            FurnitureFactory europeFactory = new EuropeFurnitureFactory();
            FurnitureWorld europeWorld = new FurnitureWorld(europeFactory);
            europeWorld.UseFurniture();

            Console.ReadKey();
        }
    }
}
