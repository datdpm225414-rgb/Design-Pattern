using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TranNamDat_Pattern05_SingletonPattern
{
    public class Singleton
    {
        static Singleton instance;
        protected Singleton()
        {
        }
        public static Singleton Instance()
        {

            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }
}
