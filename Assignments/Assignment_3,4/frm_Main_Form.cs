using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Assignment
{
    public partial class frm_Main_Form : Form
    {
        public frm_Main_Form()
        {
            InitializeComponent();
        }

        private void frm_Main_Form_Load(object sender, EventArgs e)
        {
            lbl_Username.Text = "Welcome " + Shared_Conternt.Uname;
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_New_Student obj = new frm_Add_New_Student();
            obj.MdiParent = this;
            obj.Show();

        }

        private void searchStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Search_Student_Details obj = new frm_Search_Student_Details();
            obj.MdiParent = this;
            obj.Show();

        }

        private void studentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_View_All_Student_List obj = new frm_View_All_Student_List();
            obj.MdiParent = this;
            obj.Show();

        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure want to Logout", "Warning", MessageBoxButtons.YesNo);
            frm_Login_Form obj = new frm_Login_Form();
            obj.Show();
            this.Hide();
        }

        private void updateStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Update_Student obj = new frm_Update_Student();
            obj.MdiParent = this;
            obj.Show();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_Course obj = new frm_Add_Course();
            obj.MdiParent = this;
            obj.Show();
        }

        private void courseListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frm_Course_List obj = new frm_Course_List();
            obj.MdiParent = this;
            obj.Show();
        }
    }
}
