using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace DatabaseProj
{
    public partial class AdminUpdateEmp : Form
    {
        DBAccess objdBAccess = new DBAccess();
        DataTable dtemp = new DataTable();
        public AdminUpdateEmp()
        {
            InitializeComponent();
        }


        private void selectbtn_Click(object sender, EventArgs e)
        {
            string empID = IDtxtF.Text;
            if (empID == "")
            {
                MessageBox.Show("please enter a value ");
            }
            else
            {
                string query = "select * from Employee where ID = '" + empID + "'";
                objdBAccess.readDatathroughAdapter(query, dtemp);
                dataGridView1.DataSource = dtemp;
                objdBAccess.closeConn();
            }


        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin home = new Admin ();
            home.Show();
        }

        private void updateEmpbtn_Click(object sender, EventArgs e)
        {
            string query;
            int lala = 0;
            string newID = IDtxtF.Text;
            string newName = nametxtFnew.Text;
            string newMobile = mobtxtFnew.Text;
            string newSalary = salarytxtFnew.Text;
            string newStreet = streettxtFnew.Text;
            string newBuilding= buildtxtFnew.Text;
            string newCity = citytxtFnew.Text;


            if (newName == "")
            {
                lala = 1;
            }
            else
            {
                 query = "update Employee SET EmployeeName  = '" + newName + "' where ID =  '" + newID + "'";
                objdBAccess.readDatathroughAdapter(query, dtemp);
            }


            if (newMobile == "")
            {
                lala = 1;
            }
            else
            {
                query = "update Employee SET MobileNo   = '" + newMobile + "' where ID =  '" + newID + "'";
                objdBAccess.readDatathroughAdapter(query, dtemp);
            }
            if (newSalary == "")
            {
                lala = 1;
            }
            else
            {
                query = "update Employee SET Salary   = '" + newSalary + "' where ID =  '" + newID + "'";
                objdBAccess.readDatathroughAdapter(query, dtemp);
            }
            if (newStreet == "")
            {
                lala = 1;
            }
            else
            {
                query = "update Employee SET Street   = '" + newStreet + "' where ID =  '" + newID + "'";
                objdBAccess.readDatathroughAdapter(query, dtemp);
            }
            if (newBuilding == "")
            {
                lala = 1;
            }
            else
            {
                query = "update Employee SET BuildingNo   = '" + newBuilding + "' where ID =  '" + newID + "'";
                objdBAccess.readDatathroughAdapter(query, dtemp);
            }
            if (newCity == "")
            {
                lala = 1;
            }
            else
            {
                query = "update Employee SET City   = '" + newCity + "' where ID =  '" + newID + "'";
                objdBAccess.readDatathroughAdapter(query, dtemp);
            }

            
            objdBAccess.closeConn();
        }

        private void buildtxtFnew_TextChanged(object sender, EventArgs e)
        {

        }

        private void citytxtFnew_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
