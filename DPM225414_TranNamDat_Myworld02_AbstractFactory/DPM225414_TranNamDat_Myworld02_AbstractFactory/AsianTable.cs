using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TranNamDat_Myworld02_AbstractFactory
{
    public class AsianTable : Table
    {
        public override void UseTable()
        {
            Console.WriteLine("Sử dụng bàn Châu Á.");
        }
    }
}
