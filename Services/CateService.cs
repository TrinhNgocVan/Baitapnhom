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
    class CateService
    {
        private Configuration.Configuration configuration = Configuration.Configuration.GetService();
        public async Task<Root> GetCategory()
        {
            HttpClient httpClient = new HttpClient();
            var res = await httpClient.GetAsync(configuration.GetCategoryApi());
            if (res.StatusCode == HttpStatusCode.OK)
            {
                var stringContent = await res.Content.ReadAsStringAsync(); //JSON
                Root cate = JsonConvert.DeserializeObject<Root>(stringContent);
                return cate;
            }
            return null;
        }
    }
}
