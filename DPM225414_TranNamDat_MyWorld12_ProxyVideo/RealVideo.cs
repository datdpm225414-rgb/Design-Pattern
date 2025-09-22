using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TranNamDat_MyWorld12_ProxyVideo
{
    public class RealVideo: Video
    {
        private string FileName;

        public RealVideo(string FileName)
        {
            FileName = FileName;
            LoadFromDisk(FileName);
        }

        public void Display()
        {
            Console.WriteLine("Displaying " + FileName);
        }

        private void LoadFromDisk(string FileName)
        {
            Console.WriteLine("Loading " + FileName);
        }
    }
}
