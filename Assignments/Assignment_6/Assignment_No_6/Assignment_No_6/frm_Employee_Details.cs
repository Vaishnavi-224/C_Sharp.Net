using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_No_6
{
    public partial class frm_Employee_Details : System.Windows.Forms.Form
    {
        public frm_Employee_Details()
        {
            InitializeComponent();
        }

 

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            tb_Employee_Name.Clear();
            cmb_Employee_Department.SelectedIndex = -1;

            rb_Male.Checked = false;
            rb_Female.Checked = false;

            cb_Marathi.Checked = false;
            cb_Hindi.Checked = false;
            cb_English.Checked = false;
            cb_French.Checked = false;

            for (int i = 0; i < clb_Hobbies.Items.Count; i++)
            {
                clb_Hobbies.SetItemChecked(i, false);
            }

            lbl_Output.Visible = false;
        }

        private void frm_Employee_Details_Load(object sender, EventArgs e)
        {

        }

       
            private void btn_Submit_Click(object sender, EventArgs e)
            {
                string Result = "";
                bool Flag = true, LFlag = true;

                if (tb_Employee_Name.Text != "")
                {
                    Result += tb_Employee_Name.Text + " is From Department ";
                    lbl_Error_Name.Visible = false;
                }
                else
                {
                    lbl_Error_Name.Text = "Enter Employee Name";
                    lbl_Error_Name.Visible = true;
                    Flag = false;
                }

                if (cmb_Employee_Department.Text != "")
                {
                    Result += cmb_Employee_Department.Text;
                    lbl_Error_Department.Visible = false;
                }
                else
                {
                    lbl_Error_Department.Text = "Select Dept";
                    lbl_Error_Department.Visible = true;
                    Flag = false;
                }

                if (rb_Male.Checked == true)
                {
                    Result += ", is " + rb_Male.Text + " And He Knows ";
                    lbl_Error_Gender.Visible = false;
                }
                else if (rb_Female.Checked == true)
                {
                    Result += ", is " + rb_Female.Text + " And She Knows ";
                    lbl_Error_Gender.Visible = false;
                }
                else
                {
                    lbl_Error_Gender.Text = "Select Gender";
                    lbl_Error_Gender.Visible = true;
                    Flag = false;
                }

                if (cb_Marathi.Checked == true)
                {
                    Result += cb_Marathi.Text + ", ";
                    lbl_Error_Lang.Visible = false;
                    LFlag = false;
                }
                if (cb_Hindi.Checked == true)
                {
                    Result += cb_Hindi.Text + ", ";
                    lbl_Error_Lang.Visible = false;
                    LFlag = false;
                }
                if (cb_English.Checked == true)
                {
                    Result += cb_English.Text + ", ";
                    lbl_Error_Lang.Visible = false;
                    LFlag = false;
                }
                if (cb_French.Checked == true)
                {
                    Result += cb_French.Text + ", ";
                    lbl_Error_Lang.Visible = false;
                    LFlag = false;
                }

                if (LFlag == true)
                {
                    lbl_Error_Lang.Text = "Select Known Lang";
                    lbl_Error_Lang.Visible = true;
                    Flag = false;
                }

                int Cnt = clb_Hobbies.CheckedItems.Count;

                if (Cnt > 0)
                {
                    lbl_Error_Hobbies.Visible = false;
                    Result += " And Has Hobbies as ";

                    for (int i = 0; i < clb_Hobbies.Items.Count; i++)
                    {
                        if (clb_Hobbies.GetItemChecked(i))
                        {
                            if (Cnt > 1)
                            {
                                Result += clb_Hobbies.Items[i] + " ,";
                            }
                            else
                            {
                                Result += clb_Hobbies.Items[i] + ".";
                                break;
                            }

                            Cnt--;
                        }
                    }

                }
                else
                {
                    lbl_Error_Hobbies.Visible = true;
                    Flag = false;
                }

                if (Flag == false)
                {
                    MessageBox.Show("Incomplte Data", "Fill Required Details", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lbl_Output.Visible = false;
                }
                else
                {
                lbl_Result_Text.Text = Result;
                lbl_Result_Text.Visible = true;
            }
            }

       
    }
    
}
