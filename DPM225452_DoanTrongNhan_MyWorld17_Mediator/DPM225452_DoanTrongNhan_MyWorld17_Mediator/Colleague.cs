using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225452_DoanTrongNhan_MyWorld17_Mediator
{
    public abstract class Colleague
    {
        protected Mediator mediator;
        // Constructor
        public Colleague(Mediator mediator)
        {
            this.mediator = mediator;
        }
    }
}
