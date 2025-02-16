
namespace _01_Assignment
{
    partial class frm_Add_Course
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
            this.btn_Save = new System.Windows.Forms.Button();
            this.tb_Course_Name = new System.Windows.Forms.TextBox();
            this.tb_Course_ID = new System.Windows.Forms.TextBox();
            this.lbl_Course_Name = new System.Windows.Forms.Label();
            this.lbl_Course_ID = new System.Windows.Forms.Label();
            this.lal_title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Save.Font = new System.Drawing.Font("Rockwell", 18F);
            this.btn_Save.ForeColor = System.Drawing.Color.DarkOrange;
            this.btn_Save.Location = new System.Drawing.Point(356, 467);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(128, 46);
            this.btn_Save.TabIndex = 56;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // tb_Course_Name
            // 
            this.tb_Course_Name.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Course_Name.Location = new System.Drawing.Point(467, 338);
            this.tb_Course_Name.MaxLength = 80;
            this.tb_Course_Name.Name = "tb_Course_Name";
            this.tb_Course_Name.Size = new System.Drawing.Size(258, 33);
            this.tb_Course_Name.TabIndex = 55;
            // 
            // tb_Course_ID
            // 
            this.tb_Course_ID.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Course_ID.Location = new System.Drawing.Point(467, 226);
            this.tb_Course_ID.MaxLength = 5;
            this.tb_Course_ID.Name = "tb_Course_ID";
            this.tb_Course_ID.Size = new System.Drawing.Size(258, 33);
            this.tb_Course_ID.TabIndex = 54;
            // 
            // lbl_Course_Name
            // 
            this.lbl_Course_Name.AutoSize = true;
            this.lbl_Course_Name.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Course_Name.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Course_Name.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lbl_Course_Name.Location = new System.Drawing.Point(146, 342);
            this.lbl_Course_Name.Name = "lbl_Course_Name";
            this.lbl_Course_Name.Size = new System.Drawing.Size(164, 27);
            this.lbl_Course_Name.TabIndex = 59;
            this.lbl_Course_Name.Text = "Course Name";
            // 
            // lbl_Course_ID
            // 
            this.lbl_Course_ID.AutoSize = true;
            this.lbl_Course_ID.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Course_ID.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Course_ID.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lbl_Course_ID.Location = new System.Drawing.Point(146, 231);
            this.lbl_Course_ID.Name = "lbl_Course_ID";
            this.lbl_Course_ID.Size = new System.Drawing.Size(124, 27);
            this.lbl_Course_ID.TabIndex = 58;
            this.lbl_Course_ID.Text = "Course ID";
            // 
            // lal_title
            // 
            this.lal_title.AutoSize = true;
            this.lal_title.BackColor = System.Drawing.Color.White;
            this.lal_title.Font = new System.Drawing.Font("Century", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lal_title.ForeColor = System.Drawing.Color.DeepPink;
            this.lal_title.Location = new System.Drawing.Point(187, 73);
            this.lal_title.Name = "lal_title";
            this.lal_title.Size = new System.Drawing.Size(513, 64);
            this.lal_title.TabIndex = 57;
            this.lal_title.Text = "Add Course Details";
            // 
            // frm_Add_Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 673);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tb_Course_Name);
            this.Controls.Add(this.tb_Course_ID);
            this.Controls.Add(this.lbl_Course_Name);
            this.Controls.Add(this.lbl_Course_ID);
            this.Controls.Add(this.lal_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Add_Course";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Add_Course";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Add_Course_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox tb_Course_Name;
        private System.Windows.Forms.TextBox tb_Course_ID;
        private System.Windows.Forms.Label lbl_Course_Name;
        private System.Windows.Forms.Label lbl_Course_ID;
        private System.Windows.Forms.Label lal_title;
    }
}