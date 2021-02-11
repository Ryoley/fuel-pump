using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pompe_a_essence
{
    public partial class Ecran : Form
    {
        Interactions maVariable = new Interactions();

        public static string textDisplayButton = "";

        private void maVariable_clickBtn(string param1)
        {
            textDisplayButton = param1;
            if (param1 == "Insérer votre carte bancaire") {
                panelInsererCarte.Visible = false;
                panelCodeCarte.Visible = true;
            }
        }

        public Ecran()
        {
            InitializeComponent();
            Interactions ecransSimultanes = new Interactions();
            ecransSimultanes.Show();
            maVariable.clickBtn += maVariable_clickBtn;
            panelCodeCarte.Visible = false;
        }

        private void Ecran_Load(object sender, EventArgs e)
        {
            
        }

        private void labelInsererCarte_Click(object sender, EventArgs e)
        {

        }

        private void panelInsererCarte_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelCodeCarte_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void button0_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {

        }

        private void buttonValider_Click(object sender, EventArgs e)
        {

        }
    }
}
