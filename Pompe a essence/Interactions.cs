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
    public partial class Interactions : Form
    {
        public Interactions()
        {
            InitializeComponent();
        }

        public delegate void DelegateClickBtn(string touche);
        public event DelegateClickBtn clickBtn;

        private void Interactions_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (clickBtn != null)
            {
                clickBtn(((Button)sender).Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
