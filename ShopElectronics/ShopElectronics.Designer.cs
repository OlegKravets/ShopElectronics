namespace ShopElectronics
{
    partial class ShopElectronics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopElectronics));
            this.BuyProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DeleteProduct = new System.Windows.Forms.Button();
            this.llLogOut = new System.Windows.Forms.LinkLabel();
            this.btnViewUsers = new System.Windows.Forms.Button();
            this.AddProduct = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.NameProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Firm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // BuyProduct
            // 
            this.BuyProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BuyProduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BuyProduct.BackColor = System.Drawing.Color.Azure;
            this.BuyProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BuyProduct.BackgroundImage")));
            this.BuyProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BuyProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuyProduct.FlatAppearance.BorderSize = 0;
            this.BuyProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuyProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BuyProduct.Location = new System.Drawing.Point(563, 217);
            this.BuyProduct.Name = "BuyProduct";
            this.BuyProduct.Size = new System.Drawing.Size(44, 44);
            this.BuyProduct.TabIndex = 1;
            this.BuyProduct.UseVisualStyleBackColor = false;
            this.BuyProduct.Click += new System.EventHandler(this.BuyProduct_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Jokerman", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(38, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 58);
            this.label1.TabIndex = 2;
            this.label1.Text = "SHOP    ELECTRONICS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "The program was written by Kravets Oleg. ";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(595, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "(с)All rights reserved";
            // 
            // DeleteProduct
            // 
            this.DeleteProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteProduct.BackColor = System.Drawing.Color.Azure;
            this.DeleteProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeleteProduct.BackgroundImage")));
            this.DeleteProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DeleteProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteProduct.FlatAppearance.BorderSize = 0;
            this.DeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DeleteProduct.Location = new System.Drawing.Point(563, 162);
            this.DeleteProduct.Name = "DeleteProduct";
            this.DeleteProduct.Size = new System.Drawing.Size(44, 44);
            this.DeleteProduct.TabIndex = 7;
            this.DeleteProduct.UseVisualStyleBackColor = false;
            this.DeleteProduct.Click += new System.EventHandler(this.DeleteProduct_Click);
            // 
            // llLogOut
            // 
            this.llLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.llLogOut.AutoSize = true;
            this.llLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.llLogOut.Location = new System.Drawing.Point(560, 24);
            this.llLogOut.Name = "llLogOut";
            this.llLogOut.Size = new System.Drawing.Size(52, 16);
            this.llLogOut.TabIndex = 8;
            this.llLogOut.TabStop = true;
            this.llLogOut.Text = "Log out";
            this.llLogOut.Click += new System.EventHandler(this.llLogOut_Click);
            // 
            // btnViewUsers
            // 
            this.btnViewUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewUsers.BackColor = System.Drawing.Color.MistyRose;
            this.btnViewUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewUsers.FlatAppearance.BorderSize = 0;
            this.btnViewUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnViewUsers.Location = new System.Drawing.Point(541, 352);
            this.btnViewUsers.Name = "btnViewUsers";
            this.btnViewUsers.Size = new System.Drawing.Size(126, 28);
            this.btnViewUsers.TabIndex = 10;
            this.btnViewUsers.Text = "User manager";
            this.btnViewUsers.UseVisualStyleBackColor = false;
            this.btnViewUsers.Click += new System.EventHandler(this.btnViewUsers_Click);
            // 
            // AddProduct
            // 
            this.AddProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddProduct.BackColor = System.Drawing.Color.Azure;
            this.AddProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddProduct.BackgroundImage")));
            this.AddProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddProduct.FlatAppearance.BorderSize = 0;
            this.AddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AddProduct.Location = new System.Drawing.Point(563, 107);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(44, 44);
            this.AddProduct.TabIndex = 0;
            this.AddProduct.UseVisualStyleBackColor = false;
            this.AddProduct.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameProduct,
            this.Firm,
            this.Number,
            this.Price});
            this.dataGridView.Location = new System.Drawing.Point(35, 100);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(500, 280);
            this.dataGridView.TabIndex = 0;
            // 
            // NameProduct
            // 
            this.NameProduct.HeaderText = "Name Product";
            this.NameProduct.Name = "NameProduct";
            this.NameProduct.ReadOnly = true;
            this.NameProduct.Width = 150;
            // 
            // Firm
            // 
            this.Firm.HeaderText = "Firm";
            this.Firm.Name = "Firm";
            this.Firm.ReadOnly = true;
            this.Firm.Width = 150;
            // 
            // Number
            // 
            this.Number.HeaderText = "Number";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Width = 78;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price($)";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 79;
            // 
            // menuMain
            // 
            this.menuMain.BackColor = System.Drawing.Color.White;
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(701, 24);
            this.menuMain.TabIndex = 4;
            this.menuMain.Text = "menuMain";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToExcelToolStripMenuItem,
            this.printToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // exportToExcelToolStripMenuItem
            // 
            this.exportToExcelToolStripMenuItem.Name = "exportToExcelToolStripMenuItem";
            this.exportToExcelToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.exportToExcelToolStripMenuItem.Text = "Export to Excel";
            this.exportToExcelToolStripMenuItem.Click += new System.EventHandler(this.ExportProducts_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.PrintProducts_Click);
            // 
            // ShopElectronics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(701, 418);
            this.Controls.Add(this.btnViewUsers);
            this.Controls.Add(this.llLogOut);
            this.Controls.Add(this.DeleteProduct);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BuyProduct);
            this.Controls.Add(this.AddProduct);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(800, 800);
            this.MainMenuStrip = this.menuMain;
            this.MaximumSize = new System.Drawing.Size(1280, 1024);
            this.MinimumSize = new System.Drawing.Size(717, 356);
            this.Name = "ShopElectronics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShopElectronics";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ShopElectronics_FormClosing);
            this.Load += new System.EventHandler(this.ShopElectronics_Load);
            this.SizeChanged += new System.EventHandler(this.ShopElectronics_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddProduct;
        private System.Windows.Forms.Button BuyProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DeleteProduct;
        private System.Windows.Forms.LinkLabel llLogOut;
        private System.Windows.Forms.Button btnViewUsers;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Firm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
    }
}