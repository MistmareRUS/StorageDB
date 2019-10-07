namespace StorageProject
{
    partial class MainForm
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
            this.dataGridViewStorages = new System.Windows.Forms.DataGridView();
            this.productBtn = new System.Windows.Forms.Button();
            this.employeesBtn = new System.Windows.Forms.Button();
            this.rolesBtn = new System.Windows.Forms.Button();
            this.departmensBtn = new System.Windows.Forms.Button();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.AddStorageItem_btn = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storageItemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DeleteStorageItem_btn = new System.Windows.Forms.Button();
            this.AddStorage_btn = new System.Windows.Forms.Button();
            this.DeleteStorage_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStorages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageItemBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStorages
            // 
            this.dataGridViewStorages.AllowUserToAddRows = false;
            this.dataGridViewStorages.AllowUserToDeleteRows = false;
            this.dataGridViewStorages.AutoGenerateColumns = false;
            this.dataGridViewStorages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStorages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridViewStorages.DataSource = this.storageBindingSource;
            this.dataGridViewStorages.Location = new System.Drawing.Point(13, 13);
            this.dataGridViewStorages.Name = "dataGridViewStorages";
            this.dataGridViewStorages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStorages.Size = new System.Drawing.Size(515, 508);
            this.dataGridViewStorages.TabIndex = 0;
            this.dataGridViewStorages.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStorages_CellClick);
            // 
            // productBtn
            // 
            this.productBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.productBtn.Location = new System.Drawing.Point(12, 620);
            this.productBtn.Name = "productBtn";
            this.productBtn.Size = new System.Drawing.Size(75, 23);
            this.productBtn.TabIndex = 3;
            this.productBtn.Text = "Товары";
            this.productBtn.UseVisualStyleBackColor = true;
            // 
            // employeesBtn
            // 
            this.employeesBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.employeesBtn.Location = new System.Drawing.Point(93, 620);
            this.employeesBtn.Name = "employeesBtn";
            this.employeesBtn.Size = new System.Drawing.Size(75, 23);
            this.employeesBtn.TabIndex = 4;
            this.employeesBtn.Text = "Сотрудники";
            this.employeesBtn.UseVisualStyleBackColor = true;
            // 
            // rolesBtn
            // 
            this.rolesBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rolesBtn.Location = new System.Drawing.Point(174, 620);
            this.rolesBtn.Name = "rolesBtn";
            this.rolesBtn.Size = new System.Drawing.Size(75, 23);
            this.rolesBtn.TabIndex = 5;
            this.rolesBtn.Text = "Роли";
            this.rolesBtn.UseVisualStyleBackColor = true;
            // 
            // departmensBtn
            // 
            this.departmensBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.departmensBtn.Location = new System.Drawing.Point(255, 620);
            this.departmensBtn.Name = "departmensBtn";
            this.departmensBtn.Size = new System.Drawing.Size(75, 23);
            this.departmensBtn.TabIndex = 6;
            this.departmensBtn.Text = "Отделы";
            this.departmensBtn.UseVisualStyleBackColor = true;
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.AllowUserToAddRows = false;
            this.dataGridViewProducts.AllowUserToDeleteRows = false;
            this.dataGridViewProducts.AutoGenerateColumns = false;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.unitsDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.dataGridViewProducts.DataSource = this.storageItemBindingSource1;
            this.dataGridViewProducts.Location = new System.Drawing.Point(535, 13);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.Size = new System.Drawing.Size(682, 508);
            this.dataGridViewProducts.TabIndex = 7;
            // 
            // AddStorageItem_btn
            // 
            this.AddStorageItem_btn.Location = new System.Drawing.Point(1141, 528);
            this.AddStorageItem_btn.Name = "AddStorageItem_btn";
            this.AddStorageItem_btn.Size = new System.Drawing.Size(75, 23);
            this.AddStorageItem_btn.TabIndex = 8;
            this.AddStorageItem_btn.Text = "Добавить";
            this.AddStorageItem_btn.UseVisualStyleBackColor = true;
            this.AddStorageItem_btn.Click += new System.EventHandler(this.AddStorageItem_btn_Click);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn6.HeaderText = "Id";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn7.HeaderText = "Name";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Count";
            this.dataGridViewTextBoxColumn8.HeaderText = "Count";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // unitsDataGridViewTextBoxColumn
            // 
            this.unitsDataGridViewTextBoxColumn.DataPropertyName = "Units";
            this.unitsDataGridViewTextBoxColumn.HeaderText = "Units";
            this.unitsDataGridViewTextBoxColumn.Name = "unitsDataGridViewTextBoxColumn";
            this.unitsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Comment";
            this.dataGridViewTextBoxColumn9.HeaderText = "Comment";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "ProductId";
            this.dataGridViewTextBoxColumn10.HeaderText = "ProductId";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Product";
            this.dataGridViewTextBoxColumn11.HeaderText = "Product";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Visible = false;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "StorageId";
            this.dataGridViewTextBoxColumn12.HeaderText = "StorageId";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Visible = false;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Storage";
            this.dataGridViewTextBoxColumn13.HeaderText = "Storage";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Visible = false;
            // 
            // storageItemBindingSource1
            // 
            this.storageItemBindingSource1.DataSource = typeof(StorageProject.Model.StorageItem);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Location";
            this.dataGridViewTextBoxColumn3.HeaderText = "Location";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Area";
            this.dataGridViewTextBoxColumn4.HeaderText = "Area";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // storageBindingSource
            // 
            this.storageBindingSource.DataSource = typeof(StorageProject.Model.Storage);
            // 
            // DeleteStorageItem_btn
            // 
            this.DeleteStorageItem_btn.Location = new System.Drawing.Point(1060, 527);
            this.DeleteStorageItem_btn.Name = "DeleteStorageItem_btn";
            this.DeleteStorageItem_btn.Size = new System.Drawing.Size(75, 23);
            this.DeleteStorageItem_btn.TabIndex = 9;
            this.DeleteStorageItem_btn.Text = "Удалить";
            this.DeleteStorageItem_btn.UseVisualStyleBackColor = true;
            this.DeleteStorageItem_btn.Click += new System.EventHandler(this.DeleteStorageItem_btn_Click);
            // 
            // AddStorage_btn
            // 
            this.AddStorage_btn.Location = new System.Drawing.Point(452, 528);
            this.AddStorage_btn.Name = "AddStorage_btn";
            this.AddStorage_btn.Size = new System.Drawing.Size(75, 23);
            this.AddStorage_btn.TabIndex = 10;
            this.AddStorage_btn.Text = "Добавить";
            this.AddStorage_btn.UseVisualStyleBackColor = true;
            this.AddStorage_btn.Click += new System.EventHandler(this.AddStorage_btn_Click);
            // 
            // DeleteStorage_btn
            // 
            this.DeleteStorage_btn.Location = new System.Drawing.Point(371, 528);
            this.DeleteStorage_btn.Name = "DeleteStorage_btn";
            this.DeleteStorage_btn.Size = new System.Drawing.Size(75, 23);
            this.DeleteStorage_btn.TabIndex = 11;
            this.DeleteStorage_btn.Text = "Удалить";
            this.DeleteStorage_btn.UseVisualStyleBackColor = true;
            this.DeleteStorage_btn.Click += new System.EventHandler(this.DeleteStorage_btn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 655);
            this.Controls.Add(this.DeleteStorage_btn);
            this.Controls.Add(this.AddStorage_btn);
            this.Controls.Add(this.DeleteStorageItem_btn);
            this.Controls.Add(this.AddStorageItem_btn);
            this.Controls.Add(this.dataGridViewProducts);
            this.Controls.Add(this.departmensBtn);
            this.Controls.Add(this.rolesBtn);
            this.Controls.Add(this.employeesBtn);
            this.Controls.Add(this.productBtn);
            this.Controls.Add(this.dataGridViewStorages);
            this.Name = "MainForm";
            this.Text = "Текущие склады";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStorages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageItemBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStorages;
        private System.Windows.Forms.Button productBtn;
        private System.Windows.Forms.Button employeesBtn;
        private System.Windows.Forms.Button rolesBtn;
        private System.Windows.Forms.Button departmensBtn;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storageIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storageDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource storageBindingSource;
        private System.Windows.Forms.BindingSource storageItemBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button AddStorageItem_btn;
        private System.Windows.Forms.Button DeleteStorageItem_btn;
        private System.Windows.Forms.Button AddStorage_btn;
        private System.Windows.Forms.Button DeleteStorage_btn;
    }
}