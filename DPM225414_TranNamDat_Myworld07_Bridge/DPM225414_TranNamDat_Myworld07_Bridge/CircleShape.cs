using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TranNamDat_Myworld07_Bridge
{
    public class CircleShape : Shape
    {
        double x, y, radius;

        public CircleShape(double x, double y, double radius, IDrawingAPI drawingAPI)
            : base(drawingAPI)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
        }

        public override void Draw()
        {
            drawingAPI.DrawCircle(x, y, radius);
        }

        public override void ResizeByPercentage(double pct)
        {
            radius *= pct;
        }
    }
}
