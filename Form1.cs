namespace Reviewer
{
    public partial class Reviewer : Form
    {
        public Reviewer()
        {
            InitializeComponent();
        }
        public void showpro()
        {
            if (Vars.dead[Vars.pos[Vars.now]] == 1)
            {
                Vars.now++;
                if (Vars.now == Vars.tot + 1)
                {
                    progressBar1.Value = 100;
                    ifcor.Hide();
                    inpbox.Hide();
                    conti.Text = "Finish";
                    if (Vars.num == 0) des.Text = "There is nothing in your library now, add some!";
                    else des.Text = "Grade:" + (double)Vars.cor / Vars.num * 100;
                    coun = 5;
                    return;
                }
                showpro();
                return;
            }
            Vars.num++;
            des.Text = Vars.disc[Vars.pos[Vars.now]];
            des.Show();
            inpbox.Show();
            conti.Text = "Check";
            conti.Show();
        }

        private void impbut_Click(object sender, EventArgs e)
        {
            Vars.getlib();
            Vars.readVars();
            Form3 form3 = new Form3();
            form3.Show();
        }

        int coun = 0,totc = 0;
        private void conti_Click(object sender, EventArgs e)
        {
            coun++;
            if (coun % 2 == 1)
            {
                if (inpbox.Text == Vars.ans[Vars.pos[Vars.now]])
                {
                    ifcor.Text = "Correct!";
                    Vars.cor++;
                }
                else ifcor.Text = "Please check it yourself, the order may not be the same as the answer\nAnswer: " + Vars.ans[Vars.pos[Vars.now]];
                ifcor.Show();
                conti.Text = "Continue";
                progressBar1.PerformStep();
            }
            else
            {
                Vars.now++;
                if (Vars.now == Vars.tot + 1)
                {
                    ifcor.Hide();
                    inpbox.Hide();
                    conti.Text = "Finish";
                    if (Vars.num == 0) des.Text = "There is nothing in your library now, add some!";
                    else des.Text = "Grade:" + (double)Vars.cor / Vars.num * 100;
                    coun++;
                    return;
                }
                if (Vars.now == Vars.tot + 2)
                {
                    progressBar1.Hide();
                    button1.Hide();
                    conti.Hide();
                    des.Hide();
                    revbut.Show();
                    impbut.Show();
                    manbut.Show();
                    abtbut.Show();
                    wel.Show();
                    return;
                }
                inpbox.Text = "";
                ifcor.Hide();
                conti.Text = "Check";
                showpro();
            }
        }

        private void abtbut_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            totc = 0;
            progressBar1.Value = 0;
            progressBar1.Show();
            coun = 0;
            Vars.getlib();
            Vars.readVars();
            revbut.Hide();
            impbut.Hide();
            manbut.Hide();
            abtbut.Hide();
            wel.Hide();
            Vars.cor = Vars.num = 0;
            for (int i = 1; i <= Vars.tot; i++) Vars.vis[i] = 0;
            int sed = Guid.NewGuid().GetHashCode(), flag = 0;
            Random rand = new Random(sed);
            for (int i = 1; i <= Vars.tot; i++)
            {
                if (Vars.dead[i] == 0)
                {
                    flag = 1;
                    totc++;
                }
                int rd = rand.Next(1, 10000);
                rd %= Vars.tot;
                rd++;
                while (Vars.vis[rd] == 1) rd++;
                if (rd == Vars.tot + 1) rd = 1;
                while (Vars.vis[rd] == 1) rd++;
                Vars.pos[i] = rd;
                Vars.vis[rd] = 1;
            }
            int tmp = totc*10;
            progressBar1.Maximum = tmp;
            Vars.now = 1;
            if (Vars.tot == 0 || flag == 0)
            {
                MessageBox.Show("There are nothing in your library now, please add something into it");
                conti.Hide();
                des.Hide();
                revbut.Show();
                impbut.Show();
                manbut.Show();
                abtbut.Show();
                wel.Show();
                return;
            }
            button1.Show();
            inpbox.Text = "";
            showpro();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            inpbox.Hide();
            progressBar1.Hide();
            conti.Hide();
            des.Hide();
            button1.Hide();
            revbut.Show();
            impbut.Show();
            manbut.Show();
            abtbut.Show();
            wel.Show();
        }

        private void manbut_Click(object sender, EventArgs e)
        {
            Vars.readVars();
            Form4 form4 = new Form4();
            form4.Show();
        }
    }
    public class Vars
    {
        public static int tot = 0, now = 0, cor = 0, num = 0,id = 0;
        public static int[] pos = new int[2021], dead = new int[2021], vis = new int[2021],keyto = new int[2021];
        public static string[] disc = new string[2021], ans = new string[2021],dir = new string[2];
        public static void getlib()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "lib.name";
            if (!File.Exists(path)) return;
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            StreamReader input = new StreamReader(path, System.Text.Encoding.GetEncoding("gb2312"));
            string line;
            line = input.ReadLine();
            dir[1] = line;
            input.Close();
            return;
        }
        public static void updlib()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "lib.name";
            FileStream fs = System.IO.File.Create(path);
            fs.Close();
            fs.Dispose();
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            StreamWriter output = new StreamWriter(path, true, System.Text.Encoding.GetEncoding("gb2312"));
            output.WriteLine(dir[1]);
            output.Close();
        }
        public static void readVars()
        {
            string path = dir[1];
            if (!File.Exists(path)) return;
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            StreamReader input = new StreamReader(path, System.Text.Encoding.GetEncoding("gb2312"));
            string line;
            line = input.ReadLine();
            Vars.tot = Convert.ToInt32(line);
            for (int i = 1; i <= Vars.tot; i++)
            {
                Vars.disc[i] = input.ReadLine();
                Vars.ans[i] = input.ReadLine();
            }
            for (int i = 1; i <= Vars.tot; i++)
            {
                line = input.ReadLine();
                if (line == "0") Vars.dead[i] = 0;
                else Vars.dead[i] = 1;
            }
            input.Close();
            return;
        }
        public static void backup()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "backup.txt";
            FileStream fs = System.IO.File.Create(path);
            fs.Close();
            fs.Dispose();
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            StreamWriter output = new StreamWriter(path, true, System.Text.Encoding.GetEncoding("gb2312"));
            string num = Vars.tot + "";
            output.WriteLine(num);
            for (int i = 1; i <= Vars.tot; i++)
            {
                output.WriteLine(Vars.disc[i]);
                output.WriteLine(Vars.ans[i]);
            }
            for (int i = 1; i <= Vars.tot; i++)
            {
                output.WriteLine(Vars.dead[i]);
            }
            output.Close();
        }
        public static void writeVars()
        {
            if (dir[1] == null) dir[1] = AppDomain.CurrentDomain.BaseDirectory+"library.txt";
            string path = dir[1];
            FileStream fs = System.IO.File.Create(path);
            fs.Close();
            fs.Dispose();
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            StreamWriter output = new StreamWriter(path, true, System.Text.Encoding.GetEncoding("gb2312"));
            string num = Vars.tot + "";
            output.WriteLine(num);
            for (int i = 1; i <= Vars.tot; i++)
            {
                output.WriteLine(Vars.disc[i]);
                output.WriteLine(Vars.ans[i]);
            }
            for (int i = 1; i <= Vars.tot; i++)
            {
                output.WriteLine(Vars.dead[i]);
            }
            output.Close();
            return;
        }
    }
}