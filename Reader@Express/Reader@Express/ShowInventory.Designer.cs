namespace Reader_Express
{
    partial class ShowInventory
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
            this.gridControlInventory = new DevExpress.XtraGrid.GridControl();
            this.gridViewInventory = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlInventory
            // 
            this.gridControlInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlInventory.Location = new System.Drawing.Point(0, 0);
            this.gridControlInventory.MainView = this.gridViewInventory;
            this.gridControlInventory.Name = "gridControlInventory";
            this.gridControlInventory.Size = new System.Drawing.Size(556, 308);
            this.gridControlInventory.TabIndex = 0;
            this.gridControlInventory.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewInventory});
            // 
            // gridViewInventory
            // 
            this.gridViewInventory.GridControl = this.gridControlInventory;
            this.gridViewInventory.Name = "gridViewInventory";
            // 
            // ShowInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 308);
            this.Controls.Add(this.gridControlInventory);
            this.Name = "ShowInventory";
            this.Text = "Inventory History";
            ((System.ComponentModel.ISupportInitialize)(this.gridControlInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewInventory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlInventory;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewInventory;
    }
}