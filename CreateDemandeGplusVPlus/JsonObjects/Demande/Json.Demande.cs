using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreateDemandeGplusVPlus.JsonObjects;
using CreateDemandeGplusVPlus.JsonObjects.Demande.Data;

namespace CreateDemandeGplusVPlus.JsonObjects.Demande
{

    class Demandes
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public EnumTypeDemande Type;

        public string NumeroDossier;

        public string Client;

        public DemandeData Data;

        public Demandes(
            EnumTypeDemande Type, 
            string NumeroDossier, string Client, 
            string Data, string XmlNormalise)
        {
            // This Object
            this.Type = Type;
            this.NumeroDossier = NumeroDossier;
            this.Client = Client;

            // Inspection Data Object
            switch (Type)
            {
                case EnumTypeDemande.Inspection:
                    this.Data = new DemandeDataInspection(Data, XmlNormalise);
                    break;
                case EnumTypeDemande.EspacesLocatifs:
                    this.Data = new DemandeDataEspacesLocatifs(Data, XmlNormalise);
                    break;
                case EnumTypeDemande.RevenusDepenses:
                    this.Data = new DemandeDataRevenusDepenses(Data, XmlNormalise);
                    break;
            }          
        }

    }
}
