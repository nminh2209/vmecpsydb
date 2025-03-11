namespace EESSP
{
    partial class AddPatientForm
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
            this.textBoxAllergies = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.radioButtonRetired = new System.Windows.Forms.RadioButton();
            this.textBoxOccupation = new System.Windows.Forms.TextBox();
            this.radioButtonNoOccupation = new System.Windows.Forms.RadioButton();
            this.radioButtonStudent = new System.Windows.Forms.RadioButton();
            this.radioButtonEmployed = new System.Windows.Forms.RadioButton();
            this.radioButtonUnemployed = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioButtonPositive = new System.Windows.Forms.RadioButton();
            this.radioButtonNegative = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton0I = new System.Windows.Forms.RadioButton();
            this.radioButtonABIV = new System.Windows.Forms.RadioButton();
            this.radioButtonBIII = new System.Windows.Forms.RadioButton();
            this.radioButtonAII = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonAddP = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMI = new System.Windows.Forms.TextBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelBirthPlace = new System.Windows.Forms.Label();
            this.labelSex = new System.Windows.Forms.Label();
            this.labelDOB = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.maskedTextBoxID = new System.Windows.Forms.MaskedTextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.tips = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.textBoxAllergies);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.textBoxWeight);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.textBoxHeight);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.textBoxEmail);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.buttonExit);
            this.panel1.Controls.Add(this.buttonAddP);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxMI);
            this.panel1.Controls.Add(this.labelAge);
            this.panel1.Controls.Add(this.labelBirthPlace);
            this.panel1.Controls.Add(this.labelSex);
            this.panel1.Controls.Add(this.labelDOB);
            this.panel1.Controls.Add(this.textBoxAddress);
            this.panel1.Controls.Add(this.maskedTextBoxID);
            this.panel1.Controls.Add(this.textBoxLastName);
            this.panel1.Controls.Add(this.textBoxName);
            this.panel1.Location = new System.Drawing.Point(9, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 403);
            this.panel1.TabIndex = 0;
            // 
            // textBoxAllergies
            // 
            this.textBoxAllergies.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxAllergies.Location = new System.Drawing.Point(67, 290);
            this.textBoxAllergies.Name = "textBoxAllergies";
            this.textBoxAllergies.Size = new System.Drawing.Size(302, 20);
            this.textBoxAllergies.TabIndex = 12;
            this.textBoxAllergies.Text = "-";
            this.tips.SetToolTip(this.textBoxAllergies, "Type new patient\'s allergies");
            this.textBoxAllergies.TextChanged += new System.EventHandler(this.textBoxAllergies_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(15, 293);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(46, 13);
            this.label18.TabIndex = 60;
            this.label18.Text = "Allergies";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(97, 167);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(19, 13);
            this.label17.TabIndex = 59;
            this.label17.Text = "kg";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(97, 128);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(21, 13);
            this.label16.TabIndex = 58;
            this.label16.Text = "cm";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.radioButtonRetired);
            this.panel4.Controls.Add(this.textBoxOccupation);
            this.panel4.Controls.Add(this.radioButtonNoOccupation);
            this.panel4.Controls.Add(this.radioButtonStudent);
            this.panel4.Controls.Add(this.radioButtonEmployed);
            this.panel4.Controls.Add(this.radioButtonUnemployed);
            this.panel4.Location = new System.Drawing.Point(18, 217);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(351, 51);
            this.panel4.TabIndex = 57;
            // 
            // radioButtonRetired
            // 
            this.radioButtonRetired.AutoSize = true;
            this.radioButtonRetired.Location = new System.Drawing.Point(105, 3);
            this.radioButtonRetired.Name = "radioButtonRetired";
            this.radioButtonRetired.Size = new System.Drawing.Size(59, 17);
            this.radioButtonRetired.TabIndex = 12;
            this.radioButtonRetired.Text = "Retired";
            this.tips.SetToolTip(this.radioButtonRetired, "Retired");
            this.radioButtonRetired.UseVisualStyleBackColor = true;
            // 
            // textBoxOccupation
            // 
            this.textBoxOccupation.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxOccupation.Location = new System.Drawing.Point(203, 25);
            this.textBoxOccupation.Name = "textBoxOccupation";
            this.textBoxOccupation.Size = new System.Drawing.Size(143, 20);
            this.textBoxOccupation.TabIndex = 11;
            this.tips.SetToolTip(this.textBoxOccupation, "Type new patient\'s profession");
            this.textBoxOccupation.Visible = false;
            this.textBoxOccupation.TextChanged += new System.EventHandler(this.textBoxOccupation_TextChanged);
            // 
            // radioButtonNoOccupation
            // 
            this.radioButtonNoOccupation.AutoSize = true;
            this.radioButtonNoOccupation.Checked = true;
            this.radioButtonNoOccupation.Location = new System.Drawing.Point(3, 3);
            this.radioButtonNoOccupation.Name = "radioButtonNoOccupation";
            this.radioButtonNoOccupation.Size = new System.Drawing.Size(97, 17);
            this.radioButtonNoOccupation.TabIndex = 10;
            this.radioButtonNoOccupation.TabStop = true;
            this.radioButtonNoOccupation.Text = "No Occupation";
            this.tips.SetToolTip(this.radioButtonNoOccupation, "No occupation");
            this.radioButtonNoOccupation.UseVisualStyleBackColor = true;
            // 
            // radioButtonStudent
            // 
            this.radioButtonStudent.AutoSize = true;
            this.radioButtonStudent.Location = new System.Drawing.Point(3, 26);
            this.radioButtonStudent.Name = "radioButtonStudent";
            this.radioButtonStudent.Size = new System.Drawing.Size(62, 17);
            this.radioButtonStudent.TabIndex = 10;
            this.radioButtonStudent.Text = "Student";
            this.tips.SetToolTip(this.radioButtonStudent, "Student");
            this.radioButtonStudent.UseVisualStyleBackColor = true;
            // 
            // radioButtonEmployed
            // 
            this.radioButtonEmployed.AutoSize = true;
            this.radioButtonEmployed.Location = new System.Drawing.Point(203, 3);
            this.radioButtonEmployed.Name = "radioButtonEmployed";
            this.radioButtonEmployed.Size = new System.Drawing.Size(71, 17);
            this.radioButtonEmployed.TabIndex = 10;
            this.radioButtonEmployed.Text = "Employed";
            this.tips.SetToolTip(this.radioButtonEmployed, "Employed");
            this.radioButtonEmployed.UseVisualStyleBackColor = true;
            this.radioButtonEmployed.CheckedChanged += new System.EventHandler(this.radioButtonEmployed_CheckedChanged);
            // 
            // radioButtonUnemployed
            // 
            this.radioButtonUnemployed.AutoSize = true;
            this.radioButtonUnemployed.Location = new System.Drawing.Point(105, 25);
            this.radioButtonUnemployed.Name = "radioButtonUnemployed";
            this.radioButtonUnemployed.Size = new System.Drawing.Size(84, 17);
            this.radioButtonUnemployed.TabIndex = 10;
            this.radioButtonUnemployed.Text = "Unemployed";
            this.tips.SetToolTip(this.radioButtonUnemployed, "Unemployed");
            this.radioButtonUnemployed.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 201);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 13);
            this.label15.TabIndex = 55;
            this.label15.Text = "Occupation";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 148);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 54;
            this.label14.Text = "Weight";
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBoxWeight.Location = new System.Drawing.Point(18, 164);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxWeight.Size = new System.Drawing.Size(73, 20);
            this.textBoxWeight.TabIndex = 7;
            this.tips.SetToolTip(this.textBoxWeight, "Type new patient\'s weight");
            this.textBoxWeight.TextChanged += new System.EventHandler(this.textBoxWeight_TextChanged);
            this.textBoxWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxWeight_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 109);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 52;
            this.label13.Text = "Height";
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBoxHeight.Location = new System.Drawing.Point(18, 125);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxHeight.Size = new System.Drawing.Size(73, 20);
            this.textBoxHeight.TabIndex = 6;
            this.tips.SetToolTip(this.textBoxHeight, "Type new patient\'s height");
            this.textBoxHeight.TextChanged += new System.EventHandler(this.textBoxHeight_TextChanged);
            this.textBoxHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxHeight_KeyPress);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.radioButtonPositive);
            this.panel3.Controls.Add(this.radioButtonNegative);
            this.panel3.Location = new System.Drawing.Point(296, 125);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(73, 59);
            this.panel3.TabIndex = 50;
            // 
            // radioButtonPositive
            // 
            this.radioButtonPositive.AutoSize = true;
            this.radioButtonPositive.Checked = true;
            this.radioButtonPositive.Location = new System.Drawing.Point(3, 9);
            this.radioButtonPositive.Name = "radioButtonPositive";
            this.radioButtonPositive.Size = new System.Drawing.Size(62, 17);
            this.radioButtonPositive.TabIndex = 9;
            this.radioButtonPositive.TabStop = true;
            this.radioButtonPositive.Text = "Pozitive";
            this.tips.SetToolTip(this.radioButtonPositive, "Rh+");
            this.radioButtonPositive.UseVisualStyleBackColor = true;
            // 
            // radioButtonNegative
            // 
            this.radioButtonNegative.AutoSize = true;
            this.radioButtonNegative.Location = new System.Drawing.Point(3, 32);
            this.radioButtonNegative.Name = "radioButtonNegative";
            this.radioButtonNegative.Size = new System.Drawing.Size(68, 17);
            this.radioButtonNegative.TabIndex = 9;
            this.radioButtonNegative.Text = "Negative";
            this.tips.SetToolTip(this.radioButtonNegative, "Rh-");
            this.radioButtonNegative.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.radioButton0I);
            this.panel2.Controls.Add(this.radioButtonABIV);
            this.panel2.Controls.Add(this.radioButtonBIII);
            this.panel2.Controls.Add(this.radioButtonAII);
            this.panel2.Location = new System.Drawing.Point(147, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(111, 59);
            this.panel2.TabIndex = 49;
            // 
            // radioButton0I
            // 
            this.radioButton0I.AutoSize = true;
            this.radioButton0I.Checked = true;
            this.radioButton0I.Location = new System.Drawing.Point(3, 9);
            this.radioButton0I.Name = "radioButton0I";
            this.radioButton0I.Size = new System.Drawing.Size(43, 17);
            this.radioButton0I.TabIndex = 8;
            this.radioButton0I.TabStop = true;
            this.radioButton0I.Text = "0 (I)";
            this.tips.SetToolTip(this.radioButton0I, "O (I)");
            this.radioButton0I.UseVisualStyleBackColor = true;
            // 
            // radioButtonABIV
            // 
            this.radioButtonABIV.AutoSize = true;
            this.radioButtonABIV.Location = new System.Drawing.Point(52, 32);
            this.radioButtonABIV.Name = "radioButtonABIV";
            this.radioButtonABIV.Size = new System.Drawing.Size(58, 17);
            this.radioButtonABIV.TabIndex = 8;
            this.radioButtonABIV.Text = "AB (IV)";
            this.tips.SetToolTip(this.radioButtonABIV, "AB (IV)");
            this.radioButtonABIV.UseVisualStyleBackColor = true;
            // 
            // radioButtonBIII
            // 
            this.radioButtonBIII.AutoSize = true;
            this.radioButtonBIII.Location = new System.Drawing.Point(52, 9);
            this.radioButtonBIII.Name = "radioButtonBIII";
            this.radioButtonBIII.Size = new System.Drawing.Size(50, 17);
            this.radioButtonBIII.TabIndex = 8;
            this.radioButtonBIII.Text = "B (III)";
            this.tips.SetToolTip(this.radioButtonBIII, "B (III)");
            this.radioButtonBIII.UseVisualStyleBackColor = true;
            // 
            // radioButtonAII
            // 
            this.radioButtonAII.AutoSize = true;
            this.radioButtonAII.Location = new System.Drawing.Point(3, 32);
            this.radioButtonAII.Name = "radioButtonAII";
            this.radioButtonAII.Size = new System.Drawing.Size(47, 17);
            this.radioButtonAII.TabIndex = 8;
            this.radioButtonAII.Text = "A (II)";
            this.tips.SetToolTip(this.radioButtonAII, "A (II)");
            this.radioButtonAII.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(261, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 42;
            this.label12.Text = "Email";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBoxEmail.Location = new System.Drawing.Point(264, 30);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(105, 20);
            this.textBoxEmail.TabIndex = 3;
            this.tips.SetToolTip(this.textBoxEmail, "Type new patient\'s email");
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(293, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 13);
            this.label11.TabIndex = 39;
            this.label11.Text = "Rh";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(144, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "Blood Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Age: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(94, 366);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Birth Place: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 366);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Sex: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(94, 344);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Date of Birth: ";
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExit.Location = new System.Drawing.Point(279, 361);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(90, 23);
            this.buttonExit.TabIndex = 14;
            this.buttonExit.Text = "Exit";
            this.tips.SetToolTip(this.buttonExit, "Discard new patient");
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonAddP
            // 
            this.buttonAddP.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonAddP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddP.Location = new System.Drawing.Point(279, 332);
            this.buttonAddP.Name = "buttonAddP";
            this.buttonAddP.Size = new System.Drawing.Size(90, 23);
            this.buttonAddP.TabIndex = 13;
            this.buttonAddP.Text = "Add Patient";
            this.tips.SetToolTip(this.buttonAddP, "Add new patient");
            this.buttonAddP.UseVisualStyleBackColor = false;
            this.buttonAddP.Click += new System.EventHandler(this.buttonAddP_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(121, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "M.I.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "CNP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Last name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Name";
            // 
            // textBoxMI
            // 
            this.textBoxMI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxMI.Location = new System.Drawing.Point(124, 30);
            this.textBoxMI.Name = "textBoxMI";
            this.textBoxMI.Size = new System.Drawing.Size(28, 20);
            this.textBoxMI.TabIndex = 1;
            this.tips.SetToolTip(this.textBoxMI, "Type new patient\'s middle initials");
            this.textBoxMI.TextChanged += new System.EventHandler(this.textBoxMI_TextChanged);
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(53, 344);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(32, 13);
            this.labelAge.TabIndex = 25;
            this.labelAge.Text = "Age: ";
            this.tips.SetToolTip(this.labelAge, "New patient\'s age");
            // 
            // labelBirthPlace
            // 
            this.labelBirthPlace.AutoSize = true;
            this.labelBirthPlace.Location = new System.Drawing.Point(167, 366);
            this.labelBirthPlace.Name = "labelBirthPlace";
            this.labelBirthPlace.Size = new System.Drawing.Size(64, 13);
            this.labelBirthPlace.TabIndex = 24;
            this.labelBirthPlace.Text = "Birth Place: ";
            this.tips.SetToolTip(this.labelBirthPlace, "New patient\'s birth place");
            // 
            // labelSex
            // 
            this.labelSex.AutoSize = true;
            this.labelSex.Location = new System.Drawing.Point(52, 366);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(31, 13);
            this.labelSex.TabIndex = 23;
            this.labelSex.Text = "Sex: ";
            this.tips.SetToolTip(this.labelSex, "New patient\'s sex");
            // 
            // labelDOB
            // 
            this.labelDOB.AutoSize = true;
            this.labelDOB.Location = new System.Drawing.Point(167, 344);
            this.labelDOB.Name = "labelDOB";
            this.labelDOB.Size = new System.Drawing.Size(72, 13);
            this.labelDOB.TabIndex = 22;
            this.labelDOB.Text = "Date of Birth: ";
            this.tips.SetToolTip(this.labelDOB, "New patient\'s date of birth");
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxAddress.Location = new System.Drawing.Point(124, 69);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(245, 20);
            this.textBoxAddress.TabIndex = 5;
            this.tips.SetToolTip(this.textBoxAddress, "Type new patient\'s address");
            this.textBoxAddress.TextChanged += new System.EventHandler(this.textBoxAddress_TextChanged);
            // 
            // maskedTextBoxID
            // 
            this.maskedTextBoxID.Location = new System.Drawing.Point(18, 69);
            this.maskedTextBoxID.Mask = "0000000000000";
            this.maskedTextBoxID.Name = "maskedTextBoxID";
            this.maskedTextBoxID.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxID.TabIndex = 4;
            this.tips.SetToolTip(this.maskedTextBoxID, "Type new patient\'s CNP");
            this.maskedTextBoxID.Click += new System.EventHandler(this.maskedTextBoxID_Click);
            this.maskedTextBoxID.TextChanged += new System.EventHandler(this.maskedTextBoxID_TextChanged);
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxLastName.Location = new System.Drawing.Point(158, 30);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxLastName.TabIndex = 2;
            this.tips.SetToolTip(this.textBoxLastName, "Type new patient\'s last name");
            this.textBoxLastName.TextChanged += new System.EventHandler(this.textBoxLastName_TextChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxName.Location = new System.Drawing.Point(18, 30);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 0;
            this.tips.SetToolTip(this.textBoxName, "Type new patient\'s name");
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // AddPatientForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.CancelButton = this.buttonExit;
            this.ClientSize = new System.Drawing.Size(406, 423);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "AddPatientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Patient";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddPatientForm_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxMI;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelBirthPlace;
        private System.Windows.Forms.Label labelSex;
        private System.Windows.Forms.Label labelDOB;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxID;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonAddP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBoxOccupation;
        private System.Windows.Forms.RadioButton radioButtonNoOccupation;
        private System.Windows.Forms.RadioButton radioButtonStudent;
        private System.Windows.Forms.RadioButton radioButtonEmployed;
        private System.Windows.Forms.RadioButton radioButtonUnemployed;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioButtonPositive;
        private System.Windows.Forms.RadioButton radioButtonNegative;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButton0I;
        private System.Windows.Forms.RadioButton radioButtonABIV;
        private System.Windows.Forms.RadioButton radioButtonBIII;
        private System.Windows.Forms.RadioButton radioButtonAII;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxAllergies;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.RadioButton radioButtonRetired;
        private System.Windows.Forms.ToolTip tips;
    }
}