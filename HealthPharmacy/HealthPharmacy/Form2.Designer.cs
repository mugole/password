namespace HealthPharmacy
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.productDatabaseDataSet1 = new HealthPharmacy.ProductDatabaseDataSet();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Salestab = new System.Windows.Forms.TabPage();
            this.MonthReportbutton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.AddTab = new System.Windows.Forms.TabPage();
            this.SalesBox = new System.Windows.Forms.TextBox();
            this.PurchaseBox = new System.Windows.Forms.TextBox();
            this.CategoryBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.AddSalesButton = new System.Windows.Forms.Button();
            this.Namelabel = new System.Windows.Forms.Label();
            this.Saleslabel = new System.Windows.Forms.Label();
            this.Purchaselabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EditTab = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EditSalesBox = new System.Windows.Forms.TextBox();
            this.EditPurchaseBox = new System.Windows.Forms.TextBox();
            this.EditCategoryBox = new System.Windows.Forms.TextBox();
            this.EditNameBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.EditButton = new System.Windows.Forms.Button();
            this.DisplayPage = new System.Windows.Forms.TabPage();
            this.SalesList = new System.Windows.Forms.ComboBox();
            this.productDatabaseDataSet2 = new HealthPharmacy.ProductDatabaseDataSet();
            this.productDatabaseDataSet3 = new HealthPharmacy.ProductDatabaseDataSet();
            this.SalesReport = new System.Windows.Forms.TabPage();
            this.Viewbutton = new System.Windows.Forms.Button();
            this.MonthlyView = new System.Windows.Forms.DataGridView();
            this.NameItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WeekReport = new System.Windows.Forms.TabPage();
            this.WeekView = new System.Windows.Forms.DataGridView();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.View2button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productDatabaseDataSet1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.Salestab.SuspendLayout();
            this.AddTab.SuspendLayout();
            this.EditTab.SuspendLayout();
            this.DisplayPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDatabaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDatabaseDataSet3)).BeginInit();
            this.SalesReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MonthlyView)).BeginInit();
            this.WeekReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WeekView)).BeginInit();
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
            this.tabControl1.Controls.Add(this.SalesReport);
            this.tabControl1.Controls.Add(this.WeekReport);
            this.tabControl1.Location = new System.Drawing.Point(-1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(547, 416);
            this.tabControl1.TabIndex = 0;
            // 
            // Salestab
            // 
            this.Salestab.BackColor = System.Drawing.Color.Transparent;
            this.Salestab.BackgroundImage = global::HealthPharmacy.Properties.Resources.image2;
            this.Salestab.Controls.Add(this.MonthReportbutton);
            this.Salestab.Controls.Add(this.button2);
            this.Salestab.Controls.Add(this.button1);
            this.Salestab.Location = new System.Drawing.Point(4, 22);
            this.Salestab.Name = "Salestab";
            this.Salestab.Padding = new System.Windows.Forms.Padding(3);
            this.Salestab.Size = new System.Drawing.Size(539, 390);
            this.Salestab.TabIndex = 0;
            this.Salestab.Text = "Sales";
            this.Salestab.Click += new System.EventHandler(this.Salestab_Click);
            // 
            // MonthReportbutton
            // 
            this.MonthReportbutton.BackColor = System.Drawing.SystemColors.Highlight;
            this.MonthReportbutton.Font = new System.Drawing.Font("Book Antiqua", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthReportbutton.Location = new System.Drawing.Point(183, 322);
            this.MonthReportbutton.Name = "MonthReportbutton";
            this.MonthReportbutton.Size = new System.Drawing.Size(165, 35);
            this.MonthReportbutton.TabIndex = 2;
            this.MonthReportbutton.Text = "Monthly Sales Report";
            this.MonthReportbutton.UseVisualStyleBackColor = false;
            this.MonthReportbutton.Click += new System.EventHandler(this.MonthReportbutton_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.Font = new System.Drawing.Font("Book Antiqua", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(9, 322);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 38);
            this.button2.TabIndex = 1;
            this.button2.Text = "Weekly Sales Report";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Font = new System.Drawing.Font("Book Antiqua", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(354, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Manage Sales Record";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // AddTab
            // 
            this.AddTab.BackgroundImage = global::HealthPharmacy.Properties.Resources.image2;
            this.AddTab.Controls.Add(this.SalesBox);
            this.AddTab.Controls.Add(this.PurchaseBox);
            this.AddTab.Controls.Add(this.CategoryBox);
            this.AddTab.Controls.Add(this.NameBox);
            this.AddTab.Controls.Add(this.AddSalesButton);
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
            // SalesBox
            // 
            this.SalesBox.Location = new System.Drawing.Point(292, 239);
            this.SalesBox.Name = "SalesBox";
            this.SalesBox.Size = new System.Drawing.Size(100, 20);
            this.SalesBox.TabIndex = 14;
            // 
            // PurchaseBox
            // 
            this.PurchaseBox.Location = new System.Drawing.Point(292, 201);
            this.PurchaseBox.Name = "PurchaseBox";
            this.PurchaseBox.Size = new System.Drawing.Size(100, 20);
            this.PurchaseBox.TabIndex = 13;
            // 
            // CategoryBox
            // 
            this.CategoryBox.Location = new System.Drawing.Point(292, 155);
            this.CategoryBox.Name = "CategoryBox";
            this.CategoryBox.Size = new System.Drawing.Size(100, 20);
            this.CategoryBox.TabIndex = 12;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(292, 116);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(100, 20);
            this.NameBox.TabIndex = 11;
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
            this.EditTab.Controls.Add(this.label5);
            this.EditTab.Controls.Add(this.label4);
            this.EditTab.Controls.Add(this.label3);
            this.EditTab.Controls.Add(this.label1);
            this.EditTab.Controls.Add(this.EditSalesBox);
            this.EditTab.Controls.Add(this.EditPurchaseBox);
            this.EditTab.Controls.Add(this.EditCategoryBox);
            this.EditTab.Controls.Add(this.EditNameBox);
            this.EditTab.Controls.Add(this.comboBox1);
            this.EditTab.Controls.Add(this.EditButton);
            this.EditTab.Location = new System.Drawing.Point(4, 22);
            this.EditTab.Name = "EditTab";
            this.EditTab.Size = new System.Drawing.Size(539, 390);
            this.EditTab.TabIndex = 2;
            this.EditTab.Text = "Edit Sales";
            this.EditTab.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(81, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Sales Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Purchase Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name";
            // 
            // EditSalesBox
            // 
            this.EditSalesBox.Location = new System.Drawing.Point(221, 304);
            this.EditSalesBox.Name = "EditSalesBox";
            this.EditSalesBox.Size = new System.Drawing.Size(100, 20);
            this.EditSalesBox.TabIndex = 9;
            // 
            // EditPurchaseBox
            // 
            this.EditPurchaseBox.Location = new System.Drawing.Point(221, 254);
            this.EditPurchaseBox.Name = "EditPurchaseBox";
            this.EditPurchaseBox.Size = new System.Drawing.Size(100, 20);
            this.EditPurchaseBox.TabIndex = 8;
            // 
            // EditCategoryBox
            // 
            this.EditCategoryBox.Location = new System.Drawing.Point(221, 202);
            this.EditCategoryBox.Name = "EditCategoryBox";
            this.EditCategoryBox.Size = new System.Drawing.Size(100, 20);
            this.EditCategoryBox.TabIndex = 7;
            // 
            // EditNameBox
            // 
            this.EditNameBox.Location = new System.Drawing.Point(221, 155);
            this.EditNameBox.Name = "EditNameBox";
            this.EditNameBox.Size = new System.Drawing.Size(100, 20);
            this.EditNameBox.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(35, 100);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(271, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.EditButton.Font = new System.Drawing.Font("Book Antiqua", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.Location = new System.Drawing.Point(403, 323);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 34);
            this.EditButton.TabIndex = 4;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
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
            this.SalesList.Location = new System.Drawing.Point(119, 106);
            this.SalesList.Name = "SalesList";
            this.SalesList.Size = new System.Drawing.Size(278, 21);
            this.SalesList.TabIndex = 0;
            this.SalesList.SelectedIndexChanged += new System.EventHandler(this.SalesList_SelectedIndexChanged);
            // 
            // productDatabaseDataSet2
            // 
            this.productDatabaseDataSet2.DataSetName = "ProductDatabaseDataSet";
            this.productDatabaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productDatabaseDataSet3
            // 
            this.productDatabaseDataSet3.DataSetName = "ProductDatabaseDataSet";
            this.productDatabaseDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SalesReport
            // 
            this.SalesReport.BackColor = System.Drawing.Color.White;
            this.SalesReport.BackgroundImage = global::HealthPharmacy.Properties.Resources.image2;
            this.SalesReport.Controls.Add(this.MonthlyView);
            this.SalesReport.Controls.Add(this.Viewbutton);
            this.SalesReport.Font = new System.Drawing.Font("Book Antiqua", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesReport.Location = new System.Drawing.Point(4, 22);
            this.SalesReport.Name = "SalesReport";
            this.SalesReport.Size = new System.Drawing.Size(539, 390);
            this.SalesReport.TabIndex = 4;
            this.SalesReport.Text = "MonthlySalesReport";
            // 
            // Viewbutton
            // 
            this.Viewbutton.BackColor = System.Drawing.SystemColors.Highlight;
            this.Viewbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Viewbutton.Font = new System.Drawing.Font("Book Antiqua", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Viewbutton.Location = new System.Drawing.Point(429, 354);
            this.Viewbutton.Name = "Viewbutton";
            this.Viewbutton.Size = new System.Drawing.Size(81, 30);
            this.Viewbutton.TabIndex = 0;
            this.Viewbutton.Text = "View";
            this.Viewbutton.UseVisualStyleBackColor = false;
            this.Viewbutton.Click += new System.EventHandler(this.Viewbutton_Click);
            // 
            // MonthlyView
            // 
            this.MonthlyView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MonthlyView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MonthlyView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameItem,
            this.Category,
            this.Quantity,
            this.PurchasePrice});
            this.MonthlyView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MonthlyView.Location = new System.Drawing.Point(33, 81);
            this.MonthlyView.Name = "MonthlyView";
            this.MonthlyView.Size = new System.Drawing.Size(447, 267);
            this.MonthlyView.TabIndex = 1;
            // 
            // NameItem
            // 
            this.NameItem.HeaderText = "Name";
            this.NameItem.Name = "NameItem";
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // PurchasePrice
            // 
            this.PurchasePrice.HeaderText = "Purchase Price";
            this.PurchasePrice.Name = "PurchasePrice";
            // 
            // WeekReport
            // 
            this.WeekReport.BackgroundImage = global::HealthPharmacy.Properties.Resources.image2;
            this.WeekReport.Controls.Add(this.View2button);
            this.WeekReport.Controls.Add(this.WeekView);
            this.WeekReport.Location = new System.Drawing.Point(4, 22);
            this.WeekReport.Name = "WeekReport";
            this.WeekReport.Size = new System.Drawing.Size(539, 390);
            this.WeekReport.TabIndex = 5;
            this.WeekReport.Text = "Weekly Report";
            this.WeekReport.UseVisualStyleBackColor = true;
            // 
            // WeekView
            // 
            this.WeekView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Book Antiqua", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.WeekView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.WeekView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WeekView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemName,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.WeekView.Location = new System.Drawing.Point(37, 83);
            this.WeekView.Name = "WeekView";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Book Antiqua", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.WeekView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.WeekView.Size = new System.Drawing.Size(449, 262);
            this.WeekView.TabIndex = 0;
            this.WeekView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.WeekView_CellContentClick);
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "Name";
            this.ItemName.Name = "ItemName";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Category";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Purchase Price";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // View2button
            // 
            this.View2button.BackColor = System.Drawing.SystemColors.Highlight;
            this.View2button.Font = new System.Drawing.Font("Book Antiqua", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View2button.Location = new System.Drawing.Point(445, 351);
            this.View2button.Name = "View2button";
            this.View2button.Size = new System.Drawing.Size(65, 33);
            this.View2button.TabIndex = 1;
            this.View2button.Text = "View";
            this.View2button.UseVisualStyleBackColor = false;
            this.View2button.Click += new System.EventHandler(this.View2button_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.productDatabaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDatabaseDataSet3)).EndInit();
            this.SalesReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MonthlyView)).EndInit();
            this.WeekReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WeekView)).EndInit();
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
        private System.Windows.Forms.Button MonthReportbutton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AddSalesButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.TabPage DisplayPage;
        private System.Windows.Forms.ComboBox SalesList;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EditSalesBox;
        private System.Windows.Forms.TextBox EditPurchaseBox;
        private System.Windows.Forms.TextBox EditCategoryBox;
        private System.Windows.Forms.TextBox EditNameBox;
        private ProductDatabaseDataSet productDatabaseDataSet2;
        private ProductDatabaseDataSet productDatabaseDataSet3;
        private System.Windows.Forms.TextBox SalesBox;
        private System.Windows.Forms.TextBox PurchaseBox;
        private System.Windows.Forms.TextBox CategoryBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TabPage SalesReport;
        private System.Windows.Forms.DataGridView MonthlyView;
        private System.Windows.Forms.Button Viewbutton;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchasePrice;
        private System.Windows.Forms.TabPage WeekReport;
        private System.Windows.Forms.DataGridView WeekView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button View2button;
    }
}