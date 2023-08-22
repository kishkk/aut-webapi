using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class DataManager
    {
        string _strConnectionString = string.Empty;
        public DataManager()
        {
            _strConnectionString = ConfigurationManager.ConnectionStrings["AUT_PROD_ConnectionString"].ConnectionString;
        }

        public string GetConnectionString() => _strConnectionString;

    }
}
