using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DAL.Entities
{
    public partial class Invoices
    {
        //[JsonIgnore]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? InvoiceNo { get; set; }
        [JsonIgnore]
        public Guid? CompanyId { get; set; }
        [JsonIgnore]
        public int? CustomerId { get; set; }
        [JsonIgnore]
        public DateTime InvoiceDate { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? SgstRate { get; set; }
        public decimal? CgstRate { get; set; }

        public decimal? TotalAmt { get; set; }   
        [JsonIgnore]
        public virtual UserAccount? Company { get; set; }
        [JsonIgnore]
        public virtual Customers? Customers { get; set; }

        public virtual ICollection<ItemsDetails> Details { get; set; } 
    }
}
