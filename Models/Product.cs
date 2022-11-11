using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComputerStore.Models
{
    public class Product
    {
        public long ProductId { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resources.SharedResource),
            ErrorMessageResourceName = "NameRequired")]
        [Display(Name = "Name", ResourceType = typeof(Resources.SharedResource))]
        public string Name { get; set; } = String.Empty;

        [Required(ErrorMessageResourceType = typeof(Resources.SharedResource),
            ErrorMessageResourceName = "DescriptionRequired")]
        [Display(Name = "Description", ResourceType = typeof(Resources.SharedResource))]
        public string Description { get; set; } = String.Empty;

        [Required(ErrorMessageResourceType = typeof(Resources.SharedResource),
            ErrorMessageResourceName = "PriceRequired")]
        [Display(Name = "Price", ResourceType = typeof(Resources.SharedResource))]
        [Range(0.01, double.MaxValue, ErrorMessageResourceType = typeof(Resources.SharedResource),
            ErrorMessageResourceName = "PriceLessThanZero")]
        [Column(TypeName = "decimal(8, 2)")]
        public decimal Price { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public List<Purchase> Purchases { get; set; } = new List<Purchase>();
    }
}
