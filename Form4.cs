namespace Reviewer
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            chkbox.CheckOnClick = true;
            lab1.Hide();
        }
        public void init(int mode)
        {
            while (chkbox.Items.Count > 0) chkbox.Items.RemoveAt(chkbox.Items.Count - 1);
            Vars.getlib();
            Vars.readVars();
            int count = -1;
            for (int i = 1; i <= Vars.tot; i++)
            {
                string text;
                if (Vars.dead[i] == 1 && mode != 0)
                {
                    text = Vars.disc[i];
                    if (mode == 2) text = text + "  (Disabled)";
                    chkbox.Items.Add(text);
                    Vars.keyto[++count] = i;
                }
                else if (Vars.dead[i] == 0 && mode != 1)
                {
                    text = Vars.disc[i];
                    if (mode == 2) text = text + "  (Enabled)";
                    chkbox.Items.Add(text);
                    Vars.keyto[++count] = i;
                }
            }
            but3.Hide();
        }

        private void but1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chkbox.Items.Count; i++) if (chkbox.GetItemChecked(i)) Vars.dead[Vars.keyto[i]] = 0;
            lab1.Text = "Modify was successful!";
            lab1.Show();
            timer1.Stop();
            timer1.Interval = 1500;
            timer1.Start();
            Vars.writeVars();
            init(comboBox1.SelectedIndex);
        }

        private void but2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chkbox.Items.Count; i++) if (chkbox.GetItemChecked(i)) Vars.dead[Vars.keyto[i]] = 1;
            lab1.Text = "Modify was successful!";
            lab1.Show();
            timer1.Stop();
            timer1.Interval = 1500;
            timer1.Start();
            Vars.writeVars();
            init(comboBox1.SelectedIndex);
        }
        private int cnt;
        private void chkbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cnt = 0;
            for (int i = 0; i < chkbox.Items.Count; i++) if (chkbox.GetItemChecked(i)) cnt++;
            if (cnt == 1) but3.Show();
            else but3.Hide();
        }

        private void but3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chkbox.Items.Count; i++) if (chkbox.GetItemChecked(i)) Vars.id = Vars.keyto[i];
            Form6 form6 = new Form6();
            form6.ShowDialog();
            init(comboBox1.SelectedIndex);
        }

        private void but4_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFile.ShowDialog();
            string filename = openFile.FileName;
            if (dr == System.Windows.Forms.DialogResult.OK && !string.IsNullOrEmpty(filename)) Vars.dir[1] = filename;
            Vars.readVars();
            Vars.updlib();
            init(comboBox1.SelectedIndex);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lab1.Hide();
            timer1.Stop();
        }

        private void but5_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog();
            init(comboBox1.SelectedIndex);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            init(comboBox1.SelectedIndex);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vars.backup();
            lab1.Text = "Backup Completed!";
            lab1.Show();
            timer1.Stop();
            timer1.Interval = 1500;
            timer1.Start();
        }
        private int tmptot = 0;
        private int[] tmpdead = new int[2021],del = new int[2021];
        private string[] tmpdisc = new string[2021], tmpans = new string[2021];
        private void delbut_Click(object sender, EventArgs e)
        {
            if (cnt == 0)
            {
                MessageBox.Show("No item is selected!");
                return;
            }
            DialogResult dr;
            if (cnt == 1) dr = MessageBox.Show("Do you still want to delete this item?","Warning",MessageBoxButtons.YesNo);
            else dr = MessageBox.Show("Do you still want to delete these items?","Warning",MessageBoxButtons.YesNo);
            if (dr == DialogResult.No) return;
            tmptot = 0;
            for (int i = 1; i <= 2000; i++)
            {
                tmpdead[i] = 0;
                tmpdisc[i] = "";
                tmpans[i] = "";
                del[i] = 0;
            }
            for (int i = 0; i < chkbox.Items.Count; i++)
            {
                if (chkbox.GetItemChecked(i))
                {
                    del[Vars.keyto[i]] = 1;
                }
            }
            for (int i = 1; i <= Vars.tot; i++)
            {
                if (del[i] == 0)
                {
                    tmptot++;
                    tmpdisc[tmptot] = Vars.disc[i];
                    tmpans[tmptot] = Vars.ans[i];
                    tmpdead[tmptot] = Vars.dead[i];
                }
            }
            for (int i = 1; i <= tmptot; i++)
            {
                Vars.disc[i] = tmpdisc[i];
                Vars.ans[i] = tmpans[i];
                Vars.dead[i] = tmpdead[i];
            }
            Vars.tot = tmptot;
            Vars.writeVars();
            init(comboBox1.SelectedIndex);
        }
    }
}
