using System;

namespace EESSP
{
    public class Patient
    {
        public int ID { get; private set; }
        public Doctor ReferingDoctor { get; private set; }
        public string Name { get; private set; }
        public string MiddleInitials { get; private set; }
        public string LastName { get; private set; }
        public string CNP { get; private set; }
        public string Email { get; private set; }
        public string Occupation { get; private set; }
        public string Address { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public string BirthPlace { get; private set; }
        public int Age { get; private set; }
        public string Sex { get; private set; }
        public string RegisterNr { get; private set; }
        public string BloodType { get; private set; }
        public string Rh { get; private set; }
        public double Height { get; private set; }
        public double Weight { get; private set; }
        public string Allergies { get; private set; }

        private int IDDoc;

        public Patient() { }

        public Patient(int ID, int IDDoc, string Name, string MiddleInitials, string LastName, string CNP, string Email, string Occupation, string Address, string BloodType, string Rh, double Height, double Weight, string Allergies)
        {
            this.ID = ID;
            this.IDDoc = IDDoc;
            this.Name = Name;
            this.MiddleInitials = MiddleInitials;
            this.LastName = LastName;
            this.CNP = CNP;
            this.Email = Email;
            this.Occupation = Occupation;
            this.Address = Address;
            this.BloodType = BloodType;
            this.Rh = Rh;
            this.Height = Height;
            this.Weight = Weight;
            this.Allergies = Allergies;

            getCnpDetails(CNP);
        }

        public void getDoc(ConnectionClass connectionClass)
        {
            ReferingDoctor = new Doctor(connectionClass, IDDoc);
        }

        public void getCnpDetails(string cnp)
        {
            CNP = cnp;

            string str = cnp.Substring(0, 1);
            string yearPrefix = (str.Equals("1") || str.Equals("2")) ? "19" : ((str.Equals("3") || str.Equals("4")) ? "18" : "20");
            Sex = (str.Equals("1") || str.Equals("3") || str.Equals("5")) ? "M" : "F";
            DateOfBirth = DateTime.Parse(cnp.Substring(5, 2) + "-" + cnp.Substring(3, 2) + "-" + yearPrefix + cnp.Substring(1, 2));
            Age = getAge(DateOfBirth);
            BirthPlace = new JudeteRo().getJudet(cnp.Substring(7, 2));
            RegisterNr = cnp.Substring(9, 3);
        }

        //get age from date of birth method
        private int getAge(DateTime dateOfBirth)
        {
            var today = DateTime.Today;
            var age = today.Year - dateOfBirth.Year;
            if (dateOfBirth.Date > today.AddYears(-age)) age--;
            return age;
        }
    }
}
