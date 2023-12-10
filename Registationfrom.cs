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

namespace project2
{
    public partial class Registrationfrom : Form
    {
        private const string connectionString = "Data Source=DESKTOP-SE2MU48;Initial Catalog=Facultydatabase; Integrated security =True";
        public Registrationfrom()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Query to check if the user exists in the faculty table
                    string query = "Insert into Faculty(FacultyID,FirstName,LastName,Password,DateOfBirth,Gender,Address,Email, PhoneNumber,Department) Values (@FacultyID,@FirstName,@LastName,@Password,@DateOfBirth,@Gender,@Address, @Email,@PhoneNumber , @Department)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Use parameters to prevent SQL injection
                        command.Parameters.AddWithValue("@FacultyID", Convert.ToInt32(txtfact.Text));
                        command.Parameters.AddWithValue("@FirstName", Convert.ToString(txtfirst.Text));
                        command.Parameters.AddWithValue("@LastName", Convert.ToString(txtlast.Text));
                        command.Parameters.AddWithValue("@Password", Convert.ToInt32(txtpass.Text));
                        command.Parameters.AddWithValue("@DateOfBirth", txtDOB.Text);
                        command.Parameters.AddWithValue("@Gender", Convert.ToString(txtgender.Text));
                        command.Parameters.AddWithValue("@Address", Convert.ToString(txtaddress.Text));
                        command.Parameters.AddWithValue("@Email", Convert.ToString(txtemail.Text));
                        command.Parameters.AddWithValue("@PhoneNumber", Convert.ToInt32(txtphone.Text));
                        command.Parameters.AddWithValue("@Department", Convert.ToString(txtdepart.Text));

                        int rf = command.ExecuteNonQuery();

                        if (rf > 0)
                        {
                            MessageBox.Show("record inserted");
                            // Add additional actions after successful login if needed
                        }
                        else
                        {
                            MessageBox.Show("insertion failed.");
                        }

                    }
                }


                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void txtphone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtaddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtgender_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDOB_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtlast_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtfirst_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtfact_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
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

        private void StudentID_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtdepart_TextChanged(object sender, EventArgs e)
        {

        }
    }
}