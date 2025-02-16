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
    public partial class frm_Add_Course : Form
    {
        public frm_Add_Course()
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

        void Clear_Cantrols()
        {
            Auto_Incr();
            tb_Course_Name.Clear();
        }
        void Auto_Incr()
        {
            con_open();
            int Cnt = 0;

            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = con;
            Cmd.CommandText = "select count (*) from Course_Details";

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.Connection = con;
                Cmd.CommandText = "select max(Course_Id) from Course_Details";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

                Cnt++;
            }
            else
            {
                Cnt = 1;
            }

            tb_Course_ID.Text = Convert.ToString(Cnt);

            con_Close();
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

        private void frm_Add_Course_Load(object sender, EventArgs e)
        {
            Clear_Cantrols();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

            con_open();

            if (tb_Course_ID.Text != "" && tb_Course_Name.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = con;
                Cmd.CommandText = "Insert into Course_Details values(@Cid, @Cnm)";

                Cmd.Parameters.Add("Cid", SqlDbType.Int).Value = tb_Course_ID.Text;
                Cmd.Parameters.Add("Cnm", SqlDbType.NVarChar).Value = tb_Course_Name.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Course Saved Succsefully !!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("First Mention The Course Name !!!", "INCOMPLETE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Clear_Cantrols();
            con_Close();
        }
    }
}
