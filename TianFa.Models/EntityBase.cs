using System;
using System.ComponentModel.DataAnnotations;

namespace TianFa.Models
{
    [Serializable]
    public abstract class EntityBase
    {
        protected EntityBase()
        {
            IsDeleted = false;
            AddDate = DateTime.Now;
        }

        /// <summary>
        /// 备注
        /// </summary>
        [Display(Name = "备注")]
        [DataType(DataType.MultilineText)]
        public string Remark { get; set; }

        /// <summary>
        /// 已删除
        /// </summary>
        [ScaffoldColumn(false)]
        [Display(Name = "已删除")]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// 登记时间
        /// </summary>
        [ScaffoldColumn(false)]
        [Display(Name = "登记时间")]
        [DataType(DataType.DateTime)]
        public DateTime AddDate { get; set; }

        /// <summary>
        /// 登记人
        /// </summary>
        [ScaffoldColumn(false)]
        [Display(Name = "登记")]
        public string AddUser { get; set; }

        /// <summary>
        /// 编辑时间
        /// </summary>
        [ScaffoldColumn(false)]
        [Display(Name = "编辑时间")]
        [DataType(DataType.DateTime)]
        public DateTime? ModDate { get; set; }

        /// <summary>
        /// 编辑人
        /// </summary>
        [ScaffoldColumn(false)]
        [Display(Name = "编辑")]
        public string ModUser { get; set; }

        [ScaffoldColumn(false)]
        [ConcurrencyCheck]
        [Timestamp]
        public byte[] Version { get; set; }
    }
}
