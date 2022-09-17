namespace ADONetConnectedCRUD
{
    partial class ProductForm
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
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSuppliers = new System.Windows.Forms.ComboBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nuUnitPrice = new System.Windows.Forms.NumericUpDown();
            this.nuUnitsInStock = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nuOrder = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.nuReorderLvel = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nuUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuUnitsInStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuReorderLvel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(103, 10);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(410, 25);
            this.txtProductName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tedarikçi";
            // 
            // cmbSuppliers
            // 
            this.cmbSuppliers.FormattingEnabled = true;
            this.cmbSuppliers.Location = new System.Drawing.Point(102, 44);
            this.cmbSuppliers.Name = "cmbSuppliers";
            this.cmbSuppliers.Size = new System.Drawing.Size(154, 25);
            this.cmbSuppliers.TabIndex = 3;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(352, 44);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(161, 25);
            this.cmbCategory.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kategori";
            // 
            // txtQuantityPerUnit
            // 
            this.txtQuantityPerUnit.Location = new System.Drawing.Point(103, 75);
            this.txtQuantityPerUnit.Name = "txtQuantityPerUnit";
            this.txtQuantityPerUnit.Size = new System.Drawing.Size(153, 25);
            this.txtQuantityPerUnit.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Birim";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(271, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Birim Fiyatı";
            // 
            // nuUnitPrice
            // 
            this.nuUnitPrice.DecimalPlaces = 2;
            this.nuUnitPrice.Location = new System.Drawing.Point(352, 76);
            this.nuUnitPrice.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nuUnitPrice.Name = "nuUnitPrice";
            this.nuUnitPrice.Size = new System.Drawing.Size(161, 25);
            this.nuUnitPrice.TabIndex = 9;
            // 
            // nuUnitsInStock
            // 
            this.nuUnitsInStock.Location = new System.Drawing.Point(103, 106);
            this.nuUnitsInStock.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nuUnitsInStock.Name = "nuUnitsInStock";
            this.nuUnitsInStock.Size = new System.Drawing.Size(153, 25);
            this.nuUnitsInStock.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Toplam Stok";
            // 
            // nuOrder
            // 
            this.nuOrder.Location = new System.Drawing.Point(352, 105);
            this.nuOrder.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nuOrder.Name = "nuOrder";
            this.nuOrder.Size = new System.Drawing.Size(161, 25);
            this.nuOrder.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(271, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "G. Sipariş";
            // 
            // nuReorderLvel
            // 
            this.nuReorderLvel.Location = new System.Drawing.Point(103, 137);
            this.nuReorderLvel.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nuReorderLvel.Name = "nuReorderLvel";
            this.nuReorderLvel.Size = new System.Drawing.Size(153, 25);
            this.nuReorderLvel.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Kritik Seviye";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(18, 202);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(77, 42);
            this.btnNew.TabIndex = 16;
            this.btnNew.Text = "Yeni";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(186, 202);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(77, 42);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(103, 202);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(77, 42);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(434, 202);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(77, 42);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Kapat";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 255);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.nuReorderLvel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nuOrder);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nuUnitsInStock);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nuUnitPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtQuantityPerUnit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbSuppliers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nuUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuUnitsInStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuReorderLvel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSuppliers;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQuantityPerUnit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nuUnitPrice;
        private System.Windows.Forms.NumericUpDown nuUnitsInStock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nuOrder;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nuReorderLvel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
    }
}