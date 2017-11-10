using System;
using System.ComponentModel;

namespace ShopElectronics
{
    partial class AddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProduct));
            this.AddNewProduct = new System.Windows.Forms.Button();
            this.tbNameFirm = new System.Windows.Forms.TextBox();
            this.tbNameProduct = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.numUpDownNumber = new System.Windows.Forms.NumericUpDown();
            this.numUpDownPrice = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // AddNewProduct
            // 
            this.AddNewProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(230)))), ((int)(((byte)(137)))));
            this.AddNewProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddNewProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddNewProduct.FlatAppearance.BorderSize = 0;
            this.AddNewProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddNewProduct.ForeColor = System.Drawing.Color.Black;
            this.AddNewProduct.Location = new System.Drawing.Point(126, 159);
            this.AddNewProduct.Name = "AddNewProduct";
            this.AddNewProduct.Size = new System.Drawing.Size(65, 30);
            this.AddNewProduct.TabIndex = 5;
            this.AddNewProduct.Text = "Add";
            this.AddNewProduct.UseVisualStyleBackColor = false;
            this.AddNewProduct.Click += new System.EventHandler(this.AddNewProduct_Click);
            // 
            // tbNameFirm
            // 
            this.tbNameFirm.Location = new System.Drawing.Point(152, 56);
            this.tbNameFirm.Name = "tbNameFirm";
            this.tbNameFirm.Size = new System.Drawing.Size(120, 20);
            this.tbNameFirm.TabIndex = 2;
            // 
            // tbNameProduct
            // 
            this.tbNameProduct.Location = new System.Drawing.Point(152, 24);
            this.tbNameProduct.Name = "tbNameProduct";
            this.tbNameProduct.Size = new System.Drawing.Size(119, 20);
            this.tbNameProduct.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Azure;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(18, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(18, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Firm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.Location = new System.Drawing.Point(18, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label4.Location = new System.Drawing.Point(18, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Price";
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Gainsboro;
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.ForeColor = System.Drawing.Color.Black;
            this.Exit.Location = new System.Drawing.Point(207, 162);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(65, 27);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "Cancel";
            this.Exit.UseVisualStyleBackColor = false;
            // 
            // numUpDownNumber
            // 
            this.numUpDownNumber.Location = new System.Drawing.Point(152, 89);
            this.numUpDownNumber.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numUpDownNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownNumber.Name = "numUpDownNumber";
            this.numUpDownNumber.Size = new System.Drawing.Size(120, 20);
            this.numUpDownNumber.TabIndex = 3;
            this.numUpDownNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numUpDownPrice
            // 
            this.numUpDownPrice.Location = new System.Drawing.Point(152, 124);
            this.numUpDownPrice.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numUpDownPrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownPrice.Name = "numUpDownPrice";
            this.numUpDownPrice.Size = new System.Drawing.Size(120, 20);
            this.numUpDownPrice.TabIndex = 4;
            this.numUpDownPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(288, 201);
            this.Controls.Add(this.numUpDownPrice);
            this.Controls.Add(this.numUpDownNumber);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNameProduct);
            this.Controls.Add(this.tbNameFirm);
            this.Controls.Add(this.AddNewProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(337, 240);
            this.MinimumSize = new System.Drawing.Size(300, 240);
            this.Name = "AddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddProduct";
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Button AddNewProduct;
        private System.Windows.Forms.TextBox tbNameFirm;
        private System.Windows.Forms.TextBox tbNameProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.NumericUpDown numUpDownNumber;
        private System.Windows.Forms.NumericUpDown numUpDownPrice;
    }
}