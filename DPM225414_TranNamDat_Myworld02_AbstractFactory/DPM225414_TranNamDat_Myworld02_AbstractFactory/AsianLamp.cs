using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TranNamDat_Myworld02_AbstractFactory
{
    public class AsianLamp : Lamp
    {
        public override void TurnOn()
        {
            Console.WriteLine("Bật đèn Châu Á.");
        }
    }
}
