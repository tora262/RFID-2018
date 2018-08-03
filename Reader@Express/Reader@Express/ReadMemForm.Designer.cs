namespace Reader_Express
{
    partial class ReadMemForm
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
            this.components = new System.ComponentModel.Container();
            this.cbReadMemType = new System.Windows.Forms.ComboBox();
            this.tbReadLocation = new System.Windows.Forms.NumericUpDown();
            this.tbReadLength = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.navigationPane1 = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.navPageRead = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.tbReadResult = new System.Windows.Forms.RichTextBox();
            this.navPageWrite = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.tbWriteData = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbWriteLength = new System.Windows.Forms.NumericUpDown();
            this.lbWriteResult = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbWriteMemType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbWriteLocation = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.navPageWriteText = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.tbWriteTextData = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbWriteTextResult = new System.Windows.Forms.Label();
            this.cbWriteTextMemType = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbWriteTextLocation = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.btnExe = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbReadLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbReadLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).BeginInit();
            this.navigationPane1.SuspendLayout();
            this.navPageRead.SuspendLayout();
            this.navPageWrite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbWriteLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbWriteLocation)).BeginInit();
            this.navPageWriteText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbWriteTextLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbReadMemType
            // 
            this.cbReadMemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReadMemType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbReadMemType.FormattingEnabled = true;
            this.cbReadMemType.Items.AddRange(new object[] {
            "EPC",
            "TID",
            "User",
            "Reserved"});
            this.cbReadMemType.Location = new System.Drawing.Point(143, 7);
            this.cbReadMemType.Name = "cbReadMemType";
            this.cbReadMemType.Size = new System.Drawing.Size(106, 24);
            this.cbReadMemType.TabIndex = 0;
            // 
            // tbReadLocation
            // 
            this.tbReadLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbReadLocation.Location = new System.Drawing.Point(143, 39);
            this.tbReadLocation.Name = "tbReadLocation";
            this.tbReadLocation.Size = new System.Drawing.Size(106, 22);
            this.tbReadLocation.TabIndex = 1;
            // 
            // tbReadLength
            // 
            this.tbReadLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbReadLength.Location = new System.Drawing.Point(143, 67);
            this.tbReadLength.Name = "tbReadLength";
            this.tbReadLength.Size = new System.Drawing.Size(106, 22);
            this.tbReadLength.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Memory type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Location at:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Length:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Result:";
            // 
            // navigationPane1
            // 
            this.navigationPane1.Controls.Add(this.navPageRead);
            this.navigationPane1.Controls.Add(this.navPageWrite);
            this.navigationPane1.Controls.Add(this.navPageWriteText);
            this.navigationPane1.Location = new System.Drawing.Point(13, 13);
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navPageRead,
            this.navPageWrite,
            this.navPageWriteText});
            this.navigationPane1.RegularSize = new System.Drawing.Size(453, 269);
            this.navigationPane1.SelectedPage = this.navPageWrite;
            this.navigationPane1.Size = new System.Drawing.Size(453, 269);
            this.navigationPane1.TabIndex = 10;
            this.navigationPane1.Text = "navigationPane1";
            // 
            // navPageRead
            // 
            this.navPageRead.Caption = "Read";
            this.navPageRead.Controls.Add(this.tbReadResult);
            this.navPageRead.Controls.Add(this.label1);
            this.navPageRead.Controls.Add(this.tbReadLength);
            this.navPageRead.Controls.Add(this.label3);
            this.navPageRead.Controls.Add(this.cbReadMemType);
            this.navPageRead.Controls.Add(this.label2);
            this.navPageRead.Controls.Add(this.tbReadLocation);
            this.navPageRead.Controls.Add(this.label4);
            this.navPageRead.Name = "navPageRead";
            this.navPageRead.Size = new System.Drawing.Size(366, 209);
            // 
            // tbReadResult
            // 
            this.tbReadResult.BackColor = System.Drawing.SystemColors.Menu;
            this.tbReadResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbReadResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbReadResult.Location = new System.Drawing.Point(143, 95);
            this.tbReadResult.Name = "tbReadResult";
            this.tbReadResult.Size = new System.Drawing.Size(205, 53);
            this.tbReadResult.TabIndex = 9;
            this.tbReadResult.Text = "";
            // 
            // navPageWrite
            // 
            this.navPageWrite.Caption = "Write";
            this.navPageWrite.Controls.Add(this.tbWriteData);
            this.navPageWrite.Controls.Add(this.label11);
            this.navPageWrite.Controls.Add(this.label5);
            this.navPageWrite.Controls.Add(this.tbWriteLength);
            this.navPageWrite.Controls.Add(this.lbWriteResult);
            this.navPageWrite.Controls.Add(this.label7);
            this.navPageWrite.Controls.Add(this.cbWriteMemType);
            this.navPageWrite.Controls.Add(this.label8);
            this.navPageWrite.Controls.Add(this.tbWriteLocation);
            this.navPageWrite.Controls.Add(this.label9);
            this.navPageWrite.Name = "navPageWrite";
            this.navPageWrite.Size = new System.Drawing.Size(366, 209);
            // 
            // tbWriteData
            // 
            this.tbWriteData.Location = new System.Drawing.Point(141, 98);
            this.tbWriteData.Name = "tbWriteData";
            this.tbWriteData.Size = new System.Drawing.Size(160, 39);
            this.tbWriteData.TabIndex = 23;
            this.tbWriteData.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "Data:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Memory type:";
            // 
            // tbWriteLength
            // 
            this.tbWriteLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWriteLength.Location = new System.Drawing.Point(141, 70);
            this.tbWriteLength.Name = "tbWriteLength";
            this.tbWriteLength.Size = new System.Drawing.Size(106, 22);
            this.tbWriteLength.TabIndex = 12;
            // 
            // lbWriteResult
            // 
            this.lbWriteResult.AutoSize = true;
            this.lbWriteResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWriteResult.Location = new System.Drawing.Point(141, 145);
            this.lbWriteResult.Name = "lbWriteResult";
            this.lbWriteResult.Size = new System.Drawing.Size(0, 16);
            this.lbWriteResult.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Length:";
            // 
            // cbWriteMemType
            // 
            this.cbWriteMemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWriteMemType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWriteMemType.FormattingEnabled = true;
            this.cbWriteMemType.Items.AddRange(new object[] {
            "EPC",
            "TID",
            "User",
            "Reserved"});
            this.cbWriteMemType.Location = new System.Drawing.Point(141, 10);
            this.cbWriteMemType.Name = "cbWriteMemType";
            this.cbWriteMemType.Size = new System.Drawing.Size(106, 24);
            this.cbWriteMemType.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Location at:";
            // 
            // tbWriteLocation
            // 
            this.tbWriteLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWriteLocation.Location = new System.Drawing.Point(141, 42);
            this.tbWriteLocation.Name = "tbWriteLocation";
            this.tbWriteLocation.Size = new System.Drawing.Size(106, 22);
            this.tbWriteLocation.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Result:";
            // 
            // navPageWriteText
            // 
            this.navPageWriteText.Caption = "Write TEXT";
            this.navPageWriteText.Controls.Add(this.tbWriteTextData);
            this.navPageWriteText.Controls.Add(this.label10);
            this.navPageWriteText.Controls.Add(this.label6);
            this.navPageWriteText.Controls.Add(this.lbWriteTextResult);
            this.navPageWriteText.Controls.Add(this.cbWriteTextMemType);
            this.navPageWriteText.Controls.Add(this.label12);
            this.navPageWriteText.Controls.Add(this.tbWriteTextLocation);
            this.navPageWriteText.Controls.Add(this.label13);
            this.navPageWriteText.Name = "navPageWriteText";
            this.navPageWriteText.Size = new System.Drawing.Size(366, 209);
            // 
            // tbWriteTextData
            // 
            this.tbWriteTextData.Location = new System.Drawing.Point(147, 98);
            this.tbWriteTextData.Name = "tbWriteTextData";
            this.tbWriteTextData.Size = new System.Drawing.Size(160, 39);
            this.tbWriteTextData.TabIndex = 21;
            this.tbWriteTextData.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "Data:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Memory type:";
            // 
            // lbWriteTextResult
            // 
            this.lbWriteTextResult.AutoSize = true;
            this.lbWriteTextResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWriteTextResult.Location = new System.Drawing.Point(144, 140);
            this.lbWriteTextResult.Name = "lbWriteTextResult";
            this.lbWriteTextResult.Size = new System.Drawing.Size(0, 16);
            this.lbWriteTextResult.TabIndex = 19;
            // 
            // cbWriteTextMemType
            // 
            this.cbWriteTextMemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWriteTextMemType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWriteTextMemType.FormattingEnabled = true;
            this.cbWriteTextMemType.Items.AddRange(new object[] {
            "EPC",
            "TID",
            "User",
            "Reserved"});
            this.cbWriteTextMemType.Location = new System.Drawing.Point(147, 11);
            this.cbWriteTextMemType.Name = "cbWriteTextMemType";
            this.cbWriteTextMemType.Size = new System.Drawing.Size(106, 24);
            this.cbWriteTextMemType.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(18, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 16);
            this.label12.TabIndex = 16;
            this.label12.Text = "Location at:";
            // 
            // tbWriteTextLocation
            // 
            this.tbWriteTextLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWriteTextLocation.Location = new System.Drawing.Point(147, 43);
            this.tbWriteTextLocation.Name = "tbWriteTextLocation";
            this.tbWriteTextLocation.Size = new System.Drawing.Size(106, 22);
            this.tbWriteTextLocation.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(18, 140);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 16);
            this.label13.TabIndex = 18;
            this.label13.Text = "Result:";
            // 
            // btnExe
            // 
            this.btnExe.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExe.Appearance.Options.UseFont = true;
            this.btnExe.Location = new System.Drawing.Point(286, 299);
            this.btnExe.Name = "btnExe";
            this.btnExe.Size = new System.Drawing.Size(87, 23);
            this.btnExe.TabIndex = 11;
            this.btnExe.Text = "Execute";
            this.btnExe.Click += new System.EventHandler(this.btnExe_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.Location = new System.Drawing.Point(379, 299);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Clear Result";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReadMemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 334);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnExe);
            this.Controls.Add(this.navigationPane1);
            this.Name = "ReadMemForm";
            this.Text = "Access Operation";
            ((System.ComponentModel.ISupportInitialize)(this.tbReadLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbReadLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).EndInit();
            this.navigationPane1.ResumeLayout(false);
            this.navPageRead.ResumeLayout(false);
            this.navPageRead.PerformLayout();
            this.navPageWrite.ResumeLayout(false);
            this.navPageWrite.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbWriteLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbWriteLocation)).EndInit();
            this.navPageWriteText.ResumeLayout(false);
            this.navPageWriteText.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbWriteTextLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbReadMemType;
        private System.Windows.Forms.NumericUpDown tbReadLocation;
        private System.Windows.Forms.NumericUpDown tbReadLength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraBars.Navigation.NavigationPane navigationPane1;
        private DevExpress.XtraBars.Navigation.NavigationPage navPageRead;
        private DevExpress.XtraBars.Navigation.NavigationPage navPageWrite;
        private DevExpress.XtraBars.Navigation.NavigationPage navPageWriteText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown tbWriteLength;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbWriteMemType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown tbWriteLocation;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbWriteTextResult;
        private System.Windows.Forms.ComboBox cbWriteTextMemType;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown tbWriteTextLocation;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox tbWriteData;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox tbWriteTextData;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.RichTextBox tbReadResult;
        private System.Windows.Forms.Label lbWriteResult;
        private DevExpress.XtraEditors.SimpleButton btnExe;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private System.Windows.Forms.Button button1;
    }
}