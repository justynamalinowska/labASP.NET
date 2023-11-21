using System;
using System.ComponentModel.DataAnnotations.Schema;
using Data.Models;

namespace Data.Entities
{
    [Table("Producents")]
    public class ProducentEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Address? Address { get; set; }
        public ISet<ProductEntity> Products { get; set; }
    }
}