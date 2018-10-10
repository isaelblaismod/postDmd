using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateDemandeGplusVPlus.JsonObjects.Demande.Data
{
    class DemandeDataEspacesLocatifs : DemandeData
    {
        public string FrmData;
        public string XmlNormalise;
        public DemandeDataEspacesLocatifs() { }

        public DemandeDataEspacesLocatifs(string data, string xmlNormalise)
        {
            this.FrmData = data;
            this.XmlNormalise = xmlNormalise;
        }
    }
}
