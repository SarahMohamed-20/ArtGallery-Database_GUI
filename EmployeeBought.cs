using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseProj
{
    public partial class EmployeeBought : Form
    {
        public EmployeeBought()
        {
            InitializeComponent();
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.customerBoughtArtworksDataSet);
            this.artWorkBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.customerBoughtArtworksDataSet);

        }

        private void EmployeeBought_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customerBoughtArtworksDataSet.ArtWork' table. You can move, or remove it, as needed.
            this.artWorkTableAdapter.Fill(this.customerBoughtArtworksDataSet.ArtWork);
            // TODO: This line of code loads data into the 'customerBoughtArtworksDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.customerBoughtArtworksDataSet.Customer);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee home = new Employee();
            home.Show();
        }
    }
}
