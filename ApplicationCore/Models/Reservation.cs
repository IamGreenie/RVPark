using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models
{
    public class Reservation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReservationId { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool PcsOrders { get; set; }
        public float TotalCost { get; set; }
        public string Notes { get; set; }

        // Foreign Key
        [ForeignKey("Site")]
        public int SiteId { get; set; }
        public Site Site { get; set; }
    }
}
