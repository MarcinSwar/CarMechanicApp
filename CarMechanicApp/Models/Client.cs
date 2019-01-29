using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarMechanicApp.Models
{
    class Client : Person
    {
        
        public int? Discount { get; set; }

        public ICollection<Vehicle> Vehicles { get; set; }
    }
}
