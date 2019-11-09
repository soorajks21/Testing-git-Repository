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

namespace LoginApp
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\soora\source\repos\LoginApp\MyDataBase.mdf;Integrated Security=True;Connect Timeout=30";
        public Form1()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                string query = "Select * from Log where name = '" + User_textBox.Text.Trim() + "' and pass = '" + Pass_text.Text.Trim() + "'";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
                DataTable tbl = new DataTable();
                sqlDataAdapter.Fill(tbl);
                if (tbl.Rows.Count == 1)
                {
                    Dash dsh = new Dash();
                    this.Hide();
                    dsh.Show();
                }
                else
                {
                    MessageBox.Show("Not exsit");
                }
            }
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int id = random.Next(1,1000);
            // String insertQuery = "Insert into log values( '" + User_textBox.Text.Trim() + "','" + Pass_text.Text.Trim() + "')";
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCmd = new SqlCommand("UserAdd", sqlConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@Uid", id);
                sqlCmd.Parameters.AddWithValue("@Uname ", User_textBox.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Pass", Pass_text.Text.Trim());
                sqlCmd.ExecuteNonQuery();
            }
            Clear();
            displayLbl.Text = "Registered Successfully";


        }


        void Clear()
        {
            User_textBox.Text = " ";
            Pass_text.Text = " ";

        }
    }
}
