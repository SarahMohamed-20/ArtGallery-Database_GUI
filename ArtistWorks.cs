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
    public partial class ArtistWorks : Form
    {
        public ArtistWorks()
        {
            InitializeComponent();
        }

        private void artistBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.artistBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.artistArtworksDataSet);
            this.artWorkBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.artistArtworksDataSet);

        }

        private void ArtistWorks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'artistArtworksDataSet.ArtWork' table. You can move, or remove it, as needed.
            this.artWorkTableAdapter.Fill(this.artistArtworksDataSet.ArtWork);
            // TODO: This line of code loads data into the 'artistArtworksDataSet.Artist' table. You can move, or remove it, as needed.
            this.artistTableAdapter.Fill(this.artistArtworksDataSet.Artist);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin home = new Admin();
            home.Show();
        }
    }
}
