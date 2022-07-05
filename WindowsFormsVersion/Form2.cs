using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsVersion
{
    public partial class Form2 : Form
    {
        Character mc;
        Weapon mc_wn;
        public Form2(Character mc, Weapon mc_wn)
        {
            this.mc = mc;
            this.mc_wn = mc_wn;
            InitializeComponent();
        }
        private void cont_bn_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }
    }
}
