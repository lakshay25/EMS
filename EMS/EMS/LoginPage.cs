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
    public partial class Login : Form
    {
        SqlConnection connection;

        public Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {

            string username = txt_username.Text;
            string Password = txt_password.Text;
            string query = "SELECT * FROM TB_Login WHERE Username='"+username+"' AND Password='"+Password+"'";

            SqlDataAdapter da = new SqlDataAdapter(query, connection);

            DataSet xyz = new DataSet();

            da.Fill(xyz);

            if (xyz.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Not valid");
            }
            else
            {
                string dUsername = xyz.Tables[0].Rows[0][1].ToString();
                string dpassword = xyz.Tables[0].Rows[0][2].ToString();
                string dUsertype = xyz.Tables[0].Rows[0][3].ToString();

                this.Hide();

                Dashboard dashboard = new Dashboard();
                dashboard.Show();
            }



        }
           
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-Q66P4DD;Initial Catalog=EMS_DataCenter;Integrated Security=True";
            connection = new SqlConnection(connectionString);
            connection.Open();
        }
    }
}
