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
            this.zpatky = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // zpatky
            // 
            this.zpatky.Location = new System.Drawing.Point(713, 415);
            this.zpatky.Name = "zpatky";
            this.zpatky.Size = new System.Drawing.Size(75, 23);
            this.zpatky.TabIndex = 1;
            this.zpatky.Text = "Zpět";
            this.zpatky.UseVisualStyleBackColor = true;
            this.zpatky.Click += new System.EventHandler(this.zpatky_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.zpatky);
            this.Name = "Form3";
            this.Text = "Form3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button zpatky;
    }
}