using System;
using System.Collections.Generic;
using System.Linq;
//using System.Text;
using System.Threading.Tasks;
using System.Net;
//using System.Net.Http;
using Windows.Storage.Streams;
using Windows.Web.Http;
using Newtonsoft.Json;
using Baitapnhom.Models;
using Baitapnhom.Adapters;

namespace Baitapnhom.Services
{
    class OrderService
    {
        private Adapters.Adaper _adaper = Adapters.Adaper.GetAdaper();
        public async Task<CreateOrder> CreateOrder(List<CartItem> items)
        {
            HttpClient httpClient = new HttpClient();
            Uri uri = new Uri(_adaper.GetCreateOrderApi);
            HttpStringContent content = new HttpStringContent(
                "items:" + JsonConvert.SerializeObject(items),
                UnicodeEncoding.Utf8,
                "application/json"
                );
            HttpResponseMessage httpResponseMessage = await httpClient.PostAsync(uri, content);
            httpResponseMessage.EnsureSuccessStatusCode();
            var httpResponseBody = await httpResponseMessage.Content.ReadAsStringAsync();
            CreateOrder createOrder = JsonConvert.DeserializeObject<CreateOrder>(httpResponseBody);// sau khi có order id phải lưu lại trong client
            return createOrder;
        }
    }
}
