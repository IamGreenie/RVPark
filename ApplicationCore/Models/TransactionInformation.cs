using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models
{
    public class TransactionInformation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TransactionId { get; set; }

        [Required, MaxLength(50)]
        public string PaymentType { get; set; }

        [Required, CreditCard]
        public string CardNumber { get; set; }

        [Required]
        public string ExpDate { get; set; }

        [Required, Range(100, 9999)]
        public int SecurityCode { get; set; }

        public string BillingStreetNumber { get; set; }
        public string BillingStreet { get; set; }
        public string BillingCity { get; set; }
        public string BillingState { get; set; }
        public string BillingZip { get; set; }
    }
}
