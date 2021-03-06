using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TRexWebApi.Data.Models
{
    public class Machine
    {
        public Machine()
        {

        }

        [Key]
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        
        [Column(TypeName = "decimal (5,2)")]
        public decimal Temp { get; set; }
        public int Status { get; set; } 
    }
}
