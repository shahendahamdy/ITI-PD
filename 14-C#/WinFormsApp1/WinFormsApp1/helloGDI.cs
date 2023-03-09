namespace WinFormsApp1
{
    public partial class helloGDI : Form
    {
        public helloGDI()
        {
            InitializeComponent();
            //1. protected property in form class
            //this.ResizeRedraw=true;

            //2. handle Resize event
            this.Resize += (sender, e) => Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Font myFont = new Font(this.Font.FontFamily, 18);

            string str = "hello GDI";
            var strL = e.Graphics.MeasureString(str, myFont);

            Brush b = new SolidBrush(Color.FromArgb(this.Height % 255, this.Width % 255, (this.Height / 2 + this.Width / 2) % 255));
            e.Graphics.DrawString(str, myFont, b, ClientSize.Width / 2 - strL.Width / 2, ClientSize.Height / 2 - strL.Height / 2);

            foreach (var ee in lst)
            {
                e.Graphics.FillEllipse(Brushes.Red, ee.X - 15, ee.Y - 15, 30, 30);
                e.Graphics.DrawEllipse(Pens.DarkBlue, ee.X - 15, ee.Y - 15, 30, 30);

            }

            base.OnPaint(e);
        }
        List<Point> lst = new List<Point>();
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics grx = this.CreateGraphics();
            if (e.Button == MouseButtons.Left)
            {
                grx.FillEllipse(Brushes.Red, e.X - 15, e.Y - 15, 30, 30);

                grx.DrawEllipse(Pens.DarkBlue, e.X - 15, e.Y - 15, 30, 30);

            }
            lst.Add(e.Location);
        }

        
    }
}