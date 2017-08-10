using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Data
{
    class DBHelper
    {
        public static string GetConnection()
        {
            return ConfigurationManager.ConnectionStrings["ContosoDB"].ConnectionString;
        }
    }
}
