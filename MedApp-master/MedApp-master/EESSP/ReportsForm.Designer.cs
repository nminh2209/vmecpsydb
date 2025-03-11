namespace EESSP
{
    partial class ReportsForm
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
            this.buttonExit = new System.Windows.Forms.Button();
            this.crystalReportViewerReports = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tips = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExit.Location = new System.Drawing.Point(413, 12);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(90, 23);
            this.buttonExit.TabIndex = 24;
            this.buttonExit.Text = "Exit";
            this.tips.SetToolTip(this.buttonExit, "Close Reports");
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // crystalReportViewerReports
            // 
            this.crystalReportViewerReports.ActiveViewIndex = -1;
            this.crystalReportViewerReports.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerReports.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerReports.DisplayStatusBar = false;
            this.crystalReportViewerReports.Location = new System.Drawing.Point(12, 53);
            this.crystalReportViewerReports.Name = "crystalReportViewerReports";
            this.crystalReportViewerReports.Size = new System.Drawing.Size(868, 441);
            this.crystalReportViewerReports.TabIndex = 23;
            this.crystalReportViewerReports.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.CancelButton = this.buttonExit;
            this.ClientSize = new System.Drawing.Size(896, 506);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.crystalReportViewerReports);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "ReportsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerReports;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ToolTip tips;
    }
}