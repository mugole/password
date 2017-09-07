namespace HealthPharmacy
{
    partial class Pharmacy
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
            this.components = new System.ComponentModel.Container();
            this.productDatabaseDataSet = new HealthPharmacy.ProductDatabaseDataSet();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsTableAdapter = new HealthPharmacy.ProductDatabaseDataSetTableAdapters.ItemsTableAdapter();
            this.tableAdapterManager = new HealthPharmacy.ProductDatabaseDataSetTableAdapters.TableAdapterManager();
            this.LabelItems = new System.Windows.Forms.Label();
            this.listItems = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.productDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // productDatabaseDataSet
            // 
            this.productDatabaseDataSet.DataSetName = "ProductDatabaseDataSet";
            this.productDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.productDatabaseDataSet;
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ItemsTableAdapter = this.itemsTableAdapter;
            this.tableAdapterManager.SalesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HealthPharmacy.ProductDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // LabelItems
            // 
            this.LabelItems.AutoSize = true;
            this.LabelItems.Location = new System.Drawing.Point(22, 13);
            this.LabelItems.Name = "LabelItems";
            this.LabelItems.Size = new System.Drawing.Size(27, 13);
            this.LabelItems.TabIndex = 0;
            this.LabelItems.Text = "Item";
            // 
            // listItems
            // 
            this.listItems.FormattingEnabled = true;
            this.listItems.Location = new System.Drawing.Point(25, 30);
            this.listItems.Name = "listItems";
            this.listItems.Size = new System.Drawing.Size(108, 134);
            this.listItems.TabIndex = 1;
            this.listItems.SelectedIndexChanged += new System.EventHandler(this.listItems_SelectedIndexChanged);
            // 
            // Pharmacy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 353);
            this.Controls.Add(this.listItems);
            this.Controls.Add(this.LabelItems);
            this.Name = "Pharmacy";
            this.Text = "Pharmancy";
            this.Load += new System.EventHandler(this.Pharmacy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProductDatabaseDataSet productDatabaseDataSet;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private ProductDatabaseDataSetTableAdapters.ItemsTableAdapter itemsTableAdapter;
        private ProductDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label LabelItems;
        private System.Windows.Forms.ListBox listItems;
    }
}

