﻿namespace FilediTesto
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCreaDirectory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 190);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(690, 47);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(319, 58);
            this.button1.TabIndex = 1;
            this.button1.Text = "Scrivi testo su file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(476, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(319, 58);
            this.button2.TabIndex = 2;
            this.button2.Text = "Leggi file di testo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCreaDirectory
            // 
            this.btnCreaDirectory.Location = new System.Drawing.Point(293, 301);
            this.btnCreaDirectory.Name = "btnCreaDirectory";
            this.btnCreaDirectory.Size = new System.Drawing.Size(297, 58);
            this.btnCreaDirectory.TabIndex = 3;
            this.btnCreaDirectory.Text = "crea Directory";
            this.btnCreaDirectory.UseVisualStyleBackColor = true;
            this.btnCreaDirectory.Click += new System.EventHandler(this.btnCreaDirectory_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 450);
            this.Controls.Add(this.btnCreaDirectory);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button btnCreaDirectory;
    }
}