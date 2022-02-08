using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        float ans = 0;
        float num1 = 0;
        int count = 0;

        private void btn1_Click(object sender, EventArgs e)
        {
            txtboxInsert.Text += 1;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtboxInsert.Text += 0;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtboxInsert.Text += 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtboxInsert.Text += 3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtboxInsert.Text += 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtboxInsert.Text += 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtboxInsert.Text += 6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtboxInsert.Text += 7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtboxInsert.Text += 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtboxInsert.Text += 9;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtboxInsert.Text != "")
                {
                    num1 = float.Parse(txtboxInsert.Text);
                    txtboxInsert.Clear();
                    txtboxInsert.Focus();
                    count = 2;
                }
            }
            catch (Exception GeneralException)
            {
                MessageBox.Show("Two entries of the same sign " + GeneralException);
            }

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtboxInsert.Text != "")
                {
                    num1 = float.Parse(txtboxInsert.Text);
                    txtboxInsert.Clear();
                    txtboxInsert.Focus();
                    count = 1;
                }
            }
            catch (Exception GeneralException)
            {
                MessageBox.Show("Two entries of the same sign " + GeneralException);
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = float.Parse(txtboxInsert.Text);
                txtboxInsert.Clear();
                txtboxInsert.Focus();
                count = 3;
            }
            catch(Exception GeneralException)
            {
                MessageBox.Show("Two entries of the same sign " + GeneralException);
            }
            
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = float.Parse(txtboxInsert.Text);
                txtboxInsert.Clear();
                txtboxInsert.Focus();
                count = 4;
            }
            catch(Exception GeneralException)
            {
                MessageBox.Show("Two entries of the same sign " + GeneralException);
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            compute(count);
        }
            
            public void compute(int count)
            {
                    ans = Convert.ToInt32(txtboxInsert.Text);
                    switch (count)
                    {
                    case 1:
                        ans = num1 - float.Parse(txtboxInsert.Text);
                        txtboxInsert.Text = ans.ToString();
                        break;
                    case 2:
                        ans = num1 + float.Parse(txtboxInsert.Text);
                        txtboxInsert.Text = ans.ToString();
                    break;
                    case 3:
                        ans = num1 * float.Parse(txtboxInsert.Text);
                        txtboxInsert.Text = ans.ToString();
                    break;
                    case 4:
                        ans = num1 / float.Parse(txtboxInsert.Text);
                        txtboxInsert.Text = ans.ToString();
                    break;
                    default:
                        break;
                    }
            }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtboxInsert.Clear();
        }
    }
}
