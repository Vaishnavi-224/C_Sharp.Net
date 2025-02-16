
namespace _01_Assignment
{
    partial class frm_Update_Student
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
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.cmb_Course = new System.Windows.Forms.ComboBox();
            this.dtp_DOB = new System.Windows.Forms.DateTimePicker();
            this.tb_Mob_No = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Roll_No = new System.Windows.Forms.TextBox();
            this.lbl_Course = new System.Windows.Forms.Label();
            this.lbl_Mobile_No = new System.Windows.Forms.Label();
            this.lbl_DOB = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Roll_No = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Update.Font = new System.Drawing.Font("Rockwell", 18F);
            this.btn_Update.ForeColor = System.Drawing.Color.DarkOrange;
            this.btn_Update.Location = new System.Drawing.Point(471, 576);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(139, 46);
            this.btn_Update.TabIndex = 100;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Search.Font = new System.Drawing.Font("Rockwell", 18F);
            this.btn_Search.ForeColor = System.Drawing.Color.DarkOrange;
            this.btn_Search.Location = new System.Drawing.Point(720, 199);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(138, 41);
            this.btn_Search.TabIndex = 88;
            this.btn_Search.Text = "Search ";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Refresh.Font = new System.Drawing.Font("Rockwell", 18F);
            this.btn_Refresh.ForeColor = System.Drawing.Color.DarkOrange;
            this.btn_Refresh.Location = new System.Drawing.Point(195, 576);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(139, 46);
            this.btn_Refresh.TabIndex = 89;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // cmb_Course
            // 
            this.cmb_Course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Course.Enabled = false;
            this.cmb_Course.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Course.FormattingEnabled = true;
            this.cmb_Course.Items.AddRange(new object[] {
            "BCS",
            "BCA",
            "BSc.CS",
            "MSc.CS",
            "MCS",
            "MCA"});
            this.cmb_Course.Location = new System.Drawing.Point(412, 503);
            this.cmb_Course.MaxLength = 80;
            this.cmb_Course.Name = "cmb_Course";
            this.cmb_Course.Size = new System.Drawing.Size(258, 33);
            this.cmb_Course.TabIndex = 99;
            // 
            // dtp_DOB
            // 
            this.dtp_DOB.Enabled = false;
            this.dtp_DOB.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_DOB.Location = new System.Drawing.Point(412, 348);
            this.dtp_DOB.MaxDate = new System.DateTime(2007, 6, 1, 0, 0, 0, 0);
            this.dtp_DOB.MinDate = new System.DateTime(1985, 7, 5, 0, 0, 0, 0);
            this.dtp_DOB.Name = "dtp_DOB";
            this.dtp_DOB.Size = new System.Drawing.Size(258, 33);
            this.dtp_DOB.TabIndex = 92;
            this.dtp_DOB.Value = new System.DateTime(2007, 6, 1, 0, 0, 0, 0);
            // 
            // tb_Mob_No
            // 
            this.tb_Mob_No.Enabled = false;
            this.tb_Mob_No.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mob_No.Location = new System.Drawing.Point(412, 425);
            this.tb_Mob_No.MaxLength = 10;
            this.tb_Mob_No.Name = "tb_Mob_No";
            this.tb_Mob_No.Size = new System.Drawing.Size(258, 33);
            this.tb_Mob_No.TabIndex = 98;
            // 
            // tb_Name
            // 
            this.tb_Name.Enabled = false;
            this.tb_Name.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(412, 279);
            this.tb_Name.MaxLength = 80;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(258, 33);
            this.tb_Name.TabIndex = 91;
            // 
            // tb_Roll_No
            // 
            this.tb_Roll_No.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Roll_No.Location = new System.Drawing.Point(412, 207);
            this.tb_Roll_No.MaxLength = 5;
            this.tb_Roll_No.Name = "tb_Roll_No";
            this.tb_Roll_No.Size = new System.Drawing.Size(258, 33);
            this.tb_Roll_No.TabIndex = 87;
            // 
            // lbl_Course
            // 
            this.lbl_Course.AutoSize = true;
            this.lbl_Course.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Course.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Course.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lbl_Course.Location = new System.Drawing.Point(75, 503);
            this.lbl_Course.Name = "lbl_Course";
            this.lbl_Course.Size = new System.Drawing.Size(93, 27);
            this.lbl_Course.TabIndex = 97;
            this.lbl_Course.Text = "Course";
            // 
            // lbl_Mobile_No
            // 
            this.lbl_Mobile_No.AutoSize = true;
            this.lbl_Mobile_No.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Mobile_No.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile_No.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lbl_Mobile_No.Location = new System.Drawing.Point(75, 425);
            this.lbl_Mobile_No.Name = "lbl_Mobile_No";
            this.lbl_Mobile_No.Size = new System.Drawing.Size(135, 27);
            this.lbl_Mobile_No.TabIndex = 96;
            this.lbl_Mobile_No.Text = "Mobile No.";
            // 
            // lbl_DOB
            // 
            this.lbl_DOB.AutoSize = true;
            this.lbl_DOB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_DOB.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DOB.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lbl_DOB.Location = new System.Drawing.Point(75, 348);
            this.lbl_DOB.Name = "lbl_DOB";
            this.lbl_DOB.Size = new System.Drawing.Size(84, 27);
            this.lbl_DOB.TabIndex = 95;
            this.lbl_DOB.Text = "D.O.B.";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Name.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lbl_Name.Location = new System.Drawing.Point(75, 279);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(77, 27);
            this.lbl_Name.TabIndex = 94;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_Roll_No
            // 
            this.lbl_Roll_No.AutoSize = true;
            this.lbl_Roll_No.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Roll_No.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Roll_No.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lbl_Roll_No.Location = new System.Drawing.Point(75, 211);
            this.lbl_Roll_No.Name = "lbl_Roll_No";
            this.lbl_Roll_No.Size = new System.Drawing.Size(99, 27);
            this.lbl_Roll_No.TabIndex = 93;
            this.lbl_Roll_No.Text = "Roll No.";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.BackColor = System.Drawing.Color.White;
            this.lbl_Title.Font = new System.Drawing.Font("Century", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.DeepPink;
            this.lbl_Title.Location = new System.Drawing.Point(150, 34);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(621, 64);
            this.lbl_Title.TabIndex = 90;
            this.lbl_Title.Text = "Update Student Details";
            this.lbl_Title.Click += new System.EventHandler(this.lbl_Title_Click);
            // 
            // frm_Update_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 712);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.cmb_Course);
            this.Controls.Add(this.dtp_DOB);
            this.Controls.Add(this.tb_Mob_No);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.tb_Roll_No);
            this.Controls.Add(this.lbl_Course);
            this.Controls.Add(this.lbl_Mobile_No);
            this.Controls.Add(this.lbl_DOB);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_Roll_No);
            this.Controls.Add(this.lbl_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Update_Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Update_Student";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Update_Student_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.ComboBox cmb_Course;
        private System.Windows.Forms.DateTimePicker dtp_DOB;
        private System.Windows.Forms.TextBox tb_Mob_No;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_Roll_No;
        private System.Windows.Forms.Label lbl_Course;
        private System.Windows.Forms.Label lbl_Mobile_No;
        private System.Windows.Forms.Label lbl_DOB;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Roll_No;
        private System.Windows.Forms.Label lbl_Title;
    }
}