namespace ShopElectronics
{
    partial class Buy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buy));
            this.lbProduct = new System.Windows.Forms.ListBox();
            this.lbFirm = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbNumber = new System.Windows.Forms.ListBox();
            this.lbPrice = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.numUpDownNumber = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // lbProduct
            // 
            this.lbProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbProduct.FormattingEnabled = true;
            this.lbProduct.Location = new System.Drawing.Point(23, 50);
            this.lbProduct.Name = "lbProduct";
            this.lbProduct.Size = new System.Drawing.Size(145, 212);
            this.lbProduct.TabIndex = 1;
            this.lbProduct.SelectedIndexChanged += new System.EventHandler(this.listBoxProduct_SelectedIndexChanged);
            // 
            // lbFirm
            // 
            this.lbFirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbFirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lbFirm.FormattingEnabled = true;
            this.lbFirm.Location = new System.Drawing.Point(195, 50);
            this.lbFirm.Name = "lbFirm";
            this.lbFirm.Size = new System.Drawing.Size(91, 212);
            this.lbFirm.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(192, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Firm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(415, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Select Number";
            // 
            // lbNumber
            // 
            this.lbNumber.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lbNumber.FormattingEnabled = true;
            this.lbNumber.Location = new System.Drawing.Point(269, 50);
            this.lbNumber.Name = "lbNumber";
            this.lbNumber.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbNumber.Size = new System.Drawing.Size(68, 212);
            this.lbNumber.TabIndex = 7;
            // 
            // lbPrice
            // 
            this.lbPrice.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lbPrice.FormattingEnabled = true;
            this.lbPrice.Location = new System.Drawing.Point(331, 50);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbPrice.Size = new System.Drawing.Size(68, 212);
            this.lbPrice.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(266, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(328, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Price";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Gainsboro;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(484, 247);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(59, 27);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // btnBuy
            // 
            this.btnBuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnBuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuy.FlatAppearance.BorderSize = 0;
            this.btnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBuy.ForeColor = System.Drawing.Color.Black;
            this.btnBuy.Location = new System.Drawing.Point(414, 247);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(59, 27);
            this.btnBuy.TabIndex = 15;
            this.btnBuy.Text = "BUY";
            this.btnBuy.UseVisualStyleBackColor = false;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // numUpDownNumber
            // 
            this.numUpDownNumber.Location = new System.Drawing.Point(418, 50);
            this.numUpDownNumber.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numUpDownNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownNumber.Name = "numUpDownNumber";
            this.numUpDownNumber.Size = new System.Drawing.Size(120, 20);
            this.numUpDownNumber.TabIndex = 17;
            this.numUpDownNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Buy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(555, 286);
            this.Controls.Add(this.numUpDownNumber);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbFirm);
            this.Controls.Add(this.lbProduct);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1280, 1024);
            this.MinimumSize = new System.Drawing.Size(571, 325);
            this.Name = "Buy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buy";
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbProduct;
        private System.Windows.Forms.ListBox lbFirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbNumber;
        private System.Windows.Forms.ListBox lbPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.NumericUpDown numUpDownNumber;
    }
}