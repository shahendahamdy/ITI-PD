using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class micky : Form
    {
        public micky()
        {
            InitializeComponent();
            this.FormBorderStyle= FormBorderStyle.None;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, this.ClientSize.Width, this.ClientSize.Height);
            path.AddEllipse(0, 0, 200, 200);
            path.AddEllipse(this.ClientSize.Width-200, 0, 200, 200);
            //  path.AddRectangle(new Rectangle(0, 0, 150, 150));
            path.FillMode = FillMode.Winding;

             this.Region=new Region(path);

            base.OnPaint(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Location=new Point(this.Location.X+10,this.Location.Y+10);
        }

       
    }
}
