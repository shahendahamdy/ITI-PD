using EF1.Models;
using Microsoft.EntityFrameworkCore;

namespace EF1
{
    public partial class gridView : Form
    {

        public gridView()
        {
            InitializeComponent();
            this.FormClosed += (sender, e) => context?.Dispose();
        }
        pubsContext context = new pubsContext();

        private void gridView_Load(object sender, EventArgs e)
        {
            //var titles = (from t in context.Titles
            //             select t).ToList();

           // this.dataGridView1.DataSource= titles;

            context.Titles.Load();
            this.dataGridView1.DataSource=context.Titles.Local.ToBindingList();
            DataGridViewComboBoxColumn PubCol = new DataGridViewComboBoxColumn();
            var PublisherList = context.Publishers.Local.ToBindingList();
            PubCol.DataSource = PublisherList;



            PubCol.HeaderText = "Publisher Name";
            PubCol.DisplayMember = "PubName";
            PubCol.ValueMember = "PubId";
            PubCol.DataPropertyName = "PubId";

            dataGridView1.Columns.Add(PubCol);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();
            context.SaveChanges();
        }
    }
}