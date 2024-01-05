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
    public partial class frmEqua3 : Form
    {
        public frmEqua3()
        {
            InitializeComponent();
        }

        private void btnsol_Click(object sender, EventArgs e)
        {
            double a1, b1, a2, b2, c1, c2, d1, d2, a3, b3, c3, d3;
            a1 = double.Parse(txta1.Text);
            b1 = double.Parse(txtb1.Text);
            c1 = double.Parse(txtc1.Text);
            d1 = double.Parse(txtd1.Text);

            a2 = double.Parse(txta2.Text);
            b2 = double.Parse(txtb2.Text);
            c2 = double.Parse(txtc2.Text);
            d2 = double.Parse(txtd2.Text);

            a3 = double.Parse(txta3.Text);
            b3 = double.Parse(txtb3.Text);
            c3 = double.Parse(txtc3.Text);
            d3 = double.Parse(txtd3.Text);


            double M = a1 * b2 * c3 + b1 * c2 * a3 + c1 * a2 * b3 - c1 * b2 * a3 - b1 * a2 * c3 - a1 * c2 * b3;
            if (M == 0)
            {
                MessageBox.Show("Hệ phương trình vô nghiệm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                double x, y, z;
                x = (d1 * b2 * c3 + b1 * c2 * d3 + c1 * d2 * b3 - c1 * b2 * d3 - b1 * d2 * c3 - d1 * c2 * b3) / M;
                y = (a1 * d2 * c3 + d1 * c2 * a3 + c1 * a2 * d3 - c1 * d2 * a3 - d1 * a2 * c3 - a1 * c2 * d3) / M;
                z = (a1 * b2 * d3 + b1 * d2 * a3 + d1 * a2 * b3 - d1 * b2 * a3 - b1 * a2 * d3 - a1 * d2 * b3) / M;
                lblx.Text = "x = " + x.ToString();
                lbly.Text = "y = " + y.ToString();
                lblz.Text = "z = " + z.ToString();
            }
        }
    }
}
