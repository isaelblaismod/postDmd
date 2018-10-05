using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateDemandeGplusVPlus
{

    class Demande
    {
        public EnumTypeDemande Type;
        public string UE_NoDossier;
        public string Client;
        public InpsectionData Inspection;

        public Demande(
            EnumTypeDemande Type, 
            string UE_NoDossier, string Client, 
            string Data, string XmlNormalise)
        {
            // This Object
            this.Type = Type;
            this.UE_NoDossier = UE_NoDossier;
            this.Client = Client;

            // Inspection Data Object
            this.Inspection = new InpsectionData(Data, XmlNormalise);
        }

    }
}
