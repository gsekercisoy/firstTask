using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities
{
    public class categories
    {

        [Key]
        public int categoryid { get; set; }
        [StringLength(50)]
        public string categoryname { get; set; }

        public ICollection<product> urunler { get; set; }


    }
}
