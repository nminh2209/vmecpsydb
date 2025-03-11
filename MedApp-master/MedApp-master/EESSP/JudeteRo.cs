using System.Windows.Forms;

namespace EESSP
{
    class JudeteRo
    {
        public string getJudet(string cod)
        {
            switch (cod)
            {
                case "01": return "ALBA";
                case "02": return "ARAD";
                case "03": return "ARGES";
                case "04": return "BACAU";
                case "05": return "BIHOR";
                case "06": return "BISTRITA-NASAUD";
                case "07": return "BOTOSANI";
                case "08": return "BRASOV";
                case "09": return "BRAILA";
                case "10": return "BUZAU";
                case "11": return "CARAS-SEVERIN";
                case "12": return "CLUJ";
                case "13": return "CONSTANTA";
                case "14": return "COVASNA";
                case "15": return "DAMBOVITA";
                case "16": return "DOLJ";
                case "17": return "GALATI";
                case "18": return "GORJ";
                case "19": return "HARGHITA";
                case "20": return "HUNEDOARA";
                case "21": return "IALOMITA";
                case "22": return "IASI";
                case "23": return "IFLOV";
                case "24": return "MARAMURES";
                case "25": return "MEHEDINTI";
                case "26": return "MURES";
                case "27": return "NEAMT";
                case "28": return "OLT";
                case "29": return "PRAHOVA";
                case "30": return "SATU MARE";
                case "31": return "SALAJ";
                case "32": return "SIBIU";
                case "33": return "SUCEAVA";
                case "34": return "TELEORMAN";
                case "35": return "TIMIS";
                case "36": return "TULCEA";
                case "37": return "VASLUI";
                case "38": return "VALCEA";
                case "39": return "VRANCEA";
                case "40": return "BUCURESTI";
                case "41": return "BUCURESTI - SECTOR 1";
                case "42": return "BUCURESTI - SECTOR 2";
                case "43": return "BUCURESTI - SECTOR 3";
                case "44": return "BUCURESTI - SECTOR 4";
                case "45": return "BUCURESTI - SECTOR 5";
                case "46": return "BUCURESTI - SECTOR 6";
                case "51": return "CALARASI";
                case "52": return "GIURGIU";
                default:
                    MessageBox.Show("Invalid CNP!");
                    break;
            }
            return null;
        }
    }
}
