using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Web;


namespace HostApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Per il funzionamento: lanciare da cmd autenticato come amministratore
            // mettendo nel parametro user l'utente loggato
            // netsh http add urlacl url=http://+:8000/ user=administrator


            WebServiceHost host = new WebServiceHost(typeof(ServiceEsposed.Service));
            host.Open();
            Console.WriteLine("Service running");
            Console.WriteLine("Press ENTER to stop the service");
            Console.ReadLine();
            host.Close();
        }
    }
}
