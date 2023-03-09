using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Cart_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txt = textBox1.Text;
         
                SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-BTCH7D6;Initial Catalog=onlineShopping;Integrated Security=True";
                con.Open();
            var command = new SqlCommand("INSERT INTO product_cart values(5,"+txt+")", con);
            var reader = command.ExecuteReader();
            if (txt!="")
                MessageBox.Show("Product is Added to cart");
            else
                MessageBox.Show("please Enter Product name");

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
