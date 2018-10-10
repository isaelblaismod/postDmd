using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreateDemandeGplusVPlus.JsonObjects.Demande;
using CreateDemandeGplusVPlus.JsonObjects.Demande.Data;

namespace CreateDemandeGplusVPlus.JsonObjects.BodyRequest
{
    class BodyRequestDemande : BodyRequest
    {
        public List<Demandes> demandes;

        public BodyRequestDemande() { }

        public BodyRequestDemande(List<Demandes> lstDemandes)
        {
            this.demandes = lstDemandes;
        }
    }
}
