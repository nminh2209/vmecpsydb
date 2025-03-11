namespace EESSP
{
    class Consultation
    {
        public int ID { get; private set; }
        public int IdPatient { get; private set; }
        public string CIM { get; private set; }
        public string Date { get; private set; }

        public Consultation(int ID, int IdPatient, string CIM, string Date)
        {
            this.ID = ID;
            this.IdPatient = IdPatient;
            this.CIM = CIM;
            this.Date = Date;
        }
    }
}
