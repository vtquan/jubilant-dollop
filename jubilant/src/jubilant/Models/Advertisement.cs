using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jubilant.Models
{
    public class Advertisement
    {
        public int AdvertisementId { get; set; }

        public string URL { get; set; }

        public byte[] ImageData { get; set; }

        public DateTime Date { get; set; }
    }
}
