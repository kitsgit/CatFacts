using System;
using unirest_net.http;
using System.Xml;
using Newtonsoft.Json.Linq;
namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 0 to display new cat fact");
            string n = "0";
            while (n == "0")
            {
                
                HttpResponse<string> response = Unirest.get("https://catfact.ninja/fact?max_length=140")
                   // .header("X-RapidAPI-Host", "microsoft-azure-translation-v1.p.rapidapi.com")
                   // .header("X-RapidAPI-Key", "9c107e3831msh9dd3bfb8e246300p1b7654jsn9cf51b6f5fd1")
                   .header("Accept", "application/json")
                   .asJson<string>();
                //string myJsonString = (response.Body.ToString());
                // var jo = JObject.Parse(myJsonString);
                //var fact = jo["fact"].ToString();
                Console.WriteLine(JObject.Parse(response.Body.ToString())["fact"].ToString());//(fact);
                n = Console.ReadLine();                                                                              //  XmlDocument doc = new XmlDocument();
                                                                                              //  doc.LoadXml(response.Body.ToString());
                                                                                              //   Console.WriteLine(doc.DocumentElement.FirstChild.InnerText);
            }
        }
    }
}
