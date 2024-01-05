using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancedCalc
{
    public partial class Form1 : Form
    {
        double a, b, res;
        char expr;
        bool bsol, equa;
        public Form1()
        {
            InitializeComponent();
        }
        private void calc(double a, double b)
        {
            if (expr == '+') res = a + b;
            if (expr == '-') res = a - b;
            if (expr == '*') res = a * b;
            if (expr == '/') res = a / b;
            if (expr == '#') res = a % b;
            if (expr == '$')
            {
                a = a - (a % b);
                res = a / b;
            }
            if (expr == '^') res = Math.Pow(a, b);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            expr = '@';
            bsol = true;
            equa = false;
        }

        private void so1_Click(object sender, EventArgs e)
        {
            if(bsol == true)
            {
                bsol = false;
                txtbx.Text = "";
                res = 0;
                expr = '@';
                lbl.Text = "";
            }
            txtbx.Text += "1";
        }

        private void so2_Click(object sender, EventArgs e)
        {
            if (bsol == true)
            {
                bsol = false; 
                txtbx.Text = "";
                res = 0;
                expr = '@';
                lbl.Text = "";
            }
            txtbx.Text += "2";
        }

        private void so3_Click(object sender, EventArgs e)
        {
            if (bsol == true)
            {
                bsol = false;
                txtbx.Text = "";
                res = 0;
                expr = '@';
                lbl.Text = "";
            }
            txtbx.Text += "3";
        }

        private void so4_Click(object sender, EventArgs e)
        {
            if (bsol == true)
            {
                bsol = false;
                txtbx.Text = "";
                res = 0;
                expr = '@';
                lbl.Text = "";
            }
            txtbx.Text += "4";
        }

        private void so5_Click(object sender, EventArgs e)
        {
            if (bsol == true)
            {
                bsol = false;
                txtbx.Text = "";
                res = 0;
                expr = '@';
                lbl.Text = "";
            }
            txtbx.Text += "5";
        }

        private void so6_Click(object sender, EventArgs e)
        {
            if (bsol == true)
            {
                bsol = false;
                txtbx.Text = "";
                res = 0;
                expr = '@';
                lbl.Text = "";
            }
            txtbx.Text += "6";
        }

        private void so7_Click(object sender, EventArgs e)
        {
            if (bsol == true)
            {
                bsol = false;
                txtbx.Text = "";
                res = 0;
                expr = '@';
                lbl.Text = "";
            }
            txtbx.Text += "7";
        }

        private void so8_Click(object sender, EventArgs e)
        {
            if (bsol == true)
            {
                bsol = false;
                txtbx.Text = "";
                res = 0;
                expr = '@';
                lbl.Text = "";
            }
            txtbx.Text += "8";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (bsol == false && txtbx.Text == "")
            {
                lbl.Text = lbl.Text.Remove(lbl.Text.Length-1);
                lbl.Text = lbl.Text + '-';
                expr = '-';
            }
            else if (expr == '@') a = double.Parse(txtbx.Text);
            else
            {
                b = double.Parse(txtbx.Text);
                calc(a, b);
                a = res;
            }
            lbl.Text = a.ToString() + "-";
            txtbx.Text = "";
            expr = '-';
            bsol = false;
        }

        private void so9_Click(object sender, EventArgs e)
        {
            if (bsol == true)
            {
                bsol = false;
                txtbx.Text = "";
                res = 0;
                expr = '@';
                lbl.Text = "";
            }
            txtbx.Text += "9";
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            if (bsol == false && txtbx.Text == "")
            {
                lbl.Text = lbl.Text.Remove(lbl.Text.Length - 1);
                lbl.Text = lbl.Text + '*';
                expr = '*';
            }
            else if(expr == '@') a = double.Parse(txtbx.Text);
            else
            {
                b = double.Parse(txtbx.Text);
                calc(a, b);
                a = res;
            }
            lbl.Text = a.ToString() + "*";
            txtbx.Text = "";
            expr = '*';
            bsol = false;
        }

        private void divide_Click(object sender, EventArgs e)
        {
            if (bsol == false && txtbx.Text == "")
            {
                lbl.Text = lbl.Text.Remove(lbl.Text.Length - 1);
                lbl.Text = lbl.Text + '/';
                expr = '/';
            }
            else
            if (expr == '@') a = double.Parse(txtbx.Text);
            else
            {
                b = double.Parse(txtbx.Text);
                calc(a, b);
                a = res;
            }
            lbl.Text = a.ToString() + "/";
            txtbx.Text = "";
            expr = '/';
            bsol = false;
        }

        private void sol_Click(object sender, EventArgs e)
        {
            if (equa == true)
            {
                lblequa.Text = "";
                if (txtbx.Text == "1")
                {
                    frmQua frmQ = new frmQua();
                    frmQ.ShowDialog();
                }
                else 
                if (txtbx.Text == "2")
                {
                    frmEqua2 frmE2 = new frmEqua2();
                    frmE2.ShowDialog();
                }
                else
                {
                    frmEqua3 frmE3 = new frmEqua3();
                    frmE3.ShowDialog();
                }
                equa = false;
            }
            else
            { 
                if(txtbx.Text == "")
                {
                    MessageBox.Show("Please enter the next number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    b = double.Parse(txtbx.Text);
                    lbl.Text += txtbx.Text + "=";
                    if (expr == '@') res = b;
                    else calc(a, b);
                    txtbx.Text = res.ToString();
                    expr = '@';
                    bsol = true;
                }
            }
        }

        private void ac_Click(object sender, EventArgs e)
        {
            bsol = true;
            txtbx.Text = "";
            res = 0;
            expr = '@';
            lbl.Text = "";
        }

        private void del_Click(object sender, EventArgs e)
        {
            if (lbl.Text == "" && txtbx.Text == "") return;
            if (txtbx.Text == "" && lbl.Text != "")
            {
                txtbx.Text = lbl.Text.Remove(lbl.Text.Length - 1);
                lbl.Text = "";
                bsol = true;
            } else
            {
                char s = txtbx.Text[txtbx.Text.Length - 1];
                if (s == '+' || s == '-' || s == '*' || s == '/' || s == '^' || s == 'v' || s == 'd')
                {
                    if (s == 'v' || s == 'd')
                    {
                        for(int i = 1; i <= 3; i++)
                            txtbx.Text = txtbx.Text.Remove(txtbx.Text.Length - 1);
                    }
                    else txtbx.Text = txtbx.Text.Remove(txtbx.Text.Length - 1);
                    expr = '@';
                    bsol = true;
                    
                }
                txtbx.Text = txtbx.Text.Remove(txtbx.Text.Length - 1);
            }
        }

        private void mod_Click(object sender, EventArgs e)
        {
            if (bsol == false && txtbx.Text == "")
            {
                lbl.Text = lbl.Text.Remove(lbl.Text.Length - 1);
                lbl.Text = lbl.Text + " mod ";
                expr = '#';
            }
            else
            if (expr == '@') a = double.Parse(txtbx.Text);
            else
            {
                b = double.Parse(txtbx.Text);
                calc(a, b);
                a = res;
            }
            lbl.Text = a.ToString() + " mod ";
            txtbx.Text = "";
            expr = '#';
            bsol = false;
        }

        private void dot_Click(object sender, EventArgs e)
        {
            if (txtbx.Text.Contains('.')) return;
            txtbx.Text = txtbx.Text + ".";
        }

        private void div_Click(object sender, EventArgs e)
        {
            if (bsol == false && txtbx.Text == "")
            {
                lbl.Text = lbl.Text.Remove(lbl.Text.Length - 1);
                lbl.Text = lbl.Text + '$';
                expr = '$';
            }
            else
            if (expr == '@') a = double.Parse(txtbx.Text);
            else
            {
                b = double.Parse(txtbx.Text);
                calc(a, b);
                a = res;
            }
            lbl.Text = a.ToString() + " div ";
            txtbx.Text = "";
            expr = '$';
            bsol = false;
        }

        private void luythua_Click(object sender, EventArgs e)
        {
            if (bsol == false && txtbx.Text == "")
            {
                lbl.Text = lbl.Text.Remove(lbl.Text.Length - 1);
                lbl.Text = lbl.Text + '^';
                expr = '^';
            }
            else
            if (expr == '@') a = double.Parse(txtbx.Text);
            else
            {
                b = double.Parse(txtbx.Text);
                calc(a, b);
                a = res;
            }
            lbl.Text = a.ToString() + "^";
            txtbx.Text = "";
            expr = '^';
            bsol = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtbx.Text == "")
            {
                MessageBox.Show("Please enter the next number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                b = double.Parse(txtbx.Text);
                b = Math.Sqrt(b);
                txtbx.Text = b.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txtbx.Text == "")
            {
                MessageBox.Show("Please enter the next number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                b = double.Parse(txtbx.Text);
                b = b / 100;
                txtbx.Text = b.ToString();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtbx.Text == "")
            {
                MessageBox.Show("Please enter the next number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if(txtbx.Text.Contains('.'))
                {
                    MessageBox.Show("Invalid factorial", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    b = double.Parse(txtbx.Text);
                    double num = 1;
                    for (double i = 1; i <= b; ++i) num *= i;
                    b = num;
                    txtbx.Text = b.ToString();
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            equationMenu eMenu = new equationMenu();
            eMenu.ShowDialog();
        }

        private void so0_Click(object sender, EventArgs e)
        {
            if (bsol == true)
            {
                bsol = false;
                txtbx.Text = "";
                res = 0;
                expr = '@';
                lbl.Text = "";
            }
            txtbx.Text += "0";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            if (bsol == false && txtbx.Text == "") return;
            if (expr == '@') a = double.Parse(txtbx.Text);
            else
            {
                b = double.Parse(txtbx.Text);
                calc(a, b);
                a = res;
            }
            lbl.Text = a.ToString() + "+";
            txtbx.Text = "";
            expr = '+';
            bsol = false;
        }
    }
}
