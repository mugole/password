namespace HawthornPharmacy
{
    partial class ItemForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.AddPage = new System.Windows.Forms.TabPage();
            this.Editpage = new System.Windows.Forms.TabPage();
            this.DisplayPage = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AddName = new System.Windows.Forms.TextBox();
            this.AddCategory = new System.Windows.Forms.TextBox();
            this.AddQuantity = new System.Windows.Forms.TextBox();
            this.AddPurchase = new System.Windows.Forms.TextBox();
            this.AddSales = new System.Windows.Forms.TextBox();
            this.AddMaker = new System.Windows.Forms.TextBox();
            this.EditcomboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.EditName = new System.Windows.Forms.TextBox();
            this.EditCategory = new System.Windows.Forms.TextBox();
            this.EditQuantity = new System.Windows.Forms.TextBox();
            this.EditPurchase = new System.Windows.Forms.TextBox();
            this.EditMaker = new System.Windows.Forms.TextBox();
            this.EditSales = new System.Windows.Forms.TextBox();
            this.DisplaycomboBox = new System.Windows.Forms.ComboBox();
            this.Editbutton = new System.Windows.Forms.Button();
            this.Addbutton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.AddPage.SuspendLayout();
            this.Editpage.SuspendLayout();
            this.DisplayPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.AddPage);
            this.tabControl1.Controls.Add(this.Editpage);
            this.tabControl1.Controls.Add(this.DisplayPage);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(571, 410);
            this.tabControl1.TabIndex = 0;
            // 
            // AddPage
            // 
            this.AddPage.BackgroundImage = global::HawthornPharmacy.Properties.Resources.image1;
            this.AddPage.Controls.Add(this.Addbutton);
            this.AddPage.Controls.Add(this.AddMaker);
            this.AddPage.Controls.Add(this.AddSales);
            this.AddPage.Controls.Add(this.AddPurchase);
            this.AddPage.Controls.Add(this.AddQuantity);
            this.AddPage.Controls.Add(this.AddCategory);
            this.AddPage.Controls.Add(this.AddName);
            this.AddPage.Controls.Add(this.label6);
            this.AddPage.Controls.Add(this.label5);
            this.AddPage.Controls.Add(this.label4);
            this.AddPage.Controls.Add(this.label3);
            this.AddPage.Controls.Add(this.label2);
            this.AddPage.Controls.Add(this.label1);
            this.AddPage.Location = new System.Drawing.Point(4, 22);
            this.AddPage.Name = "AddPage";
            this.AddPage.Padding = new System.Windows.Forms.Padding(3);
            this.AddPage.Size = new System.Drawing.Size(563, 384);
            this.AddPage.TabIndex = 0;
            this.AddPage.Text = "Add Item";
            this.AddPage.UseVisualStyleBackColor = true;
            // 
            // Editpage
            // 
            this.Editpage.BackgroundImage = global::HawthornPharmacy.Properties.Resources.image1;
            this.Editpage.Controls.Add(this.Editbutton);
            this.Editpage.Controls.Add(this.EditSales);
            this.Editpage.Controls.Add(this.EditMaker);
            this.Editpage.Controls.Add(this.EditPurchase);
            this.Editpage.Controls.Add(this.EditQuantity);
            this.Editpage.Controls.Add(this.EditCategory);
            this.Editpage.Controls.Add(this.EditName);
            this.Editpage.Controls.Add(this.label12);
            this.Editpage.Controls.Add(this.label11);
            this.Editpage.Controls.Add(this.label10);
            this.Editpage.Controls.Add(this.label9);
            this.Editpage.Controls.Add(this.label8);
            this.Editpage.Controls.Add(this.label7);
            this.Editpage.Controls.Add(this.EditcomboBox);
            this.Editpage.Location = new System.Drawing.Point(4, 22);
            this.Editpage.Name = "Editpage";
            this.Editpage.Padding = new System.Windows.Forms.Padding(3);
            this.Editpage.Size = new System.Drawing.Size(563, 384);
            this.Editpage.TabIndex = 1;
            this.Editpage.Text = "Edit Item";
            this.Editpage.UseVisualStyleBackColor = true;
            // 
            // DisplayPage
            // 
            this.DisplayPage.BackgroundImage = global::HawthornPharmacy.Properties.Resources.image1;
            this.DisplayPage.Controls.Add(this.DisplaycomboBox);
            this.DisplayPage.Location = new System.Drawing.Point(4, 22);
            this.DisplayPage.Name = "DisplayPage";
            this.DisplayPage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DisplayPage.Size = new System.Drawing.Size(563, 384);
            this.DisplayPage.TabIndex = 2;
            this.DisplayPage.Text = "Display Item";
            this.DisplayPage.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Purchase Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sales Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Manufacturer";
            // 
            // AddName
            // 
            this.AddName.Location = new System.Drawing.Point(251, 101);
            this.AddName.Name = "AddName";
            this.AddName.Size = new System.Drawing.Size(100, 20);
            this.AddName.TabIndex = 6;
            // 
            // AddCategory
            // 
            this.AddCategory.Location = new System.Drawing.Point(251, 134);
            this.AddCategory.Name = "AddCategory";
            this.AddCategory.Size = new System.Drawing.Size(100, 20);
            this.AddCategory.TabIndex = 7;
            // 
            // AddQuantity
            // 
            this.AddQuantity.Location = new System.Drawing.Point(251, 167);
            this.AddQuantity.Name = "AddQuantity";
            this.AddQuantity.Size = new System.Drawing.Size(100, 20);
            this.AddQuantity.TabIndex = 8;
            // 
            // AddPurchase
            // 
            this.AddPurchase.Location = new System.Drawing.Point(251, 200);
            this.AddPurchase.Name = "AddPurchase";
            this.AddPurchase.Size = new System.Drawing.Size(100, 20);
            this.AddPurchase.TabIndex = 9;
            // 
            // AddSales
            // 
            this.AddSales.Location = new System.Drawing.Point(251, 237);
            this.AddSales.Name = "AddSales";
            this.AddSales.Size = new System.Drawing.Size(100, 20);
            this.AddSales.TabIndex = 10;
            // 
            // AddMaker
            // 
            this.AddMaker.Location = new System.Drawing.Point(251, 269);
            this.AddMaker.Name = "AddMaker";
            this.AddMaker.Size = new System.Drawing.Size(100, 20);
            this.AddMaker.TabIndex = 11;
            // 
            // EditcomboBox
            // 
            this.EditcomboBox.FormattingEnabled = true;
            this.EditcomboBox.Location = new System.Drawing.Point(101, 101);
            this.EditcomboBox.Name = "EditcomboBox";
            this.EditcomboBox.Size = new System.Drawing.Size(288, 21);
            this.EditcomboBox.TabIndex = 0;
            this.EditcomboBox.SelectedIndexChanged += new System.EventHandler(this.EditcomboBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(101, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(101, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Category";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(101, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Quantity";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(101, 230);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "PurchasePrice";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(101, 257);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Manufacturer";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(101, 282);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Sales Price";
            // 
            // EditName
            // 
            this.EditName.Location = new System.Drawing.Point(252, 141);
            this.EditName.Name = "EditName";
            this.EditName.Size = new System.Drawing.Size(100, 20);
            this.EditName.TabIndex = 7;
            // 
            // EditCategory
            // 
            this.EditCategory.Location = new System.Drawing.Point(252, 168);
            this.EditCategory.Name = "EditCategory";
            this.EditCategory.Size = new System.Drawing.Size(100, 20);
            this.EditCategory.TabIndex = 8;
            // 
            // EditQuantity
            // 
            this.EditQuantity.Location = new System.Drawing.Point(252, 195);
            this.EditQuantity.Name = "EditQuantity";
            this.EditQuantity.Size = new System.Drawing.Size(100, 20);
            this.EditQuantity.TabIndex = 9;
            // 
            // EditPurchase
            // 
            this.EditPurchase.Location = new System.Drawing.Point(252, 222);
            this.EditPurchase.Name = "EditPurchase";
            this.EditPurchase.Size = new System.Drawing.Size(100, 20);
            this.EditPurchase.TabIndex = 10;
            // 
            // EditMaker
            // 
            this.EditMaker.Location = new System.Drawing.Point(252, 249);
            this.EditMaker.Name = "EditMaker";
            this.EditMaker.Size = new System.Drawing.Size(100, 20);
            this.EditMaker.TabIndex = 11;
            // 
            // EditSales
            // 
            this.EditSales.Location = new System.Drawing.Point(252, 275);
            this.EditSales.Name = "EditSales";
            this.EditSales.Size = new System.Drawing.Size(100, 20);
            this.EditSales.TabIndex = 12;
            // 
            // DisplaycomboBox
            // 
            this.DisplaycomboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DisplaycomboBox.FormattingEnabled = true;
            this.DisplaycomboBox.Location = new System.Drawing.Point(94, 130);
            this.DisplaycomboBox.Name = "DisplaycomboBox";
            this.DisplaycomboBox.Size = new System.Drawing.Size(286, 21);
            this.DisplaycomboBox.TabIndex = 0;
            this.DisplaycomboBox.SelectedIndexChanged += new System.EventHandler(this.DisplaycomboBox_SelectedIndexChanged);
            // 
            // Editbutton
            // 
            this.Editbutton.Location = new System.Drawing.Point(385, 326);
            this.Editbutton.Name = "Editbutton";
            this.Editbutton.Size = new System.Drawing.Size(75, 23);
            this.Editbutton.TabIndex = 13;
            this.Editbutton.Text = "EDIT";
            this.Editbutton.UseVisualStyleBackColor = true;
            this.Editbutton.Click += new System.EventHandler(this.Editbutton_Click);
            // 
            // Addbutton
            // 
            this.Addbutton.Location = new System.Drawing.Point(395, 323);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(75, 23);
            this.Addbutton.TabIndex = 12;
            this.Addbutton.Text = "ADD";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HawthornPharmacy.Properties.Resources.image1;
            this.ClientSize = new System.Drawing.Size(559, 407);
            this.Controls.Add(this.tabControl1);
            this.Name = "ItemForm";
            this.Text = "ItemForm";
            this.Load += new System.EventHandler(this.ItemForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.AddPage.ResumeLayout(false);
            this.AddPage.PerformLayout();
            this.Editpage.ResumeLayout(false);
            this.Editpage.PerformLayout();
            this.DisplayPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage AddPage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage Editpage;
        private System.Windows.Forms.TabPage DisplayPage;
        private System.Windows.Forms.TextBox AddMaker;
        private System.Windows.Forms.TextBox AddSales;
        private System.Windows.Forms.TextBox AddPurchase;
        private System.Windows.Forms.TextBox AddQuantity;
        private System.Windows.Forms.TextBox AddCategory;
        private System.Windows.Forms.TextBox AddName;
        private System.Windows.Forms.TextBox EditSales;
        private System.Windows.Forms.TextBox EditMaker;
        private System.Windows.Forms.TextBox EditPurchase;
        private System.Windows.Forms.TextBox EditQuantity;
        private System.Windows.Forms.TextBox EditCategory;
        private System.Windows.Forms.TextBox EditName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox EditcomboBox;
        private System.Windows.Forms.ComboBox DisplaycomboBox;
        private System.Windows.Forms.Button Editbutton;
        private System.Windows.Forms.Button Addbutton;
    }
}