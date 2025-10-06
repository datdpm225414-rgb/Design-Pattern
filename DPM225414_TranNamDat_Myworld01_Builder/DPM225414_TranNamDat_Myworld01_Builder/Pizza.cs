using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TranNamDat_Myworld01_Builder
{
    public class Pizza
    {
        private string _pizzaType;
        private System.Collections.Generic.Dictionary<string, string> _ingredients =
          new System.Collections.Generic.Dictionary<string, string>();

        public Pizza(string pizzaType)
        {
            this._pizzaType = pizzaType;
        }

        public string this[string key]
        {
            get { return _ingredients[key]; }
            set { _ingredients[key] = value; }
        }

        public void Show()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Pizza Type: {0}", _pizzaType);
            Console.WriteLine(" Dough : {0}", _ingredients["dough"]);
            Console.WriteLine(" Sauce : {0}", _ingredients["sauce"]);
            Console.WriteLine(" Cheese : {0}", _ingredients["cheese"]);
            Console.WriteLine(" Toppings: {0}", _ingredients["toppings"]);
        }
    }
}
