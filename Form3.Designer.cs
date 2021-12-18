namespace Reviewer
{
    partial class Form3
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
            this.anslab = new System.Windows.Forms.Label();
            this.dislab = new System.Windows.Forms.Label();
            this.ansbox = new System.Windows.Forms.TextBox();
            this.desbox = new System.Windows.Forms.TextBox();
            this.qui = new System.Windows.Forms.Button();
            this.confir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // anslab
            // 
            this.anslab.AutoSize = true;
            this.anslab.Location = new System.Drawing.Point(12, 202);
            this.anslab.Name = "anslab";
            this.anslab.Size = new System.Drawing.Size(73, 24);
            this.anslab.TabIndex = 0;
            this.anslab.Text = "Answer";
            // 
            // dislab
            // 
            this.dislab.AutoSize = true;
            this.dislab.Location = new System.Drawing.Point(12, 131);
            this.dislab.Name = "dislab";
            this.dislab.Size = new System.Drawing.Size(88, 24);
            this.dislab.TabIndex = 1;
            this.dislab.Text = "Question";
            // 
            // ansbox
            // 
            this.ansbox.Location = new System.Drawing.Point(106, 196);
            this.ansbox.Name = "ansbox";
            this.ansbox.Size = new System.Drawing.Size(653, 30);
            this.ansbox.TabIndex = 2;
            // 
            // desbox
            // 
            this.desbox.Location = new System.Drawing.Point(106, 131);
            this.desbox.Name = "desbox";
            this.desbox.Size = new System.Drawing.Size(653, 30);
            this.desbox.TabIndex = 3;
            // 
            // qui
            // 
            this.qui.Location = new System.Drawing.Point(224, 308);
            this.qui.Name = "qui";
            this.qui.Size = new System.Drawing.Size(112, 34);
            this.qui.TabIndex = 4;
            this.qui.Text = "Quit";
            this.qui.UseVisualStyleBackColor = true;
            this.qui.Click += new System.EventHandler(this.qui_Click);
            // 
            // confir
            // 
            this.confir.Location = new System.Drawing.Point(399, 308);
            this.confir.Name = "confir";
            this.confir.Size = new System.Drawing.Size(112, 34);
            this.confir.TabIndex = 5;
            this.confir.Text = "Confirm";
            this.confir.UseVisualStyleBackColor = true;
            this.confir.Click += new System.EventHandler(this.confir_Click);
            // 
            // Form3
            // 
            this.AcceptButton = this.confir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.confir);
            this.Controls.Add(this.qui);
            this.Controls.Add(this.desbox);
            this.Controls.Add(this.ansbox);
            this.Controls.Add(this.dislab);
            this.Controls.Add(this.anslab);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label anslab;
        private Label dislab;
        private TextBox ansbox;
        private TextBox desbox;
        private Button qui;
        private Button confir;
    }
}