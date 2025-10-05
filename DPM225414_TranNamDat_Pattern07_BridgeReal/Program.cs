using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TranNamDat_Pattern07_BridgeReal
{
    public class Program
    {

        public static void Main(string[] args)
        {
            var customers = new Customers();
            customers.Data = new CustomersData("Chicago");
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Add("Henry Velasquez");
            customers.ShowAll();
            Console.ReadKey();
        }
    }
}
