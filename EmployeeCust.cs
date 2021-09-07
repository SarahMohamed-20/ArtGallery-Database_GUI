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
    public partial class EmployeeCust : Form
    {
        DBAccess objDB = new DBAccess();
        DataTable tables = new DataTable();
        public EmployeeCust()
        {
            InitializeComponent();
        }

        private void EmployeeCust_Load(object sender, EventArgs e)
        {
            string query = "Select * from Customer";
            objDB.readDatathroughAdapter(query, tables);
            dataGridView1.DataSource = tables;
            objDB.closeConn();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee cust = new Employee();
            cust.Show();
        }
    }
}
