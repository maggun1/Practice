using System;
using System.Windows.Forms;

namespace WindowsFormsVersion
{
    public partial class Form3 : Form
    {
        Character enemy = null;
        Weapon en_wp = new Weapon("Ржавый меч", 10);
        string choose;
        public Form3()
        {
            InitializeComponent();
        }

        private void ralof_bn_Click(object sender, EventArgs e)
        {
            enemy = new Character("Имперец", 70, 10);
            choose = "Ралоф";
        }

        private void hadvar_bn_Click(object sender, EventArgs e)
        {
            enemy = new Character("Брат Бури", 70, 10);
            choose = "Хадвар";
        }
    }
}
