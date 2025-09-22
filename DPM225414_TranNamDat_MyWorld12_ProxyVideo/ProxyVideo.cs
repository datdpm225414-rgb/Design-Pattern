using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TranNamDat_MyWorld12_ProxyVideo
{
    internal class ProxyVideo : Video
    {
        private RealVideo RealVideo;
        private string FileName;

        public ProxyVideo(string FileName)
        {
            this.FileName = FileName;
        }

        public void Display()
        {
            if (RealVideo == null)
            {
                RealVideo = new RealVideo(FileName);
            }
            RealVideo.Display();
        }
    }
}
