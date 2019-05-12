using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Script.Serialization;
using GolfLigueConsole.Classes.TechnicalClasses;
using GolfLigueConsole;


namespace WSGolf
{
    /// <summary>
    /// Description résumée de WSGolf
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    [System.Web.Script.Services.ScriptService]
    public class WSGolf : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public string chercherUnClub(string id)
        {
            Club c = ApplicationData.chargerUnClub(id);
            var json = "";
            JavaScriptSerializer jss = new JavaScriptSerializer();
            json = jss.Serialize(c);

            return json;
        }

        [WebMethod]
        public string tousLesClub()
        {
            ApplicationData.createJeuEssai();
            List<Club> lesc = ApplicationData.lesClubs;
            var json = "";
            JavaScriptSerializer jss = new JavaScriptSerializer();
            json = jss.Serialize(lesc);

            return json;
        }

        [WebMethod]
        public string tousLesTrousDuClub(string id)
        {
            Club c = ApplicationData.chargerUnClub(id);
            List<Trou> lesTrous = c.getLesTrous();
            var json = "";
            JavaScriptSerializer jss = new JavaScriptSerializer();
            json = jss.Serialize(lesTrous);

            return json;
        }
    }
}
