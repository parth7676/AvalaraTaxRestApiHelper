using AvalaraTaxRestApiHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNode.Libraries.AvalaraTax.Entities;

namespace ZNode.Libraries.AvalaraTax.Entities
{
    public class Response
    {
        public Enums.Status Status { get; set; }

        public AvalaraSuccessResponseData SuccessResponse { get; set; }

        public AvalaraErrorResponseData ErrorResponse { get; set; }
    }
}
