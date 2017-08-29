namespace RomanNumeralsConverter
{
    partial class RomanToInteger
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
            this.buttonRomanToInteger = new System.Windows.Forms.Button();
            this.textBoxInteger = new System.Windows.Forms.TextBox();
            this.textBoxRoman = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonRomanToInteger
            // 
            this.buttonRomanToInteger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonRomanToInteger.Location = new System.Drawing.Point(169, 79);
            this.buttonRomanToInteger.Name = "buttonRomanToInteger";
            this.buttonRomanToInteger.Size = new System.Drawing.Size(178, 29);
            this.buttonRomanToInteger.TabIndex = 9;
            this.buttonRomanToInteger.Text = "ÇEVİR";
            this.buttonRomanToInteger.UseVisualStyleBackColor = true;
            this.buttonRomanToInteger.Click += new System.EventHandler(this.buttonRomanToInteger_Click);
            // 
            // textBoxInteger
            // 
            this.textBoxInteger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxInteger.Location = new System.Drawing.Point(169, 128);
            this.textBoxInteger.Name = "textBoxInteger";
            this.textBoxInteger.ReadOnly = true;
            this.textBoxInteger.Size = new System.Drawing.Size(178, 26);
            this.textBoxInteger.TabIndex = 8;
            // 
            // textBoxRoman
            // 
            this.textBoxRoman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxRoman.Location = new System.Drawing.Point(169, 28);
            this.textBoxRoman.MaxLength = 15;
            this.textBoxRoman.Name = "textBoxRoman";
            this.textBoxRoman.Size = new System.Drawing.Size(178, 26);
            this.textBoxRoman.TabIndex = 7;
            this.textBoxRoman.TextChanged += new System.EventHandler(this.textBoxRoman_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(32, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "ROMA RAKAMI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(32, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "TAM SAYI";
            // 
            // RomanToInteger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 188);
            this.Controls.Add(this.buttonRomanToInteger);
            this.Controls.Add(this.textBoxInteger);
            this.Controls.Add(this.textBoxRoman);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "RomanToInteger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TAM SAYIYA ÇEVİR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRomanToInteger;
        private System.Windows.Forms.TextBox textBoxInteger;
        private System.Windows.Forms.TextBox textBoxRoman;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}