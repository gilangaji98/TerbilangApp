namespace TerbilangAplikasi
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxHasil = new System.Windows.Forms.ListBox();
            this.textBoxAngka = new System.Windows.Forms.TextBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nominal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Terbilang";
            // 
            // listBoxHasil
            // 
            this.listBoxHasil.FormattingEnabled = true;
            this.listBoxHasil.Location = new System.Drawing.Point(85, 65);
            this.listBoxHasil.Name = "listBoxHasil";
            this.listBoxHasil.Size = new System.Drawing.Size(498, 95);
            this.listBoxHasil.TabIndex = 2;
            // 
            // textBoxAngka
            // 
            this.textBoxAngka.Location = new System.Drawing.Point(85, 21);
            this.textBoxAngka.Name = "textBoxAngka";
            this.textBoxAngka.Size = new System.Drawing.Size(100, 20);
            this.textBoxAngka.TabIndex = 3;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(204, 19);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(98, 23);
            this.Button1.TabIndex = 4;
            this.Button1.Text = "Cek Terbilang";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 183);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.textBoxAngka);
            this.Controls.Add(this.listBoxHasil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxHasil;
        private System.Windows.Forms.TextBox textBoxAngka;
        private System.Windows.Forms.Button Button1;
    }
}

