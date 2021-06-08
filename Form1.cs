using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace OOP_Lab5
{
    public partial class Form1 : Form
    {
        int count = 0;
        Task[] task = new Task[500];
        public Form1()
        {
            InitializeComponent();
            Bitmap b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = b;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (x_textBox.Text != "" && y_textBox.Text != "" && rad_textBox.Text != "")
            {
                Circle cir = new Circle(Convert.ToInt32(x_textBox.Text),
                Convert.ToInt32(y_textBox.Text), Convert.ToInt32(rad_textBox.Text));
                int len1 = Convert.ToInt32(rad_textBox.Text);
                count++;
                task[count] = Task.Run(() =>
                {
                    while ((cir.x + len1) < 482)
                    {
                        cir.MoveRight(pictureBox1);
                    }
                });
            }
            if (x_textBox.Text != "" && y_textBox.Text != "" && sideLen_textBox.Text != "")
            {
                Figure squ = new Square(Convert.ToInt32(x_textBox.Text),
                Convert.ToInt32(y_textBox.Text), Convert.ToInt32(sideLen_textBox.Text));
                int len2 = Convert.ToInt32(sideLen_textBox.Text);
                count++;
                task[count] = Task.Run(() =>
                {
                    while ((squ.x +  len2)< 482)
                    {
                        squ.MoveRight(pictureBox1);
                    }
                });
            }
            if (x_textBox.Text != "" && y_textBox.Text != "" && verLen_textBox.Text != "" && horLen_textBox.Text != "")
            {
                Figure rho = new Rhomb(Convert.ToInt32(x_textBox.Text), Convert.ToInt32(y_textBox.Text),
                Convert.ToInt32(horLen_textBox.Text), Convert.ToInt32(verLen_textBox.Text));
                int len3 = Convert.ToInt32(horLen_textBox.Text);
                count++;
                task[count] = Task.Run(() =>
                {
                    while ((rho.x + len3) < 482)
                    {
                        rho.MoveRight(pictureBox1);
                    }
                });
            }
        }
    }
}
