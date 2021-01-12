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

namespace EMS
{
    public partial class leave : Form
    {
        SqlConnection connection;

        public leave()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Close();

        }

        private void leave_Load(object sender, EventArgs e)
        {


            string connectionString = @"Data Source=DESKTOP-Q66P4DD;Initial Catalog=EMS_DataCenter;Integrated Security=True";
            connection = new SqlConnection(connectionString);
            connection.Open();


            string query = "SELECT * FROM TB_Users";
            SqlDataAdapter da = new SqlDataAdapter(query, connection);

            DataSet dataSet = new DataSet();

            da.Fill(dataSet);

            for (int lineNumber = 0; lineNumber < dataSet.Tables[0].Rows.Count; lineNumber++)
            {
                var Id = dataSet.Tables[0].Rows[lineNumber][0].ToString();
                var firstName = dataSet.Tables[0].Rows[lineNumber][1].ToString();
                var lastName = dataSet.Tables[0].Rows[lineNumber][2].ToString();


                cbx_EmployeeName.Items.Add(Id + " " + firstName + " " + lastName);

            }

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            { 
            if (string.IsNullOrEmpty(cbx_EmployeeName.Text))
                {
                    MessageBox.Show("please select employee name");
                }
                else
                {
                    if (string.IsNullOrEmpty(cbx_EmployeeName.Text))
                    {
                        MessageBox.Show("please select Employee name");
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(cbx_leavetype.Text))
                        {
                            MessageBox.Show("please select leave type");
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(dtp_Fromdate.Text))
                            {
                                MessageBox.Show("please select date");
                            }
                            else
                            {
                                if (string.IsNullOrEmpty(dtp_todate.Text))
                                {
                                    MessageBox.Show("slect to date");
                                }
                                else
                                {
                                    if (string.IsNullOrEmpty(txt_description.Text))
                                    {
                                        MessageBox.Show("please select description");
                                    }
                                    else
                                    {
                                        using (SqlCommand sqlCmd = new SqlCommand
                                        {
                                            CommandText = "INSERT INTO [TB_Users] ([EmployeeName],[LeaveType],[FromDate],[ToDate],[Description]) VALUES (@EmployeeName,@LeaveType,@FromDate,@ToDate,@Description)",
                                            Connection = connection
                                        })
                                        {
                                            
                                            sqlCmd.Parameters.AddWithValue("@EmployeeName",cbx_EmployeeName.Text);
                                            sqlCmd.Parameters.AddWithValue("@Leavetype", cbx_leavetype.Text);
                                            sqlCmd.Parameters.AddWithValue("@FromDate", dtp_Fromdate.Text);
                                            sqlCmd.Parameters.AddWithValue("@ToDate", dtp_todate.Text);
                                            sqlCmd.Parameters.AddWithValue("@Description",txt_description.Text);
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
