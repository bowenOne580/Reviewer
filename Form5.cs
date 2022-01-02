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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vars.dir[1] = AppDomain.CurrentDomain.BaseDirectory+textBox1.Text+".txt";
            string path = Vars.dir[1];
            FileStream fs = System.IO.File.Create(path);
            fs.Close();
            fs.Dispose();
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            StreamWriter output = new StreamWriter(path, true, System.Text.Encoding.GetEncoding("gb2312"));
            string num = "0";
            output.WriteLine(num);
            Vars.updlib();
            this.Close();
        }
    }
}
