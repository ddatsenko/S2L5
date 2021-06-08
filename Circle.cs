using System.Drawing;
using System.Windows.Forms;

namespace OOP_Lab5
{
    class Circle:Figure
    {
        double radius { get; set; }
        public Circle(int x, int y, double radius)
        {
            this.radius = radius;
            this.x = x;
            this.y = y;
        }
        public override void DrawBlack(PictureBox pbox)
        {
            using (var g = Graphics.FromImage(pbox.Image))
            {
                g.DrawEllipse(Pens.Black, x, y, (int)radius, (int)radius);
            }
        }
        public override void HideDrawingBackGround(PictureBox pbox)
        {
            using (var g = Graphics.FromImage(pbox.Image))
            {
                g.DrawEllipse(Pens.White, x, y, (int)radius, (int)radius);
            }
        }
    }
}
