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
            Vars.updlib();
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
