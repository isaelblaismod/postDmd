using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateDemandeGplusVPlus
{
    class BodyRequest
    {
        public List<Demande> demandes;

        public BodyRequest(List<Demande> lstDemandes)
        {
            this.demandes = lstDemandes;
        }
    }
}
