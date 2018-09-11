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
using System.Configuration;

namespace DbConnection
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        Employee obj = (Employee)Application.OpenForms["Employee"];

        private void button1_Click(object sender, EventArgs e)
        {
            AddEmployee addEmpUI = new AddEmployee();
            addEmpUI.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateEmployee updateEmpUI = new UpdateEmployee();
            updateEmpUI.Show();            
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            employeeList.DataSource = GetEmployeeList();
            
        }

        private void loaddata()
        {
            throw new NotImplementedException();
        }

        private void Employee_Load(object sender, EventArgs e)
        {

            employeeList.DataSource = GetEmployeeList();
        }

        private DataTable GetEmployeeList()
        {
            DataTable employeeLst = new DataTable();

            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

            using (SqlConnection cnn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("Select EmployeeId, EmployeeName,Age,Salary,Dept_Id from Employee", cnn))
                {
                    cnn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    employeeLst.Load(reader);
                }
            }

            return employeeLst;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DeleteEmployee deleteEmployee = new DeleteEmployee();
            deleteEmployee.Show();
        }
    }
}
