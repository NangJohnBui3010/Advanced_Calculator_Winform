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
    public partial class equationMenu : Form
    {
        public equationMenu()
        {
            InitializeComponent();
        }

        private void equationMenu_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmQua frmQ = new frmQua();
            frmQ.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmEqua2 frmE2 = new frmEqua2();
            frmE2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmEqua3 frmE3 = new frmEqua3();
            frmE3.ShowDialog();
        }
    }
}
