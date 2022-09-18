namespace ADONetConnectedCRUD
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
            this.grdProducts = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuProductButton = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCategoryButton = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSupplierButton = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCustomerButton = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEmployeeButton = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTerritoryButton = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grdProducts)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdProducts
            // 
            this.grdProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdProducts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdProducts.Location = new System.Drawing.Point(0, 24);
            this.grdProducts.MultiSelect = false;
            this.grdProducts.Name = "grdProducts";
            this.grdProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdProducts.Size = new System.Drawing.Size(1067, 564);
            this.grdProducts.TabIndex = 0;
            this.grdProducts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProducts_CellDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuProductButton,
            this.menuCategoryButton,
            this.menuSupplierButton,
            this.menuCustomerButton,
            this.menuEmployeeButton,
            this.menuTerritoryButton});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuProductButton
            // 
            this.menuProductButton.Name = "menuProductButton";
            this.menuProductButton.Size = new System.Drawing.Size(92, 20);
            this.menuProductButton.Text = "Ürün İşlemleri";
            this.menuProductButton.Click += new System.EventHandler(this.menuProductButton_Click);
            // 
            // menuCategoryButton
            // 
            this.menuCategoryButton.Name = "menuCategoryButton";
            this.menuCategoryButton.Size = new System.Drawing.Size(110, 20);
            this.menuCategoryButton.Text = "Kategori İşlemleri";
            // 
            // menuSupplierButton
            // 
            this.menuSupplierButton.Name = "menuSupplierButton";
            this.menuSupplierButton.Size = new System.Drawing.Size(112, 20);
            this.menuSupplierButton.Text = "Tedarikçi İşlemleri";
            // 
            // menuCustomerButton
            // 
            this.menuCustomerButton.Name = "menuCustomerButton";
            this.menuCustomerButton.Size = new System.Drawing.Size(106, 20);
            this.menuCustomerButton.Text = "Müşteri İşlemleri";
            // 
            // menuEmployeeButton
            // 
            this.menuEmployeeButton.Name = "menuEmployeeButton";
            this.menuEmployeeButton.Size = new System.Drawing.Size(104, 20);
            this.menuEmployeeButton.Text = "Çalışan İşlemleri";
            // 
            // menuTerritoryButton
            // 
            this.menuTerritoryButton.Name = "menuTerritoryButton";
            this.menuTerritoryButton.Size = new System.Drawing.Size(96, 20);
            this.menuTerritoryButton.Text = "Bölge İşlemleri";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 588);
            this.Controls.Add(this.grdProducts);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdProducts)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdProducts;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuProductButton;
        private System.Windows.Forms.ToolStripMenuItem menuCategoryButton;
        private System.Windows.Forms.ToolStripMenuItem menuSupplierButton;
        private System.Windows.Forms.ToolStripMenuItem menuCustomerButton;
        private System.Windows.Forms.ToolStripMenuItem menuEmployeeButton;
        private System.Windows.Forms.ToolStripMenuItem menuTerritoryButton;
    }
}

