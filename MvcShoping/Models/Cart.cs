using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MvcShoping.Models
{
    public class Cart
    {
        [DisplayName("选购商品")]
        [Required]
        public Product product { get; set; }

        [DisplayName("选购数量")]
        [Required]
        public int Amount { get; set; }


    }
}