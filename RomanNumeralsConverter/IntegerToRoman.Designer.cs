namespace RomanNumeralsConverter
{
    partial class IntegerToRoman
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
            this.textBoxInteger = new System.Windows.Forms.TextBox();
            this.textBoxRoman = new System.Windows.Forms.TextBox();
            this.buttonIntegerToRoman = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(34, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "TAMSAYI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(34, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "ROMA RAKAMI";
            // 
            // textBoxInteger
            // 
            this.textBoxInteger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxInteger.Location = new System.Drawing.Point(171, 26);
            this.textBoxInteger.MaxLength = 4;
            this.textBoxInteger.Name = "textBoxInteger";
            this.textBoxInteger.Size = new System.Drawing.Size(191, 26);
            this.textBoxInteger.TabIndex = 2;
            this.textBoxInteger.TextChanged += new System.EventHandler(this.textBoxInteger_TextChanged);
            this.textBoxInteger.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInteger_KeyPress);
            // 
            // textBoxRoman
            // 
            this.textBoxRoman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxRoman.Location = new System.Drawing.Point(171, 126);
            this.textBoxRoman.Name = "textBoxRoman";
            this.textBoxRoman.ReadOnly = true;
            this.textBoxRoman.Size = new System.Drawing.Size(191, 26);
            this.textBoxRoman.TabIndex = 3;
            // 
            // buttonIntegerToRoman
            // 
            this.buttonIntegerToRoman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonIntegerToRoman.Location = new System.Drawing.Point(171, 77);
            this.buttonIntegerToRoman.Name = "buttonIntegerToRoman";
            this.buttonIntegerToRoman.Size = new System.Drawing.Size(191, 27);
            this.buttonIntegerToRoman.TabIndex = 4;
            this.buttonIntegerToRoman.Text = "ÇEVİR";
            this.buttonIntegerToRoman.UseVisualStyleBackColor = true;
            this.buttonIntegerToRoman.Click += new System.EventHandler(this.buttonIntegerToRoman_Click);
            // 
            // IntegerToRoman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 188);
            this.Controls.Add(this.buttonIntegerToRoman);
            this.Controls.Add(this.textBoxRoman);
            this.Controls.Add(this.textBoxInteger);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "IntegerToRoman";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ROMA RAKAMINA ÇEVİR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxInteger;
        private System.Windows.Forms.TextBox textBoxRoman;
        private System.Windows.Forms.Button buttonIntegerToRoman;
    }
}