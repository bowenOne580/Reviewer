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
				showpro();
				return;
			}
			Vars.num++;
			des.Text = Vars.disc[Vars.pos[Vars.now]];
			des.Show();
			inpbox.Show();
			conti.Text = "Check";
			conti.Show();
			if (Vars.now == Vars.tot + 1)
            {
				revbut.Show();
				impbut.Show();
				manbut.Show();
				abtbut.Show();
				wel.Show();
			}
		}

        private void impbut_Click(object sender, EventArgs e)
        {
            Vars.readVars();
			Form3 form3 = new Form3();
			form3.Show();
		}

        int coun = 0;
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
					else des.Text = "Grade:"+(double)Vars.cor/Vars.num*100;
					coun++;
					return;
				}
				if (Vars.now == Vars.tot + 2)
                {
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
				showpro();
				conti.Text = "Check";
			}
        }

        private void abtbut_Click(object sender, EventArgs e)
        {
			Form2 form = new Form2();
			form.ShowDialog();
        }

		private void button1_Click(object sender, EventArgs e)
        {
			Vars.readVars();
			revbut.Hide();
			impbut.Hide();
			manbut.Hide();
			abtbut.Hide();
			wel.Hide();
			Vars.cor = Vars.num = 0;
			for (int i = 1; i <= Vars.tot; i++) Vars.vis[i] = 0;
			int sed = Guid.NewGuid().GetHashCode();
			Random rand = new Random(sed);
			for (int i = 1;i <= Vars.tot; i++)
            {
				int rd = rand.Next(1,10000);
				rd %= Vars.tot;
				rd++;
				while (Vars.vis[rd] == 1) rd++;
				if (rd == Vars.tot + 1) rd = 1;
				while (Vars.vis[rd] == 1) rd++;
				Vars.pos[i] = rd;
				Vars.vis[rd] = 1;
            }
			Vars.now = 1;
			if (Vars.tot == 0)
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
			inpbox.Text = "";
			while (Vars.dead[Vars.pos[Vars.now]] == 1) Vars.now++;
			showpro();
		}

    }
    public class Vars
	{
		public static int tot = 0, now = 0, cor = 0, num = 0;
		public static int[] pos = new int[2021], dead = new int[2021], vis = new int[2021];
		public static string[] disc = new string[2021], ans = new string[2021];
		public static void readVars()
		{
			string path = AppDomain.CurrentDomain.BaseDirectory + "library.txt";
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
		public static void writeVars()
		{
			string path = AppDomain.CurrentDomain.BaseDirectory + "library.txt";
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