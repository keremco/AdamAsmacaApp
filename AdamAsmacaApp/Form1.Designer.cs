﻿namespace AdamAsmacaApp
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
            label1 = new Label();
            tbKelime = new TextBox();
            label2 = new Label();
            tbHarf = new TextBox();
            lBilgi = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Kelime";
            // 
            // tbKelime
            // 
            tbKelime.Location = new Point(61, 6);
            tbKelime.Name = "tbKelime";
            tbKelime.ReadOnly = true;
            tbKelime.Size = new Size(221, 23);
            tbKelime.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 41);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 0;
            label2.Text = "Harf";
            // 
            // tbHarf
            // 
            tbHarf.Location = new Point(61, 35);
            tbHarf.MaxLength = 1;
            tbHarf.Name = "tbHarf";
            tbHarf.Size = new Size(221, 23);
            tbHarf.TabIndex = 1;
            tbHarf.TextChanged += tbHarf_TextChanged;
            // 
            // lBilgi
            // 
            lBilgi.AutoSize = true;
            lBilgi.Location = new Point(12, 77);
            lBilgi.Name = "lBilgi";
            lBilgi.Size = new Size(33, 15);
            lBilgi.TabIndex = 0;
            lBilgi.Text = "lBilgi";
            lBilgi.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbHarf);
            Controls.Add(tbKelime);
            Controls.Add(lBilgi);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Adam Asmaca";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbKelime;
        private Label label2;
        private TextBox tbHarf;
        private Label lBilgi;
    }
}