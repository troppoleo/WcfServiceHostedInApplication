using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.ComponentModel;


namespace ServiceEsposed
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        [WebGet(UriTemplate = "o?skip={skip}&top={top}",ResponseFormat=WebMessageFormat.Json)]
        [Description("Returns a list of all orders. By default, the list is limited to" +
        " the first 100 orders; specify the SKIP and TOP parameters to" +
        " implement paging.")]
        string GetMyParams(int skip, int top);

        [OperationContract]
        [WebGet(UriTemplate = "sum?val1={d1}&val2={d2}", ResponseFormat = WebMessageFormat.Json)]        
        string GetSum(int d1, int d2);

        [OperationContract]
        [WebGet(UriTemplate = "Eco/{pEco}", ResponseFormat = WebMessageFormat.Json)]
        string GetEco(string pEco);
    }


    /// <summary>
    /// per ottenere una descrizione dei metodi:
    /// http://localhost:8000/Test/help
    /// </summary>
    public class Service : IService
    {
        //http://localhost:8000/Test/o?skip=10&top=11
        public string GetMyParams(int skip, int top)
        {
            return string.Format("ship: {0} top: {1}", skip, top);
        }



        
        //http://localhost:8000/Test/sum?va1=10&val2=11
        public string GetSum(int d1, int d2)
        {
            return (d1 + d2).ToString();
        }

        //http://localhost:8000/Test/eco/ciao
        public string GetEco(string pEco)
        {
            return string.Format("Eco='{0}'", pEco);
        }
    }
}
