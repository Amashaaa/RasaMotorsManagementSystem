﻿namespace RasaMotorsManagementSystem.Finance
{
    partial class financialView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvFinancial = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.serviceCenterManagementDBDataSet = new RasaMotorsManagementSystem.ServiceCenterManagementDBDataSet();
            this.tblProfitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_ProfitTableAdapter = new RasaMotorsManagementSystem.ServiceCenterManagementDBDataSetTableAdapters.tbl_ProfitTableAdapter();
            this.customerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invenSalesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invenPayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utilityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netProfitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceCenterManagementDBDataSet1 = new RasaMotorsManagementSystem.ServiceCenterManagementDBDataSet1();
            this.tblProfitBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_ProfitTableAdapter1 = new RasaMotorsManagementSystem.ServiceCenterManagementDBDataSet1TableAdapters.tbl_ProfitTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinancial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceCenterManagementDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProfitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceCenterManagementDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProfitBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Location = new System.Drawing.Point(-4, 224);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1595, 25);
            this.panel1.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(655, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 55);
            this.label1.TabIndex = 66;
            this.label1.Text = "Financial View";
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.Maroon;
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Location = new System.Drawing.Point(1282, 897);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(162, 76);
            this.btnReport.TabIndex = 65;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Maroon;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(338, 897);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(159, 76);
            this.btnBack.TabIndex = 64;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgvFinancial
            // 
            this.dgvFinancial.AutoGenerateColumns = false;
            this.dgvFinancial.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvFinancial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFinancial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIdDataGridViewTextBoxColumn,
            this.incomeDataGridViewTextBoxColumn,
            this.invenSalesDataGridViewTextBoxColumn,
            this.ordersDataGridViewTextBoxColumn,
            this.invenPayDataGridViewTextBoxColumn,
            this.utilityDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn,
            this.netProfitDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dgvFinancial.DataSource = this.tblProfitBindingSource1;
            this.dgvFinancial.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvFinancial.Location = new System.Drawing.Point(167, 310);
            this.dgvFinancial.Name = "dgvFinancial";
            this.dgvFinancial.RowTemplate.Height = 24;
            this.dgvFinancial.Size = new System.Drawing.Size(1406, 419);
            this.dgvFinancial.TabIndex = 62;
            this.dgvFinancial.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvFinancial_CellMouseDoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RasaMotorsManagementSystem.Properties.Resources.Rasa_Motors_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(459, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // serviceCenterManagementDBDataSet
            // 
            this.serviceCenterManagementDBDataSet.DataSetName = "ServiceCenterManagementDBDataSet";
            this.serviceCenterManagementDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblProfitBindingSource
            // 
            this.tblProfitBindingSource.DataMember = "tbl_Profit";
            this.tblProfitBindingSource.DataSource = this.serviceCenterManagementDBDataSet;
            // 
            // tbl_ProfitTableAdapter
            // 
            this.tbl_ProfitTableAdapter.ClearBeforeFill = true;
            // 
            // customerIdDataGridViewTextBoxColumn
            // 
            this.customerIdDataGridViewTextBoxColumn.DataPropertyName = "CustomerId";
            this.customerIdDataGridViewTextBoxColumn.HeaderText = "CustomerId";
            this.customerIdDataGridViewTextBoxColumn.Name = "customerIdDataGridViewTextBoxColumn";
            this.customerIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // incomeDataGridViewTextBoxColumn
            // 
            this.incomeDataGridViewTextBoxColumn.DataPropertyName = "Income";
            this.incomeDataGridViewTextBoxColumn.HeaderText = "Income";
            this.incomeDataGridViewTextBoxColumn.Name = "incomeDataGridViewTextBoxColumn";
            // 
            // invenSalesDataGridViewTextBoxColumn
            // 
            this.invenSalesDataGridViewTextBoxColumn.DataPropertyName = "InvenSales";
            this.invenSalesDataGridViewTextBoxColumn.HeaderText = "InvenSales";
            this.invenSalesDataGridViewTextBoxColumn.Name = "invenSalesDataGridViewTextBoxColumn";
            // 
            // ordersDataGridViewTextBoxColumn
            // 
            this.ordersDataGridViewTextBoxColumn.DataPropertyName = "Orders";
            this.ordersDataGridViewTextBoxColumn.HeaderText = "Orders";
            this.ordersDataGridViewTextBoxColumn.Name = "ordersDataGridViewTextBoxColumn";
            // 
            // invenPayDataGridViewTextBoxColumn
            // 
            this.invenPayDataGridViewTextBoxColumn.DataPropertyName = "InvenPay";
            this.invenPayDataGridViewTextBoxColumn.HeaderText = "InvenPay";
            this.invenPayDataGridViewTextBoxColumn.Name = "invenPayDataGridViewTextBoxColumn";
            // 
            // utilityDataGridViewTextBoxColumn
            // 
            this.utilityDataGridViewTextBoxColumn.DataPropertyName = "Utility";
            this.utilityDataGridViewTextBoxColumn.HeaderText = "Utility";
            this.utilityDataGridViewTextBoxColumn.Name = "utilityDataGridViewTextBoxColumn";
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "Salary";
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            // 
            // netProfitDataGridViewTextBoxColumn
            // 
            this.netProfitDataGridViewTextBoxColumn.DataPropertyName = "NetProfit";
            this.netProfitDataGridViewTextBoxColumn.HeaderText = "NetProfit";
            this.netProfitDataGridViewTextBoxColumn.Name = "netProfitDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // serviceCenterManagementDBDataSet1
            // 
            this.serviceCenterManagementDBDataSet1.DataSetName = "ServiceCenterManagementDBDataSet1";
            this.serviceCenterManagementDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblProfitBindingSource1
            // 
            this.tblProfitBindingSource1.DataMember = "tbl_Profit";
            this.tblProfitBindingSource1.DataSource = this.serviceCenterManagementDBDataSet1;
            // 
            // tbl_ProfitTableAdapter1
            // 
            this.tbl_ProfitTableAdapter1.ClearBeforeFill = true;
            // 
            // financialView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(1586, 992);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvFinancial);
            this.Name = "financialView";
            this.Text = "financialView";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.financialView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinancial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceCenterManagementDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProfitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceCenterManagementDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProfitBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.DataGridView dgvFinancial;
        private ServiceCenterManagementDBDataSet serviceCenterManagementDBDataSet;
        private System.Windows.Forms.BindingSource tblProfitBindingSource;
        private ServiceCenterManagementDBDataSetTableAdapters.tbl_ProfitTableAdapter tbl_ProfitTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invenSalesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invenPayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn utilityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn netProfitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private ServiceCenterManagementDBDataSet1 serviceCenterManagementDBDataSet1;
        private System.Windows.Forms.BindingSource tblProfitBindingSource1;
        private ServiceCenterManagementDBDataSet1TableAdapters.tbl_ProfitTableAdapter tbl_ProfitTableAdapter1;
    }
}