using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComputerStore.Models
{
    public class Purchase
    {
        public int PurchaseId { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resources.SharedResource),
    ErrorMessageResourceName = "PersonRequired")]
        [Display(Name = "Person", ResourceType = typeof(Resources.SharedResource))]
        public string Person { get; set; } = String.Empty;

        [Required(ErrorMessageResourceType = typeof(Resources.SharedResource),
    ErrorMessageResourceName = "AddressRequired")]
        [Display(Name = "Address", ResourceType = typeof(Resources.SharedResource))]
        public string Address { get; set; } = String.Empty;


        [Display(Name = "Date", ResourceType = typeof(Resources.SharedResource))]
        public DateTime Date { get; set; } = DateTime.Now;


        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
