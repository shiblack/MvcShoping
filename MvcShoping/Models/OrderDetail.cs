﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System;

namespace MvcShoping.Models
{
    [DisplayName("订单明细")]
    [DisplayColumn("Name")]
    public class OrderDetail
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("订单主文件")]
        [Required]
        public virtual OrderHeader OrderHeader { get; set; }

        [DisplayName("订购商品")]
        [Required]
        public Product Product { get; set; }

        [DisplayName("商品售价")]
        [Required(ErrorMessage = "请输入商品售价")]
        [Range(99, 10000, ErrorMessage = "商品售价必须在99-10000之间")]
        [Description("由于商品售价可能或经常变动因此必须保留当下购买的商品售价")]
        [DataType(DataType.Currency)]
        public int Price { get; set; }

        [DisplayName("选购数量")]
        [Required]
        public int Amount { get; set; }


    }
}