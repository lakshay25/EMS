
namespace EMS
{
    partial class leave
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.dtp_todate = new System.Windows.Forms.DateTimePicker();
            this.dtp_Fromdate = new System.Windows.Forms.DateTimePicker();
            this.cbx_leavetype = new System.Windows.Forms.ComboBox();
            this.cbx_EmployeeName = new System.Windows.Forms.ComboBox();
            this.lbl_description = new System.Windows.Forms.Label();
            this.lbl_Todate = new System.Windows.Forms.Label();
            this.lbl_fromdate = new System.Windows.Forms.Label();
            this.lbl_leavetype = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(8, 8);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(702, 544);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.btn_cancel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(694, 518);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "list";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(201, 195);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_cancel.Location = new System.Drawing.Point(96, 195);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 33);
            this.btn_cancel.TabIndex = 0;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.tabPage2.Controls.Add(this.txt_description);
            this.tabPage2.Controls.Add(this.btn_submit);
            this.tabPage2.Controls.Add(this.btn_back);
            this.tabPage2.Controls.Add(this.dtp_todate);
            this.tabPage2.Controls.Add(this.dtp_Fromdate);
            this.tabPage2.Controls.Add(this.cbx_leavetype);
            this.tabPage2.Controls.Add(this.cbx_EmployeeName);
            this.tabPage2.Controls.Add(this.lbl_description);
            this.tabPage2.Controls.Add(this.lbl_Todate);
            this.tabPage2.Controls.Add(this.lbl_fromdate);
            this.tabPage2.Controls.Add(this.lbl_leavetype);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(694, 518);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "leave approval";
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(377, 273);
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(256, 20);
            this.txt_description.TabIndex = 7;
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_submit.Location = new System.Drawing.Point(211, 468);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(84, 40);
            this.btn_submit.TabIndex = 8;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_back.Location = new System.Drawing.Point(341, 468);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(84, 40);
            this.btn_back.TabIndex = 9;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            // 
            // dtp_todate
            // 
            this.dtp_todate.Location = new System.Drawing.Point(377, 225);
            this.dtp_todate.Name = "dtp_todate";
            this.dtp_todate.Size = new System.Drawing.Size(256, 20);
            this.dtp_todate.TabIndex = 6;
            // 
            // dtp_Fromdate
            // 
            this.dtp_Fromdate.Location = new System.Drawing.Point(380, 172);
            this.dtp_Fromdate.Name = "dtp_Fromdate";
            this.dtp_Fromdate.Size = new System.Drawing.Size(253, 20);
            this.dtp_Fromdate.TabIndex = 5;
            // 
            // cbx_leavetype
            // 
            this.cbx_leavetype.FormattingEnabled = true;
            this.cbx_leavetype.Items.AddRange(new object[] {
            "Casual Leave",
            "Sick Leave/Medical Leave",
            "Maternity Leave",
            "Quarantine Leave",
            "Work From  Home Leave"});
            this.cbx_leavetype.Location = new System.Drawing.Point(380, 119);
            this.cbx_leavetype.Name = "cbx_leavetype";
            this.cbx_leavetype.Size = new System.Drawing.Size(253, 21);
            this.cbx_leavetype.TabIndex = 4;
            // 
            // cbx_EmployeeName
            // 
            this.cbx_EmployeeName.FormattingEnabled = true;
            this.cbx_EmployeeName.Location = new System.Drawing.Point(380, 66);
            this.cbx_EmployeeName.Name = "cbx_EmployeeName";
            this.cbx_EmployeeName.Size = new System.Drawing.Size(253, 21);
            this.cbx_EmployeeName.TabIndex = 3;
            // 
            // lbl_description
            // 
            this.lbl_description.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_description.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_description.Location = new System.Drawing.Point(48, 269);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(129, 23);
            this.lbl_description.TabIndex = 6;
            this.lbl_description.Text = "Description";
            // 
            // lbl_Todate
            // 
            this.lbl_Todate.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Todate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_Todate.Location = new System.Drawing.Point(48, 222);
            this.lbl_Todate.Name = "lbl_Todate";
            this.lbl_Todate.Size = new System.Drawing.Size(100, 23);
            this.lbl_Todate.TabIndex = 5;
            this.lbl_Todate.Text = "To Date";
            // 
            // lbl_fromdate
            // 
            this.lbl_fromdate.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fromdate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_fromdate.Location = new System.Drawing.Point(48, 169);
            this.lbl_fromdate.Name = "lbl_fromdate";
            this.lbl_fromdate.Size = new System.Drawing.Size(117, 23);
            this.lbl_fromdate.TabIndex = 4;
            this.lbl_fromdate.Text = "From Date";
            // 
            // lbl_leavetype
            // 
            this.lbl_leavetype.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_leavetype.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_leavetype.Location = new System.Drawing.Point(48, 113);
            this.lbl_leavetype.Name = "lbl_leavetype";
            this.lbl_leavetype.Size = new System.Drawing.Size(135, 32);
            this.lbl_leavetype.TabIndex = 3;
            this.lbl_leavetype.Text = "Leave Type";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(48, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Employee Name";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(694, 518);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "search emplyoee";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // leave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 550);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "leave";
            this.Text = "leave";
            this.Load += new System.EventHandler(this.leave_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.Label lbl_Todate;
        private System.Windows.Forms.Label lbl_fromdate;
        private System.Windows.Forms.Label lbl_leavetype;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_todate;
        private System.Windows.Forms.DateTimePicker dtp_Fromdate;
        private System.Windows.Forms.ComboBox cbx_leavetype;
        private System.Windows.Forms.ComboBox cbx_EmployeeName;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.TextBox txt_description;
    }
}