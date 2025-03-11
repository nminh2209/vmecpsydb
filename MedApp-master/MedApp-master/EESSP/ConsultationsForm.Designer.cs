namespace EESSP
{
    partial class ConsultationsForm
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
            this.buttonManage = new System.Windows.Forms.Button();
            this.buttonReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPatient = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonConsultationRep = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxDate = new System.Windows.Forms.CheckBox();
            this.checkBoxDiagnostic = new System.Windows.Forms.CheckBox();
            this.checkBoxID = new System.Windows.Forms.CheckBox();
            this.numericUpDownSearchID = new System.Windows.Forms.NumericUpDown();
            this.labelOption = new System.Windows.Forms.Label();
            this.dataGridViewConsultations = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diagnostic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelIdC = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelDiagnostic = new System.Windows.Forms.Label();
            this.buttonDiscard = new System.Windows.Forms.Button();
            this.textBoxDiagnostic = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBoxDate = new System.Windows.Forms.MaskedTextBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.radioButtonAnotherDate = new System.Windows.Forms.RadioButton();
            this.radioButtonToday = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.patientReport1 = new EESSP.PatientReport();
            this.consultationReport1 = new EESSP.ConsultationReport();
            this.tips = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSearchID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsultations)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.buttonManage);
            this.panel1.Controls.Add(this.buttonReport);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelPatient);
            this.panel1.Controls.Add(this.buttonExit);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Location = new System.Drawing.Point(683, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(143, 370);
            this.panel1.TabIndex = 0;
            // 
            // buttonManage
            // 
            this.buttonManage.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonManage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonManage.Location = new System.Drawing.Point(27, 191);
            this.buttonManage.Name = "buttonManage";
            this.buttonManage.Size = new System.Drawing.Size(90, 23);
            this.buttonManage.TabIndex = 1;
            this.buttonManage.Text = "Manage";
            this.tips.SetToolTip(this.buttonManage, "Manage consultations (Ctrl+Shift+M)");
            this.buttonManage.UseVisualStyleBackColor = false;
            this.buttonManage.Click += new System.EventHandler(this.buttonManage_Click);
            // 
            // buttonReport
            // 
            this.buttonReport.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonReport.Location = new System.Drawing.Point(27, 220);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(90, 23);
            this.buttonReport.TabIndex = 2;
            this.buttonReport.Text = "Report";
            this.tips.SetToolTip(this.buttonReport, "Generate pacient\'s consultations report (Ctrl+Shift+A)");
            this.buttonReport.UseVisualStyleBackColor = false;
            this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultations Menu";
            // 
            // labelPatient
            // 
            this.labelPatient.AutoSize = true;
            this.labelPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPatient.Location = new System.Drawing.Point(3, 4);
            this.labelPatient.Name = "labelPatient";
            this.labelPatient.Size = new System.Drawing.Size(47, 13);
            this.labelPatient.TabIndex = 8;
            this.labelPatient.Text = "Patient";
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExit.Location = new System.Drawing.Point(27, 249);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(90, 23);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Exit";
            this.tips.SetToolTip(this.buttonExit, "Close Consultations");
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Location = new System.Drawing.Point(27, 162);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(90, 23);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add";
            this.tips.SetToolTip(this.buttonAdd, "Add new patient (Ctrl+A)");
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRemove.Location = new System.Drawing.Point(179, 285);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(114, 23);
            this.buttonRemove.TabIndex = 7;
            this.buttonRemove.Text = "Remove";
            this.tips.SetToolTip(this.buttonRemove, "Remove consultation (Ctrl+Del)");
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonModify
            // 
            this.buttonModify.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonModify.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonModify.Location = new System.Drawing.Point(24, 285);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(114, 23);
            this.buttonModify.TabIndex = 5;
            this.buttonModify.Text = "Modify";
            this.tips.SetToolTip(this.buttonModify, "Modify consultation (Ctrl+M)");
            this.buttonModify.UseVisualStyleBackColor = false;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Tan;
            this.panel2.Controls.Add(this.buttonConsultationRep);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.buttonRemove);
            this.panel2.Controls.Add(this.checkBoxDate);
            this.panel2.Controls.Add(this.buttonModify);
            this.panel2.Controls.Add(this.checkBoxDiagnostic);
            this.panel2.Controls.Add(this.checkBoxID);
            this.panel2.Controls.Add(this.numericUpDownSearchID);
            this.panel2.Controls.Add(this.labelOption);
            this.panel2.Controls.Add(this.dataGridViewConsultations);
            this.panel2.Controls.Add(this.labelIdC);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.labelDiagnostic);
            this.panel2.Controls.Add(this.buttonDiscard);
            this.panel2.Controls.Add(this.textBoxDiagnostic);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.maskedTextBoxDate);
            this.panel2.Controls.Add(this.buttonConfirm);
            this.panel2.Controls.Add(this.radioButtonAnotherDate);
            this.panel2.Controls.Add(this.radioButtonToday);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(665, 370);
            this.panel2.TabIndex = 1;
            // 
            // buttonConsultationRep
            // 
            this.buttonConsultationRep.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonConsultationRep.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonConsultationRep.Location = new System.Drawing.Point(24, 317);
            this.buttonConsultationRep.Name = "buttonConsultationRep";
            this.buttonConsultationRep.Size = new System.Drawing.Size(114, 23);
            this.buttonConsultationRep.TabIndex = 6;
            this.buttonConsultationRep.Text = "Report";
            this.tips.SetToolTip(this.buttonConsultationRep, "Generate consultation report (Ctrl+R)");
            this.buttonConsultationRep.UseVisualStyleBackColor = false;
            this.buttonConsultationRep.Click += new System.EventHandler(this.buttonConsultationRep_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Search a consultation:";
            // 
            // checkBoxDate
            // 
            this.checkBoxDate.AutoSize = true;
            this.checkBoxDate.Location = new System.Drawing.Point(20, 212);
            this.checkBoxDate.Name = "checkBoxDate";
            this.checkBoxDate.Size = new System.Drawing.Size(15, 14);
            this.checkBoxDate.TabIndex = 2;
            this.tips.SetToolTip(this.checkBoxDate, "Search consultation by consultation date");
            this.checkBoxDate.UseVisualStyleBackColor = true;
            this.checkBoxDate.Visible = false;
            this.checkBoxDate.CheckedChanged += new System.EventHandler(this.checkBoxDate_CheckedChanged);
            // 
            // checkBoxDiagnostic
            // 
            this.checkBoxDiagnostic.AutoSize = true;
            this.checkBoxDiagnostic.Location = new System.Drawing.Point(20, 154);
            this.checkBoxDiagnostic.Name = "checkBoxDiagnostic";
            this.checkBoxDiagnostic.Size = new System.Drawing.Size(15, 14);
            this.checkBoxDiagnostic.TabIndex = 1;
            this.tips.SetToolTip(this.checkBoxDiagnostic, "Search consultation by diagnostic");
            this.checkBoxDiagnostic.UseVisualStyleBackColor = true;
            this.checkBoxDiagnostic.Visible = false;
            this.checkBoxDiagnostic.CheckedChanged += new System.EventHandler(this.checkBoxDiagnostic_CheckedChanged);
            // 
            // checkBoxID
            // 
            this.checkBoxID.AutoSize = true;
            this.checkBoxID.Location = new System.Drawing.Point(20, 131);
            this.checkBoxID.Name = "checkBoxID";
            this.checkBoxID.Size = new System.Drawing.Size(15, 14);
            this.checkBoxID.TabIndex = 0;
            this.tips.SetToolTip(this.checkBoxID, "Search consultation by ID");
            this.checkBoxID.UseVisualStyleBackColor = true;
            this.checkBoxID.Visible = false;
            this.checkBoxID.CheckedChanged += new System.EventHandler(this.checkBoxID_CheckedChanged);
            // 
            // numericUpDownSearchID
            // 
            this.numericUpDownSearchID.Location = new System.Drawing.Point(144, 128);
            this.numericUpDownSearchID.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownSearchID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSearchID.Name = "numericUpDownSearchID";
            this.numericUpDownSearchID.Size = new System.Drawing.Size(42, 20);
            this.numericUpDownSearchID.TabIndex = 0;
            this.numericUpDownSearchID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tips.SetToolTip(this.numericUpDownSearchID, "Choose consultation ID");
            this.numericUpDownSearchID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSearchID.Visible = false;
            this.numericUpDownSearchID.ValueChanged += new System.EventHandler(this.numericUpDownSearchID_ValueChanged);
            // 
            // labelOption
            // 
            this.labelOption.AutoSize = true;
            this.labelOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOption.Location = new System.Drawing.Point(16, 14);
            this.labelOption.Name = "labelOption";
            this.labelOption.Size = new System.Drawing.Size(90, 13);
            this.labelOption.TabIndex = 2;
            this.labelOption.Text = "Chosen Option";
            // 
            // dataGridViewConsultations
            // 
            this.dataGridViewConsultations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewConsultations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConsultations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Date,
            this.Diagnostic});
            this.dataGridViewConsultations.Location = new System.Drawing.Point(348, 0);
            this.dataGridViewConsultations.Name = "dataGridViewConsultations";
            this.dataGridViewConsultations.Size = new System.Drawing.Size(316, 370);
            this.dataGridViewConsultations.TabIndex = 13;
            this.dataGridViewConsultations.Visible = false;
            this.dataGridViewConsultations.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewConsultations_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "Nr.";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 46;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 55;
            // 
            // Diagnostic
            // 
            this.Diagnostic.HeaderText = "Diagnostic";
            this.Diagnostic.Name = "Diagnostic";
            this.Diagnostic.ReadOnly = true;
            this.Diagnostic.Width = 82;
            // 
            // labelIdC
            // 
            this.labelIdC.AutoSize = true;
            this.labelIdC.Location = new System.Drawing.Point(144, 131);
            this.labelIdC.Name = "labelIdC";
            this.labelIdC.Size = new System.Drawing.Size(18, 13);
            this.labelIdC.TabIndex = 6;
            this.labelIdC.Text = "ID";
            this.labelIdC.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Consultation Date:";
            this.label5.Visible = false;
            // 
            // labelDiagnostic
            // 
            this.labelDiagnostic.AutoSize = true;
            this.labelDiagnostic.Location = new System.Drawing.Point(95, 154);
            this.labelDiagnostic.Name = "labelDiagnostic";
            this.labelDiagnostic.Size = new System.Drawing.Size(57, 13);
            this.labelDiagnostic.TabIndex = 7;
            this.labelDiagnostic.Text = "Diagnostic";
            this.labelDiagnostic.Visible = false;
            // 
            // buttonDiscard
            // 
            this.buttonDiscard.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonDiscard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDiscard.Location = new System.Drawing.Point(179, 317);
            this.buttonDiscard.Name = "buttonDiscard";
            this.buttonDiscard.Size = new System.Drawing.Size(114, 23);
            this.buttonDiscard.TabIndex = 8;
            this.buttonDiscard.Text = "Discard";
            this.tips.SetToolTip(this.buttonDiscard, "Discard changes (Ctrl+Shift+Del)");
            this.buttonDiscard.UseVisualStyleBackColor = false;
            this.buttonDiscard.Visible = false;
            this.buttonDiscard.Click += new System.EventHandler(this.buttonDiscard_Click);
            // 
            // textBoxDiagnostic
            // 
            this.textBoxDiagnostic.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxDiagnostic.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxDiagnostic.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxDiagnostic.Location = new System.Drawing.Point(38, 175);
            this.textBoxDiagnostic.Name = "textBoxDiagnostic";
            this.textBoxDiagnostic.Size = new System.Drawing.Size(255, 20);
            this.textBoxDiagnostic.TabIndex = 1;
            this.tips.SetToolTip(this.textBoxDiagnostic, "Type diagnostic");
            this.textBoxDiagnostic.Visible = false;
            this.textBoxDiagnostic.TextChanged += new System.EventHandler(this.textBoxDiagnostic_TextChanged);
            this.textBoxDiagnostic.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxDiagnostic_KeyDown);
            this.textBoxDiagnostic.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxDiagnostic_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Consultation number:";
            this.label2.Visible = false;
            // 
            // maskedTextBoxDate
            // 
            this.maskedTextBoxDate.Location = new System.Drawing.Point(225, 232);
            this.maskedTextBoxDate.Mask = "00/00/0000";
            this.maskedTextBoxDate.Name = "maskedTextBoxDate";
            this.maskedTextBoxDate.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxDate.TabIndex = 4;
            this.tips.SetToolTip(this.maskedTextBoxDate, "Type consultation date");
            this.maskedTextBoxDate.ValidatingType = typeof(System.DateTime);
            this.maskedTextBoxDate.Visible = false;
            this.maskedTextBoxDate.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.maskedTextBoxDate_TypeValidationCompleted);
            this.maskedTextBoxDate.Click += new System.EventHandler(this.maskedTextBoxDate_Click);
            this.maskedTextBoxDate.TextChanged += new System.EventHandler(this.maskedTextBoxDate_TextChanged);
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonConfirm.Enabled = false;
            this.buttonConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonConfirm.Location = new System.Drawing.Point(24, 317);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(114, 23);
            this.buttonConfirm.TabIndex = 5;
            this.buttonConfirm.Text = "Confirm";
            this.tips.SetToolTip(this.buttonConfirm, "Confirm new patient");
            this.buttonConfirm.UseVisualStyleBackColor = false;
            this.buttonConfirm.Visible = false;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // radioButtonAnotherDate
            // 
            this.radioButtonAnotherDate.AutoSize = true;
            this.radioButtonAnotherDate.Location = new System.Drawing.Point(131, 233);
            this.radioButtonAnotherDate.Name = "radioButtonAnotherDate";
            this.radioButtonAnotherDate.Size = new System.Drawing.Size(88, 17);
            this.radioButtonAnotherDate.TabIndex = 3;
            this.radioButtonAnotherDate.Text = "Another Date";
            this.radioButtonAnotherDate.UseVisualStyleBackColor = true;
            this.radioButtonAnotherDate.Visible = false;
            this.radioButtonAnotherDate.CheckedChanged += new System.EventHandler(this.radioButtonAnotherDate_CheckedChanged);
            // 
            // radioButtonToday
            // 
            this.radioButtonToday.AutoSize = true;
            this.radioButtonToday.Checked = true;
            this.radioButtonToday.Location = new System.Drawing.Point(131, 210);
            this.radioButtonToday.Name = "radioButtonToday";
            this.radioButtonToday.Size = new System.Drawing.Size(55, 17);
            this.radioButtonToday.TabIndex = 2;
            this.radioButtonToday.TabStop = true;
            this.radioButtonToday.Text = "Today";
            this.radioButtonToday.UseVisualStyleBackColor = true;
            this.radioButtonToday.Visible = false;
            this.radioButtonToday.CheckedChanged += new System.EventHandler(this.radioButtonToday_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Diagnostic:";
            this.label4.Visible = false;
            // 
            // ConsultationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.CancelButton = this.buttonExit;
            this.ClientSize = new System.Drawing.Size(838, 394);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "ConsultationsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultations";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ConsultationsForm_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSearchID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsultations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Button buttonReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.RadioButton radioButtonAnotherDate;
        private System.Windows.Forms.RadioButton radioButtonToday;
        private System.Windows.Forms.Label labelIdC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDiagnostic;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDate;
        private System.Windows.Forms.Label labelOption;
        private System.Windows.Forms.Label labelDiagnostic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelPatient;
        private System.Windows.Forms.Button buttonDiscard;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.DataGridView dataGridViewConsultations;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownSearchID;
        private System.Windows.Forms.CheckBox checkBoxDate;
        private System.Windows.Forms.CheckBox checkBoxDiagnostic;
        private System.Windows.Forms.CheckBox checkBoxID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diagnostic;
        private PatientReport patientReport1;
        private System.Windows.Forms.Button buttonManage;
        private System.Windows.Forms.Button buttonConsultationRep;
        private ConsultationReport consultationReport1;
        private System.Windows.Forms.ToolTip tips;
    }
}