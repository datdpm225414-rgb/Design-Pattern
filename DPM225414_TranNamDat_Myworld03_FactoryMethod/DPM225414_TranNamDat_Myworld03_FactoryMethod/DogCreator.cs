using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TranNamDat_Myworld03_FactoryMethod
{
    public class DogCreator : PetCreator
    {
        public override Pet CreatePet()
        {
            return new Cho();
        }
    }
}
