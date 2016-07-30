using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZNode.Libraries.AvalaraTax.Entities
{
    /// <summary>
    /// Success Response Data
    /// </summary>
    public class AvalaraSuccessResponseData
    {
        public string DocCode { get; set; }
        public string DocDate { get; set; }
        public string TimeStamp { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal TotalDiscount { get; set; }
        public decimal TotalExemption { get; set; }
        public decimal TotalTaxable { get; set; }
        public decimal TotalTax { get; set; }
        public decimal TotalTaxCalculated { get; set; }
        public string TaxDate { get; set; }
        public List<TaxLines> TaxLines { get; set; }
    }

    public class TaxLines
    {
        public string LineNo { get; set; }
        public string TaxCode { get; set; }
        public bool Taxability { get; set; }
        public decimal Taxable { get; set; }
        public decimal Rate { get; set; }
        public decimal Tax { get; set; }
        public decimal Discount { get; set; }
        public decimal TaxCalculated { get; set; }
        public decimal Exemption { get; set; }
        public string BoundaryLevel { get; set; }
    }
    /// <summary>
    /// Error Response Data
    /// </summary>
    public class AvalaraErrorResponseData
    {
        public string ResultCode { get; set; }

        public List<Message> Messages { get; set; } 
    }

    public class Message
    {

        public string Summary { get; set; }

        public string Source { get; set; }

        public string Severity { get; set; }

    }
    
}
