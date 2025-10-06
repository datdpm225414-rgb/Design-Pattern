using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TranNamDat_Myworld01_Builder
{
    public class PizzaShop
    {
        public void Construct(PizzaBuilder pizzaBuilder)
        {
            pizzaBuilder.BuildDough();
            pizzaBuilder.BuildSauce();
            pizzaBuilder.BuildCheese();
            pizzaBuilder.BuildToppings();
        }
    }
}
