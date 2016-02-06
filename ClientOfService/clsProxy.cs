using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ServiceModel;
using ServiceEsposed;


namespace ClientOfService
{
    class clsProxy : ClientBase<IService>, IService
    {
        public string GetMyParams(int skip, int top)
        {
            throw new NotImplementedException();
        }

        public string GetSum(int d1, int d2)
        {
            throw new NotImplementedException();
        }

        public string GetEco(string pEco)
        {
            return this.Channel.GetEco(pEco);
        }
    }
}
