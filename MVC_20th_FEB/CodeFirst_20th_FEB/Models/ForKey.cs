using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_console.Models
{
    internal class ForKey
    {
        [Key]
        public int Id { get; set; }
        public string ?Name { get; set; }

        public ICollection<Kkey> ?Km { get; set; }
    }

    class Kkey
    {
        [Key] public int Kid { get; set; }
        public string ?KName { get; set; }

        [ForeignKey("ForKey")]
        public int Kfid { get; set; }
        public ForKey ForKey { get; set; }
    }
}
