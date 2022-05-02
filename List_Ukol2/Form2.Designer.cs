namespace List_Ukol2
{
    partial class Form2
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
            this.zpatky = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_N = new System.Windows.Forms.TextBox();
            this.textBox_A1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_D = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.vytvorit = new System.Windows.Forms.Button();
            this.listBox_cisla = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pridat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // zpatky
            // 
            this.zpatky.Location = new System.Drawing.Point(298, 90);
            this.zpatky.Name = "zpatky";
            this.zpatky.Size = new System.Drawing.Size(75, 23);
            this.zpatky.TabIndex = 0;
            this.zpatky.Text = "Zpět";
            this.zpatky.UseVisualStyleBackColor = true;
            this.zpatky.Click += new System.EventHandler(this.zpatky_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Zadej N:";
            // 
            // textBox_N
            // 
            this.textBox_N.Location = new System.Drawing.Point(66, 12);
            this.textBox_N.Name = "textBox_N";
            this.textBox_N.Size = new System.Drawing.Size(100, 20);
            this.textBox_N.TabIndex = 2;
            // 
            // textBox_A1
            // 
            this.textBox_A1.Location = new System.Drawing.Point(66, 38);
            this.textBox_A1.Name = "textBox_A1";
            this.textBox_A1.Size = new System.Drawing.Size(100, 20);
            this.textBox_A1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Zadej A1:";
            // 
            // textBox_D
            // 
            this.textBox_D.Location = new System.Drawing.Point(66, 64);
            this.textBox_D.Name = "textBox_D";
            this.textBox_D.Size = new System.Drawing.Size(100, 20);
            this.textBox_D.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Zadej D:";
            // 
            // vytvorit
            // 
            this.vytvorit.Location = new System.Drawing.Point(91, 90);
            this.vytvorit.Name = "vytvorit";
            this.vytvorit.Size = new System.Drawing.Size(75, 23);
            this.vytvorit.TabIndex = 7;
            this.vytvorit.Text = "Vytvořit";
            this.vytvorit.UseVisualStyleBackColor = true;
            this.vytvorit.Click += new System.EventHandler(this.vytvorit_Click);
            // 
            // listBox_cisla
            // 
            this.listBox_cisla.FormattingEnabled = true;
            this.listBox_cisla.Location = new System.Drawing.Point(172, 38);
            this.listBox_cisla.Name = "listBox_cisla";
            this.listBox_cisla.Size = new System.Drawing.Size(120, 69);
            this.listBox_cisla.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(223, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(69, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Přidat N:";
            this.label4.Visible = false;
            // 
            // pridat
            // 
            this.pridat.Location = new System.Drawing.Point(298, 10);
            this.pridat.Name = "pridat";
            this.pridat.Size = new System.Drawing.Size(75, 23);
            this.pridat.TabIndex = 11;
            this.pridat.Text = "Přidat";
            this.pridat.UseVisualStyleBackColor = true;
            this.pridat.Visible = false;
            this.pridat.Click += new System.EventHandler(this.pridat_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 123);
            this.Controls.Add(this.pridat);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox_cisla);
            this.Controls.Add(this.vytvorit);
            this.Controls.Add(this.textBox_D);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_A1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_N);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zpatky);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button zpatky;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_N;
        private System.Windows.Forms.TextBox textBox_A1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_D;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button vytvorit;
        private System.Windows.Forms.ListBox listBox_cisla;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button pridat;
    }
}