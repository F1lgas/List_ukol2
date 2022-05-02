namespace List_Ukol2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.listBox_cisla = new System.Windows.Forms.ListBox();
            this.vytvorit = new System.Windows.Forms.Button();
            this.textBox_A2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_A1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_N = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.secist = new System.Windows.Forms.Button();
            this.textBox_P = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox_cisla
            // 
            this.listBox_cisla.FormattingEnabled = true;
            this.listBox_cisla.Location = new System.Drawing.Point(175, 41);
            this.listBox_cisla.Name = "listBox_cisla";
            this.listBox_cisla.Size = new System.Drawing.Size(120, 69);
            this.listBox_cisla.TabIndex = 20;
            // 
            // vytvorit
            // 
            this.vytvorit.Location = new System.Drawing.Point(94, 90);
            this.vytvorit.Name = "vytvorit";
            this.vytvorit.Size = new System.Drawing.Size(75, 23);
            this.vytvorit.TabIndex = 19;
            this.vytvorit.Text = "Vytvořit";
            this.vytvorit.UseVisualStyleBackColor = true;
            this.vytvorit.Click += new System.EventHandler(this.vytvorit_Click_1);
            // 
            // textBox_A2
            // 
            this.textBox_A2.Location = new System.Drawing.Point(69, 64);
            this.textBox_A2.Name = "textBox_A2";
            this.textBox_A2.Size = new System.Drawing.Size(100, 20);
            this.textBox_A2.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Zadej A2:";
            // 
            // textBox_A1
            // 
            this.textBox_A1.Location = new System.Drawing.Point(69, 38);
            this.textBox_A1.Name = "textBox_A1";
            this.textBox_A1.Size = new System.Drawing.Size(100, 20);
            this.textBox_A1.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Zadej A1:";
            // 
            // textBox_N
            // 
            this.textBox_N.Location = new System.Drawing.Point(69, 12);
            this.textBox_N.Name = "textBox_N";
            this.textBox_N.Size = new System.Drawing.Size(100, 20);
            this.textBox_N.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Zadej N:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(301, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Zpět";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // secist
            // 
            this.secist.Location = new System.Drawing.Point(301, 12);
            this.secist.Name = "secist";
            this.secist.Size = new System.Drawing.Size(75, 23);
            this.secist.TabIndex = 23;
            this.secist.Text = "Sečíst";
            this.secist.UseVisualStyleBackColor = true;
            this.secist.Visible = false;
            this.secist.Click += new System.EventHandler(this.pridat_Click);
            // 
            // textBox_P
            // 
            this.textBox_P.Location = new System.Drawing.Point(226, 14);
            this.textBox_P.Name = "textBox_P";
            this.textBox_P.Size = new System.Drawing.Size(69, 20);
            this.textBox_P.TabIndex = 22;
            this.textBox_P.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Zadej P:";
            this.label4.Visible = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 122);
            this.Controls.Add(this.secist);
            this.Controls.Add(this.textBox_P);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox_cisla);
            this.Controls.Add(this.vytvorit);
            this.Controls.Add(this.textBox_A2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_A1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_N);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.Text = "Úkol 2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox_cisla;
        private System.Windows.Forms.Button vytvorit;
        private System.Windows.Forms.TextBox textBox_A2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_A1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_N;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button secist;
        private System.Windows.Forms.TextBox textBox_P;
        private System.Windows.Forms.Label label4;
    }
}