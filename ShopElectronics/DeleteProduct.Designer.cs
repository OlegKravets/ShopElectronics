namespace ShopElectronics
{
    partial class DeleteProduct
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
            if(disposing && (components != null)) {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteProduct));
            this.dataGridViewDelete = new System.Windows.Forms.DataGridView();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameFirm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDelete
            // 
            this.dataGridViewDelete.AllowUserToAddRows = false;
            this.dataGridViewDelete.AllowUserToDeleteRows = false;
            this.dataGridViewDelete.AllowUserToResizeColumns = false;
            this.dataGridViewDelete.AllowUserToResizeRows = false;
            this.dataGridViewDelete.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewDelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDelete.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.NameFirm,
            this.NumberProduct,
            this.ProductPrice});
            this.dataGridViewDelete.Location = new System.Drawing.Point(35, 12);
            this.dataGridViewDelete.Name = "dataGridViewDelete";
            this.dataGridViewDelete.ReadOnly = true;
            this.dataGridViewDelete.Size = new System.Drawing.Size(645, 400);
            this.dataGridViewDelete.TabIndex = 0;
            this.dataGridViewDelete.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SelectProductForDelete);
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 150;
            // 
            // NameFirm
            // 
            this.NameFirm.HeaderText = "Name Firm";
            this.NameFirm.Name = "NameFirm";
            this.NameFirm.ReadOnly = true;
            this.NameFirm.Width = 150;
            // 
            // NumberProduct
            // 
            this.NumberProduct.HeaderText = "Number Product";
            this.NumberProduct.Name = "NumberProduct";
            this.NumberProduct.ReadOnly = true;
            this.NumberProduct.Width = 150;
            // 
            // ProductPrice
            // 
            this.ProductPrice.HeaderText = "Product Price";
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.ReadOnly = true;
            this.ProductPrice.Width = 150;
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Gainsboro;
            this.Delete.FlatAppearance.BorderSize = 0;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete.Location = new System.Drawing.Point(516, 419);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(79, 28);
            this.Delete.TabIndex = 1;
            this.Delete.Text = "DELETE";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Gainsboro;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(601, 418);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(79, 28);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // DeleteProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(713, 459);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.dataGridViewDelete);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1280, 1024);
            this.MinimumSize = new System.Drawing.Size(729, 339);
            this.Name = "DeleteProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DeleteProduct";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameFirm;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPrice;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button btnExit;
    }
}