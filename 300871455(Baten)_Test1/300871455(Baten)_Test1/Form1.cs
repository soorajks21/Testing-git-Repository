using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _300871455_Baten__Test1
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\soora\source\repos\300871455(Baten)_Test1\Customer.mdf;Integrated Security=True;Connect Timeout=30";

        public Form1()
        {
            InitializeComponent();
            listBox1.ScrollBars = ScrollBars.Vertical;
                
        }

        private void addCustomer_Click(object sender, EventArgs e)
        {
            listBox1.Text = " ";
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {

                sqlConnection.Open();
               
                SqlCommand sqlCmd = new SqlCommand("AddUser", sqlConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@CustomerId", customerId.Text);
                sqlCmd.Parameters.AddWithValue("@NameStyle", fontStyle.Text);
                sqlCmd.Parameters.AddWithValue("@Title", title.Text);
                sqlCmd.Parameters.AddWithValue("@FirstName", FName.Text);
                sqlCmd.Parameters.AddWithValue("@LastName", LName.Text);
                sqlCmd.Parameters.AddWithValue("@CompanyName", CName.Text);
                sqlCmd.Parameters.AddWithValue("@SalesPerson", SPerson.Text);
                sqlCmd.Parameters.AddWithValue("@EmailAddress", EMail.Text);
                sqlCmd.Parameters.AddWithValue("@Phone", Phone.Text);
                sqlCmd.Parameters.AddWithValue("@Password", Password.Text);
                sqlCmd.Parameters.AddWithValue("MiddleName", MName.Text);
                sqlCmd.ExecuteNonQuery();

                AddAddress();
            }
        }

        void AddAddress()
        {
            listBox1.Text = " ";
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                SqlCommand sqlCmd = new SqlCommand("AddAddress", sqlConnection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@AddressId", customerId.Text);
                sqlCmd.Parameters.AddWithValue("@Addressline1",line1_txt.Text);
                sqlCmd.Parameters.AddWithValue("@Addressline2", line2_txt.Text);
                sqlCmd.Parameters.AddWithValue("@City", City.Text);
                sqlCmd.Parameters.AddWithValue("@StateProvince", State.Text);
                sqlCmd.Parameters.AddWithValue("@CountryRegion", Country.Text);
                sqlCmd.Parameters.AddWithValue("@PostalCode", Postal.Text);
                sqlCmd.ExecuteNonQuery();
                listBox1.Text = "Customer Added";

            }
        }

        private void FCustomer_Click(object sender, EventArgs e)
        {
            listBox1.Text = " ";
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

               

                string query = "Select * from customer where CustomerId = '" + customerId.Text.Trim()+"' ";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
                DataTable tbl = new DataTable();
                sqlDataAdapter.Fill(tbl);
               
                if (tbl.Rows.Count == 1)
                {
                    foreach (DataRow dr in tbl.Rows)
                    {


                        listBox1.Text += "FirstName: " + dr["FirstName"].ToString() + "\r\n" + "LastName: " + dr["LastName"].ToString() + "\r\n" + "LastName: " + dr["MiddleName"].ToString() + "\r\n" +
                                              "Company: " + dr["CompanyName"].ToString() + "\r\n" + "Title: " + dr["Title"].ToString() + "\r\n" + "SalesPerson: " + dr["SalesPerson"].ToString() +
                                              "\r\n" + " EmailAddress: " + dr["EmailAddress"] + "\r\n" + "Phone: " + dr["Phone"].ToString();

                    }

                }


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Text = " ";
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
               
               string query  = "Delete from customer where CustomerId = '" + customerId.Text.Trim() + "'";
                SqlCommand sqlCommand = new SqlCommand( query, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                listBox1.Text = "Customer id "+" " +"'" + customerId.Text.Trim() + "'  Deleted";
;
            }


            }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Text = " ";
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
               // string i = "Canada";
                sqlConnection.Open();
                string query = "Select Customer.FirstName,Customer.LastName,Customer.CompanyName,Customer.MiddleName, Customer.Title,Customer.EmailAddress,Customer.Phone, Address.City,Address.CountryRegion " +
                                "From Customer INNER JOIN Address ON Customer.CustomerId= Address.AddressId where Address.CountryRegion =  'Canada' ORDER BY Customer.CompanyName ";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
                DataTable tbl = new DataTable();
                sqlDataAdapter.Fill(tbl);
                listBox1.Text = "Customers in Canada";
                if (tbl.Rows.Count >= 1)
                {
                    foreach (DataRow dr in tbl.Rows)
                    {
                        listBox1.Text +="\r\n"+ "FirstName: " + dr["FirstName"].ToString() + "\r\n" + "LastName: " + dr["LastName"].ToString() + "\r\n" + "LastName: " + dr["MiddleName"].ToString() + "\r\n" +
                                           "Company: " + dr["CompanyName"].ToString() + "\r\n" + "Title: " + dr["Title"].ToString() + "\r\n" + 
                                            " EmailAddress: " + dr["EmailAddress"] + "\r\n" + "Phone: " + dr["Phone"].ToString() +"\r\n";


                        
                    }

                }
                else
                {
                    listBox1.Text = "No Customer in Country Canada";
                }

            }

            }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Text = " ";
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                string query = "Select Customer.FirstName,Customer.LastName,Customer.CompanyName,Customer.MiddleName, Customer.Title,Customer.EmailAddress,Customer.Phone, Address.AddressLine1, Address.City,Address.CountryRegion " +
                                "From Customer INNER JOIN Address ON Customer.CustomerId= Address.AddressId  ORDER BY Customer.FirstName";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
                DataTable tbl = new DataTable();
                sqlDataAdapter.Fill(tbl);
                listBox1.Text = "Customer Details and ADDRESS";
                if (tbl.Rows.Count >= 1)
                {
                    foreach (DataRow dr in tbl.Rows)
                    {
                        listBox1.Text +="\r\n"+ "FirstName: " + dr["FirstName"].ToString() + "\r\n" + "LastName: " + dr["LastName"].ToString() + "\r\n" + "LastName: " + dr["MiddleName"].ToString() + "\r\n" +
                                          "Company: " + dr["CompanyName"].ToString() + "\r\n" + "Title: " + dr["Title"].ToString() + "\r\n" +
                                           " EmailAddress: " + dr["EmailAddress"] + "\r\n" + "Phone: " + dr["Phone"].ToString() + "\r\n"+ "Address: " + dr["AddressLine1"].ToString() + "\r\n"+ "City: " + dr["City"].ToString()+
                                           "\r\n" + "CountryRegion : " + dr["CountryRegion"].ToString() + "\r\n";
                    }

                }

            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            SortForm sort = new SortForm();
            this.Hide();
            sort.Show();

        }
    }
}