using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace CreateDemandeGplusVPlus
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            // Transformer Object TAJ_R01Portrait -> R -> XML
            string xmlString = System.IO.File.ReadAllText(@"C:\Users\isabla\Desktop\r01.xml"); //.Replace("\r\n", ""); ;

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xmlString); //or xmlDoc.Load(filepath)
             //-- this should return one liner

            string xmlStringOneLine = xmlDoc.InnerXml;

            EnumTypeDemande currentType = EnumTypeDemande.Inspection;                    

            Demande objDemande = new Demande(currentType, txtNoDossier.Text, "", "", xmlStringOneLine);
            List<Demande> lstDemandes = new List<Demande>();
            lstDemandes.Add(objDemande);

            BodyRequest objBodyRequest = new BodyRequest(lstDemandes);
            List<BodyRequest> lstBodyRequest = new List<BodyRequest>();
            lstBodyRequest.Add(objBodyRequest);

            try
            {
                GPPDHttpClient.doPostJSON(objBodyRequest);
            }
            catch (WebException excep)
            {
                rchTxtResponse.Text = new StreamReader(excep.Response.GetResponseStream()).ReadToEnd();

            }
            
        }
    }
}
