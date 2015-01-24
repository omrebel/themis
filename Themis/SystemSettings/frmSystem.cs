using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Themis.SystemSettings
{
    public partial class frmSystem : DevExpress.XtraEditors.XtraForm
    {
        public frmSystem()
        {
            InitializeComponent();
        }

        private void frmSystem_Load(object sender, EventArgs e)
        {
            #region Load General as Default Page
            foreach (Form f in Application.OpenForms)
            {
                string formType = f.GetType().ToString();
                if (formType == "Themis.SystemSettings.frmGeneralSettings")
                {
                    f.Focus();
                    return;
                }
            }

            frmGeneralSettings gsForm = new frmGeneralSettings { Text = "General Settings", MdiParent = this };
            gsForm.Show();
            #endregion
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void lblGeneral_Click(object sender, EventArgs e)
        {
            #region Load General Page
            foreach (Form f in Application.OpenForms)
            {
                string formType = f.GetType().ToString();
                if (formType == "Themis.SystemSettings.frmGeneralSettings")
                {
                    f.Focus();
                    return;
                }
            }

            frmGeneralSettings gsForm = new frmGeneralSettings { Text = "General Settings", MdiParent = this };
            gsForm.Show();
            #endregion
        }

        private void lblOptions_Click(object sender, EventArgs e)
        {
            #region Load Options Page
            foreach (Form f in Application.OpenForms)
            {
                string formType = f.GetType().ToString();
                if (formType == "Themis.SystemSettings.frmOptions")
                {
                    f.Focus();
                    return;
                }
            }

            frmOptions opForm = new frmOptions { Text = "System Options", MdiParent = this };
            opForm.Show();
            #endregion
        }

        private void lblTables_Click(object sender, EventArgs e)
        {
            #region Load Tables Page
            foreach (Form f in Application.OpenForms)
            {
                string formType = f.GetType().ToString();
                if (formType == "Themis.SystemSettings.frmTables")
                {
                    f.Focus();
                    return;
                }
            }

            frmTables tblForm = new frmTables { Text = "System Tables", MdiParent = this };
            tblForm.Show();
            #endregion
        }
    }
}