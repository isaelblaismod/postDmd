using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateDemandeGplusVPlus.JsonObjects.Demande.Data
{
    class DemandeDataRevenusDepenses : DemandeData
    {
        public string FrmData;
        public string XmlNormalise;
        public DemandeDataRevenusDepenses() { }

        public DemandeDataRevenusDepenses(string data, string xmlNormalise)
        {
            this.FrmData = data;
            this.XmlNormalise = xmlNormalise;
        }
    }
}
