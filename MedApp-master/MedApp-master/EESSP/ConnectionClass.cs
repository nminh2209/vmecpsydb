using CrystalDecisions.CrystalReports.Engine;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace EESSP
{
    public class ConnectionClass
    {
        private MySqlConnection mySqlConn { get; set; }

        public ConnectionClass()
        {
            connect();
        }

        public MySqlDataReader execReader(string query)
        {
            MySqlCommand command = new MySqlCommand(query, mySqlConn);
            return command.ExecuteReader();
        }

        public bool sqlCommand(string command, List<string> paramList, List<object> valueList, string except)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = mySqlConn;
                cmd.CommandText = command;
                cmd.Prepare();
                
                for(int i=0; i<paramList.Count; i++)
                    cmd.Parameters.AddWithValue(paramList[i], valueList[i]);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(except);
                Console.Write(ex);
            }
            return false;
        }

        public ArrayList getPatientsData(string query)
        {
            MySqlDataReader rowReader = null;
            try
            {
                ArrayList listPatients = new ArrayList();

                rowReader = execReader(query);
                if (rowReader.HasRows)
                {
                    while (rowReader.Read())
                    {
                        Patient p = readPatientRow(rowReader);
                        listPatients.Add(p);
                    }
                }
                rowReader.Close();
                if (listPatients.Count != 0) return listPatients;
            }
            catch (Exception ex)
            {
                if(rowReader != null) rowReader.Close();
                Console.Write(ex);
            }

            return null;
        }

        public Patient updatePatient(int ID)
        {
            MySqlDataReader rowReader = null;
            Patient patient = null;

            try
            {
                string query = "select * from patients WHERE ID=" + ID;
                rowReader = execReader(query);
                if (rowReader.HasRows)
                {
                    while (rowReader.Read())
                    {
                        patient = readPatientRow(rowReader);
                    }
                }
                rowReader.Close();
            }
            catch (Exception ex)
            {
                if (rowReader != null) rowReader.Close();
                Console.Write(ex);
            }

            if (patient != null) patient.getDoc(this);
            return patient;
        }

        public Patient checkCNP(string cnp)
        {
            MySqlDataReader rowReader = null;
            Patient patient = null;
            try
            {
                string query = "select * from patients WHERE cnp=\'" + cnp + "\'";
                rowReader = execReader(query);
                if (rowReader.HasRows)
                {
                    while (rowReader.Read())
                    {
                        patient = readPatientRow(rowReader);
                    }
                }
                rowReader.Close();

                return patient;
            }
            catch (Exception ex)
            {
                if (rowReader != null) rowReader.Close();
                Console.Write(ex);
            }

            return null;
        }

        public int getLastConsultation()
        {
            MySqlDataReader rowReader = null;
            int ID = -1;

            try
            {
                string query = "select * from consultations order by ID desc limit 1";
                rowReader = execReader(query);
                if (rowReader.HasRows)
                {
                    while (rowReader.Read())
                    {
                        ID = int.Parse(rowReader["ID"].ToString()) + 1;
                    }
                }
                rowReader.Close();

                if (ID == -1) return 1;
                return ID;
            }
            catch (Exception ex)
            {
                if (rowReader != null) rowReader.Close();
                Console.Write(ex);
            }

            return ID;
        }

        public ArrayList getListCIM()
        {
            MySqlDataReader rowReader = null;
            try
            {
                ArrayList listCim = new ArrayList();

                string query = "select * from cim";
                rowReader = execReader(query);
                if (rowReader.HasRows)
                {
                    while (rowReader.Read())
                    {
                        CimCodes cim = new CimCodes(rowReader["ID"].ToString(), rowReader["name"].ToString());
                        listCim.Add(cim);
                    }
                }
                rowReader.Close();
                if (listCim.Count != 0) return listCim;
            }
            catch (Exception ex)
            {
                if (rowReader != null) rowReader.Close();
                Console.Write(ex);
            }

            return null;
        }

        public ArrayList getConsultationsData(string query)
        {
            MySqlDataReader rowReader = null;
            try
            {
                ArrayList listConsultations = new ArrayList();

                rowReader = execReader(query);
                if (rowReader.HasRows)
                {
                    while (rowReader.Read())
                    {
                        int ID = int.Parse(rowReader["ID"].ToString());
                        int IdPatient = int.Parse(rowReader["IdPatient"].ToString());
                        string CIM = rowReader["CIM"].ToString();
                        string ConsDate = rowReader["ConsDate"].ToString();
                        Consultation cons = new Consultation(ID, IdPatient, CIM, ConsDate);
                        listConsultations.Add(cons);
                    }
                }
                rowReader.Close();
                if (listConsultations.Count != 0) return listConsultations;
            }
            catch (Exception ex)
            {
                if (rowReader != null) rowReader.Close();
                Console.Write(ex);
            }
            return null;
        }

        private void connect()
        {
            try
            {
                string mySqlStr = "Server=localhost;Database=eessp;Uid=root;Pwd=parola";
                mySqlConn = new MySqlConnection(mySqlStr);
                mySqlConn.Open();
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
        }

        public void disconnect()
        {
            mySqlConn.Close();
        }

        private Patient readPatientRow(MySqlDataReader rowReader)
        {
            Patient patient = null;
            try
            {
                int ID = int.Parse(rowReader["ID"].ToString());
                int idDoc = int.Parse(rowReader["IDDoc"].ToString());
                string name = rowReader["name"].ToString();
                string mi = rowReader["MI"].ToString();
                string lastName = rowReader["lastname"].ToString();
                string cnp = rowReader["CNP"].ToString();
                string email = rowReader["email"].ToString();
                string occupation = rowReader["occupation"].ToString();
                string address = rowReader["address"].ToString();
                double weight = double.Parse(rowReader["weight"].ToString());
                double height = double.Parse(rowReader["height"].ToString());
                string bloodType = rowReader["bloodType"].ToString();
                string rh = rowReader["rh"].ToString();
                string allergies = rowReader["allergies"].ToString();
                patient = new Patient(ID,idDoc,name,mi,lastName,cnp,email,occupation,address,bloodType,rh,height,weight,allergies);
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
            return patient;
        }
    }
}
