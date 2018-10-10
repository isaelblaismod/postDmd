using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateDemandeGplusVPlus.JsonObjects.Demande.Data
{
    class DemandeDataInspection : DemandeData
    {
        public string FrmData;
        public string XmlNormalise;
        public DemandeDataInspection() { }

        public DemandeDataInspection(string data, string xmlNormalise)
        {
            this.FrmData = data;
            this.XmlNormalise = xmlNormalise;
        }
    }
}
