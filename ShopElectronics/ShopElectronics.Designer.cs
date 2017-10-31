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
            this.AddProduct = new System.Windows.Forms.Button();
            this.BuyProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ViewProducts = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DeleteProduct = new System.Windows.Forms.Button();
            this.llLogOut = new System.Windows.Forms.LinkLabel();
            this.llCheckOut = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // AddProduct
            // 
            this.AddProduct.BackColor = System.Drawing.Color.LemonChiffon;
            this.AddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddProduct.FlatAppearance.BorderSize = 0;
            this.AddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AddProduct.Location = new System.Drawing.Point(57, 132);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(126, 28);
            this.AddProduct.TabIndex = 0;
            this.AddProduct.Text = "Add product";
            this.AddProduct.UseVisualStyleBackColor = false;
            this.AddProduct.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // BuyProduct
            // 
            this.BuyProduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BuyProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BuyProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuyProduct.FlatAppearance.BorderSize = 0;
            this.BuyProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuyProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BuyProduct.Location = new System.Drawing.Point(529, 132);
            this.BuyProduct.Name = "BuyProduct";
            this.BuyProduct.Size = new System.Drawing.Size(126, 28);
            this.BuyProduct.TabIndex = 1;
            this.BuyProduct.Text = "Buy Product";
            this.BuyProduct.UseVisualStyleBackColor = false;
            this.BuyProduct.Click += new System.EventHandler(this.BuyProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Jokerman", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(92, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 58);
            this.label1.TabIndex = 2;
            this.label1.Text = "SHOP    ELECTRONICS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ViewProducts
            // 
            this.ViewProducts.BackColor = System.Drawing.Color.MistyRose;
            this.ViewProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewProducts.FlatAppearance.BorderSize = 0;
            this.ViewProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ViewProducts.Location = new System.Drawing.Point(368, 132);
            this.ViewProducts.Name = "ViewProducts";
            this.ViewProducts.Size = new System.Drawing.Size(126, 28);
            this.ViewProducts.TabIndex = 3;
            this.ViewProducts.Text = "View Products";
            this.ViewProducts.UseVisualStyleBackColor = false;
            this.ViewProducts.Click += new System.EventHandler(this.ViewProducts_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "The program was written by Kravets Oleg. ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(595, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "(с)All rights reserved";
            // 
            // DeleteProduct
            // 
            this.DeleteProduct.BackColor = System.Drawing.Color.Silver;
            this.DeleteProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteProduct.FlatAppearance.BorderSize = 0;
            this.DeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DeleteProduct.Location = new System.Drawing.Point(209, 132);
            this.DeleteProduct.Name = "DeleteProduct";
            this.DeleteProduct.Size = new System.Drawing.Size(126, 28);
            this.DeleteProduct.TabIndex = 7;
            this.DeleteProduct.Text = "Delete Product";
            this.DeleteProduct.UseVisualStyleBackColor = false;
            this.DeleteProduct.Click += new System.EventHandler(this.DeleteProduct_Click);
            // 
            // llLogOut
            // 
            this.llLogOut.AutoSize = true;
            this.llLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.llLogOut.Location = new System.Drawing.Point(596, 9);
            this.llLogOut.Name = "llLogOut";
            this.llLogOut.Size = new System.Drawing.Size(52, 16);
            this.llLogOut.TabIndex = 8;
            this.llLogOut.TabStop = true;
            this.llLogOut.Text = "Log out";
            this.llLogOut.Click += new System.EventHandler(this.llLogOut_Click);
            // 
            // llCheckOut
            // 
            this.llCheckOut.AutoSize = true;
            this.llCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.llCheckOut.Location = new System.Drawing.Point(596, 34);
            this.llCheckOut.Name = "llCheckOut";
            this.llCheckOut.Size = new System.Drawing.Size(59, 16);
            this.llCheckOut.TabIndex = 9;
            this.llCheckOut.TabStop = true;
            this.llCheckOut.Text = "Check in";
            this.llCheckOut.Click += new System.EventHandler(this.llCheckOut_Click);
            // 
            // ShopElectronics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(701, 317);
            this.Controls.Add(this.llCheckOut);
            this.Controls.Add(this.llLogOut);
            this.Controls.Add(this.DeleteProduct);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ViewProducts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BuyProduct);
            this.Controls.Add(this.AddProduct);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(800, 800);
            this.MaximumSize = new System.Drawing.Size(1280, 1024);
            this.MinimumSize = new System.Drawing.Size(717, 356);
            this.Name = "ShopElectronics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShopElectronics";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ShopElectronics_FormClosing);
            this.Load += new System.EventHandler(this.ShopElectronics_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddProduct;
        private System.Windows.Forms.Button BuyProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ViewProducts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DeleteProduct;
        private System.Windows.Forms.LinkLabel llLogOut;
        private System.Windows.Forms.LinkLabel llCheckOut;
    }
}