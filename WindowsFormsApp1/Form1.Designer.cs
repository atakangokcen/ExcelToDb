namespace WindowsFormsApp1
{
    partial class Form1
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
            this.Browse_Btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_fileName = new System.Windows.Forms.TextBox();
            this.Import_Btn = new System.Windows.Forms.Button();
            this.dapperPlusManagerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Con = new System.Windows.Forms.TextBox();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouseIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateProvinceIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shippingMethodIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderSubtotalFromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderSubtotalToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percentageRateOfSubtotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratePerWeightUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lowerWeightLimitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shippingByWeightByTotalRecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shippingByWeightBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shippingByWeightByTotalRecordBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.CountryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZoneId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WeightFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WeightTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.From = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.To = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.additionalFixedCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shippingMethodIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StoreId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dapperPlusManagerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippingByWeightByTotalRecordBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippingByWeightBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippingByWeightByTotalRecordBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Browse_Btn
            // 
            this.Browse_Btn.Location = new System.Drawing.Point(561, 529);
            this.Browse_Btn.Name = "Browse_Btn";
            this.Browse_Btn.Size = new System.Drawing.Size(54, 21);
            this.Browse_Btn.TabIndex = 0;
            this.Browse_Btn.Text = "Browse";
            this.Browse_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Browse_Btn.UseVisualStyleBackColor = true;
            this.Browse_Btn.Click += new System.EventHandler(this.Browse_Btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 513);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "File Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CountryId,
            this.ZoneId,
            this.WeightFrom,
            this.WeightTo,
            this.From,
            this.To,
            this.additionalFixedCostDataGridViewTextBoxColumn,
            this.shippingMethodIdDataGridViewTextBoxColumn1,
            this.StoreId});
            this.dataGridView1.DataSource = this.shippingByWeightByTotalRecordBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(603, 479);
            this.dataGridView1.TabIndex = 2;
            // 
            // textBox_fileName
            // 
            this.textBox_fileName.Location = new System.Drawing.Point(12, 529);
            this.textBox_fileName.Name = "textBox_fileName";
            this.textBox_fileName.Size = new System.Drawing.Size(543, 20);
            this.textBox_fileName.TabIndex = 4;
            // 
            // Import_Btn
            // 
            this.Import_Btn.Location = new System.Drawing.Point(466, 597);
            this.Import_Btn.Name = "Import_Btn";
            this.Import_Btn.Size = new System.Drawing.Size(75, 49);
            this.Import_Btn.TabIndex = 6;
            this.Import_Btn.Text = "Import to SQL";
            this.Import_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Import_Btn.UseVisualStyleBackColor = true;
            this.Import_Btn.Click += new System.EventHandler(this.Import_Btn_Click);
            // 
            // dapperPlusManagerBindingSource
            // 
            this.dapperPlusManagerBindingSource.DataSource = typeof(Z.Dapper.Plus.DapperPlusManager);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(-1, 670);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(628, 24);
            this.progressBar.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 581);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Connection String";
            // 
            // textBox_Con
            // 
            this.textBox_Con.Location = new System.Drawing.Point(15, 597);
            this.textBox_Con.Multiline = true;
            this.textBox_Con.Name = "textBox_Con";
            this.textBox_Con.Size = new System.Drawing.Size(445, 49);
            this.textBox_Con.TabIndex = 12;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // storeIdDataGridViewTextBoxColumn
            // 
            this.storeIdDataGridViewTextBoxColumn.DataPropertyName = "StoreId";
            this.storeIdDataGridViewTextBoxColumn.HeaderText = "StoreId";
            this.storeIdDataGridViewTextBoxColumn.Name = "storeIdDataGridViewTextBoxColumn";
            // 
            // warehouseIdDataGridViewTextBoxColumn
            // 
            this.warehouseIdDataGridViewTextBoxColumn.DataPropertyName = "WarehouseId";
            this.warehouseIdDataGridViewTextBoxColumn.HeaderText = "WarehouseId";
            this.warehouseIdDataGridViewTextBoxColumn.Name = "warehouseIdDataGridViewTextBoxColumn";
            // 
            // stateProvinceIdDataGridViewTextBoxColumn
            // 
            this.stateProvinceIdDataGridViewTextBoxColumn.DataPropertyName = "StateProvinceId";
            this.stateProvinceIdDataGridViewTextBoxColumn.HeaderText = "StateProvinceId";
            this.stateProvinceIdDataGridViewTextBoxColumn.Name = "stateProvinceIdDataGridViewTextBoxColumn";
            // 
            // zipDataGridViewTextBoxColumn
            // 
            this.zipDataGridViewTextBoxColumn.DataPropertyName = "Zip";
            this.zipDataGridViewTextBoxColumn.HeaderText = "Zip";
            this.zipDataGridViewTextBoxColumn.Name = "zipDataGridViewTextBoxColumn";
            // 
            // shippingMethodIdDataGridViewTextBoxColumn
            // 
            this.shippingMethodIdDataGridViewTextBoxColumn.DataPropertyName = "ShippingMethodId";
            this.shippingMethodIdDataGridViewTextBoxColumn.HeaderText = "ShippingMethodId";
            this.shippingMethodIdDataGridViewTextBoxColumn.Name = "shippingMethodIdDataGridViewTextBoxColumn";
            // 
            // orderSubtotalFromDataGridViewTextBoxColumn
            // 
            this.orderSubtotalFromDataGridViewTextBoxColumn.DataPropertyName = "OrderSubtotalFrom";
            this.orderSubtotalFromDataGridViewTextBoxColumn.HeaderText = "OrderSubtotalFrom";
            this.orderSubtotalFromDataGridViewTextBoxColumn.Name = "orderSubtotalFromDataGridViewTextBoxColumn";
            // 
            // orderSubtotalToDataGridViewTextBoxColumn
            // 
            this.orderSubtotalToDataGridViewTextBoxColumn.DataPropertyName = "OrderSubtotalTo";
            this.orderSubtotalToDataGridViewTextBoxColumn.HeaderText = "OrderSubtotalTo";
            this.orderSubtotalToDataGridViewTextBoxColumn.Name = "orderSubtotalToDataGridViewTextBoxColumn";
            // 
            // percentageRateOfSubtotalDataGridViewTextBoxColumn
            // 
            this.percentageRateOfSubtotalDataGridViewTextBoxColumn.DataPropertyName = "PercentageRateOfSubtotal";
            this.percentageRateOfSubtotalDataGridViewTextBoxColumn.HeaderText = "PercentageRateOfSubtotal";
            this.percentageRateOfSubtotalDataGridViewTextBoxColumn.Name = "percentageRateOfSubtotalDataGridViewTextBoxColumn";
            // 
            // ratePerWeightUnitDataGridViewTextBoxColumn
            // 
            this.ratePerWeightUnitDataGridViewTextBoxColumn.DataPropertyName = "RatePerWeightUnit";
            this.ratePerWeightUnitDataGridViewTextBoxColumn.HeaderText = "RatePerWeightUnit";
            this.ratePerWeightUnitDataGridViewTextBoxColumn.Name = "ratePerWeightUnitDataGridViewTextBoxColumn";
            // 
            // lowerWeightLimitDataGridViewTextBoxColumn
            // 
            this.lowerWeightLimitDataGridViewTextBoxColumn.DataPropertyName = "LowerWeightLimit";
            this.lowerWeightLimitDataGridViewTextBoxColumn.HeaderText = "LowerWeightLimit";
            this.lowerWeightLimitDataGridViewTextBoxColumn.Name = "lowerWeightLimitDataGridViewTextBoxColumn";
            // 
            // shippingByWeightByTotalRecordBindingSource
            // 
            this.shippingByWeightByTotalRecordBindingSource.DataSource = typeof(WindowsFormsApp1.ShippingByWeightByTotalRecord);
            // 
            // shippingByWeightBindingSource
            // 
            this.shippingByWeightBindingSource.DataSource = typeof(WindowsFormsApp1.ShippingByWeight);
            // 
            // shippingByWeightByTotalRecordBindingSource1
            // 
            this.shippingByWeightByTotalRecordBindingSource1.DataSource = typeof(WindowsFormsApp1.ShippingByWeightByTotalRecord);
            // 
            // CountryId
            // 
            this.CountryId.DataPropertyName = "CountryId";
            this.CountryId.HeaderText = "CountryId";
            this.CountryId.Name = "CountryId";
            // 
            // ZoneId
            // 
            this.ZoneId.DataPropertyName = "ZoneId";
            this.ZoneId.HeaderText = "ZoneId";
            this.ZoneId.Name = "ZoneId";
            // 
            // WeightFrom
            // 
            this.WeightFrom.DataPropertyName = "WeightFrom";
            this.WeightFrom.HeaderText = "WeightFrom";
            this.WeightFrom.Name = "WeightFrom";
            // 
            // WeightTo
            // 
            this.WeightTo.DataPropertyName = "WeightTo";
            this.WeightTo.HeaderText = "WeightTo";
            this.WeightTo.Name = "WeightTo";
            // 
            // From
            // 
            this.From.DataPropertyName = "From";
            this.From.HeaderText = "From";
            this.From.Name = "From";
            // 
            // To
            // 
            this.To.DataPropertyName = "To";
            this.To.HeaderText = "To";
            this.To.Name = "To";
            // 
            // additionalFixedCostDataGridViewTextBoxColumn
            // 
            this.additionalFixedCostDataGridViewTextBoxColumn.DataPropertyName = "AdditionalFixedCost";
            this.additionalFixedCostDataGridViewTextBoxColumn.HeaderText = "AdditionalFixedCost";
            this.additionalFixedCostDataGridViewTextBoxColumn.Name = "additionalFixedCostDataGridViewTextBoxColumn";
            // 
            // shippingMethodIdDataGridViewTextBoxColumn1
            // 
            this.shippingMethodIdDataGridViewTextBoxColumn1.DataPropertyName = "ShippingMethodId";
            this.shippingMethodIdDataGridViewTextBoxColumn1.HeaderText = "ShippingMethodId";
            this.shippingMethodIdDataGridViewTextBoxColumn1.Name = "shippingMethodIdDataGridViewTextBoxColumn1";
            // 
            // StoreId
            // 
            this.StoreId.DataPropertyName = "StoreId";
            this.StoreId.HeaderText = "StoreId";
            this.StoreId.Name = "StoreId";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 691);
            this.Controls.Add(this.textBox_Con);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.Import_Btn);
            this.Controls.Add(this.textBox_fileName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Browse_Btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dapperPlusManagerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippingByWeightByTotalRecordBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippingByWeightBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippingByWeightByTotalRecordBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Browse_Btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_fileName;
        private System.Windows.Forms.Button Import_Btn;
        private System.Windows.Forms.BindingSource shippingByWeightByTotalRecordBindingSource;
        private System.Windows.Forms.BindingSource dapperPlusManagerBindingSource;
        private System.Windows.Forms.BindingSource shippingByWeightByTotalRecordBindingSource1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Con;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn warehouseIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateProvinceIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shippingMethodIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderSubtotalFromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderSubtotalToDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentageRateOfSubtotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratePerWeightUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lowerWeightLimitDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource shippingByWeightBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZoneId;
        private System.Windows.Forms.DataGridViewTextBoxColumn WeightFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn WeightTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn From;
        private System.Windows.Forms.DataGridViewTextBoxColumn To;
        private System.Windows.Forms.DataGridViewTextBoxColumn additionalFixedCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shippingMethodIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreId;
    }
}

