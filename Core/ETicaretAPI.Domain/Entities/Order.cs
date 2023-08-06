using ETicaretAPI.Domain.Entities.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace ETicaretAPI.Domain.Entities
{
    public class Order : BaseEntity
    {
        public string Description { get; set; }
        public string Address { get; set; }
        //public int CustomerId { get; set; }
        //[ForeignKey("CustomerId")]
        public Customer Customer { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
