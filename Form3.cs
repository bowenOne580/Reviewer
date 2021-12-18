using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reviewer
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void qui_Click(object sender, EventArgs e)
        {
            Vars.writeVars();
            this.Close();
        }

        private void confir_Click(object sender, EventArgs e)
        {
            Vars.disc[++Vars.tot] = desbox.Text;
            Vars.ans[Vars.tot] = ansbox.Text;
            desbox.Text = "";
            ansbox.Text = "";
        }
    }
}
