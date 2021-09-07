using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace DatabaseProj
{
    public partial class AdminAddEmp : Form

    {
        DBAccess objdBAccess = new DBAccess();

        public AdminAddEmp()
        {
            InitializeComponent();
        }

        

        private void AddEmpbtn_Click(object sender, EventArgs e)
        {
            string id = IDtxtF.Text;
            string empName = nametxtF.Text;
            string salary = salarytxtF.Text;
            string street = streettxtF.Text;
            string building = buildtxtF.Text;
            string city = citytxtF.Text;
            string mobileNo = mobtxtF.Text;
         


            if (id.Equals(""))
            {
                MessageBox.Show("please enter a value");
            }
            else if (empName.Equals(""))
            {
                MessageBox.Show("please enter a value");
            }
            else
            if (salary.Equals(""))
            {
                MessageBox.Show("please enter a value");
            }
            else
            if (street.Equals(""))
            {
                MessageBox.Show("please enter a value");
            }
            else
            if (building.Equals(""))
            {
                MessageBox.Show("please enter a value");
            }

            else if (city.Equals(""))
            {
                MessageBox.Show("please enter a value");
            }
            else
            if (mobileNo.Equals(""))
            {
                MessageBox.Show("please enter a value");
            }
            else
            {
                SqlCommand insertCommand = new SqlCommand("insert into Employee (ID ,EmployeeName ,MobileNo ,Salary ,Street ,BuildingNo ,City )values (@id,@empName,@mobileNo,@salary, @street, @building , @city)");
                insertCommand.Parameters.AddWithValue("@id", id);
                insertCommand.Parameters.AddWithValue("@empName ", empName);
                insertCommand.Parameters.AddWithValue("@salary ", salary);
                insertCommand.Parameters.AddWithValue("@street ", street);
                insertCommand.Parameters.AddWithValue("@building ", building);
                insertCommand.Parameters.AddWithValue("@city ", city);
                insertCommand.Parameters.AddWithValue("@mobileNo ", mobileNo);

              int row =   objdBAccess.executeQuery(insertCommand);
                if (row == 1)
                {
                    MessageBox.Show("Employee is added Succesfully");
                }
                else
                    MessageBox.Show("error");

            }
            IDtxtF.Clear();
            nametxtF.Clear();
            salarytxtF.Clear();
            streettxtF.Clear();
            buildtxtF.Clear();
            citytxtF.Clear();
            mobtxtF.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin home = new Admin();
            home.Show();
        }

        private void IDtxtF_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void mobtxtF_TextChanged(object sender, EventArgs e)
        {

        }

        private void citytxtF_TextChanged(object sender, EventArgs e)
        {

        }

        private void buildtxtF_TextChanged(object sender, EventArgs e)
        {

        }

        private void streettxtF_TextChanged(object sender, EventArgs e)
        {

        }

        private void salarytxtF_TextChanged(object sender, EventArgs e)
        {

        }

        private void nametxtF_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
