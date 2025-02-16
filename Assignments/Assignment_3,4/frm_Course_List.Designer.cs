
namespace _01_Assignment
{
    partial class frm_Course_List
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lal_title = new System.Windows.Forms.Label();
            this._Assignment34_dboDataSet1 = new _01_Assignment._Assignment34_dboDataSet1();
            this.courseDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.course_DetailsTableAdapter = new _01_Assignment._Assignment34_dboDataSet1TableAdapters.Course_DetailsTableAdapter();
            this.courseIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Assignment34_dboDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseIdDataGridViewTextBoxColumn,
            this.courseNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.courseDetailsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(36, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(812, 386);
            this.dataGridView1.TabIndex = 51;
            // 
            // lal_title
            // 
            this.lal_title.AutoSize = true;
            this.lal_title.BackColor = System.Drawing.Color.White;
            this.lal_title.Font = new System.Drawing.Font("Century", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lal_title.ForeColor = System.Drawing.Color.DeepPink;
            this.lal_title.Location = new System.Drawing.Point(262, 41);
            this.lal_title.Name = "lal_title";
            this.lal_title.Size = new System.Drawing.Size(317, 64);
            this.lal_title.TabIndex = 50;
            this.lal_title.Text = "Course List";
            // 
            // _Assignment34_dboDataSet1
            // 
            this._Assignment34_dboDataSet1.DataSetName = "_Assignment34_dboDataSet1";
            this._Assignment34_dboDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseDetailsBindingSource
            // 
            this.courseDetailsBindingSource.DataMember = "Course_Details";
            this.courseDetailsBindingSource.DataSource = this._Assignment34_dboDataSet1;
            // 
            // course_DetailsTableAdapter
            // 
            this.course_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // courseIdDataGridViewTextBoxColumn
            // 
            this.courseIdDataGridViewTextBoxColumn.DataPropertyName = "Course_Id";
            this.courseIdDataGridViewTextBoxColumn.HeaderText = "Course_Id";
            this.courseIdDataGridViewTextBoxColumn.Name = "courseIdDataGridViewTextBoxColumn";
            this.courseIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseNameDataGridViewTextBoxColumn
            // 
            this.courseNameDataGridViewTextBoxColumn.DataPropertyName = "Course_Name";
            this.courseNameDataGridViewTextBoxColumn.HeaderText = "Course_Name";
            this.courseNameDataGridViewTextBoxColumn.Name = "courseNameDataGridViewTextBoxColumn";
            this.courseNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frm_Course_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 634);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lal_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Course_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Course_List";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Course_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Assignment34_dboDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lal_title;
        private _Assignment34_dboDataSet1 _Assignment34_dboDataSet1;
        private System.Windows.Forms.BindingSource courseDetailsBindingSource;
        private _Assignment34_dboDataSet1TableAdapters.Course_DetailsTableAdapter course_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseNameDataGridViewTextBoxColumn;
    }
}