using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarMechanicApp.Models
{
    class ServiceOrder
    {
        public int Id { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public Mechanic Mechanic { get; set; }
        [Required]
        public int MechanicId { get; set; }

        public Vehicle Vehicle { get; set; }
        [Required]
        public int VehicleId { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

    }
}
