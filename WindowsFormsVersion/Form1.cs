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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var myToolTip = new ToolTip();
            myToolTip.SetToolTip(nord_button, "Раса: Норд \nЗдоровье: 100 \nБроня: 20 \nОружие:\nМеч \nУрон: 30");
            myToolTip.SetToolTip(elven_button, "Раса: Эльф \nЗдоровье: 75 \nБроня: 15 \nОружие:\nКинжал \nУрон: 40");
            myToolTip.SetToolTip(ork_button, "Раса: Орк \nЗдоровье: 100 \nБроня: 20 \nОружие:\nБревно \nУрон: 40");
        }
        Character mc = null;
        Weapon mc_wn = null;

        private void nord_button_Click(object sender, EventArgs e) 
        {
            mc = new Character("Норд", 100, 20);
            mc_wn = new Weapon("Меч", 30);
            Form2 form2 = new Form2(mc, mc_wn);
            form2.ShowDialog();
        }
        
        private void elven_button_Click(object sender, EventArgs e) 
        {
            mc = new Character("Эльф", 75, 15);
            mc_wn = new Weapon("Кинжал", 40);
            Form2 form2 = new Form2(mc, mc_wn);
            form2.ShowDialog();
        }

        private void ork_button_Click(object sender, EventArgs e)
        {
            mc = new Character("Орк", 125, 25);
            mc_wn = new Weapon("Бревно", 35);
            Form2 form2 = new Form2(mc, mc_wn);
            form2.ShowDialog();
        }
    }
}
