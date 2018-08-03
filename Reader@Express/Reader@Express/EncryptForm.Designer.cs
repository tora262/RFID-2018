namespace Reader_Express
{
    partial class EncryptForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbPlainText = new System.Windows.Forms.TextBox();
            this.tbCipherText = new System.Windows.Forms.TextBox();
            this.tbPT = new System.Windows.Forms.TextBox();
            this.tbCT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(171, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Encrypt >";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(171, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "< Decrypt";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbPlainText
            // 
            this.tbPlainText.Location = new System.Drawing.Point(65, 54);
            this.tbPlainText.Name = "tbPlainText";
            this.tbPlainText.Size = new System.Drawing.Size(100, 21);
            this.tbPlainText.TabIndex = 2;
            // 
            // tbCipherText
            // 
            this.tbCipherText.Location = new System.Drawing.Point(252, 54);
            this.tbCipherText.Name = "tbCipherText";
            this.tbCipherText.Size = new System.Drawing.Size(100, 21);
            this.tbCipherText.TabIndex = 3;
            // 
            // tbPT
            // 
            this.tbPT.Location = new System.Drawing.Point(65, 100);
            this.tbPT.Name = "tbPT";
            this.tbPT.Size = new System.Drawing.Size(100, 21);
            this.tbPT.TabIndex = 4;
            // 
            // tbCT
            // 
            this.tbCT.Location = new System.Drawing.Point(252, 100);
            this.tbCT.Name = "tbCT";
            this.tbCT.Size = new System.Drawing.Size(100, 21);
            this.tbCT.TabIndex = 5;
            // 
            // EncryptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 262);
            this.Controls.Add(this.tbCT);
            this.Controls.Add(this.tbPT);
            this.Controls.Add(this.tbCipherText);
            this.Controls.Add(this.tbPlainText);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "EncryptForm";
            this.Text = "EncryptForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbPlainText;
        private System.Windows.Forms.TextBox tbCipherText;
        private System.Windows.Forms.TextBox tbPT;
        private System.Windows.Forms.TextBox tbCT;
    }
}