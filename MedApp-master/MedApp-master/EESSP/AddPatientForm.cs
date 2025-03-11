using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EESSP
{
    public partial class AddPatientForm : Form
    {
        public Patient newPatient { get; private set; }
        public DialogResult result { get; private set; }

        private ConnectionClass connectionClass;
        private HelperForm helperForm;
        private int IdDoc;

        private void startForm(ConnectionClass connectionClass, int IdDoc)
        {
            InitializeComponent();
            this.connectionClass = connectionClass;
            this.IdDoc = IdDoc;
            buttonAddP.Enabled = false;
            newPatient = null;
            ActiveControl = textBoxName;
            helperForm = new HelperForm(this);
        }

        public AddPatientForm(ConnectionClass connectionClass, int IdDoc)
        {
            startForm(connectionClass, IdDoc);
            patientCNPDetails(null);
        }

        public AddPatientForm(ConnectionClass connectionClass, int IdDoc, string cnp)
        {
            maskedTextBoxID.Text = cnp;
            startForm(connectionClass, IdDoc);
            patientCNPDetails(null);
        }

        private void buttonAddP_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
            if (!helperForm.isValidEmail(email))
            {
                MessageBox.Show("Email format is not correct!");
                return;
            }
            string cnp = maskedTextBoxID.Text;
            string name = textBoxName.Text;
            string lastname = textBoxLastName.Text;
            string MI = textBoxMI.Text;
            string address = textBoxAddress.Text;
            double weight = double.Parse(textBoxWeight.Text);
            double height = double.Parse(textBoxHeight.Text);
            string bloodType = (radioButton0I.Checked) ? "O (I)" : (
                    (radioButtonAII.Checked) ? "A (II)" : (
                    (radioButtonBIII.Checked) ? "B (III)" : "AB (IV)"));
            string rh = (radioButtonPositive.Checked) ? "POSITIVE" : "NEGATIVE";
            string occupation = (radioButtonNoOccupation.Checked) ? "NO OCCUPATION" : (
                    (radioButtonStudent.Checked) ? "STUDENT" : (
                    (radioButtonRetired.Checked) ? "RETIRED" : (
                    (radioButtonUnemployed.Checked) ? "UNEMPLOYED" : textBoxOccupation.Text)));
            string allergies = textBoxAllergies.Text;

            string command = "INSERT INTO patients(IDDoc,name,MI,lastname,cnp,email,address,";
            command += "occupation,sex,DOB,RomanianCountry,age,weight,height,bloodType,rh,allergies) ";
            command += "VALUES(@IDDoc,@name,@MI,@lastname,@cnp,@email,@address,";
            command += "@occupation,@sex,@DOB,@RomanianCountry,@age,@weight,@height,@bloodType,@rh,@allergies)";
            List<string> paramList = new List<string>();
            List<object> valueList = new List<object>();
            paramList.Add("@IDDoc");           valueList.Add(IdDoc);
            paramList.Add("@name");            valueList.Add(name);
            paramList.Add("@MI");              valueList.Add(MI);
            paramList.Add("@lastname");        valueList.Add(lastname);
            paramList.Add("@cnp");             valueList.Add(cnp);
            paramList.Add("@email");           valueList.Add(email);
            paramList.Add("@address");         valueList.Add(address);
            paramList.Add("@occupation");      valueList.Add(occupation);
            paramList.Add("@sex");             valueList.Add(labelSex.Text);
            paramList.Add("@DOB");             valueList.Add(labelDOB.Text);
            paramList.Add("@RomanianCountry"); valueList.Add(labelBirthPlace.Text);
            paramList.Add("@age");             valueList.Add(int.Parse(labelAge.Text));
            paramList.Add("@weight");          valueList.Add(weight);
            paramList.Add("@height");          valueList.Add(height);
            paramList.Add("@bloodType");       valueList.Add(bloodType);
            paramList.Add("@rh");              valueList.Add(rh);
            paramList.Add("@allergies");       valueList.Add(allergies);

            if (connectionClass.sqlCommand(command, paramList, valueList, "Patient CNP already exists!"))
            {
                newPatient = connectionClass.checkCNP(cnp);
                newPatient.getDoc(connectionClass);
                result = MessageBox.Show("Successfully inserted!");
                emptyFields();
            }
            else maskedTextBoxID.Text = string.Empty;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void maskedTextBoxID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (maskedTextBoxID.Text.Equals(string.Empty))
                {
                    patientCNPDetails(null);
                }

                if (maskedTextBoxID.Text.Length == 13)
                {
                    Patient patient = new Patient();
                    patient.getCnpDetails(maskedTextBoxID.Text);
                    patientCNPDetails(patient);

                    checkForEmptyField();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void maskedTextBoxID_Click(object sender, EventArgs e)
        {
            maskedTextBoxID.Select(0, 0);
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            checkForEmptyField();
        }

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {
            checkForEmptyField();
        }

        private void textBoxMI_TextChanged(object sender, EventArgs e)
        {
            checkForEmptyField();
        }

        private void textBoxAddress_TextChanged(object sender, EventArgs e)
        {
            checkForEmptyField();
        }

        private void textBoxHeight_TextChanged(object sender, EventArgs e)
        {
            checkForEmptyField();
        }

        private void textBoxHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            helperForm.checkDigit(sender,e);
        }

        private void textBoxWeight_TextChanged(object sender, EventArgs e)
        {
            checkForEmptyField();
        }

        private void textBoxWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            helperForm.checkDoubles(sender, e);
        }

        private void textBoxOccupation_TextChanged(object sender, EventArgs e)
        {
            checkForEmptyField();
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            checkForEmptyField();
        }

        private void textBoxAllergies_TextChanged(object sender, EventArgs e)
        {
            checkForEmptyField();
        }

        private void radioButtonEmployed_CheckedChanged(object sender, EventArgs e)
        {
            textBoxOccupation.Visible = radioButtonEmployed.Checked;
        }

        private void patientCNPDetails(Patient p)
        {
            labelDOB.Text = (p != null) ? p.DateOfBirth.ToString("dd-MMM-yyyy") : string.Empty;
            labelAge.Text = (p != null) ? p.Age.ToString() : string.Empty;
            labelSex.Text = (p != null) ? p.Sex : string.Empty;
            labelBirthPlace.Text = (p != null) ? p.BirthPlace : string.Empty;

            if (p == null) buttonAddP.Enabled = false;
        }

        private void emptyFields()
        {
            maskedTextBoxID.Text = string.Empty;
            textBoxName.Text = string.Empty;
            textBoxLastName.Text = string.Empty;
            textBoxMI.Text = string.Empty;
            textBoxAddress.Text = string.Empty;
            textBoxEmail.Text = string.Empty;
            textBoxWeight.Text = string.Empty;
            textBoxHeight.Text = string.Empty;
            textBoxOccupation.Text = string.Empty;
            textBoxAllergies.Text = "-";

            radioButtonNoOccupation.Checked = true;
            radioButton0I.Checked = true;
            radioButtonPositive.Checked = true;

            buttonAddP.Enabled = false;
        }

        private void checkForEmptyField()
        {
            bool cnp = maskedTextBoxID.Text.Equals("");
            bool name = textBoxName.Text.Equals("");
            bool lastName = textBoxLastName.Text.Equals("");
            bool mi = textBoxMI.Text.Equals("");
            bool address = textBoxAddress.Text.Equals("");
            bool email = textBoxEmail.Text.Equals("");
            bool weight = textBoxWeight.Text.Equals("");
            bool height = textBoxHeight.Text.Equals("");
            bool occupation = (radioButtonEmployed.Checked) ? textBoxOccupation.Text.Equals("") : false;
            bool allergies = textBoxAllergies.Text.Equals("");

            if (cnp || name || lastName || mi || address || email || height || weight || occupation || allergies) buttonAddP.Enabled = false;
            else buttonAddP.Enabled = true;
        }

        private void AddPatientForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && buttonAddP.Enabled) buttonAddP_Click(sender, e);
        }
    }
}
