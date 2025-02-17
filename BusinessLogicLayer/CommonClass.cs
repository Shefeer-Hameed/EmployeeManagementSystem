using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class CommonClass
    {
        public string RESTfulApiUrl = ConfigurationManager.AppSettings["RESTfulApiUrl"];
        public string ApiToken = ConfigurationManager.AppSettings["ApiToken"];
        public string PageSize = ConfigurationManager.AppSettings["PageSize"];

        public void WriteErrorLog(string errorMessage)
        {

            //Console.WriteLine(errorMessage);

            //Write errorMessage into Log file

        }
    }
}
