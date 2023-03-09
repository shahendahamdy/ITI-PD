using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Ado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection sqlcn;
        SqlCommand sqlcommand;
        SqlCommand selectCat;
        SqlCommand selectSup;
        SqlDataAdapter Da;
        SqlDataAdapter DaCat;
        SqlDataAdapter DaSup;
        DataTable dt;
        DataTable dtCat;
        DataTable dtSup;
        DataGridViewComboBoxColumn col;
        DataGridViewComboBoxColumn colSup;
        private void Form1_Load(object sender, EventArgs e)
        {
            sqlcn= new SqlConnection(ConfigurationManager.ConnectionStrings["northwindCon"].ConnectionString);
            sqlcommand= new SqlCommand("select * from products",sqlcn);
            Da=new SqlDataAdapter(sqlcommand); 
            SqlCommandBuilder sqlbuilder = new SqlCommandBuilder(Da);
            dt = new();
            Da.Fill(dt);

            selectCat = new("select CategoryID as CID ,CategoryName as CName from Categories", sqlcn);
            DaCat=new SqlDataAdapter(selectCat);
            dtCat = new();
            DaCat.Fill(dtCat);
            col= new DataGridViewComboBoxColumn();
            col.DataSource= dtCat;
            col.Name = "CATEGORY";
            col.DisplayMember = "CName";
            col.ValueMember = "CID";
            col.DataPropertyName = "CategoryID";

            selectSup = new("select SupplierID as SID ,CompanyName as SName from Suppliers", sqlcn);
            DaSup = new SqlDataAdapter(selectSup);
            dtSup = new();
            DaSup.Fill(dtSup);
            colSup = new DataGridViewComboBoxColumn();
            colSup.DataSource = dtSup;
            colSup.Name = "SUPPLIER";
            colSup.DisplayMember = "SName";
            colSup.ValueMember = "SID";
            colSup.DataPropertyName = "SupplierID";
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dt;
            dataGridView1.Columns.Add(col);
            dataGridView1.Columns.Add(colSup);
            dataGridView1.Columns[0].ReadOnly = true;


        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Da.Update(dt);

        }
    }
}