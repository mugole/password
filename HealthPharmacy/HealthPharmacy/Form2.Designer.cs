﻿namespace HealthPharmacy
{
    partial class Form2
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
            this.productDatabaseDataSet1 = new HealthPharmacy.ProductDatabaseDataSet();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Salestab = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.AddTab = new System.Windows.Forms.TabPage();
            this.AddSalesButton = new System.Windows.Forms.Button();
            this.SalesBox = new System.Windows.Forms.TextBox();
            this.PurchaseBox = new System.Windows.Forms.TextBox();
            this.CategoryBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.Namelabel = new System.Windows.Forms.Label();
            this.Saleslabel = new System.Windows.Forms.Label();
            this.Purchaselabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EditTab = new System.Windows.Forms.TabPage();
            this.EditButton = new System.Windows.Forms.Button();
            this.SalesBox4 = new System.Windows.Forms.TextBox();
            this.PurchaseBox3 = new System.Windows.Forms.TextBox();
            this.CategoryBox2 = new System.Windows.Forms.TextBox();
            this.NameBox1 = new System.Windows.Forms.TextBox();
            this.DisplayPage = new System.Windows.Forms.TabPage();
            this.SalesList = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.productDatabaseDataSet1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.Salestab.SuspendLayout();
            this.AddTab.SuspendLayout();
            this.EditTab.SuspendLayout();
            this.DisplayPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // productDatabaseDataSet1
            // 
            this.productDatabaseDataSet1.DataSetName = "ProductDatabaseDataSet";
            this.productDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Salestab);
            this.tabControl1.Controls.Add(this.AddTab);
            this.tabControl1.Controls.Add(this.EditTab);
            this.tabControl1.Controls.Add(this.DisplayPage);
            this.tabControl1.Location = new System.Drawing.Point(-1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(547, 416);
            this.tabControl1.TabIndex = 0;
            // 
            // Salestab
            // 
            this.Salestab.BackgroundImage = global::HealthPharmacy.Properties.Resources.image2;
            this.Salestab.Controls.Add(this.button3);
            this.Salestab.Controls.Add(this.button2);
            this.Salestab.Controls.Add(this.button1);
            this.Salestab.Location = new System.Drawing.Point(4, 22);
            this.Salestab.Name = "Salestab";
            this.Salestab.Padding = new System.Windows.Forms.Padding(3);
            this.Salestab.Size = new System.Drawing.Size(539, 390);
            this.Salestab.TabIndex = 0;
            this.Salestab.Text = "Sales";
            this.Salestab.UseVisualStyleBackColor = true;
            this.Salestab.Click += new System.EventHandler(this.Salestab_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(52, 298);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 31);
            this.button3.TabIndex = 2;
            this.button3.Text = "Monthly Sales Report";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(52, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "Weekly Sales Report";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Manage Sales Record";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AddTab
            // 
            this.AddTab.BackgroundImage = global::HealthPharmacy.Properties.Resources.image2;
            this.AddTab.Controls.Add(this.AddSalesButton);
            this.AddTab.Controls.Add(this.SalesBox);
            this.AddTab.Controls.Add(this.PurchaseBox);
            this.AddTab.Controls.Add(this.CategoryBox);
            this.AddTab.Controls.Add(this.NameBox);
            this.AddTab.Controls.Add(this.Namelabel);
            this.AddTab.Controls.Add(this.Saleslabel);
            this.AddTab.Controls.Add(this.Purchaselabel);
            this.AddTab.Controls.Add(this.label2);
            this.AddTab.Location = new System.Drawing.Point(4, 22);
            this.AddTab.Name = "AddTab";
            this.AddTab.Padding = new System.Windows.Forms.Padding(3);
            this.AddTab.Size = new System.Drawing.Size(539, 390);
            this.AddTab.TabIndex = 1;
            this.AddTab.Text = "Add Sales";
            this.AddTab.UseVisualStyleBackColor = true;
            // 
            // AddSalesButton
            // 
            this.AddSalesButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.AddSalesButton.Font = new System.Drawing.Font("Book Antiqua", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSalesButton.Location = new System.Drawing.Point(406, 330);
            this.AddSalesButton.Name = "AddSalesButton";
            this.AddSalesButton.Size = new System.Drawing.Size(75, 29);
            this.AddSalesButton.TabIndex = 10;
            this.AddSalesButton.Text = "ADD";
            this.AddSalesButton.UseVisualStyleBackColor = false;
            this.AddSalesButton.Click += new System.EventHandler(this.AddSalesButton_Click);
            // 
            // SalesBox
            // 
            this.SalesBox.Location = new System.Drawing.Point(294, 240);
            this.SalesBox.Name = "SalesBox";
            this.SalesBox.Size = new System.Drawing.Size(100, 20);
            this.SalesBox.TabIndex = 9;
            this.SalesBox.TextChanged += new System.EventHandler(this.SalesBox_TextChanged);
            // 
            // PurchaseBox
            // 
            this.PurchaseBox.Location = new System.Drawing.Point(294, 203);
            this.PurchaseBox.Name = "PurchaseBox";
            this.PurchaseBox.Size = new System.Drawing.Size(100, 20);
            this.PurchaseBox.TabIndex = 8;
            this.PurchaseBox.TextChanged += new System.EventHandler(this.PurchaseBox_TextChanged);
            // 
            // CategoryBox
            // 
            this.CategoryBox.Location = new System.Drawing.Point(294, 156);
            this.CategoryBox.Name = "CategoryBox";
            this.CategoryBox.Size = new System.Drawing.Size(100, 20);
            this.CategoryBox.TabIndex = 7;
            this.CategoryBox.TextChanged += new System.EventHandler(this.CategoryBox_TextChanged);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(294, 116);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(100, 20);
            this.NameBox.TabIndex = 6;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Font = new System.Drawing.Font("Book Antiqua", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Namelabel.Location = new System.Drawing.Point(116, 116);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(50, 20);
            this.Namelabel.TabIndex = 5;
            this.Namelabel.Text = "Name";
            // 
            // Saleslabel
            // 
            this.Saleslabel.AutoSize = true;
            this.Saleslabel.Font = new System.Drawing.Font("Book Antiqua", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Saleslabel.Location = new System.Drawing.Point(116, 240);
            this.Saleslabel.Name = "Saleslabel";
            this.Saleslabel.Size = new System.Drawing.Size(82, 20);
            this.Saleslabel.TabIndex = 3;
            this.Saleslabel.Text = "SalesPrice";
            // 
            // Purchaselabel
            // 
            this.Purchaselabel.AutoSize = true;
            this.Purchaselabel.Font = new System.Drawing.Font("Book Antiqua", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Purchaselabel.Location = new System.Drawing.Point(117, 203);
            this.Purchaselabel.Name = "Purchaselabel";
            this.Purchaselabel.Size = new System.Drawing.Size(104, 18);
            this.Purchaselabel.TabIndex = 2;
            this.Purchaselabel.Text = "PurchasePrice";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(116, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category";
            // 
            // EditTab
            // 
            this.EditTab.BackgroundImage = global::HealthPharmacy.Properties.Resources.image2;
            this.EditTab.Controls.Add(this.EditButton);
            this.EditTab.Controls.Add(this.SalesBox4);
            this.EditTab.Controls.Add(this.PurchaseBox3);
            this.EditTab.Controls.Add(this.CategoryBox2);
            this.EditTab.Controls.Add(this.NameBox1);
            this.EditTab.Location = new System.Drawing.Point(4, 22);
            this.EditTab.Name = "EditTab";
            this.EditTab.Size = new System.Drawing.Size(539, 390);
            this.EditTab.TabIndex = 2;
            this.EditTab.Text = "Edit Sales";
            this.EditTab.UseVisualStyleBackColor = true;
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(359, 313);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 4;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // SalesBox4
            // 
            this.SalesBox4.Location = new System.Drawing.Point(337, 223);
            this.SalesBox4.Name = "SalesBox4";
            this.SalesBox4.Size = new System.Drawing.Size(100, 20);
            this.SalesBox4.TabIndex = 3;
            // 
            // PurchaseBox3
            // 
            this.PurchaseBox3.Location = new System.Drawing.Point(337, 180);
            this.PurchaseBox3.Name = "PurchaseBox3";
            this.PurchaseBox3.Size = new System.Drawing.Size(100, 20);
            this.PurchaseBox3.TabIndex = 2;
            // 
            // CategoryBox2
            // 
            this.CategoryBox2.Location = new System.Drawing.Point(337, 140);
            this.CategoryBox2.Name = "CategoryBox2";
            this.CategoryBox2.Size = new System.Drawing.Size(100, 20);
            this.CategoryBox2.TabIndex = 1;
            // 
            // NameBox1
            // 
            this.NameBox1.Location = new System.Drawing.Point(337, 103);
            this.NameBox1.Name = "NameBox1";
            this.NameBox1.Size = new System.Drawing.Size(100, 20);
            this.NameBox1.TabIndex = 0;
            // 
            // DisplayPage
            // 
            this.DisplayPage.BackgroundImage = global::HealthPharmacy.Properties.Resources.image2;
            this.DisplayPage.Controls.Add(this.SalesList);
            this.DisplayPage.Location = new System.Drawing.Point(4, 22);
            this.DisplayPage.Name = "DisplayPage";
            this.DisplayPage.Size = new System.Drawing.Size(539, 390);
            this.DisplayPage.TabIndex = 3;
            this.DisplayPage.Text = "Display Sale";
            this.DisplayPage.UseVisualStyleBackColor = true;
            // 
            // SalesList
            // 
            this.SalesList.FormattingEnabled = true;
            this.SalesList.Location = new System.Drawing.Point(30, 103);
            this.SalesList.Name = "SalesList";
            this.SalesList.Size = new System.Drawing.Size(278, 21);
            this.SalesList.TabIndex = 0;
            this.SalesList.SelectedIndexChanged += new System.EventHandler(this.SalesList_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HealthPharmacy.Properties.Resources.image2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(545, 419);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.Name = "Form2";
            this.Text = "HomePage";
            ((System.ComponentModel.ISupportInitialize)(this.productDatabaseDataSet1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.Salestab.ResumeLayout(false);
            this.AddTab.ResumeLayout(false);
            this.AddTab.PerformLayout();
            this.EditTab.ResumeLayout(false);
            this.EditTab.PerformLayout();
            this.DisplayPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ProductDatabaseDataSet productDatabaseDataSet1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Salestab;
        private System.Windows.Forms.TabPage AddTab;
        private System.Windows.Forms.TabPage EditTab;
        private System.Windows.Forms.Label Saleslabel;
        private System.Windows.Forms.Label Purchaselabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox SalesBox;
        private System.Windows.Forms.TextBox PurchaseBox;
        private System.Windows.Forms.TextBox CategoryBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Button AddSalesButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.TextBox SalesBox4;
        private System.Windows.Forms.TextBox PurchaseBox3;
        private System.Windows.Forms.TextBox CategoryBox2;
        private System.Windows.Forms.TextBox NameBox1;
        private System.Windows.Forms.TabPage DisplayPage;
        private System.Windows.Forms.ComboBox SalesList;
    }
}