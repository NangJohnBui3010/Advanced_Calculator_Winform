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
    public partial class frmQua : Form
    {
        public frmQua()
        {
            InitializeComponent();
        }

        private void txta_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void frmQua_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void btnsol_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a = double.Parse(txta.Text);
            b = double.Parse(txtb.Text);
            c = double.Parse(txtc.Text);
            if (a == 0)
            {
                MessageBox.Show("Lỗi phép tính", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                double delta = b * b - 4 * a * c;
                double deno = 2 * a;
                if (delta < 0)
                {
                    MessageBox.Show("Phương trình vô nghiệm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                if (delta == 0)
                {
                    double x = -b / deno;
                    lblans1.Text = x.ToString();
                    lblans2.Text = x.ToString();
                }
                else
                {
                    double x1 = (-b / deno) + (Math.Sqrt(delta) / deno);
                    double x2 = (-b / deno) - (Math.Sqrt(delta) / deno);
                    lblans1.Text = x1.ToString();
                    lblans2.Text = x2.ToString();
                }
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
