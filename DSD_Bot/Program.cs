using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace DSD_Bot
{
    class Program
    {
        static void Main(string[] args)
        {

            preguntar();

        }

        static void preguntar()
        {
            string pregunta = Console.ReadLine();
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://localhost:53637/ServicePreguntar.svc/Preguntar/" + pregunta + "");
            request.Method = "GET";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string tramaJson = reader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();


            Console.WriteLine(tramaJson);



            HttpWebRequest request2 = (HttpWebRequest)WebRequest.Create("http://localhost:53637/ServiceRespuestas.svc/Preguntar/" + tramaJson + "");
            request2.Method = "GET";
            HttpWebResponse response2 = (HttpWebResponse)request2.GetResponse();
            StreamReader reader2 = new StreamReader(response2.GetResponseStream());
            
            preguntar();

        }
    }
}
