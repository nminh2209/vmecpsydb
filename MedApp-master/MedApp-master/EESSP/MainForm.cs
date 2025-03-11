using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EESSP
{
    public partial class MainForm : Form
    {
        private Doctor userDoctor;
        private ConnectionClass connectionClass = new ConnectionClass();
        private HelperForm helperForm;

        private ArrayList patients;
        public Patient selectedPatient = null;
        private AddPatientForm addForm = null;
        private DiagnosticDialogForm diagnosticForm = null;

        public MainForm(int IdDoc)
        {
            InitializeComponent();
            userDoctor = new Doctor(connectionClass, IdDoc);
            labelDoctor.Text = "Doctor: " + userDoctor.Name + " " + userDoctor.LastName;
            helperForm = new HelperForm(this);
            patientDetails(false);
            //ActiveControl = textBoxSearchN;
        }

        private void buttonAddP_Click(object sender, EventArgs e)
        {
            if (!maskedTextBoxSearchCNP.Text.Equals("") && maskedTextBoxSearchCNP.Text.Length == 13) addForm = new AddPatientForm(connectionClass, userDoctor.IDDoc, maskedTextBoxSearchCNP.Text);
            else addForm = new AddPatientForm(connectionClass, userDoctor.IDDoc);

            addForm.Show();
            addForm.FormClosed += new FormClosedEventHandler(AddPatietForm_FormClosed);
        }

        private void AddPatietForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (addForm.result == DialogResult.OK)
            {
                selectedPatient = addForm.newPatient;
                patientDetails(true);
            }

            buttonCancelSearch_Click(sender, e);
            maskedTextBoxID.Text = string.Empty;
        }
        
        private void buttonList_Click(object sender, EventArgs e)
        {
            new ReportsForm(allPatientsReport1).Show();
        }
        
        private void buttonMyPatients_Click(object sender, EventArgs e)
        {
            myPatientsReport1.SetParameterValue("IdDocParam", userDoctor.IDDoc);
            new ReportsForm(myPatientsReport1).Show();
        }
        
        private void buttonSameDiagnostic_Click(object sender, EventArgs e)
        {
            diagnosticForm = new DiagnosticDialogForm(connectionClass);

            diagnosticForm.Show();
            diagnosticForm.FormClosed += new FormClosedEventHandler(DiagnosticDialogForm_FormClosed);
        }
        
        private void DiagnosticDialogForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!diagnosticForm.CIM.Equals(""))
            {
                sameDiagnosticReport1.SetParameterValue("CimParam", diagnosticForm.CIM);
                new ReportsForm(sameDiagnosticReport1).Show();
            }
        }

        private void buttonCancelSearch_Click(object sender, EventArgs e)
        {
            textBoxSearchN.Text = string.Empty;
            textBoxSearchLN.Text = string.Empty;
            maskedTextBoxSearchCNP.Text = string.Empty;

            dataGridViewPatients.Rows.Clear();
        }

        private void buttonModifyP_Click(object sender, EventArgs e)
        {
            if (selectedPatient == null)
            {
                MessageBox.Show("No patient selected!");
                ActiveControl = textBoxSearchN;
                return;
            }
            
            checkAll(true);

            buttonDiscard.Visible = true;
            buttonRemoveP.Enabled = false;
            buttonConsultationsP.Enabled = false;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            int countCheck = 0; 
           
            string command = "UPDATE patients SET ";
            List<string> paramList = new List<string>();
            List<object> valueList = new List<object>();
            
            if (checkBoxCnp.Checked)
            {
                selectedPatient.getCnpDetails(maskedTextBoxID.Text);
                command += "cnp=@cnp, sex=@sex, DOB=@DOB, RomanianCountry=@RomanianCountry, age=@age";
                paramList.Add("@cnp"); valueList.Add(selectedPatient.CNP);
                paramList.Add("@sex"); valueList.Add(selectedPatient.Sex);
                paramList.Add("@DOB"); valueList.Add(selectedPatient.DateOfBirth.ToString("dd - MMM - yyyy"));
                paramList.Add("@RomanianCountry"); valueList.Add(selectedPatient.BirthPlace);
                paramList.Add("@age"); valueList.Add(selectedPatient.Age);
                countCheck++;
            }
            if (checkBoxName.Checked)
            {
                if (countCheck > 0) command += ", ";
                command += "name=@name";
                paramList.Add("@name"); valueList.Add(textBoxName.Text);
                countCheck++;
            }
            if (checkBoxLastName.Checked)
            {
                if (countCheck > 0) command += ", ";
                command += "lastname=@lastname";
                paramList.Add("@lastname"); valueList.Add(textBoxLastName.Text);
                countCheck++;
            }
            if (checkBoxMI.Checked)
            {
                if (countCheck > 0) command += ", ";
                command += "MI=@MI";
                paramList.Add("@MI"); valueList.Add(textBoxMI.Text);
                countCheck++;
            }
            if (checkBoxEmail.Checked)
            {
                if (countCheck > 0) command += ", ";
                command += "email=@email";
                paramList.Add("@email"); valueList.Add(textBoxEmail.Text);
                countCheck++;
            }
            if (checkBoxOccupation.Checked)
            {
                if (countCheck > 0) command += ", ";
                command += "occupation=@occupation";
                paramList.Add("@occupation"); valueList.Add(textBoxOccupation.Text);
                countCheck++;
            }
            if (checkBoxAddress.Checked)
            {
                if (countCheck > 0) command += ", ";
                command += "address=@address";
                paramList.Add("@address"); valueList.Add(textBoxAddress.Text);
                countCheck++;
            }
            if (checkBoxWeight.Checked)
            {
                if (countCheck > 0) command += ", ";
                command += "weight=@weight";
                paramList.Add("@weight"); valueList.Add(double.Parse(textBoxWeight.Text));
            }
            if (checkBoxHeight.Checked)
            {
                if (countCheck > 0) command += ", ";
                command += "height=@height";
                paramList.Add("@height"); valueList.Add(double.Parse(textBoxHeight.Text));
            }
            if (checkBoxAllergies.Checked)
            {
                if (countCheck > 0) command += ", ";
                command += "allergies=@allergies";
                paramList.Add("@allergies"); valueList.Add(textBoxAllergies.Text);
                countCheck++;
            }

            command += " WHERE ID=@ID";
            paramList.Add("@ID"); valueList.Add(selectedPatient.ID);

            if (connectionClass.sqlCommand(command, paramList, valueList, "Patient could not be modified!"))
            {
                buttonDiscard_Click(sender, e);
                selectedPatient = connectionClass.updatePatient(selectedPatient.ID);
                patientDetails(true);
            }
        }

        private void buttonDiscard_Click(object sender, EventArgs e)
        {
            textBoxOccupation.Text = string.Empty;
            comboBoxOccupation.Text = string.Empty;
            maskedTextBoxID.Text = string.Empty;

            checkAll(false);

            buttonRemoveP.Enabled = true;
            buttonConsultationsP.Enabled = true;
            
            buttonConfirm.Visible = false;
            buttonDiscard.Visible = false;

            ActiveControl = textBoxSearchN;
        }

        private void buttonConsultationsP_Click(object sender, EventArgs e)
        {
            if (selectedPatient == null)
            {
                MessageBox.Show("No patient selected!");
                ActiveControl = textBoxSearchN;
                return;
            }
            new ConsultationsForm(connectionClass, selectedPatient).Show();
        }

        private void buttonRemoveP_Click(object sender, EventArgs e)
        {
            if (selectedPatient == null)
            {
                MessageBox.Show("No patient selected!");
                ActiveControl = textBoxSearchN;
                return;
            }

            var confirmResult = MessageBox.Show("Warning! Deleting this patient implies deleting all its consultations as well.\nAre you sure you want to delete this patient?", "Delete Patient", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                string command = "DELETE FROM consultations WHERE IdPatient=@IdPatient";
                List<string> paramList = new List<string>();
                List<object> valueList = new List<object>();
                paramList.Add("@IdPatient"); valueList.Add(selectedPatient.ID);

                if (connectionClass.sqlCommand(command, paramList, valueList, "Patient's consultations could not be deleted!"))
                {
                    command = "DELETE FROM patients WHERE ID=@ID";
                    paramList = new List<string>();
                    valueList = new List<object>();
                    paramList.Add("@ID"); valueList.Add(selectedPatient.ID);

                    if (connectionClass.sqlCommand(command, paramList, valueList, "Patient could not be deleted!"))
                    {
                        buttonChangeP_Click(sender, e);
                    }
                }
            }
        }

        private void buttonChangeP_Click(object sender, EventArgs e)
        {
            if (selectedPatient == null)
            {
                MessageBox.Show("No patient selected!");
                ActiveControl = textBoxSearchN;
                return;
            }
            patientDetails(false);
            buttonDiscard_Click(sender, e);
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, helpProviderExample.HelpNamespace);
        }

        private void textBoxSearchN_TextChanged(object sender, EventArgs e)
        {
            if (checkNoEmptySearch()) updateDataGrid();
            else dataGridViewPatients.Rows.Clear();
        }

        private void textBoxSearchLN_TextChanged(object sender, EventArgs e)
        {
            if (checkNoEmptySearch()) updateDataGrid();
            else dataGridViewPatients.Rows.Clear();
        }

        private void maskedTextBoxSearchCNP_Click(object sender, EventArgs e)
        {
            maskedTextBoxSearchCNP.Select(0, 0);
        }

        private void maskedTextBoxSearchCNP_TextChanged(object sender, EventArgs e)
        {
            if (checkNoEmptySearch()) updateDataGrid();
            else dataGridViewPatients.Rows.Clear();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            buttonConfirm.Enabled = checkAllNotEmptyFields();
        }

        private void textBoxMI_TextChanged(object sender, EventArgs e)
        {
            buttonConfirm.Enabled = checkAllNotEmptyFields();
        }

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {
            buttonConfirm.Enabled = checkAllNotEmptyFields();
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            buttonConfirm.Enabled = checkAllNotEmptyFields();
        }

        private void textBoxAddress_TextChanged(object sender, EventArgs e)
        {
            buttonConfirm.Enabled = checkAllNotEmptyFields();
        }

        private void textBoxHeight_TextChanged(object sender, EventArgs e)
        {
            buttonConfirm.Enabled = checkAllNotEmptyFields();
        }

        private void textBoxWeight_TextChanged(object sender, EventArgs e)
        {
            buttonConfirm.Enabled = checkAllNotEmptyFields();
        }

        private void textBoxAllergies_TextChanged(object sender, EventArgs e)
        {
            buttonConfirm.Enabled = checkAllNotEmptyFields();
        }

        private void dataGridViewPatients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedPatient = (Patient)patients[e.RowIndex];
                if (selectedPatient != null)
                {
                    patientDetails(true);

                    string command = "UPDATE patients SET age=@age WHERE ID=@ID";
                    List<string> paramList = new List<string>();
                    List<object> valueList = new List<object>();
                    paramList.Add("@age"); valueList.Add(selectedPatient.Age);
                    paramList.Add("@ID"); valueList.Add(selectedPatient.ID);

                    connectionClass.sqlCommand(command, paramList, valueList, "Patient could not be updated!");
                    buttonCancelSearch_Click(sender, e);
                    ActiveControl = buttonModifyP;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Choose a valid row.\n" + ex.ToString());
            }
        }

        private void comboBoxOccupation_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxOccupation.Text = (comboBoxOccupation.Text.Equals("EMPLOYED")) ? "" : comboBoxOccupation.Text;
            textBoxOccupation.Visible = comboBoxOccupation.Text.Equals("EMPLOYED");
            if (textBoxOccupation.Visible) ActiveControl = textBoxOccupation;
        }

        private void comboBoxOccupation_Enter(object sender, EventArgs e)
        {
            ActiveControl = buttonConfirm;
        }

        private void textBoxOccupation_TextChanged(object sender, EventArgs e)
        {
            buttonConfirm.Enabled = checkAllNotEmptyFields();
        }

        private void maskedTextBoxID_Click(object sender, EventArgs e)
        {
            maskedTextBoxID.Select(0, 0);
        }

        private void maskedTextBoxID_TextChanged(object sender, EventArgs e)
        {
            buttonConfirm.Enabled = false;
            if (!checkAllNotEmptyFields()) return;

            if (maskedTextBoxID.Text.Length == 13)
            {
                if (connectionClass.checkCNP(maskedTextBoxID.Text) != null)
                {
                    buttonConfirm.Enabled = true;
                }
                else MessageBox.Show("CNP already exists.");
            }
        }

        private void checkBoxName_CheckedChanged(object sender, EventArgs e)
        {
            textBoxName.Visible = checkBoxName.Checked;
            if (checkBoxName.Checked) ActiveControl = textBoxName;
            if (!textBoxName.Visible) textBoxName.Text = "";
        }

        private void checkBoxLastName_CheckedChanged(object sender, EventArgs e)
        {
            textBoxLastName.Visible = checkBoxLastName.Checked;
            if (checkBoxLastName.Checked) ActiveControl = textBoxLastName;
            if (!textBoxLastName.Visible) textBoxLastName.Text = "";
        }

        private void checkBoxMI_CheckedChanged(object sender, EventArgs e)
        {
            textBoxMI.Visible = checkBoxMI.Checked;
            if (checkBoxMI.Checked) ActiveControl = textBoxMI;
            if (!textBoxMI.Visible) textBoxMI.Text = "";
        }

        private void checkBoxCnp_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBoxID.Visible = checkBoxCnp.Checked;
            if (checkBoxCnp.Checked) ActiveControl = maskedTextBoxID;
            if (!maskedTextBoxID.Visible) maskedTextBoxID.Text = "";
        }

        private void checkBoxEmail_CheckedChanged(object sender, EventArgs e)
        {
            textBoxEmail.Visible = checkBoxEmail.Checked;
            if (checkBoxEmail.Checked) ActiveControl = textBoxEmail;
            if (!textBoxEmail.Visible) textBoxEmail.Text = "";
        }

        private void checkBoxOccupation_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxOccupation.Visible = checkBoxOccupation.Checked;
            if (checkBoxOccupation.Checked) ActiveControl = comboBoxOccupation;
            if (!comboBoxOccupation.Visible)
            {
                textBoxOccupation.Visible = false;
                textBoxOccupation.Text = "";
            }
        }

        private void checkBoxAddress_CheckedChanged(object sender, EventArgs e)
        {
            textBoxAddress.Visible = checkBoxAddress.Checked;
            if (checkBoxAddress.Checked) ActiveControl = textBoxAddress;
            if (!textBoxAddress.Visible) textBoxAddress.Text = "";
        }

        private void checkBoxHeight_CheckedChanged(object sender, EventArgs e)
        {
            textBoxHeight.Visible = checkBoxHeight.Checked;
            if (checkBoxHeight.Checked) ActiveControl = textBoxHeight;
            if (!textBoxHeight.Visible) textBoxHeight.Text = "";
        }

        private void checkBoxWeight_CheckedChanged(object sender, EventArgs e)
        {
            textBoxWeight.Visible = checkBoxWeight.Checked;
            if (checkBoxWeight.Checked) ActiveControl = textBoxWeight;
            if (!textBoxWeight.Visible) textBoxWeight.Text = "";
        }

        private void checkBoxAllergies_CheckedChanged(object sender, EventArgs e)
        {
            textBoxAllergies.Visible = checkBoxAllergies.Checked;
            if (checkBoxAllergies.Checked) ActiveControl = textBoxAllergies;
            if (!textBoxAllergies.Visible) textBoxAllergies.Text = "";
        }

        private void textBoxWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            helperForm.checkDoubles(sender, e);
        }

        private void textBoxHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            helperForm.checkDigit(sender, e);
        }

        private void textBoxHeight_VisibleChanged(object sender, EventArgs e)
        {
            labelCm.Visible = textBoxHeight.Visible;
        }

        private void textBoxWeight_VisibleChanged(object sender, EventArgs e)
        {
            labelKg.Visible = textBoxWeight.Visible;
        }

        private void updateDataGrid()
        {
            string query = "select * from patients where ";
            query += "name like \'" + textBoxSearchN.Text + "%\' and ";
            query += "lastname like \'" + textBoxSearchLN.Text + "%\' and ";
            query += "CNP like \'" + maskedTextBoxSearchCNP.Text + "%\'";

            patients = connectionClass.getPatientsData(query);

            dataGridViewPatients.Rows.Clear();

            if (patients != null)
            {
                dataGridViewPatients.Visible = patients.Count > 0;
                buttonCancelSearch.Visible = patients.Count > 0;

                foreach (Patient p in patients)
                {
                    DataGridViewRow newRow = new DataGridViewRow();

                    newRow.CreateCells(dataGridViewPatients);
                    newRow.Cells[0].Value = p.Name;
                    newRow.Cells[1].Value = p.MiddleInitials;
                    newRow.Cells[2].Value = p.LastName;
                    newRow.Cells[3].Value = p.CNP;
                    dataGridViewPatients.Rows.Add(newRow);
                }
            }
            else
            {
                dataGridViewPatients.Visible = false;
                buttonCancelSearch.Visible = false;
            }
        }

        private bool checkAllNotEmptyFields()
        {
            var emailValid = (checkBoxEmail.Checked) ? helperForm.isValidEmail(textBoxEmail.Text) : true;
            return helperForm.checkedAndNotEmpty(textBoxName, null, checkBoxName) &&
                helperForm.checkedAndNotEmpty(textBoxLastName, null, checkBoxLastName) &&
                helperForm.checkedAndNotEmpty(null, maskedTextBoxID, checkBoxCnp) &&
                helperForm.checkedAndNotEmpty(textBoxMI, null, checkBoxMI) &&
                helperForm.checkedAndNotEmpty(textBoxOccupation, null, checkBoxOccupation) &&
                helperForm.checkedAndNotEmpty(textBoxEmail, null, checkBoxEmail) && emailValid &&
                helperForm.checkedAndNotEmpty(textBoxAddress, null, checkBoxAddress) &&
                helperForm.checkedAndNotEmpty(textBoxHeight, null, checkBoxHeight) &&
                helperForm.checkedAndNotEmpty(textBoxWeight, null, checkBoxWeight) &&
                helperForm.checkedAndNotEmpty(textBoxAllergies, null, checkBoxAllergies);
        }

        private bool checkNoEmptySearch()
        {
            if (textBoxSearchN.Text == string.Empty &&
                textBoxSearchLN.Text == string.Empty &&
                maskedTextBoxSearchCNP.Text == string.Empty)
            {
                dataGridViewPatients.Visible = false;
                buttonCancelSearch.Visible = false;
                return false;
            }
            return true;
        }

        private void patientDetails(bool show)
        {
            labelName.Text = (show) ? selectedPatient.Name : string.Empty;
            labelMI.Text = (show) ? selectedPatient.MiddleInitials : string.Empty;
            labelLastName.Text = (show) ? selectedPatient.LastName : string.Empty;
            labelCNP.Text = (show) ? selectedPatient.CNP : string.Empty;
            labelEmail.Text = (show) ? selectedPatient.Email : string.Empty;
            labelOccupation.Text = (show) ? selectedPatient.Occupation : string.Empty;
            labelAddress.Text = (show) ? selectedPatient.Address : string.Empty;
            labelDOB.Text = (show) ? selectedPatient.DateOfBirth.ToString("dd-MMM-yyyy") : string.Empty;
            labelBirthPlace.Text = (show) ? selectedPatient.BirthPlace : string.Empty;
            labelAge.Text = (show) ? selectedPatient.Age.ToString() : string.Empty;
            labelSex.Text = (show) ? selectedPatient.Sex : string.Empty;
            labelBloodType.Text = (show) ? selectedPatient.BloodType : string.Empty;
            labelRh.Text = (show) ? selectedPatient.Rh : string.Empty;
            labelWeight.Text = (show) ? selectedPatient.Weight.ToString() + " kg" : string.Empty;
            labelHeight.Text = (show) ? selectedPatient.Height.ToString() + " cm" : string.Empty;
            labelAllergies.Text = (show) ? selectedPatient.Allergies : string.Empty;
            if (show) selectedPatient.getDoc(connectionClass);
            labelRefDoc.Text = (show) ? selectedPatient.ReferingDoctor.Name + " " + selectedPatient.ReferingDoctor.LastName : string.Empty;
        }

        private void checkAll(bool visible)
        {
            if (visible) buttonConfirm.Visible = true;
            else
            {
                checkBoxName.Checked = false;
                checkBoxLastName.Checked = false;
                checkBoxMI.Checked = false;
                checkBoxEmail.Checked = false;
                checkBoxOccupation.Checked = false;
                checkBoxAddress.Checked = false;
                checkBoxCnp.Checked = false;
                checkBoxHeight.Checked = false;
                checkBoxWeight.Checked = false;
                checkBoxAllergies.Checked = false;
            }

            checkBoxName.Visible = visible;
            checkBoxLastName.Visible = visible;
            checkBoxMI.Visible = visible;
            checkBoxEmail.Visible = visible;
            checkBoxOccupation.Visible = visible;
            checkBoxAddress.Visible = visible;
            checkBoxCnp.Visible = visible;
            checkBoxHeight.Visible = visible;
            checkBoxWeight.Visible = visible;
            checkBoxAllergies.Visible = visible;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A) buttonAddP_Click(sender, e);
            if (e.Control && e.KeyCode == Keys.H) buttonHelp_Click(sender, e);
            if (e.Control && e.Shift && e.KeyCode == Keys.A) buttonList_Click(sender, e);
            if (e.Control && e.Shift && e.KeyCode == Keys.M) buttonMyPatients_Click(sender, e);
            if (e.Control && e.Shift && e.KeyCode == Keys.D) buttonSameDiagnostic_Click(sender, e);
            if (e.Control && e.KeyCode == Keys.M) buttonModifyP_Click(sender, e);
            if (e.KeyCode == Keys.Enter)
                if (buttonConfirm.Enabled) buttonConfirm_Click(sender, e);
            if (e.Control && e.KeyCode == Keys.Delete)
            {
                if (buttonRemoveP.Enabled) buttonRemoveP_Click(sender, e);
                else if (!buttonRemoveP.Enabled) buttonDiscard_Click(sender, e);
                else buttonCancelSearch_Click(sender, e);
            }
            if (e.Control && e.Shift && e.KeyCode == Keys.C) buttonConsultationsP_Click(sender, e);
            if (e.Control && e.Shift && e.KeyCode == Keys.P) buttonChangeP_Click(sender, e);

        }
    }
}
