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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            textBox1.Text = Vars.disc[Vars.id];
            textBox2.Text = Vars.ans[Vars.id];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vars.disc[Vars.id] = textBox1.Text;
            Vars.ans[Vars.id] = textBox2.Text;
            Vars.writeVars();
            Vars.updlib();
            this.Close();
        }
    }
}
