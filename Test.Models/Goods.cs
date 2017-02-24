using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Test.Models
{
    public class Goods
    {
        [Key]
        [Required]
        [StringLength(20,ErrorMessage ="长度溢出")]
        public string id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string category { get; set; }
        public string reserve { get; set; }
    }
}
