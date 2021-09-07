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
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();
        }

        private void abstractBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.abstractBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.categoriesDataSet);

        }

        private void Categories_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'categoriesDataSet.modernism' table. You can move, or remove it, as needed.
            this.modernismTableAdapter.Fill(this.categoriesDataSet.modernism);
            // TODO: This line of code loads data into the 'categoriesDataSet.expressionism' table. You can move, or remove it, as needed.
            this.expressionismTableAdapter.Fill(this.categoriesDataSet.expressionism);
            // TODO: This line of code loads data into the 'categoriesDataSet._abstract' table. You can move, or remove it, as needed.
            this.abstractTableAdapter.Fill(this.categoriesDataSet._abstract);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer cust = new Customer();
            cust.Show();
        }
    }
}
