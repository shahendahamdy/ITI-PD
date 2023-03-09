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
    public partial class Drag_Drop : Form
    {
        Rectangle r = new Rectangle(100, 100, 150, 150);
        Graphics g;
        Pen pen;
        public Drag_Drop()
        {
            InitializeComponent();
            pen = new Pen(Color.Black, 5);
        }

        

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(pen, r);
            base.OnPaint(e);
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                r.X= e.X;
                r.Y= e.Y;
                Invalidate();
            }
        }
    }
}
