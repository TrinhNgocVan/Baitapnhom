using Baitapnhom.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Baitapnhom.Services
{
    class Service
    {
        private Configuration.Configuration configuration = Configuration.Configuration.GetService();
        public async Task<Menu> GetMenu()
        {
            HttpClient httpClient = new HttpClient();
            var res = await httpClient.GetAsync(configuration.GetMenuApi());
            if (res.StatusCode == HttpStatusCode.OK)
            {
                var stringContent = await res.Content.ReadAsStringAsync(); //JSON
                Menu menu = JsonConvert.DeserializeObject<Menu>(stringContent);
                return menu;
            }
            return null;
        }
    }
}
