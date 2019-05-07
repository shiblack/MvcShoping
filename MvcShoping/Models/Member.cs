using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace MvcShoping.Models
{
    [DisplayName("会员信息")]
    [DisplayColumn("Name")]
    public class Member
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("会员账号")]
        [Required(ErrorMessage = "请输入Email地址")]
        [Description("我们直接将Email作为会员的登录账号")]
        [MaxLength(250, ErrorMessage = "Email地址不得超过250个字符")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DisplayName("会员密码")]
        [Required(ErrorMessage = "请输入密码")]
        [MaxLength(40, ErrorMessage = "密码不得超过40个字符")]
        [Description("密码将进行SHAL运算，通过SHAL哈希运算后的结果转换成为HEX表示法中的字符串皆为40个字符串")]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [DisplayName("中文姓名")]
        [Required(ErrorMessage = "请输入中文姓名")]
        [MaxLength(5, ErrorMessage = "中文姓名不得超过5个字")]
        [Description("暂时不考虑有外国人注册会员的情况")]
        public string Name { get; set; }

        [DisplayName("网络昵称")]
        [Required(ErrorMessage = "请输入网络昵称")]
        [MaxLength(10, ErrorMessage = "网络昵称不得超过10个字")]
        public string NickName { get; set; }

        [DisplayName("会员注册时间")]
        public DateTime RegisterOn { get; set; }

        [DisplayName("会员启用验证码")]
        [MaxLength(36)]
        [Description("当AuthCode等于 NULL 则代表此会员已经通过Email有效验证")]
        public string AuthCode { get; set; }
    }
}