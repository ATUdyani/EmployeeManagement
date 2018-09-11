using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace DbConnection
{
    public partial class AddEmployee : Form
    {
        private SqlConnection cnn;

        public AddEmployee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(empId.Text);
            string Name = empName.Text;
            int Age = Convert.ToInt32(empAge.Text);
            int Salary = Convert.ToInt32(empSalary.Text);
            int Dep = Convert.ToInt32(empDpt.Text);

            string connectionString;
            SqlConnection cnn;
            connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=abcCompany;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            cnn = new SqlConnection(connectionString);
            cnn.Open();

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "";
            sql = "Insert into Employee(EmployeeId, EmployeeName,Age,Salary,Dept_Id) values("+Id+",'"+Name+"',"+Age+","+Salary+","+Dep+")";
            command = new SqlCommand(sql, cnn);
            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();

            cnn.Close();
            MessageBox.Show("Add new Record!");
            this.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void empId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
