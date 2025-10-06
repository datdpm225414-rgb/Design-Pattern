using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TranNamDat_Myworld01_Builder
{
    public class AmericanPizzaBuilder : PizzaBuilder
    {
        public AmericanPizzaBuilder()
        {
            pizza = new Pizza("American Pizza");
        }

        public override void BuildDough()
        {
            pizza["dough"] = "Thick dough";
        }

        public override void BuildSauce()
        {
            pizza["sauce"] = "Barbecue sauce";
        }

        public override void BuildCheese()
        {
            pizza["cheese"] = "Cheddar cheese";
        }

        public override void BuildToppings()
        {
            pizza["toppings"] = "Pepperoni, Sausage, Bacon";
        }
    }
}
