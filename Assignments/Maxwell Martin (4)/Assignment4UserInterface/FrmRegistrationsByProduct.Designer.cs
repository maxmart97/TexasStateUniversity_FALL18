﻿namespace Assignment4UserInterface
{
    partial class FrmRegistrationsByProduct
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.ssFrmRegistrationsByProduct = new System.Windows.Forms.StatusStrip();
            this.tsslProjectAndDesignerName = new System.Windows.Forms.ToolStripStatusLabel();
            this.bsProduct = new System.Windows.Forms.BindingSource(this.components);
            this.bsCustomerRegistration = new System.Windows.Forms.BindingSource(this.components);
            this.dgvCustomerRegistration = new System.Windows.Forms.DataGridView();
            this.dgvColCustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColRegistrationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboProduct = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.ssFrmRegistrationsByProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomerRegistration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerRegistration)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInstructions
            // 
            this.lblInstructions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(148, 71);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(176, 25);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = "Select a product:";
            // 
            // ssFrmRegistrationsByProduct
            // 
            this.ssFrmRegistrationsByProduct.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssFrmRegistrationsByProduct.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslProjectAndDesignerName});
            this.ssFrmRegistrationsByProduct.Location = new System.Drawing.Point(0, 613);
            this.ssFrmRegistrationsByProduct.Name = "ssFrmRegistrationsByProduct";
            this.ssFrmRegistrationsByProduct.Size = new System.Drawing.Size(881, 25);
            this.ssFrmRegistrationsByProduct.TabIndex = 2;
            this.ssFrmRegistrationsByProduct.Text = "statusStrip1";
            // 
            // tsslProjectAndDesignerName
            // 
            this.tsslProjectAndDesignerName.Name = "tsslProjectAndDesignerName";
            this.tsslProjectAndDesignerName.Size = new System.Drawing.Size(301, 20);
            this.tsslProjectAndDesignerName.Text = "Assignment 4 - Designed by Maxwell Martin";
            // 
            // bsProduct
            // 
            this.bsProduct.DataSource = typeof(Assignment4BusinessClassLibrary.Product);
            // 
            // bsCustomerRegistration
            // 
            this.bsCustomerRegistration.DataSource = typeof(Assignment4BusinessClassLibrary.CustomerRegistration);
            // 
            // dgvCustomerRegistration
            // 
            this.dgvCustomerRegistration.AllowUserToAddRows = false;
            this.dgvCustomerRegistration.AllowUserToDeleteRows = false;
            this.dgvCustomerRegistration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCustomerRegistration.AutoGenerateColumns = false;
            this.dgvCustomerRegistration.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomerRegistration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerRegistration.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColCustomerID,
            this.dgvColName,
            this.dgvColEmail,
            this.dgvColRegistrationDate});
            this.dgvCustomerRegistration.DataSource = this.bsCustomerRegistration;
            this.dgvCustomerRegistration.Location = new System.Drawing.Point(12, 162);
            this.dgvCustomerRegistration.Name = "dgvCustomerRegistration";
            this.dgvCustomerRegistration.ReadOnly = true;
            this.dgvCustomerRegistration.RowTemplate.Height = 24;
            this.dgvCustomerRegistration.Size = new System.Drawing.Size(857, 331);
            this.dgvCustomerRegistration.TabIndex = 1;
            // 
            // dgvColCustomerID
            // 
            this.dgvColCustomerID.DataPropertyName = "CustomerID";
            this.dgvColCustomerID.HeaderText = "CustomerID";
            this.dgvColCustomerID.Name = "dgvColCustomerID";
            this.dgvColCustomerID.ReadOnly = true;
            // 
            // dgvColName
            // 
            this.dgvColName.DataPropertyName = "Name";
            this.dgvColName.HeaderText = "Name";
            this.dgvColName.Name = "dgvColName";
            this.dgvColName.ReadOnly = true;
            // 
            // dgvColEmail
            // 
            this.dgvColEmail.DataPropertyName = "Email";
            this.dgvColEmail.HeaderText = "Email";
            this.dgvColEmail.Name = "dgvColEmail";
            this.dgvColEmail.ReadOnly = true;
            // 
            // dgvColRegistrationDate
            // 
            this.dgvColRegistrationDate.DataPropertyName = "RegistrationDate";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.dgvColRegistrationDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvColRegistrationDate.HeaderText = "RegistrationDate";
            this.dgvColRegistrationDate.Name = "dgvColRegistrationDate";
            this.dgvColRegistrationDate.ReadOnly = true;
            this.dgvColRegistrationDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // cboProduct
            // 
            this.cboProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboProduct.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProduct, "Name", true));
            this.cboProduct.DataSource = this.bsProduct;
            this.cboProduct.DisplayMember = "Name";
            this.cboProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProduct.FormattingEnabled = true;
            this.cboProduct.Location = new System.Drawing.Point(387, 72);
            this.cboProduct.Name = "cboProduct";
            this.cboProduct.Size = new System.Drawing.Size(339, 24);
            this.cboProduct.TabIndex = 0;
            this.cboProduct.ValueMember = "ProductCode";
            this.cboProduct.SelectionChangeCommitted += new System.EventHandler(this.CboProduct_SelectionChangeCommitted);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(656, 567);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(213, 43);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FrmRegistrationsByProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 638);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cboProduct);
            this.Controls.Add(this.dgvCustomerRegistration);
            this.Controls.Add(this.ssFrmRegistrationsByProduct);
            this.Controls.Add(this.lblInstructions);
            this.Name = "FrmRegistrationsByProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Registrations by Product";
            this.Load += new System.EventHandler(this.FrmRegistrationsByProduct_Load);
            this.ssFrmRegistrationsByProduct.ResumeLayout(false);
            this.ssFrmRegistrationsByProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomerRegistration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerRegistration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.StatusStrip ssFrmRegistrationsByProduct;
        private System.Windows.Forms.ToolStripStatusLabel tsslProjectAndDesignerName;
        private System.Windows.Forms.BindingSource bsProduct;
        private System.Windows.Forms.BindingSource bsCustomerRegistration;
        private System.Windows.Forms.DataGridView dgvCustomerRegistration;
        private System.Windows.Forms.ComboBox cboProduct;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColCustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColRegistrationDate;
    }
}

