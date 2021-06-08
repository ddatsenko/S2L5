using System.Drawing;
using System.Windows.Forms;

namespace OOP_Lab5
{
    class Square:Figure
    {
        private int sideLength { get; set; }
        public Square(int x, int y, int side)
        {
            this.sideLength = side;
            this.x = x;
            this.y = y;
        }
        public override void DrawBlack(PictureBox pbox)
        {
            using (var g = Graphics.FromImage(pbox.Image))
            {
                g.DrawRectangle(Pens.Black, x, y, sideLength, sideLength);
            }
        }
        public override void HideDrawingBackGround(PictureBox pbox)
        {
            using (var g = Graphics.FromImage(pbox.Image))
            {
                g.DrawRectangle(Pens.White, x, y, sideLength, sideLength);
            }
        }
    }
}
