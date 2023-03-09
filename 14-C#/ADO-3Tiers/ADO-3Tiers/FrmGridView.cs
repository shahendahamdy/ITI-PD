using BLL.EntityList;
using BLL.EntityManager;
using DAL;
using System.Data;
using System.Diagnostics;

namespace ADO_3Tiers
{
    public partial class FrmGridView : Form
    {
        public FrmGridView()
        {
            InitializeComponent();

        }
        PublisherList pubList;
        TitleList titleList;
        

        private void FrmGridView_Load(object sender, EventArgs e)
        {


            // da bs elii h3mlo fe UI
        }


        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {


            titleList = TiltleManager.selectAllTitles();
            this.Text = titleList.Count.ToString();

            grdviewPub.DataSource = titleList;

            pubList = PublisherManager.selectAllPublishers();
            DataGridViewComboBoxColumn newcol = new DataGridViewComboBoxColumn();
            newcol.DataSource = pubList;
            newcol.ValueMember = "pubId";
            newcol.DisplayMember = "pubName";
            newcol.HeaderText = "publisherName";

            newcol.DataPropertyName = "pubId";

            grdviewPub.Columns.Add(newcol);



        }
    }
}