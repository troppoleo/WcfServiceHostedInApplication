using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientOfService
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press ENTER for start the client");
            Console.ReadLine();
            // Create a proxy object and connect to the service
            
            clsProxy myProxy = new clsProxy();
            try
            {
                myProxy.Open();

                Console.WriteLine(myProxy.GetEco("Buongiorno Leonardo"));

                Console.WriteLine("Press ENTER to stop the service");
                Console.ReadLine();


            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                if (ex.InnerException != null)
                {
                    Console.WriteLine(ex.InnerException.Message);
                }                
            }
            finally
            {
                myProxy.Close();
            }
        }
    }
}
