using DDona.WebService.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace DDona.WebService.Web
{
    /// <summary>
    /// Summary description for wsTeste
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class wsTeste : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public string HelloWorldEncriptado(string Frase, string Chave)
        {
            return new DefaultEncription().Encript(Frase, Chave);
        }

        [WebMethod]
        public string HelloWorldDesencriptado(string FraseEncriptada, string Chave)
        {
            return new DefaultEncription().Decript(FraseEncriptada, Chave);
        }

        [WebMethod]
        public double Soma(double A, double B)
        {
            return (A + B);
        }

        [WebMethod]
        public double Subtracao(double A, double B)
        {
            return (A - B);
        }
    }
}
