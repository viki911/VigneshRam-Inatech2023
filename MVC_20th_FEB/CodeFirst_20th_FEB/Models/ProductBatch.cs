using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_console.Models
{
    internal class ProductBatch
    {
        [Key] public int BatchId { get; set; }
        [Required][StringLength(50)] public string ?Desc { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        [ForeignKey("Product")]
        public Product productID { get; set; }
    }
}
