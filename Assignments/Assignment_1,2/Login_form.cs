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
    public partial class frm_Login_Form : Form
    {
        public frm_Login_Form()
        {
            InitializeComponent();
        }

        private void frm_Login_Form_Load(object sender, EventArgs e)
        {
           

        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (tb_Username.Text == "v" && tb_Password.Text == "v")
            {
                MessageBox.Show("Login Succesful", "Welcome");

                Shared_Conternt.Uname = tb_Username.Text;

                frm_Add_New_Student ANS = new frm_Add_New_Student();
                ANS.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login failed,Enter Correct Username Password", "Failure");
            }

            tb_Username.Clear();
            tb_Password.Clear();
        }
    }
}
