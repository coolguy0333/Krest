using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public int x = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Stretches the image to fit the pictureBox.
            Bitmap MyImage;
            string fileToDisplay = @"C:\Users\student\source\repos\Cs_praktiks\praktika7\offTop\Risovat_na_Canvas\Resources\PRO_C#_7.jpg";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            
            MyImage = new Bitmap(fileToDisplay);

            // Create pen.
            Pen blackPen = new Pen(Color.Red, 30);
            // Create coordinates of points that define line.
            x+=100;
            int x1 = 5+x;   //topleft to topright
            int y1 = 100+x;
            int x2 = x+100;
            int y2 = x;
            
            x-=40;
            int x3 = 5+x; 
            int y3 = x;
            int x4 = x+100;
            int y4 = x+100;

            // Draw line to screen.
            using (var graphics = Graphics.FromImage(MyImage))
            {
                graphics.DrawLine(blackPen, x1, y1, x2, y2);
                graphics.DrawLine(blackPen,x3, y3, x4, y4);
            }


            pictureBox1.ClientSize = new Size(400, 400);
            pictureBox1.Image = (Image)MyImage;
        }
    }
}
