using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace BouncingBall
{
    public partial class Form1 : Form
    {
        
        Timer tm;
        int x, y;
     
        public Form1()
        {
            InitializeComponent();
            
            x = y = 10;
           
            tm = new Timer();
            tm.Interval = 100;
            tm.Tick += new EventHandler(Form1_Load);
            tm.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(440, 410);
            Graphics gph = Graphics.FromImage(img);
            gph.FillEllipse(Brushes.Blue, new Rectangle(x, y, 25, 25));
            pictureBox1.Image = img;
            gph.Dispose();
            
            if (y == 10)
            {

                x += 10;
            }
            if (x == 410)
            {
                y += 10;
            }
            if (y == 410)
            {
                x -= 10;
            }
            if (x == 10)
            {
                y -= 10;
            }



            Invalidate();
        }
    }
}
