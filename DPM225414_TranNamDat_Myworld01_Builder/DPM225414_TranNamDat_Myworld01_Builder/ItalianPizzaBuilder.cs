using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TranNamDat_Myworld01_Builder
{
    public class ItalianPizzaBuilder : PizzaBuilder
    {
        public ItalianPizzaBuilder()
        {
            pizza = new Pizza("Italian Pizza");
        }

        public override void BuildDough()
        {
            pizza["dough"] = "Thin dough";
        }

        public override void BuildSauce()
        {
            pizza["sauce"] = "Tomato sauce";
        }

        public override void BuildCheese()
        {
            pizza["cheese"] = "Mozzarella cheese";
        }

        public override void BuildToppings()
        {
            pizza["toppings"] = "Basil, Tomato, Olives";
        }
    }
}
