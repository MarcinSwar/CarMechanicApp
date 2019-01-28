using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarMechanicApp.Models
{
    class Vehicle
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        public string PlateNo { get; set; }

        [StringLength(30)]
        public string Brand { get; set; }

        [StringLength(30)]
        public string Model { get; set; }

        [StringLength(30)]
        public string Colour { get; set; }

        
        public int Year { get; set; }

        public ICollection<ServiceOrder> ServiceOrders { get; set; }
        public Client Client { get; set; }
        [Required]
        public int ClientId { get; set; }
    }
}
