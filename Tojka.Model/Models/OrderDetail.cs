using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tojka.Model.Models
{
    [Table("OrderDetails")]
    public class OrderDetail
    {
        [Key]
        public int OrderID { get; set; }

        [ForeignKey("OrderID")]
        public virtual Order Orders { get; set; }

        [Key]
        public int ProductID { get; set; }

        [ForeignKey("ProductID")]
        public virtual Product Products { get; set; }

        public int QuanTity { get; set; }
    }
}