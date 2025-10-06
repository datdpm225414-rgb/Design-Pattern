using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TranNamDat_Myworld01_Builder
{
    public class Program
    {
        public static void Main()
        {
            PizzaBuilder builder;

            PizzaShop shop = new PizzaShop();

            builder = new AmericanPizzaBuilder();
            shop.Construct(builder);
            builder.Pizza.Show();

            builder = new ItalianPizzaBuilder();
            shop.Construct(builder);
            builder.Pizza.Show();

            Console.ReadKey();
        }
    }
}
