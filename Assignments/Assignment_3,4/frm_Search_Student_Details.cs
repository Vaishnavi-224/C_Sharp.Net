using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _01_Assignment
{
    public partial class frm_Search_Student_Details : Form
    {
        public frm_Search_Student_Details()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-UMB7GAF\MSSQLSERVER02;Initial Catalog=Assignment34.dbo;Integrated Security=True");
        void Con_Open()
        {
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
        }

        void Con_Close()
        {
            if (Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }
        }
        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        void Clear_Fields()
        {
            tb_Roll_No.Clear();
            tb_Name.Clear();
            tb_Mob_No.Clear();
            dtp_DOB.Text = "01-06-2007";
            cmb_Course.SelectedIndex = -1;
        }

        private void only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbl_course_Click(object sender, EventArgs e)
        {

        }

        private void tb_roll_no_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_Search_Student_Details_Load(object sender, EventArgs e)
        {
           

        }

        private void dtp_DOB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;
            Cmd.CommandText = "Select * From Student_Details Where Roll_No = @RNo";

            Cmd.Parameters.Add("RNo", SqlDbType.Int).Value = tb_Roll_No.Text;

            SqlDataReader Dr = Cmd.ExecuteReader();

            if (Dr.Read())
            {
                tb_Name.Text = Dr.GetString(Dr.GetOrdinal("Name"));
                tb_Mob_No.Text = (Dr["Mob_No"].ToString());
                dtp_DOB.Text = (Dr["DOB"].ToString());
                cmb_Course.Text = Dr.GetString(Dr.GetOrdinal("Course"));
            }
            else
            {
                MessageBox.Show("Invalid Roll Number", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Con_Close();
        }

      

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Fields();
        }

       
        
    }
}
