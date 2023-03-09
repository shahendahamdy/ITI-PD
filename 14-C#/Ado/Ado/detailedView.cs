using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ado
{
    public partial class detailedView : Form
    {
        public detailedView()
        {
            InitializeComponent();
        }
        BindingSource prdBind;
        SqlConnection sqlcn;
        SqlCommand sqlCommand;
        SqlCommand selectCat;
        SqlCommand selectSup;
        SqlDataAdapter da;
        SqlDataAdapter DaCat;
        SqlDataAdapter DaSup;
        DataTable dt;
        DataTable dtCat;
        DataTable dtSup;
        private void detailedView_Load(object sender, EventArgs e)
        {
            sqlcn = new SqlConnection(ConfigurationManager.ConnectionStrings["northwindCon"].ConnectionString);
            sqlCommand = new SqlCommand("select * from products", sqlcn);
            da = new SqlDataAdapter(sqlCommand);
            dt = new();
            da.Fill(dt);
            SqlCommandBuilder sqlbuilder = new SqlCommandBuilder(da);

            da.UpdateCommand=sqlbuilder.GetUpdateCommand();
            da.DeleteCommand=sqlbuilder.GetDeleteCommand();
            da.UpdateCommand=sqlbuilder.GetUpdateCommand();

            selectCat = new("select CategoryID as CID ,CategoryName as CName from Categories", sqlcn);
            DaCat = new SqlDataAdapter(selectCat);
            dtCat = new();
            DaCat.Fill(dtCat);

            selectSup = new("select SupplierID as SID ,CompanyName as SName from Suppliers", sqlcn);
            DaSup = new SqlDataAdapter(selectSup);
            dtSup = new();
            DaSup.Fill(dtSup);

            listBox1.DataSource = dt;
            listBox1.DisplayMember = "productName";
            listBox1.ValueMember = "productID";

             prdBind = new BindingSource(dt, "");
            prdBind.DataSource = dt;
            BindingSource catBind = new BindingSource(dtCat, "");
            catBind.DataSource = dtCat;
            catName.DataSource = dtCat;
            catName.ValueMember = "CID";
            catName.DisplayMember= "CName";

            BindingSource supBind = new BindingSource(dtSup, "");
            supName.DataSource = dtSup;
            supName.ValueMember = "SID";
            supName.DisplayMember = "SName";

            prdidLable.DataBindings.Add("Text", prdBind, "ProductID");
            prdName.DataBindings.Add("Text", prdBind, "ProductName");
            catName.DataBindings.Add("SelectedValue", prdBind, "CategoryID");
            supName.DataBindings.Add("SelectedValue", prdBind, "SupplierID");

            BindingNavigator Bindnavigator = new BindingNavigator(prdBind);

            this.Controls.Add(Bindnavigator);
            
            

        }

        private void save_Click(object sender, EventArgs e)
        {
            this.Validate();
            prdBind.EndEdit();
            da.Update(dt);
        }
    }
}
