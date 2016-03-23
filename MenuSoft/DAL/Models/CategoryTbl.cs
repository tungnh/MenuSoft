using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewMenuSoft.DAL.Models
{
    [Table("CategoryTbl")]
    public partial class CategoryTbl
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int _ID { get; set; }
        [Key]
        [Column(Order = 0)]
        public int TenpoCode { get; set; }
        [Key]
        [Column(Order = 1)]
        public int Category_Kubun { get; set; }
        [Key]
        [Column(Order = 2)]
        public int Category_Code { get; set; }
        public string Category_Name { get; set; }
        public string EtcCode1 { get; set; }
        public string EtcCode2 { get; set; }
        public string EtcCode3 { get; set; }
        public string EtcCode4 { get; set; }
        public string EtcCode5 { get; set; }
        public Nullable<int> EtcNum1 { get; set; }
        public Nullable<int> EtcNum2 { get; set; }
        public Nullable<int> EtcNum3 { get; set; }
        public Nullable<int> EtcNum4 { get; set; }
        public Nullable<int> EtcNum5 { get; set; }
        public string AddDateTime { get; set; }
        public string UpdDateTime { get; set; }
    }
}
