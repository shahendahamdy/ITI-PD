using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class paint : Form
    {
        Graphics g;
        int x = -1;
        int y= -1;
        bool moving=false;
        Pen pen;
        Color clr=Color.Black;

        public paint()
        {
            InitializeComponent();
            g =panel1.CreateGraphics();
            pen = new Pen(Color.Black, 5);
        }

        

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            x = -1;
            y=-1;

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            x = e.X; y = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(MouseButtons.Left == e.Button)
            {
                pen = new Pen(Color.White, 10);
            }
            else
            {
                pen = new Pen(clr, 5);
            }
            if (moving==true && x!=-1 && y!=-1)
            {
                g.DrawLine(pen, new Point(x,y),e.Location);
                x=e.X; y=e.Y;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                clr= colorDialog1.Color;
                button1.BackColor = colorDialog1.Color;
            }
        }
    }
}
