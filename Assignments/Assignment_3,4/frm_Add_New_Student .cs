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
    public partial class frm_Add_New_Student : Form
    {
        public frm_Add_New_Student()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-UMB7GAF\MSSQLSERVER02;Initial Catalog=Assignment34.dbo;Integrated Security=True");

        void con_open()
        {
            if (con.State != ConnectionState.Open)

            {
                con.Open();
            }

        }
        void con_Close()
        {
            if (con.State != ConnectionState.Closed)
            {
                con.Close();
            }
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

        void clear_Fields()
        {
            tb_Roll_No.Clear();
            tb_Name.Clear();
            tb_Mob_No.Clear();
            dtp_DOB.Text = "02-12-2003";
            cmb_Course.SelectedIndex = -1;
        }

        int Auto_Incr()
        {
            int ID = 0;

            con_open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = con;
            Cmd.CommandText = "Select Max(Roll_No) From Student_Details";

            ID = Convert.ToInt32(Cmd.ExecuteScalar());

            con_Close();

            return (ID + 1);
        }
        private void frm_Add_New_Student_Load(object sender, EventArgs e)
        {

            tb_Roll_No.Text = Convert.ToString(Auto_Incr());

        }

      

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            clear_Fields();
        }

      

        private void btn_Save_Click(object sender, EventArgs e)
        {
            con_open();

            if (tb_Roll_No.Text != "" && tb_Name.Text != "" && tb_Mob_No.Text != "" && cmb_Course.Text != "")
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandText = "Insert Into Student_Details values (@Rno,@Nm,@Mno,@dob,@course)";

                cmd.Parameters.Add("Rno", SqlDbType.Int).Value = tb_Roll_No.Text;
                cmd.Parameters.Add("Nm", SqlDbType.VarChar).Value = tb_Name.Text;
                cmd.Parameters.Add("Dob", SqlDbType.Date).Value = dtp_DOB.Text;
                cmd.Parameters.Add("Mno", SqlDbType.Decimal).Value = tb_Mob_No.Text;
                cmd.Parameters.Add("Course", SqlDbType.NVarChar).Value = cmb_Course.Text;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Record Saved Successfully...");
                clear_Fields();
            }

            else
            {
                MessageBox.Show("Incomplete Data");
            }
            con_Close();
        }

       
        
    }
}
