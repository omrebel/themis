namespace Themis.SystemSettings
{
    partial class frmSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSystem));
            this.pnlBottom = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.pnlOptions = new DevExpress.XtraEditors.PanelControl();
            this.lblGeneral = new DevExpress.XtraEditors.LabelControl();
            this.lblOptions = new DevExpress.XtraEditors.LabelControl();
            this.lblTables = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).BeginInit();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlOptions)).BeginInit();
            this.pnlOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnCancel);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 604);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(947, 32);
            this.pnlBottom.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(860, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlOptions
            // 
            this.pnlOptions.Controls.Add(this.lblTables);
            this.pnlOptions.Controls.Add(this.lblOptions);
            this.pnlOptions.Controls.Add(this.lblGeneral);
            this.pnlOptions.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlOptions.Location = new System.Drawing.Point(0, 0);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(120, 604);
            this.pnlOptions.TabIndex = 2;
            // 
            // lblGeneral
            // 
            this.lblGeneral.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblGeneral.Location = new System.Drawing.Point(12, 12);
            this.lblGeneral.Name = "lblGeneral";
            this.lblGeneral.Size = new System.Drawing.Size(44, 16);
            this.lblGeneral.TabIndex = 1;
            this.lblGeneral.Text = "General";
            this.lblGeneral.Click += new System.EventHandler(this.lblGeneral_Click);
            // 
            // lblOptions
            // 
            this.lblOptions.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblOptions.Location = new System.Drawing.Point(13, 46);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(43, 16);
            this.lblOptions.TabIndex = 2;
            this.lblOptions.Text = "Options";
            this.lblOptions.Click += new System.EventHandler(this.lblOptions_Click);
            // 
            // lblTables
            // 
            this.lblTables.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblTables.Location = new System.Drawing.Point(13, 83);
            this.lblTables.Name = "lblTables";
            this.lblTables.Size = new System.Drawing.Size(38, 16);
            this.lblTables.TabIndex = 3;
            this.lblTables.Text = "Tables";
            this.lblTables.Click += new System.EventHandler(this.lblTables_Click);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // frmSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 636);
            this.Controls.Add(this.pnlOptions);
            this.Controls.Add(this.pnlBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.Name = "frmSystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Settings";
            this.Load += new System.EventHandler(this.frmSystem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlOptions)).EndInit();
            this.pnlOptions.ResumeLayout(false);
            this.pnlOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlBottom;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.PanelControl pnlOptions;
        private DevExpress.XtraEditors.LabelControl lblTables;
        private DevExpress.XtraEditors.LabelControl lblOptions;
        private DevExpress.XtraEditors.LabelControl lblGeneral;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}