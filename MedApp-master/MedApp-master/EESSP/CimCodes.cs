using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EESSP
{
    class CimCodes
    {
        public string ID { get; private set; }
        public string Diagnostic { get; private set; }

        public CimCodes (string ID, string Diagnostic)
        {
            this.ID = ID;
            this.Diagnostic = Diagnostic;
        }

        public CimCodes(ArrayList Cims, string knownValue, string unknownParam)
        {
            if (unknownParam.Equals("Diagnostic")) getDiagnostic(Cims, knownValue);
            else getCIM(Cims, knownValue);
        }

        private void getCIM(ArrayList cims, string Diagnostic)
        {
            this.Diagnostic = Diagnostic;
            foreach (CimCodes cim in cims)
            {
                if (cim.Diagnostic.Equals(Diagnostic))
                {
                    ID = cim.ID;
                    break;
                }
            }
            this.ID = ID;
        }

        private void getDiagnostic(ArrayList cims, string ID)
        {
            this.ID = ID;
            foreach (CimCodes cim in cims)
            {
                if (cim.ID.Equals(ID))
                {
                    Diagnostic = cim.Diagnostic;
                }
            }
        }
    }
}
