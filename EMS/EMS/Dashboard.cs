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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btn_Entry_Click(object sender, EventArgs e)
        {
            this.Close();
            Entry Entry = new Entry();
            Entry.Show();
        }

        private void btn_leave_Click(object sender, EventArgs e)
        {
            this.Close();
            leave leave = new leave();
            leave.Show();
        }

        private void btn_compoff_Click(object sender, EventArgs e)
        {
            this.Close();
            comp_off comp_Off = new comp_off();
            comp_Off.Show();
        }

        private void btn_Emplyoee_Click(object sender, EventArgs e)
        {
            EmployeeRegistration employeeRegistration = new EmployeeRegistration();
            employeeRegistration.Show();
            this.Close();

        }

        private void btn_SearchEmployee_Click(object sender, EventArgs e)
        {
            searchemployee searchemployee = new searchemployee();
            searchemployee.Show();
            this.Close();


        }

    }
    }
