using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225452_DoanTrongNhan_MyWorld20_State
{
    public class RedState : State
    {
        public override void Handle(Context context)
        {
            context.State = new BlueState();
        }
    }

}
