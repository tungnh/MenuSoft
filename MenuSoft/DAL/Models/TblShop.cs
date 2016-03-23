namespace NewMenuSoft.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TblShop")]
    public partial class TblShop
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ShopID { get; set; }

        [Required]
        [StringLength(50)]
        public string ShopCode { get; set; }

        [Required]
        [StringLength(255)]
        public string ShopName { get; set; }

        public int? ShopStatus { get; set; }

        [StringLength(15)]
        public string CreateDateTime { get; set; }

        [StringLength(16)]
        public string CreateUserID { get; set; }

        [StringLength(15)]
        public string UpdateDateTime { get; set; }

        [StringLength(16)]
        public string UpdateUserID { get; set; }
    }
}
