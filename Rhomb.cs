using System.Drawing;
using System.Windows.Forms;

namespace OOP_Lab5
{
    class Rhomb:Figure
    {
        private int horDiagLen { get; set; }
        private int vertDiagLen { get; set; }
        public Rhomb(int x, int y, int horLen, int vertLen)
        {
            this.x = x;
            this.y = y;
            this.horDiagLen = horLen;
            this.vertDiagLen = vertLen;
        }
        public override void DrawBlack(PictureBox pbox)
        {
            int aX = (int)(x - horDiagLen / 2.0);
            int aY = y;
            int bX =x;
            int bY = (int)(y - vertDiagLen / 2.0);
            int cX =(int)(x+horDiagLen/2.0);
            int cY = y;
            int dX =x;
            int dY = (int)(y + vertDiagLen / 2.0);
            Point[] p ={ new Point(aX, aY), new Point(bX, bY),
                    new Point(cX, cY),new Point(dX, dY)};
            using (var g = Graphics.FromImage(pbox.Image))
            {
                g.DrawPolygon(Pens.Black, p);
            }
        }
        public override void HideDrawingBackGround(PictureBox pbox)
        {

            int aX = (int)(x - horDiagLen / 2.0);
            int aY = y;
            int bX = x;
            int bY = (int)(y - vertDiagLen / 2.0);
            int cX = (int)(x + horDiagLen / 2.0);
            int cY = y;
            int dX = x;
            int dY = (int)(y + vertDiagLen / 2.0);
            Point[] p ={ new Point(aX, aY), new Point(bX, bY),
                    new Point(cX, cY),new Point(dX, dY)};
            using (var g = Graphics.FromImage(pbox.Image))
            {
                g.DrawPolygon(Pens.White, p);
            }
        }
    }
}
