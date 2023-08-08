using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Petshop.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int _Id { get; set; }
        public string? Title { get; set; }
        public string? Category { get; set;  }
        public string? Description { get; set;  }
        public decimal Price { get; set; }
        public string? Image { get; set; }  


    }
}
