using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace EESSP
{
    public class Doctor
    {
        public int IDDoc { get; private set; }
        public string UserName { get; private set; }
        public string Password { get; private set; }
        public string Name { get; private set; }
        public string LastName { get; private set; }

        public Doctor(ConnectionClass connectionClass, int IDDoc)
        {
            this.IDDoc = IDDoc;
            createDoc(connectionClass);
        }

        public Doctor(ConnectionClass connectionClass, string IDDoc)
        {
            this.IDDoc = int.Parse(IDDoc);
            createDoc(connectionClass);
        }

        private void createDoc(ConnectionClass connectionClass)
        {
            try
            {
                string query = "select * from doctors WHERE IDDoc=" + IDDoc;
                MySqlDataReader rowReader = connectionClass.execReader(query);
                if (rowReader.HasRows)
                {
                    while (rowReader.Read())
                    {
                        UserName = rowReader["username"].ToString();
                        Password = rowReader["password"].ToString();
                        Name = rowReader["name"].ToString();
                        LastName = rowReader["lastname"].ToString();

                    }
                    rowReader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
