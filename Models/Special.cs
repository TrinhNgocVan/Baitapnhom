using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitapnhom.Models
{
    public class Special
    {
    }
    public class Datum
    {
        public int id { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public string description { get; set; }
        public int price { get; set; }
    }

    public class Menu_special
    {
        public string message { get; set; }
        public List<Datum> data { get; set; }
    }
}
