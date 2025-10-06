using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TranNamDat_Myworld03_FactoryMethod
{
    public class Program
    {
        static void Main(string[] args)
        {
            PetCreator dogCreator = new DogCreator();
            dogCreator.MakePetSpeak();  

            PetCreator catCreator = new CatCreator();
            catCreator.MakePetSpeak();  

            Console.ReadKey();
        }
    }
}
