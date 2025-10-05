using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TranNamDat_Pattern10_FacadeReal
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Mortgage mortgage = new Mortgage();
            Customer customer = new Customer("Ann McKinsey");
            bool eligible = mortgage.IsEligible(customer, 125000);
            Console.WriteLine("\n" + customer.Name +
                    " has been " + (eligible ? "Approved" : "Rejected"));
            Console.ReadKey();
        }
    }
}
