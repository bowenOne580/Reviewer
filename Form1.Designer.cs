namespace Reviewer
{
    partial class Reviewer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reviewer));
            this.wel = new System.Windows.Forms.Label();
            this.revbut = new System.Windows.Forms.Button();
            this.impbut = new System.Windows.Forms.Button();
            this.manbut = new System.Windows.Forms.Button();
            this.abtbut = new System.Windows.Forms.Button();
            this.des = new System.Windows.Forms.Label();
            this.inpbox = new System.Windows.Forms.TextBox();
            this.conti = new System.Windows.Forms.Button();
            this.ifcor = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wel
            // 
            this.wel.AutoSize = true;
            this.wel.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.wel.Location = new System.Drawing.Point(323, 68);
            this.wel.Name = "wel";
            this.wel.Size = new System.Drawing.Size(140, 35);
            this.wel.TabIndex = 0;
            this.wel.Text = "Welcome!";
            // 
            // revbut
            // 
            this.revbut.Location = new System.Drawing.Point(335, 157);
            this.revbut.Name = "revbut";
            this.revbut.Size = new System.Drawing.Size(112, 34);
            this.revbut.TabIndex = 1;
            this.revbut.Text = "Review";
            this.revbut.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.revbut.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.revbut.UseVisualStyleBackColor = true;
            this.revbut.Click += new System.EventHandler(this.button1_Click);
            // 
            // impbut
            // 
            this.impbut.Location = new System.Drawing.Point(335, 197);
            this.impbut.Name = "impbut";
            this.impbut.Size = new System.Drawing.Size(112, 34);
            this.impbut.TabIndex = 2;
            this.impbut.Text = "Import";
            this.impbut.UseVisualStyleBackColor = true;
            this.impbut.Click += new System.EventHandler(this.impbut_Click);
            // 
            // manbut
            // 
            this.manbut.Location = new System.Drawing.Point(335, 237);
            this.manbut.Name = "manbut";
            this.manbut.Size = new System.Drawing.Size(112, 34);
            this.manbut.TabIndex = 3;
            this.manbut.Text = "Manage";
            this.manbut.UseVisualStyleBackColor = true;
            this.manbut.Click += new System.EventHandler(this.manbut_Click);
            // 
            // abtbut
            // 
            this.abtbut.Location = new System.Drawing.Point(335, 277);
            this.abtbut.Name = "abtbut";
            this.abtbut.Size = new System.Drawing.Size(112, 34);
            this.abtbut.TabIndex = 4;
            this.abtbut.Text = "About";
            this.abtbut.UseVisualStyleBackColor = true;
            this.abtbut.Click += new System.EventHandler(this.abtbut_Click);
            // 
            // des
            // 
            this.des.Location = new System.Drawing.Point(50, 28);
            this.des.Name = "des";
            this.des.Size = new System.Drawing.Size(695, 140);
            this.des.TabIndex = 5;
            this.des.Text = "label1";
            this.des.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.des.Visible = false;
            // 
            // inpbox
            // 
            this.inpbox.Location = new System.Drawing.Point(153, 171);
            this.inpbox.Name = "inpbox";
            this.inpbox.Size = new System.Drawing.Size(500, 30);
            this.inpbox.TabIndex = 6;
            this.inpbox.Visible = false;
            // 
            // conti
            // 
            this.conti.Location = new System.Drawing.Point(335, 336);
            this.conti.Name = "conti";
            this.conti.Size = new System.Drawing.Size(112, 34);
            this.conti.TabIndex = 7;
            this.conti.Text = "Check";
            this.conti.UseVisualStyleBackColor = true;
            this.conti.Visible = false;
            this.conti.Click += new System.EventHandler(this.conti_Click);
            // 
            // ifcor
            // 
            this.ifcor.Location = new System.Drawing.Point(12, 224);
            this.ifcor.Name = "ifcor";
            this.ifcor.Size = new System.Drawing.Size(776, 100);
            this.ifcor.TabIndex = 8;
            this.ifcor.Text = "label1";
            this.ifcor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ifcor.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(208, 401);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(364, 25);
            this.progressBar1.TabIndex = 9;
            this.progressBar1.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 60);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Reviewer
            // 
            this.AcceptButton = this.conti;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.conti);
            this.Controls.Add(this.inpbox);
            this.Controls.Add(this.des);
            this.Controls.Add(this.abtbut);
            this.Controls.Add(this.manbut);
            this.Controls.Add(this.impbut);
            this.Controls.Add(this.revbut);
            this.Controls.Add(this.wel);
            this.Controls.Add(this.ifcor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reviewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reviewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label wel;
        private Button revbut;
        private Button impbut;
        private Button manbut;
        private Button abtbut;
        private Label des;
        private TextBox inpbox;
        private Button conti;
        private Label ifcor;
        private ProgressBar progressBar1;
        private Button button1;
    }
}