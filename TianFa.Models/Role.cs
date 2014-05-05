using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TianFa.Models
{
    public class Role : EntityBase
    {
        [Key]
        public int RoleId { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [Required(ErrorMessage = "必填")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "{1}到{0}个字")]
        [Display(Name = "名称")]
        public string Name { get; set; }

        /// <summary>
        /// 角色类型<br />
        /// 0普通（普通注册用户），1特权（像VIP之类的类型），3管理（管理权限的类型）
        /// </summary>
        [Required(ErrorMessage = "必填")]
        [Display(Name = "用户组类型")]
        public int Type { get; set; }

        /// <summary>
        /// 获取角色类型名称
        /// </summary>
        /// <returns></returns>
        public string TypeToString()
        {
            switch (Type)
            {
                case 0:
                    return "普通";
                case 1:
                    return "特权";
                case 2:
                    return "管理";
                default:
                    return "未知";
            }
        }

        public virtual ICollection<User> Users { get; set; }
    }
}
