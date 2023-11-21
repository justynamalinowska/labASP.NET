using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Data.Entities
{
    [Table("Products")]
    public class ProductEntity
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public DateTime? DateOfProduction { get; set; }
        public string Description { get; set; }
        public int Quality { get; set; }
        public int? ProducentId { get; set; }
        public ProducentEntity? Producent { get; set; }
    }
}
