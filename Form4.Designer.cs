namespace Reviewer
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.chkbox = new System.Windows.Forms.CheckedListBox();
            this.but1 = new System.Windows.Forms.Button();
            this.but2 = new System.Windows.Forms.Button();
            this.but3 = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.but4 = new System.Windows.Forms.Button();
            this.lab1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.but5 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.delbut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkbox
            // 
            this.chkbox.FormattingEnabled = true;
            this.chkbox.HorizontalScrollbar = true;
            this.chkbox.Location = new System.Drawing.Point(44, 31);
            this.chkbox.Name = "chkbox";
            this.chkbox.Size = new System.Drawing.Size(556, 301);
            this.chkbox.TabIndex = 0;
            this.chkbox.SelectedIndexChanged += new System.EventHandler(this.chkbox_SelectedIndexChanged);
            // 
            // but1
            // 
            this.but1.Location = new System.Drawing.Point(44, 338);
            this.but1.Name = "but1";
            this.but1.Size = new System.Drawing.Size(112, 34);
            this.but1.TabIndex = 1;
            this.but1.Text = "Enable";
            this.but1.UseVisualStyleBackColor = true;
            this.but1.Click += new System.EventHandler(this.but1_Click);
            // 
            // but2
            // 
            this.but2.Location = new System.Drawing.Point(280, 338);
            this.but2.Name = "but2";
            this.but2.Size = new System.Drawing.Size(112, 34);
            this.but2.TabIndex = 2;
            this.but2.Text = "Disable";
            this.but2.UseVisualStyleBackColor = true;
            this.but2.Click += new System.EventHandler(this.but2_Click);
            // 
            // but3
            // 
            this.but3.Location = new System.Drawing.Point(162, 338);
            this.but3.Name = "but3";
            this.but3.Size = new System.Drawing.Size(112, 34);
            this.but3.TabIndex = 3;
            this.but3.Text = "Edit";
            this.but3.UseVisualStyleBackColor = true;
            this.but3.Click += new System.EventHandler(this.but3_Click);
            // 
            // openFile
            // 
            this.openFile.Filter = "文本文档|*.txt";
            // 
            // but4
            // 
            this.but4.Location = new System.Drawing.Point(629, 247);
            this.but4.Name = "but4";
            this.but4.Size = new System.Drawing.Size(159, 34);
            this.but4.TabIndex = 4;
            this.but4.Text = "Change Library";
            this.but4.UseVisualStyleBackColor = true;
            this.but4.Click += new System.EventHandler(this.but4_Click);
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lab1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lab1.Location = new System.Drawing.Point(221, 398);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(205, 24);
            this.lab1.TabIndex = 5;
            this.lab1.Text = "Modify was successful!";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // but5
            // 
            this.but5.Location = new System.Drawing.Point(629, 298);
            this.but5.Name = "but5";
            this.but5.Size = new System.Drawing.Size(159, 34);
            this.but5.TabIndex = 6;
            this.but5.Text = "Add Library";
            this.but5.UseVisualStyleBackColor = true;
            this.but5.Click += new System.EventHandler(this.but5_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Only Enabled",
            "Only Disabled",
            "Both"});
            this.comboBox1.Location = new System.Drawing.Point(606, 92);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 32);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(606, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Filter:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(629, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 34);
            this.button1.TabIndex = 9;
            this.button1.Text = "Backup Library";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // delbut
            // 
            this.delbut.ForeColor = System.Drawing.Color.Red;
            this.delbut.Location = new System.Drawing.Point(488, 338);
            this.delbut.Name = "delbut";
            this.delbut.Size = new System.Drawing.Size(112, 34);
            this.delbut.TabIndex = 10;
            this.delbut.Text = "Delete";
            this.delbut.UseVisualStyleBackColor = true;
            this.delbut.Click += new System.EventHandler(this.delbut_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delbut);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.but5);
            this.Controls.Add(this.lab1);
            this.Controls.Add(this.but4);
            this.Controls.Add(this.but3);
            this.Controls.Add(this.but2);
            this.Controls.Add(this.but1);
            this.Controls.Add(this.chkbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Interface";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckedListBox chkbox;
        private Button but1;
        private Button but2;
        private Button but3;
        private OpenFileDialog openFile;
        private Button but4;
        private Label lab1;
        private System.Windows.Forms.Timer timer1;
        private Button but5;
        private ComboBox comboBox1;
        private Label label1;
        private Button button1;
        private Button delbut;
    }
}