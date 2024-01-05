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
    public partial class frmEqua2 : Form
    {
        public frmEqua2()
        {
            InitializeComponent();
        }

        private void txta_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmEqua2_Load(object sender, EventArgs e)
        {

        }

        private void btnsol_Click(object sender, EventArgs e)
        {
            double a1, b1, a2, b2, c1, c2;
            a1 = double.Parse(txta1.Text);
            b1 = double.Parse(txtb1.Text);
            a2 = double.Parse(txta2.Text);
            b2 = double.Parse(txtb2.Text);
            c1 = double.Parse(txtc1.Text);
            c2 = double.Parse(txtc2.Text);

            double d, dx, dy;
            d = a1 * b2 - a2 * b1;
            dx = c1 * b2 - c2 * b1;
            dy = a1 * c2 - a2 * c1;
            if (d != 0)
            {
                double x, y;
                x = dx / d;
                y = dy / d;
                lblx.Text = "x = " + x.ToString();
                lbly.Text = "y = " + y.ToString();
            }
            else
            {
                if (dx != 0 || dy != 0) 
                    MessageBox.Show("Hệ phương trình vô nghiệm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    lblx.Text = "Hệ phương trình có vô số nghiệm thỏa:";
                    lbly.Text = a1.ToString() + "x + " + b1.ToString() + "y = " + c1.ToString();
                }
            }
        }

        private void lblres_Click(object sender, EventArgs e)
        {

        }
    }
}
