using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplicationCS_Calc
{
    public partial class Form1 : Form
    {

        public string calcOperation = "0";
        public string priorVal = "0";

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_01.PerformClick();
            }

            if (e.KeyCode == Keys.NumPad1)
            {
                btn_01.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad2)
            {
                btn_02.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad3)
            {
                btn_03.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad4)
            {
                btn_04.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad5)
            {
                btn_05.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad6)
            {
                btn_06.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad7)
            {
                btn_07.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad8)
            {
                btn_08.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad9)
            {
                btn_09.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad0)
            {
                btn_00.PerformClick();
            }
            else if (e.KeyCode == Keys.Decimal )
            {
                btn_pt.PerformClick();
            }



            else if (e.KeyCode == Keys.Add )
            {
                btn_pls.PerformClick();
            }
            else if (e.KeyCode == Keys.Subtract)
            {
                btn_mn.PerformClick();
            }
            else if (e.KeyCode == Keys.Multiply)
            {
                btn_tms.PerformClick();
            }
            else if (e.KeyCode == Keys.Divide)
            {
                btn_dv.PerformClick();
            }


        }


        private void btn_01_Click(object sender, EventArgs e)
        {
            btn_eq.Select();
            if (txtOUT.Text == "0")
            {
                txtOUT.Text = "1";
            }
            else
            {
                txtOUT.Text = txtOUT.Text + "1";
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            btn_eq.Select();
            if (txtOUT.Text == "0")
            {
                txtOUT.Text = "4";
            }
            else
            {
                txtOUT.Text = txtOUT.Text + "4";
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            btn_eq.Select();
            if (txtOUT.Text == "0")
            {
                txtOUT.Text = "2";
            }
            else
            {
                txtOUT.Text = txtOUT.Text + "2";
            }

        }

        private void btn_08_Click(object sender, EventArgs e)
        {
            btn_eq.Select();
            if (txtOUT.Text == "0")
            {
                txtOUT.Text = "8";
            }
            else
            {
                txtOUT.Text = txtOUT.Text + "8";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            btn_eq.Select();
            if (txtOUT.TextLength  == 1)
            {
                txtOUT.Text = "0";
            }
            else
            {
                int outLen = txtOUT.TextLength;
                txtOUT.Text =  txtOUT.Text.Substring(0,outLen  - 1);
            }

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frmObjabout = new Form2();
            frmObjabout.ShowDialog();
            //new Form2();

        }

        private void btn_03_Click(object sender, EventArgs e)
        {
            btn_eq.Select();
            if (txtOUT.Text == "0")
            {
                txtOUT.Text = "3";
            }
            else
            {
                txtOUT.Text = txtOUT.Text + "3";
            }

        }

        private void btn_05_Click(object sender, EventArgs e)
        {
            btn_eq.Select();
            if (txtOUT.Text == "0")
            {
                txtOUT.Text = "5";
            }
            else
            {
                txtOUT.Text = txtOUT.Text + "5";
            }

        }

        private void btn_06_Click(object sender, EventArgs e)
        {
            btn_eq.Select();
            if (txtOUT.Text == "0")
            {
                txtOUT.Text = "6";
            }
            else
            {
                txtOUT.Text = txtOUT.Text + "6";
            }

        }

        private void btn_07_Click(object sender, EventArgs e)
        {
            btn_eq.Select();
            if (txtOUT.Text == "0")
            {
                txtOUT.Text = "7";
            }
            else
            {
                txtOUT.Text = txtOUT.Text + "7";
            }

        }

        private void btn_09_Click(object sender, EventArgs e)
        {
            btn_eq.Select();
            if (txtOUT.Text == "0")
            {
                txtOUT.Text = "9";
            }
            else
            {
                txtOUT.Text = txtOUT.Text + "9";
            }

        }

        private void btn_pt_Click(object sender, EventArgs e)
        {
            btn_eq.Select();
            if (txtOUT.Text.Contains(".") )
            {
                return;
            }
            if (txtOUT.Text == "0")
            {
                txtOUT.Text = "0.";
            }
            else
            {
                txtOUT.Text = txtOUT.Text + ".";
            }

        }

        private void btn_ca_Click(object sender, EventArgs e)
        {
            btn_eq.Select();
            txtOUT.Text = "0";
        }

        private void btn_pls_Click(object sender, EventArgs e)
        {
            btn_eq.Select();
            priorVal = txtOUT.Text;
            calcOperation = "+";
            txtOUT.Text = "0";
        }

        private void btn_mn_Click(object sender, EventArgs e)
        {
            btn_eq.Select();
            priorVal = txtOUT.Text;
            calcOperation = "-";
            txtOUT.Text = "0";
        }

        private void btn_tms_Click(object sender, EventArgs e)
        {
            btn_eq.Select();
            priorVal = txtOUT.Text;
            calcOperation = "x";
            txtOUT.Text = "0";
        }

        private void btn_dv_Click(object sender, EventArgs e)
        {
            btn_eq.Select();
            priorVal = txtOUT.Text;
            calcOperation = "/";
            txtOUT.Text = "0";
        }

        private void btn_eq_Click(object sender, EventArgs e)
        {
            btn_eq.Select();
            if (calcOperation != "0")
            {
                
                decimal pv = Convert.ToDecimal(priorVal);
                decimal cur= Convert.ToDecimal(txtOUT.Text);
                decimal res;

                //calcOperation
                if (calcOperation=="+")
                {
                    res = pv + cur;
                    txtOUT.Text=res.ToString();            
                }
                else if (calcOperation == "-")
                {
                    res = pv - cur;
                    txtOUT.Text = res.ToString();
                }
                else if (calcOperation == "x")
                {
                    res = pv * cur;
                    txtOUT.Text = res.ToString();
                }
                if (calcOperation == "/")
                {
                    res = pv / cur;
                    txtOUT.Text = res.ToString();
                }

                calcOperation = "0";
            }
        }

        private void btn_00_Click(object sender, EventArgs e)
        {
            btn_eq.Select();
            if (txtOUT.Text == "0")
            {
                txtOUT.Text = "0";
            }
            else
            {
                txtOUT.Text = txtOUT.Text + "0";
            }

        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

            MessageBox.Show("Test");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
