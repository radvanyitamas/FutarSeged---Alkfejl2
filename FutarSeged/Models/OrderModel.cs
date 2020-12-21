using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FutarSeged.Models
{
    public class OrderModel
    {
        [Key]
        public int OrderID { get; set; }

        [Required]
        [ForeignKey("Food")]
        public int FoodId { get; set; }

        [Required]
        [ForeignKey("User")]
        public int UserId { get; set; }

        [Required]
        [ForeignKey("Address")]
        public int AddressId { get; set; }


        public virtual Food Food { get; set; }

        public virtual AddressModel Address { get; set; }

    }
}
