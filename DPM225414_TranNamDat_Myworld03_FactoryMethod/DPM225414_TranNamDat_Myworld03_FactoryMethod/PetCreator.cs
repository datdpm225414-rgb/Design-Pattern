using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TranNamDat_Myworld03_FactoryMethod
{
    public abstract class PetCreator
    {
        public abstract Pet CreatePet();
        public void MakePetSpeak()
        {
            Pet pet = CreatePet();
            pet.Keu();
        }
    }
}
