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
                                                        // db query insert
                                                        string query = "";
                                                        //  SqlDataAdapter da = new SqlDataAdapter(query, connection);

                                                        // DataSet dataset = new DataSet();
                                                        // da.Fill(dataset);

                                                        SqlCommand cmd = new SqlCommand("sp_insert", connection);
                                                        cmd.CommandType = CommandType.StoredProcedure;
                                                        cmd.Parameters.AddWithValue("@EmployeeId", txt_EmployeeId.Text);
                                                        cmd.Parameters.AddWithValue("@First Name", txt_FirstName.Text);
                                                        cmd.Parameters.AddWithValue("@Last Name", txt_LastName.Text);
                                                        cmd.Parameters.AddWithValue("@DateOfBirth", dtp_DOB.Value);
                                                        cmd.Parameters.AddWithValue("@gender", cbx_Gender.SelectedItem);
                                                        cmd.Parameters.AddWithValue("@Email", txt_Email.Text);
                                                        cmd.Parameters.AddWithValue("@Mobile No", mtb_MobileNo.Text);
                                                        cmd.Parameters.AddWithValue("@designation", txt_designation.Text);
                                                        cmd.Parameters.AddWithValue("@Address", txt_Address.Text);
                                                        cmd.Parameters.AddWithValue("@usertype", cbx_usertype.SelectedItem);
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


    }
}
