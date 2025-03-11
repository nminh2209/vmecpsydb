using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EESSP
{
    public partial class LoginForm : Form
    {
        public bool UserSuccessfullyAuthenticated { get; private set; }
        public int ConnectedUser { get; private set; }

        //helpers
        private ConnectionClass connectionClass = new ConnectionClass();
        private HelperForm helperForm;

        public LoginForm()
        {
            InitializeComponent();
            helperForm = new HelperForm(this);
        }

        private void buttonShow_MouseDown(object sender, MouseEventArgs e)
        {
            string a = textBoxPassword.Text;
            textBoxPassword.PasswordChar = '\0';
            textBoxPassword.Text = a;
        }

        private void buttonShow_MouseUp(object sender, MouseEventArgs e)
        {
            string a = textBoxPassword.Text;
            textBoxPassword.PasswordChar = '●';
            textBoxPassword.Text = a;
        }

        private void textBoxUsername_KeyDown(object sender, KeyEventArgs e)
        {
            helperForm.keyDown(sender, e);
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            helperForm.keyDown(sender, e);
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            buttonLogin_Click(sender, e);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxUsername.Text != "" && textBoxPassword.Text != "")
                {
                    string query = "select * from doctors WHERE username='" + textBoxUsername.Text + "' AND password='" + textBoxPassword.Text + "'";
                    MySqlDataReader rowReader = connectionClass.execReader(query);
                    if (rowReader.HasRows)
                    {
                        int id = -1;
                        while (rowReader.Read())
                        {
                            id = int.Parse(rowReader["IDDoc"].ToString());

                        }
                        if(id != -1)
                        {
                            ConnectedUser = id;
                            UserSuccessfullyAuthenticated = true;
                            connectionClass.disconnect();
                            Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Data not found", "Information");
                    }
                    rowReader.Close();
                }
                else
                {
                    MessageBox.Show("Username or Password is empty", "Information");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
