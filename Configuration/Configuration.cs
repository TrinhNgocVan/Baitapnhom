using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitapnhom.Configuration
{
    class Configuration
    {
        private string baseURL = "https://foodgroup.herokuapp.com";
        private static Configuration instance;
        private Configuration()
        {

        }
        public static Configuration GetService()
        {
            if (instance == null)
            {
                instance = new Configuration();
            }
            return instance;
        }
        public string GetMenuApi()
        {
            return String.Format(baseURL + "/api/menu");
        }
    }
}
