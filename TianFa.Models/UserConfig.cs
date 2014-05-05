﻿using System;
using System.ComponentModel.DataAnnotations;

namespace TianFa.Models
{
    public class UserConfig : EntityBase
    {
        [Key]

        public int UserConfigId { get; set; }

        /// <summary>
        /// 启用注册
        /// </summary>
        [Display(Name = "启用注册")]
        [Required(ErrorMessage = "必填")]
        public bool Enabled { get; set; }

        /// <summary>
        /// 禁止使用的用户名<br />
        /// 用户名之间用“|”隔开
        /// </summary>
        [Display(Name = "禁止使用的用户名")]
        public string ProhibitUserName { get; set; }

        /// <summary>
        /// 启用管理员验证
        /// </summary>
        [Display(Name = "启用管理员验证")]
        [Required(ErrorMessage = "必填")]
        public bool EnableAdminVerify { get; set; }

        /// <summary>
        /// 启用邮件验证
        /// </summary>
        [Display(Name = "启用邮件验证")]
        [Required(ErrorMessage = "必填")]
        public bool EnableEmailVerify { get; set; }

        /// <summary>
        /// 默认用户组Id
        /// </summary>
        [Display(Name = "默认用户组Id")]
        [Required(ErrorMessage = "必填")]
        public int DefaultGroupId { get; set; }
    }
}
