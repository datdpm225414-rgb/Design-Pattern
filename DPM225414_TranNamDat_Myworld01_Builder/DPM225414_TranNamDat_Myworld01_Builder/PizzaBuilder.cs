using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TranNamDat_Myworld01_Builder
{
    public abstract class PizzaBuilder
    {
        protected Pizza pizza;

        public Pizza Pizza
        {
            get { return pizza; }
        }
        public abstract void BuildDough();
        public abstract void BuildSauce();
        public abstract void BuildCheese();
        public abstract void BuildToppings();
    }
}
