using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TranNamDat_Myworld02_AbstractFactory
{
    public class AsianChair : Chair
    {
        public override void SitOn()
        {
            Console.WriteLine("Ngồi trên ghế Châu Á.");
        }
    }
}
