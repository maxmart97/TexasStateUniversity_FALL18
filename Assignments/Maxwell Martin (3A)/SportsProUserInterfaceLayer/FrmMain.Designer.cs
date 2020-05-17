﻿namespace SportsProUserInterfaceLayer
{
    partial class FrmMain
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
            this.msMainMenuForm = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMaintenance = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMaintainProducts = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUpdateProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMaintainCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUpdateCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMaintainRegistrations = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddRegistration = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUpdateRegistration = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteRegistration = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMaintainTechnicians = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddTechnician = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUpdateTechnician = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteTechnician = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRegistration = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiIncidents = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDisplayAllIncidents = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDisplayIncidentsByTechnician = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDisplayOpenIncidentsByTechnician = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCreateIncident = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUpdateIncident = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteIncident = new System.Windows.Forms.ToolStripMenuItem();
            this.ssMainMenuForm = new System.Windows.Forms.StatusStrip();
            this.tsslMainMenuForm = new System.Windows.Forms.ToolStripStatusLabel();
            this.msMainMenuForm.SuspendLayout();
            this.ssMainMenuForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMainMenuForm
            // 
            this.msMainMenuForm.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMainMenuForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiMaintenance,
            this.tsmiRegistration,
            this.tsmiIncidents});
            this.msMainMenuForm.Location = new System.Drawing.Point(0, 0);
            this.msMainMenuForm.Name = "msMainMenuForm";
            this.msMainMenuForm.Size = new System.Drawing.Size(1464, 28);
            this.msMainMenuForm.TabIndex = 1;
            this.msMainMenuForm.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExit});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(44, 24);
            this.tsmiFile.Text = "File";
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(108, 26);
            this.tsmiExit.Text = "Exit";
            this.tsmiExit.Click += new System.EventHandler(this.ExitApplication);
            // 
            // tsmiMaintenance
            // 
            this.tsmiMaintenance.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMaintainProducts,
            this.tsmiMaintainCustomers,
            this.tsmiMaintainRegistrations,
            this.tsmiMaintainTechnicians});
            this.tsmiMaintenance.Name = "tsmiMaintenance";
            this.tsmiMaintenance.Size = new System.Drawing.Size(106, 24);
            this.tsmiMaintenance.Text = "Maintenance";
            // 
            // tsmiMaintainProducts
            // 
            this.tsmiMaintainProducts.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddProduct,
            this.tsmiUpdateProduct,
            this.tsmiDeleteProduct});
            this.tsmiMaintainProducts.Name = "tsmiMaintainProducts";
            this.tsmiMaintainProducts.Size = new System.Drawing.Size(232, 26);
            this.tsmiMaintainProducts.Text = "Maintain Products";
            // 
            // tsmiAddProduct
            // 
            this.tsmiAddProduct.Name = "tsmiAddProduct";
            this.tsmiAddProduct.Size = new System.Drawing.Size(188, 26);
            this.tsmiAddProduct.Text = "Add Product";
            // 
            // tsmiUpdateProduct
            // 
            this.tsmiUpdateProduct.Name = "tsmiUpdateProduct";
            this.tsmiUpdateProduct.Size = new System.Drawing.Size(188, 26);
            this.tsmiUpdateProduct.Text = "Update Product";
            // 
            // tsmiDeleteProduct
            // 
            this.tsmiDeleteProduct.Name = "tsmiDeleteProduct";
            this.tsmiDeleteProduct.Size = new System.Drawing.Size(188, 26);
            this.tsmiDeleteProduct.Text = "Delete Product";
            // 
            // tsmiMaintainCustomers
            // 
            this.tsmiMaintainCustomers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddCustomer,
            this.tsmiUpdateCustomer,
            this.tsmiDeleteCustomer});
            this.tsmiMaintainCustomers.Name = "tsmiMaintainCustomers";
            this.tsmiMaintainCustomers.Size = new System.Drawing.Size(232, 26);
            this.tsmiMaintainCustomers.Text = "Maintain Customers";
            // 
            // tsmiAddCustomer
            // 
            this.tsmiAddCustomer.Name = "tsmiAddCustomer";
            this.tsmiAddCustomer.Size = new System.Drawing.Size(200, 26);
            this.tsmiAddCustomer.Text = "Add Customer";
            // 
            // tsmiUpdateCustomer
            // 
            this.tsmiUpdateCustomer.Name = "tsmiUpdateCustomer";
            this.tsmiUpdateCustomer.Size = new System.Drawing.Size(200, 26);
            this.tsmiUpdateCustomer.Text = "Update Customer";
            // 
            // tsmiDeleteCustomer
            // 
            this.tsmiDeleteCustomer.Name = "tsmiDeleteCustomer";
            this.tsmiDeleteCustomer.Size = new System.Drawing.Size(200, 26);
            this.tsmiDeleteCustomer.Text = "Delete Customer";
            // 
            // tsmiMaintainRegistrations
            // 
            this.tsmiMaintainRegistrations.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddRegistration,
            this.tsmiUpdateRegistration,
            this.tsmiDeleteRegistration});
            this.tsmiMaintainRegistrations.Name = "tsmiMaintainRegistrations";
            this.tsmiMaintainRegistrations.Size = new System.Drawing.Size(232, 26);
            this.tsmiMaintainRegistrations.Text = "Maintain Registrations";
            // 
            // tsmiAddRegistration
            // 
            this.tsmiAddRegistration.Name = "tsmiAddRegistration";
            this.tsmiAddRegistration.Size = new System.Drawing.Size(217, 26);
            this.tsmiAddRegistration.Text = "Add Registration";
            // 
            // tsmiUpdateRegistration
            // 
            this.tsmiUpdateRegistration.Name = "tsmiUpdateRegistration";
            this.tsmiUpdateRegistration.Size = new System.Drawing.Size(217, 26);
            this.tsmiUpdateRegistration.Text = "Update Registration";
            // 
            // tsmiDeleteRegistration
            // 
            this.tsmiDeleteRegistration.Name = "tsmiDeleteRegistration";
            this.tsmiDeleteRegistration.Size = new System.Drawing.Size(217, 26);
            this.tsmiDeleteRegistration.Text = "Delete Registration";
            // 
            // tsmiMaintainTechnicians
            // 
            this.tsmiMaintainTechnicians.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddTechnician,
            this.tsmiUpdateTechnician,
            this.tsmiDeleteTechnician});
            this.tsmiMaintainTechnicians.Name = "tsmiMaintainTechnicians";
            this.tsmiMaintainTechnicians.Size = new System.Drawing.Size(232, 26);
            this.tsmiMaintainTechnicians.Text = "Maintain Technicians";
            // 
            // tsmiAddTechnician
            // 
            this.tsmiAddTechnician.Name = "tsmiAddTechnician";
            this.tsmiAddTechnician.Size = new System.Drawing.Size(206, 26);
            this.tsmiAddTechnician.Text = "Add Technician";
            // 
            // tsmiUpdateTechnician
            // 
            this.tsmiUpdateTechnician.Name = "tsmiUpdateTechnician";
            this.tsmiUpdateTechnician.Size = new System.Drawing.Size(206, 26);
            this.tsmiUpdateTechnician.Text = "Update Technician";
            // 
            // tsmiDeleteTechnician
            // 
            this.tsmiDeleteTechnician.Name = "tsmiDeleteTechnician";
            this.tsmiDeleteTechnician.Size = new System.Drawing.Size(206, 26);
            this.tsmiDeleteTechnician.Text = "Delete Technician";
            // 
            // tsmiRegistration
            // 
            this.tsmiRegistration.Name = "tsmiRegistration";
            this.tsmiRegistration.Size = new System.Drawing.Size(101, 24);
            this.tsmiRegistration.Text = "Registration";
            // 
            // tsmiIncidents
            // 
            this.tsmiIncidents.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDisplayAllIncidents,
            this.tsmiDisplayIncidentsByTechnician,
            this.tsmiDisplayOpenIncidentsByTechnician,
            this.tsmiCreateIncident,
            this.tsmiUpdateIncident,
            this.tsmiDeleteIncident});
            this.tsmiIncidents.Name = "tsmiIncidents";
            this.tsmiIncidents.Size = new System.Drawing.Size(80, 24);
            this.tsmiIncidents.Text = "Incidents";
            // 
            // tsmiDisplayAllIncidents
            // 
            this.tsmiDisplayAllIncidents.Name = "tsmiDisplayAllIncidents";
            this.tsmiDisplayAllIncidents.Size = new System.Drawing.Size(329, 26);
            this.tsmiDisplayAllIncidents.Text = "Display All Incidents";
            this.tsmiDisplayAllIncidents.Click += new System.EventHandler(this.DisplayForm);
            // 
            // tsmiDisplayIncidentsByTechnician
            // 
            this.tsmiDisplayIncidentsByTechnician.Name = "tsmiDisplayIncidentsByTechnician";
            this.tsmiDisplayIncidentsByTechnician.Size = new System.Drawing.Size(329, 26);
            this.tsmiDisplayIncidentsByTechnician.Text = "Display Incidents By Technician";
            this.tsmiDisplayIncidentsByTechnician.Click += new System.EventHandler(this.DisplayForm);
            // 
            // tsmiDisplayOpenIncidentsByTechnician
            // 
            this.tsmiDisplayOpenIncidentsByTechnician.Name = "tsmiDisplayOpenIncidentsByTechnician";
            this.tsmiDisplayOpenIncidentsByTechnician.Size = new System.Drawing.Size(329, 26);
            this.tsmiDisplayOpenIncidentsByTechnician.Text = "Display Open Incidents By Technician";
            this.tsmiDisplayOpenIncidentsByTechnician.Click += new System.EventHandler(this.DisplayForm);
            // 
            // tsmiCreateIncident
            // 
            this.tsmiCreateIncident.Name = "tsmiCreateIncident";
            this.tsmiCreateIncident.Size = new System.Drawing.Size(329, 26);
            this.tsmiCreateIncident.Text = "Create Incident";
            // 
            // tsmiUpdateIncident
            // 
            this.tsmiUpdateIncident.Name = "tsmiUpdateIncident";
            this.tsmiUpdateIncident.Size = new System.Drawing.Size(329, 26);
            this.tsmiUpdateIncident.Text = "Update Incident";
            // 
            // tsmiDeleteIncident
            // 
            this.tsmiDeleteIncident.Name = "tsmiDeleteIncident";
            this.tsmiDeleteIncident.Size = new System.Drawing.Size(329, 26);
            this.tsmiDeleteIncident.Text = "Delete Incident";
            // 
            // ssMainMenuForm
            // 
            this.ssMainMenuForm.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssMainMenuForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslMainMenuForm});
            this.ssMainMenuForm.Location = new System.Drawing.Point(0, 773);
            this.ssMainMenuForm.Name = "ssMainMenuForm";
            this.ssMainMenuForm.Size = new System.Drawing.Size(1464, 25);
            this.ssMainMenuForm.TabIndex = 2;
            this.ssMainMenuForm.Text = "statusStrip1";
            // 
            // tsslMainMenuForm
            // 
            this.tsslMainMenuForm.Name = "tsslMainMenuForm";
            this.tsslMainMenuForm.Size = new System.Drawing.Size(357, 20);
            this.tsslMainMenuForm.Text = "SportsPro Application - Designed By Maxwell Martin";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 798);
            this.Controls.Add(this.ssMainMenuForm);
            this.Controls.Add(this.msMainMenuForm);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMainMenuForm;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sports Pro Application - Main Menu";
            this.msMainMenuForm.ResumeLayout(false);
            this.msMainMenuForm.PerformLayout();
            this.ssMainMenuForm.ResumeLayout(false);
            this.ssMainMenuForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMainMenuForm;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiMaintenance;
        private System.Windows.Forms.ToolStripMenuItem tsmiMaintainProducts;
        private System.Windows.Forms.ToolStripMenuItem tsmiMaintainCustomers;
        private System.Windows.Forms.ToolStripMenuItem tsmiMaintainRegistrations;
        private System.Windows.Forms.ToolStripMenuItem tsmiMaintainTechnicians;
        private System.Windows.Forms.ToolStripMenuItem tsmiRegistration;
        private System.Windows.Forms.ToolStripMenuItem tsmiIncidents;
        private System.Windows.Forms.ToolStripMenuItem tsmiDisplayAllIncidents;
        private System.Windows.Forms.ToolStripMenuItem tsmiDisplayIncidentsByTechnician;
        private System.Windows.Forms.ToolStripMenuItem tsmiCreateIncident;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpdateIncident;
        private System.Windows.Forms.StatusStrip ssMainMenuForm;
        private System.Windows.Forms.ToolStripStatusLabel tsslMainMenuForm;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddProduct;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpdateProduct;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteProduct;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddCustomer;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpdateCustomer;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteCustomer;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddRegistration;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpdateRegistration;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteRegistration;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddTechnician;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpdateTechnician;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteTechnician;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteIncident;
        private System.Windows.Forms.ToolStripMenuItem tsmiDisplayOpenIncidentsByTechnician;
    }
}

