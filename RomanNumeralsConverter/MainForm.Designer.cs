namespace RomanNumeralsConverter
{
    partial class MainForm
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
            this.buttonIntegerToRoman = new System.Windows.Forms.Button();
            this.buttonRomanToInteger = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonIntegerToRoman
            // 
            this.buttonIntegerToRoman.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonIntegerToRoman.Location = new System.Drawing.Point(78, 66);
            this.buttonIntegerToRoman.Name = "buttonIntegerToRoman";
            this.buttonIntegerToRoman.Size = new System.Drawing.Size(283, 39);
            this.buttonIntegerToRoman.TabIndex = 0;
            this.buttonIntegerToRoman.Text = "TAM SAYIYI ROMA RAKAMINA ÇEVİR";
            this.buttonIntegerToRoman.UseVisualStyleBackColor = true;
            this.buttonIntegerToRoman.Click += new System.EventHandler(this.buttonIntegerToRoman_Click);
            // 
            // buttonRomanToInteger
            // 
            this.buttonRomanToInteger.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonRomanToInteger.Location = new System.Drawing.Point(78, 131);
            this.buttonRomanToInteger.Name = "buttonRomanToInteger";
            this.buttonRomanToInteger.Size = new System.Drawing.Size(283, 37);
            this.buttonRomanToInteger.TabIndex = 1;
            this.buttonRomanToInteger.Text = "ROMA RAKAMINI TAM SAYIYA ÇEVİR";
            this.buttonRomanToInteger.UseVisualStyleBackColor = true;
            this.buttonRomanToInteger.Click += new System.EventHandler(this.buttonRomanToInteger_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 234);
            this.Controls.Add(this.buttonRomanToInteger);
            this.Controls.Add(this.buttonIntegerToRoman);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ROMA RAKAMLARI DÖNÜŞTÜRÜCÜ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonIntegerToRoman;
        private System.Windows.Forms.Button buttonRomanToInteger;
    }
}

