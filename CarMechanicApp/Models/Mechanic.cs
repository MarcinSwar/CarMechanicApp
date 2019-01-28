using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarMechanicApp.Models
{
    class Mechanic : Person
    {
        [Range(0, 30000)]
        [Required]
        public decimal Salary { get; set; }

        public ICollection<ServiceOrder> ServiceOrders { get; set; }
    }
}
