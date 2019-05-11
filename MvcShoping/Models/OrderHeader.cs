using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcShoping.Models
{
    [DisplayName("订单主文件")]
    [DisplayColumn("DisplayName")]

    public class OrderHeader
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("订购会员")]
        [Required]
        public virtual Member Member { get; set; }

        [DisplayName("收件人姓名")]
        [Required(ErrorMessage = "输入收件人姓名")]
        [MaxLength(40, ErrorMessage = "收件人姓名长度不得超过40个字符")]
        [Description("订购会员的人不一定就是收到商品的人")]
        public string ContactName { get; set; }

        [DisplayName("联络电话")]
        [Required(ErrorMessage = "请输入您的联络电话，例如 + 86 133-xxxx-5846.")]
        [MaxLength(11, ErrorMessage = "电话号码的长度不得超过11位")]
        [DataType(DataType.PhoneNumber)]
        public string ContactPhoneNo { get; set; }

        [DisplayName("递送地址")]
        [Required(ErrorMessage = "请输入商品递送地址")]
        public string ContactAddress { get; set; }

        [DisplayName("订单金额")]
        [Required]
        [DataType(DataType.Currency)]
        [Description("由于订单金额可能会收到商品递送方式或者是优惠折扣等方式变动价格，因此必须保留购买当下算出来的订单金额")]
        public int TotalPrice { get; set; }

        [DisplayName("订单备注")]
        [DataType(DataType.MultilineText)]
        public string Memo { get; set; }

        [DisplayName("订购时间")]
        public DateTime BuyOn { get; set; }

        [NotMapped]
        public string DisplayName
        {
            get { return this.Member.Name + "于" + this.BuyOn + "订购的商品"; }
        }

        public virtual ICollection<OrderDetail> orderDetail { get; set; }

       
    }
}