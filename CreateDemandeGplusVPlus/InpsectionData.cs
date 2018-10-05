using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateDemandeGplusVPlus
{
    class InpsectionData
    {
        public string Data;
        public string XmlNormalise;

        public InpsectionData(string data, string xmlNormalise)
        {
            this.Data = data;
            this.XmlNormalise = xmlNormalise;
        }
    }
}
