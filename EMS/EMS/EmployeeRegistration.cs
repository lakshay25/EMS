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

namespace EMS
{
    public partial class EmployeeRegistration : Form
    {
        SqlConnection connection;
        public EmployeeRegistration()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txt_EmployeeId.Text))
            {
                MessageBox.Show("please enter employee id");
            }
            else
            {
                if (string.IsNullOrEmpty(txt_FirstName.Text))
                {
                    MessageBox.Show("please enter first name");
                }
                else
                {
                    if (string.IsNullOrEmpty(txt_LastName.Text))
                    {
                        MessageBox.Show("please enter last name");
                    }
                    else
                    {

                        if (string.IsNullOrEmpty(txt_Email.Text))
                        {
                            MessageBox.Show("please enter Email ");
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(mtb_MobileNo.Text))
                            {
                                MessageBox.Show("please enter mobile no ");
                            }
                            else
                            {
                                if (string.IsNullOrEmpty(dtp_DOB.Text))
                                {
                                    MessageBox.Show("please enter DOB ");
                                }
                                else
                                {
                                    if (cbx_Gender.SelectedItem == null)
                                    {
                                        MessageBox.Show("please select gender");
                                    }

                                    else
                                    {
                                        if (string.IsNullOrEmpty(lbl_designation.Text))
                                        {
                                            MessageBox.Show("please enter designation");
                                        }
                                        else
                                        {
                                            if (string.IsNullOrEmpty(txt_Address.Text))
                                            {
                                                MessageBox.Show("please enter Address");
                                            }
                                            else
                                            {
                                                if (string.IsNullOrEmpty(lbl_usertype.Text))
                                                {
                                                    MessageBox.Show("please user ptype enter");
                                                }
                                                else
                                                {
                                                    if (txt_Password.Text != txt_ConfirmPassword.Text)
                                                    {
                                                        MessageBox.Show("Password does not match");
                                                    }
                                                    else
                                                    {
                                                        //if (string.IsNullOrEmpty(open.ImageLocation))
                                                        //{
                                                        //    MessageBox.Show("please insert photo");
                                                        //}

                                                        // db query insert
                                                        string query = "";
                                                        //  SqlDataAdapter da = new SqlDataAdapter(query, connection);

                                                        // DataSet dataset = new DataSet();
                                                        // da.Fill(dataset);
                                                        
                                                        using (SqlCommand sqlCmd = new SqlCommand { CommandText = "INSERT INTO [TB_Users] ([EmployeeId],[FirstName],[LastName],[DateOfBirth],[Address],[MobileNumber],[Designation],[Usertype],[EMail]) VALUES (@EmployeeId,@FirstName,@LastName,@DateOfBirth,@Address,@MobileNumber,@Designation,@UserType,@Email)", Connection = connection })
                                                        {

                                                            DateTime dt = dtp_DOB.Value;
                                                            
                                                            sqlCmd.Parameters.AddWithValue("@EmployeeId", txt_EmployeeId.Text);
                                                            sqlCmd.Parameters.AddWithValue("@FirstName", txt_FirstName.Text);
                                                            sqlCmd.Parameters.AddWithValue("@LastName", txt_LastName.Text);
                                                            sqlCmd.Parameters.AddWithValue("@DateOfBirth", dt.ToString());
                                                            sqlCmd.Parameters.AddWithValue("@Address", txt_Address.Text);
                                                            sqlCmd.Parameters.AddWithValue("@MobileNumber", mtb_MobileNo.Text);
                                                            //sqlCmd.Parameters.AddWithValue("@Photo", pictureBox_picture.ImageLocation);
                                                            sqlCmd.Parameters.AddWithValue("@Designation", txt_designation.Text);
                                                            sqlCmd.Parameters.AddWithValue("@UserType", cbx_usertype.SelectedItem);
                                                            sqlCmd.Parameters.AddWithValue("@Email", txt_Email.Text);

                                                                

                                                            sqlCmd.ExecuteNonQuery();
                                                        }

                                                        MessageBox.Show("Employee data Register Sucessfully");

                                                    }

                                                }   
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        private void btn_Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image file(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";

            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox_picture.Image = new Bitmap(open.FileName);

            }
        }

        private void EmployeeRegistration_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-Q66P4DD;Initial Catalog=EMS_DataCenter;Integrated Security=True";
            connection = new SqlConnection(connectionString);
            connection.Open();

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            
            
           Dashboard Dashboard= new Dashboard();           
            Dashboard.Show();
            this.Close();

                

            
        }
    }
}
