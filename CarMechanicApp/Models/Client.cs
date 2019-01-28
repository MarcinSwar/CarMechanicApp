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
        [MaxLength(2)]
        public int Discount { get; set; }
    }
}
