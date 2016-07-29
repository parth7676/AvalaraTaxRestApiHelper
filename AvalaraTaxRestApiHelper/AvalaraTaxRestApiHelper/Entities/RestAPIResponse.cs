using AvalaraTaxRestApiHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZNode.Libraries.AvalaraTax.Entities
{
    public class RestAPIResponse
    {
        public Enums.Status Status { get; set; }

        public string ResponseData { get; set; }
    }
}
