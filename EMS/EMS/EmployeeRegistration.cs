using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMS
{
    public partial class EmployeeRegistration : Form
    {
        public EmployeeRegistration()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_EmployeeId.Text))
            {
                MessageBox.Show("please enter employee id");
            }

            if (string.IsNullOrEmpty(txt_FirstName.Text))
            {
                MessageBox.Show("please enter first name");
            }

            if (string.IsNullOrEmpty(txt_LastName.Text))
            {
                MessageBox.Show("please enter last name");
            }

            if (string.IsNullOrEmpty(txt_Email.Text))
            {
                MessageBox.Show("please enter Email ");
            }

            if (string.IsNullOrEmpty(maskedTxtbox_MobileNo.Text))
            {
                MessageBox.Show("please enter mobile no ");
            }

            if (string.IsNullOrEmpty(dateTimePicker_DOB.Text))
            {
                MessageBox.Show("please enter DOB ");

            }
            if (cbx_Gender.SelectedIndex < 0)
            {
                MessageBox.Show("please enter gender ");
            }



            if (txt_Password.Text != txt_ConfirmPassword.Text) 
            {
                MessageBox.Show("Password does not match");
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

        
    }
}
