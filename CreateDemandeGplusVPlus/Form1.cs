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
using CreateDemandeGplusVPlus.JsonObjects.BodyRequest;
using CreateDemandeGplusVPlus.JsonObjects.Demande;

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
            //string xmlString = System.IO.File.ReadAllText(@"C:\Users\IsaelBlais\Desktop\r01.xml"); //.Replace("\r\n", ""); ;
            string xmlString = "<note>ergergerger</note>";
            string formData = "{}";

            //var obj = new {"B08":{"AnneeOrigine":null},B15:{Materiaux:[]},B22:{MurExterieurs:{PercentRevetementRenovations:{YearSince:null,HaveRenovation:null},RevetementRenovations:[],Angles:{ChoixAngle:null}},PorteFenetres:{NbPortesFenetresEtg:null,NbPortesFenetresSS:null,Renovations:[]CodeImagePorteFacade:null,CodeImageFenetreFacade:null}},B23:{Materiaux:[],NbVersants:null},B33{MursEtPlafonds:{Informations:{CodeQualitePortesInt:null,CodeQualiteOrnement:null,CodeQualiteEscaliersInt:null},MursPlafondsRenovations:{YearSince:null,HaveRenovation:null,Renovations:[]},RemplacementPortesIntRenovations:{YearSince:null,HaveRenovation:null,Renovations:[]},EscaliersRenovations:{YearSince:null,HaveRenovation:null,Renovations:[]}}SousSol:{RevetementMurs:[],RevetementPlafonds:[]ProportionAmenagement:null}},B34:{Pieces:[]},B36:{CodeMateriauxArmoire:null;AnneeDerniereReno:null;CodeQualiteComptoire:null;AppareilsEncastreCode:[]}B43:{SalleDeBainsSalleEau:[]}B44:{Chauffage:{CodeType:null,CodeTypeDistribution:null,AnneeDerniereRenovation:null}Climatisation:{CodeType:null,CodeTypeDistribution:null,NbSortieInt:null,AnneeDerniereRenovation:null}},B59:{Foyers:Array<{CodeTypeCombustible:null,NbFace:null}>PoeleAutre:{HasPoele:null,NbPoele:null}ConduitsAspirateurCentral:{HasConduits:null}SaunaInterieur:{HasSaunaInterieur:null}},B62:{Dependances:{GarageAttache:{HasGarageAttache:null,CodeTypeFondation:null},AbriAuto:{HasAbriAuto:null},Verriere3Saison:{HasVerriere3Saison:null,AnneeConstruction:null}}NbPlacesStationnementVehic:null}B63:{Dependances:{GarageDetache:{HasGarageDetache:null},Remise:{HasRemise:null,Aire:null,IsLtnumber0AnneeContruction:null,AnneeContruction:null},Hangar:{HasHangar:null}}}B71:{Piscine:{HasPiscine:null,CodeType:null,UniteMesure:null,AnneeContruction:null,CodeForme:null,Longueur:null,Largeur:null,Diametre:null}SpaNature:{HasSpaNature:null,NbPlace:null,AnneeContruction:null}Stationnement:{HasStationnement:null,CodeMateriau:null,NbPlacesVehic:null}}B79:{HaveDeclared:null;FirstName:null;LastName:null;Courriel:null;Telephone:null;Poste:null}}

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xmlString); //or xmlDoc.Load(filepath)
             //-- this should return one liner

            string xmlStringOneLine = xmlDoc.InnerXml;                

            // Demande Inspection
            Demandes objDemandeIns = new Demandes(EnumTypeDemande.Inspection, txtNoDossier.Text, "", formData, xmlStringOneLine);
            // Demande Espaces Locatifs
            //Demandes objDemandeEspLoc = new Demandes(EnumTypeDemande.EspacesLocatifs, txtNoDossier.Text, "", formData, xmlStringOneLine);
            // Demande Revenus depenses
            //Demandes objDemandeRevDep = new Demandes(EnumTypeDemande.RevenusDepenses, txtNoDossier.Text, "", formData, xmlStringOneLine);

            List<Demandes> lstDemandes = new List<Demandes>();
            lstDemandes.Add(objDemandeIns);
            //lstDemandes.Add(objDemandeEspLoc);
            //lstDemandes.Add(objDemandeRevDep);

            BodyRequest objBodyRequest = new BodyRequestDemande(lstDemandes);
            //List<BodyRequest> lstBodyRequest = new List<BodyRequest>();
            //lstBodyRequest.Add(objBodyRequest);

            try
            {
                rchTxtResponse.Text = GPPDHttpClient.doPostJSON(objBodyRequest);
            }
            catch (WebException excep)
            {
                rchTxtResponse.Text = new StreamReader(excep.Response.GetResponseStream()).ReadToEnd();

            }
            
        }
    }
}
