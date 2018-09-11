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

namespace DbConnection
{
    public partial class DeleteEmployee : Form
    {
        public DeleteEmployee()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(empId.Text);

            string connectionString;
            SqlConnection cnn;
            connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=abcCompany;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            cnn = new SqlConnection(connectionString);
            cnn.Open();

            SqlCommand command;
            SqlDataReader reader;
            String sql = "";
            sql = "Select EmployeeId, EmployeeName,Age,Salary,Dept_Id from Employee where EmployeeId=" + Id + "";
            command = new SqlCommand(sql, cnn);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                empName.AppendText(reader["EmployeeName"].ToString());
                empAge.AppendText(reader["Age"].ToString());
                empSalary.AppendText(reader["Salary"].ToString());
                empDpt.AppendText(reader["Dept_Id"].ToString());
            }
            cnn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(empId.Text);

            string connectionString;
            SqlConnection cnn;
            connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=abcCompany;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            cnn = new SqlConnection(connectionString);
            cnn.Open();

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "";
            sql = "Delete from Employee where EmployeeId=" + Id + "";
            command = new SqlCommand(sql, cnn);
            adapter.DeleteCommand = new SqlCommand(sql, cnn);
            adapter.DeleteCommand.ExecuteNonQuery();

            cnn.Close();
            MessageBox.Show("Deleted!");
            this.Close();
        }

        private static SqlCommand GetUpdateCommand(SqlDataAdapter adapter)
        {
            return adapter.UpdateCommand;
        }
    }
}
