﻿namespace DateTimerPick
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
            this.dateTimePickerDatum = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerVrijeme = new System.Windows.Forms.DateTimePicker();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnRezervacija = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Upišite datum leta: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Upišite vrijeme polaska:";
            // 
            // dateTimePickerDatum
            // 
            this.dateTimePickerDatum.Location = new System.Drawing.Point(208, 40);
            this.dateTimePickerDatum.Name = "dateTimePickerDatum";
            this.dateTimePickerDatum.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDatum.TabIndex = 2;
            // 
            // dateTimePickerVrijeme
            // 
            this.dateTimePickerVrijeme.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerVrijeme.Location = new System.Drawing.Point(208, 74);
            this.dateTimePickerVrijeme.Name = "dateTimePickerVrijeme";
            this.dateTimePickerVrijeme.ShowUpDown = true;
            this.dateTimePickerVrijeme.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerVrijeme.TabIndex = 3;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(57, 115);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(351, 203);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // btnRezervacija
            // 
            this.btnRezervacija.Location = new System.Drawing.Point(193, 353);
            this.btnRezervacija.Name = "btnRezervacija";
            this.btnRezervacija.Size = new System.Drawing.Size(75, 23);
            this.btnRezervacija.TabIndex = 5;
            this.btnRezervacija.Text = "Rezerviraj";
            this.btnRezervacija.UseVisualStyleBackColor = true;
            this.btnRezervacija.Click += new System.EventHandler(this.btnRezervacija_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 431);
            this.Controls.Add(this.btnRezervacija);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dateTimePickerVrijeme);
            this.Controls.Add(this.dateTimePickerDatum);
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
        private System.Windows.Forms.DateTimePicker dateTimePickerDatum;
        private System.Windows.Forms.DateTimePicker dateTimePickerVrijeme;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnRezervacija;
    }
}

