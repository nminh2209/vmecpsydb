using System.Windows.Forms;

namespace EESSP
{
    class HelperForm
    {

        private Form form;

        public HelperForm(Form form)
        {
            this.form = form;
        }

        public void keyDown(object sender, KeyEventArgs e)
        {
            Control ctrl = (Control)sender;
            if (ctrl is TextBox)
            {
                if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
                {
                    form.SelectNextControl(ctrl, true, true, true, true);
                }
                else if (e.KeyCode == Keys.Up)
                {
                    form.SelectNextControl(ctrl, false, true, true, true);
                }
                else return;
            }
            else
            {
                if (e.KeyCode == Keys.Enter)
                {
                    form.SelectNextControl(ctrl, true, true, true, true);
                }
                else if (e.KeyCode == Keys.Up && e.Control)
                {
                    form.SelectNextControl(ctrl, false, true, true, true);
                }
                else return;
            }

            e.Handled = true;
            e.SuppressKeyPress = true;
        }

        public void checkDigit(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void checkDoubles(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        public bool checkedAndNotEmpty(TextBox textBox, MaskedTextBox maskedTextBox, CheckBox checkBox)
        {
            if (maskedTextBox != null) return !maskedTextBox.Text.Equals("") == checkBox.Checked;
            return !textBox.Text.Equals("") == checkBox.Checked;
        }

        public bool isValidEmail(string email)
        {
            if (email.Equals("-")) return true;
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
