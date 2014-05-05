using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TianFa.Models
{
    public class User : EntityBase
    {
        [Key]
        public int UserId { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [Required(ErrorMessage="必填")]
        [StringLength(20,MinimumLength=4,ErrorMessage="{1}到{2}个字符")]
        [Display(Name="用户名")]
        public string UserName { get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        [Required(ErrorMessage = "必填")]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "{1}到{2}个字符")]
        [Display(Name = "昵称")]
        public string DisplayName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        [Required(ErrorMessage = "必填")]
        [Display(Name = "密码")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        [Required(ErrorMessage = "必填")]
        [Display(Name = "邮箱")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "电子邮件地址无效")]
        public string Email { get; set; }


        /// <summary>
        /// 用户状态
        /// </summary>
        public int Enabled { get; set; }

        public virtual ICollection<Role> Roles { get; set; }
    }
}
