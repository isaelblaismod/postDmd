using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net.Http;
using System.Net.Http.Headers;
//using System.Net.Http.Formatting;  
using Newtonsoft.Json;
using System.Net;
using System.Web.Script.Serialization;
using System.IO;
using System.Diagnostics;

namespace CreateDemandeGplusVPlus
{
    static class GPPDHttpClient
    {
        public static void doPostJSON(BodyRequest JSONObject)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:3000/quebec/demandes/");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = JsonConvert.SerializeObject(JSONObject);

                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }
            
        }

        public static void doPostJSON(List<BodyRequest> JSONObject)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:3000/quebec/demandes/");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = new JavaScriptSerializer().Serialize(JSONObject);

                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }

        }

    }
}
