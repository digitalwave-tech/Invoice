using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DAL.Entities
{
    public partial class ItemsDetails
    {
        [Key]
        [JsonIgnore]
        public int? ItemID { get; set; }
        [JsonIgnore]
        public int? invoiceNo { get; set; }
        public string? itemName { get; set; }
        public int? quantity { get; set; }
        public decimal? price { get; set; }
        public decimal? Amount { get; set; }
        [ForeignKey("invoiceNo")]
        [JsonIgnore]
        public virtual Invoices? InvoiceNoNavigation { get; set; }
    }
}
