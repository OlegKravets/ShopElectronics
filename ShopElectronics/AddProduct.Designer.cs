﻿namespace ShopElectronics
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
            this.PriceNew = new System.Windows.Forms.TextBox();
            this.NameNew = new System.Windows.Forms.TextBox();
            this.NameProductNew = new System.Windows.Forms.TextBox();
            this.NumberNew = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddNewProduct
            // 
            this.AddNewProduct.BackColor = System.Drawing.Color.Gainsboro;
            this.AddNewProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddNewProduct.FlatAppearance.BorderSize = 0;
            this.AddNewProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddNewProduct.ForeColor = System.Drawing.Color.Black;
            this.AddNewProduct.Location = new System.Drawing.Point(175, 155);
            this.AddNewProduct.Name = "AddNewProduct";
            this.AddNewProduct.Size = new System.Drawing.Size(59, 27);
            this.AddNewProduct.TabIndex = 0;
            this.AddNewProduct.Text = "ADD";
            this.AddNewProduct.UseVisualStyleBackColor = false;
            this.AddNewProduct.Click += new System.EventHandler(this.AddNewProduct_Click);
            // 
            // PriceNew
            // 
            this.PriceNew.Location = new System.Drawing.Point(186, 110);
            this.PriceNew.Name = "PriceNew";
            this.PriceNew.Size = new System.Drawing.Size(113, 20);
            this.PriceNew.TabIndex = 5;
            // 
            // NameNew
            // 
            this.NameNew.Location = new System.Drawing.Point(22, 110);
            this.NameNew.Name = "NameNew";
            this.NameNew.Size = new System.Drawing.Size(120, 20);
            this.NameNew.TabIndex = 7;
            // 
            // NameProductNew
            // 
            this.NameProductNew.Location = new System.Drawing.Point(22, 47);
            this.NameProductNew.Name = "NameProductNew";
            this.NameProductNew.Size = new System.Drawing.Size(119, 20);
            this.NameProductNew.TabIndex = 8;
            // 
            // NumberNew
            // 
            this.NumberNew.Location = new System.Drawing.Point(186, 47);
            this.NumberNew.Name = "NumberNew";
            this.NumberNew.Size = new System.Drawing.Size(113, 20);
            this.NumberNew.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Azure;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(18, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.Location = new System.Drawing.Point(182, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label4.Location = new System.Drawing.Point(182, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "Price";
            // 
            // Exit
            // 
            this.Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Exit.BackColor = System.Drawing.Color.Gainsboro;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.ForeColor = System.Drawing.Color.Black;
            this.Exit.Location = new System.Drawing.Point(240, 155);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(59, 27);
            this.Exit.TabIndex = 14;
            this.Exit.Text = "EXIT";
            this.Exit.UseVisualStyleBackColor = false;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(331, 199);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumberNew);
            this.Controls.Add(this.NameProductNew);
            this.Controls.Add(this.NameNew);
            this.Controls.Add(this.PriceNew);
            this.Controls.Add(this.AddNewProduct);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1280, 1024);
            this.MinimumSize = new System.Drawing.Size(347, 238);
            this.Name = "AddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddNewProduct;
        private System.Windows.Forms.TextBox PriceNew;
        private System.Windows.Forms.TextBox NameNew;
        private System.Windows.Forms.TextBox NameProductNew;
        private System.Windows.Forms.TextBox NumberNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Exit;
    }
}