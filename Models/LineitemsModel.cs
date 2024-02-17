using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicoPlus.App.Models
{
    internal class LineitemsModel
    {
        public List<Result> results { get; set; }

        public class Result
        {
            public string id { get; set; }
            public Properties properties { get; set; }
            public DateTime createdAt { get; set; }
            public DateTime updatedAt { get; set; }
            public bool archived { get; set; }
        }

        public class Properties
        {
            public string amount { get; set; }
            public DateTime createdate { get; set; }
            public DateTime hs_lastmodifieddate { get; set; }
            public string hs_object_id { get; set; }
            public object hs_product_id { get; set; }
            public string quantity { get; set; }
        }

    }
}
