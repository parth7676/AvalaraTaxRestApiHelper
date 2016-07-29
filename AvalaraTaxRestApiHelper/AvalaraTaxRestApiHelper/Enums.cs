using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvalaraTaxRestApiHelper
{
    public class Enums
    {
        public enum HttpVerb
        {
            GET,
            POST,
            PUT,
            DELETE
        }

        public enum Status
        {
            Success,
            Failure
        }
    }
}
