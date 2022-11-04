using _6.feladat.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.feladat.Entities
{
    public class Present : Toy
    {
        public SolidBrush PresentColor { get; private set; }
        public Present(Color ribbon, Color box)
        {
            PresentColor = new SolidBrush(ribbon);
            PresentColor = new SolidBrush(box);

        }

        protected override void DrawImage(Graphics g)
        {
            g.FillEllipse(PresentColor, 0, 0, Width, Height);
        }
    }
}
