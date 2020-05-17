﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsProUserInterfaceLayer
{
    public partial class FrmMain : Form
    {
        //Instances of the currently available forms.
        static FrmViewAllIncidents allIncidentsFrm = new FrmViewAllIncidents();
        static FrmViewIncidentsByTechnician allIncidentsByTechnicianFrm = new FrmViewIncidentsByTechnician();
        static FrmOpenIncidentsByTechnician allOpenIncidentsByTechnicianFrm = new FrmOpenIncidentsByTechnician();
        static FrmAddRegistration addRegistrationFrm = new FrmAddRegistration();

        public FrmMain()
        {
            InitializeComponent();

            //Properly formats all instances of child forms when main form is constructed.
            FormatAllForms();
        }

        /// <summary>
        /// Method to hold and execute all calls to the FormatMdiChild method.
        /// </summary>
        private void FormatAllForms()
        {
            FormatMdiChild(allIncidentsFrm);
            FormatMdiChild(allIncidentsByTechnicianFrm);
            FormatMdiChild(allOpenIncidentsByTechnicianFrm);
            FormatMdiChild(addRegistrationFrm);
        }

        /// <summary>
        /// Formats a form to properly attach to parent and fill entire parent width.
        /// </summary>
        /// <param name="someForm">A Form object.</param>
        private void FormatMdiChild(Form someForm)
        {
            someForm.MdiParent = this;
            someForm.Anchor = (AnchorStyles.Left | AnchorStyles.Top);
            someForm.Dock = DockStyle.Fill;
        }
        
        private void DisplayForm(object sender, EventArgs e)
        {
            //Determines which ToolStripMenuItem the user clicked.
            switch (((ToolStripMenuItem)sender).Text)
            {
                /* If ToolStripMenuItem's text equals the case, all other forms
                 * are hidden and reset, the corresponding form is displayed,
                 * and specific controls on the selected form are focused (if needed). */
                case "Display All Incidents":
                    HideAndResetOtherForms(allIncidentsFrm.Name);
                    allIncidentsFrm.Show();
                    break;
                case "Display Incidents By Technician":
                    HideAndResetOtherForms(allIncidentsByTechnicianFrm.Name);
                    allIncidentsByTechnicianFrm.Show();
                    allIncidentsByTechnicianFrm.txtInputTechID.Focus();
                    break;
                case "Display Open Incidents By Technician":
                    HideAndResetOtherForms(allOpenIncidentsByTechnicianFrm.Name);
                    allOpenIncidentsByTechnicianFrm.Show();
                    allOpenIncidentsByTechnicianFrm.cboTechnicians.Focus();
                    break;
                case "Add Registration":
                    HideAndResetOtherForms(addRegistrationFrm.Name);
                    addRegistrationFrm.Show();
                    addRegistrationFrm.cboCustomer.Focus();
                    break;
                default: //Do nothing.
                    break;
            }
        }

        /// <summary>
        /// Hides and resets all forms that are visible.
        /// </summary>
        /// <param name="selectedFrmName">A string containing the Form object's name of the form that should open.</param>
        private void HideAndResetOtherForms(string selectedFrmName)
        {
            foreach (Form frm in this.MdiChildren)
            {
                //Checks if child form is visible and is NOT the selected form.
                if (frm.Visible is true && frm.Name != selectedFrmName)
                {
                    switch (frm.Name)
                    {
                        /* If frm.Name equals the case, the form is hidden, and if needed,
                         * specific controls on the form are reset to original state.
                         * 
                         * Resets of specific controls on each form are necessary here because
                         * the user can navigate to a different form by clicking the corresponding
                         * ToolStripMenuItem without first clicking BtnReturnToMainMenu. */
                        case "FrmViewAllIncidents":
                            frm.Hide();
                            break;
                        case "FrmViewIncidentsByTechnician":
                            frm.Hide();
                            allIncidentsByTechnicianFrm.txtInputTechID.Clear();
                            allIncidentsByTechnicianFrm.dgvIncidentsByTechnician.DataSource = null;
                            break;
                        case "FrmOpenIncidentsByTechnician":
                            frm.Hide();
                            allOpenIncidentsByTechnicianFrm.cboTechnicians.SelectedIndex = -1;
                            allOpenIncidentsByTechnicianFrm.lblTechnicianEmail.Text = string.Empty;
                            allOpenIncidentsByTechnicianFrm.lblTechnicianPhone.Text = string.Empty;
                            allOpenIncidentsByTechnicianFrm.dgvOpenIncidentsByTechnician.DataSource = null;
                            break;
                        case "FrmAddRegistration":
                            frm.Hide();
                            addRegistrationFrm.cboCustomer.SelectedIndex = -1;
                            addRegistrationFrm.cboProduct.SelectedIndex = -1;
                            break;
                        default: //Do nothing.
                            break;
                    }
                }

                //Puts child form back in original "filled" state if the form is minimized.
                if (frm.WindowState == FormWindowState.Minimized)
                    frm.WindowState = FormWindowState.Normal;
            }
        }
        
        private void ExitApplication(object sender, EventArgs e)
        {
            //Disposes and closes all child forms.
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }

            //Disposes and closes the main form.
            this.Close();

            //Exits the application.
            Application.Exit();
        }
    }
}
