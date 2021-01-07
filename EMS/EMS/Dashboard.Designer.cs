
namespace EMS
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.btn_Entry = new System.Windows.Forms.Button();
            this.btn_leave = new System.Windows.Forms.Button();
            this.btn_compoff = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Emplyoee = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Entry
            // 
            this.btn_Entry.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Entry.Font = new System.Drawing.Font("Microsoft YaHei", 9.78F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Entry.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Entry.Location = new System.Drawing.Point(553, 192);
            this.btn_Entry.Name = "btn_Entry";
            this.btn_Entry.Size = new System.Drawing.Size(107, 72);
            this.btn_Entry.TabIndex = 0;
            this.btn_Entry.Text = "Entry";
            this.btn_Entry.UseVisualStyleBackColor = false;
            this.btn_Entry.Click += new System.EventHandler(this.btn_Entry_Click);
            // 
            // btn_leave
            // 
            this.btn_leave.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_leave.Font = new System.Drawing.Font("Microsoft YaHei", 9.78F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_leave.Location = new System.Drawing.Point(354, 322);
            this.btn_leave.Name = "btn_leave";
            this.btn_leave.Size = new System.Drawing.Size(107, 72);
            this.btn_leave.TabIndex = 1;
            this.btn_leave.Text = "leave";
            this.btn_leave.UseVisualStyleBackColor = false;
            this.btn_leave.Click += new System.EventHandler(this.btn_leave_Click);
            // 
            // btn_compoff
            // 
            this.btn_compoff.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_compoff.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_compoff.Location = new System.Drawing.Point(553, 322);
            this.btn_compoff.Name = "btn_compoff";
            this.btn_compoff.Size = new System.Drawing.Size(107, 72);
            this.btn_compoff.TabIndex = 2;
            this.btn_compoff.Text = "Comp off";
            this.btn_compoff.UseVisualStyleBackColor = false;
            this.btn_compoff.Click += new System.EventHandler(this.btn_compoff_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Font = new System.Drawing.Font("Rockwell", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(198, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(545, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "MICROLENT SYSTEMS PVT. LTD";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 173);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Emplyoee
            // 
            this.btn_Emplyoee.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Emplyoee.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Emplyoee.Location = new System.Drawing.Point(354, 192);
            this.btn_Emplyoee.Name = "btn_Emplyoee";
            this.btn_Emplyoee.Size = new System.Drawing.Size(107, 72);
            this.btn_Emplyoee.TabIndex = 5;
            this.btn_Emplyoee.Text = "Employee Registration";
            this.btn_Emplyoee.UseVisualStyleBackColor = false;
            this.btn_Emplyoee.Click += new System.EventHandler(this.btn_Emplyoee_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(755, 467);
            this.Controls.Add(this.btn_Emplyoee);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_compoff);
            this.Controls.Add(this.btn_leave);
            this.Controls.Add(this.btn_Entry);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Entry;
        private System.Windows.Forms.Button btn_leave;
        private System.Windows.Forms.Button btn_compoff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Emplyoee;
    }
}