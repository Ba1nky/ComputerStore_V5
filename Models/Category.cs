using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComputerStore.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resources.SharedResource),
            ErrorMessageResourceName = "NameRequired")]
        [Display(Name = "Name", ResourceType =typeof(Resources.SharedResource))]
        public string Name { get; set; } = String.Empty;

        public List<Product> Products { get; set; } = new List<Product>();
    }
}
