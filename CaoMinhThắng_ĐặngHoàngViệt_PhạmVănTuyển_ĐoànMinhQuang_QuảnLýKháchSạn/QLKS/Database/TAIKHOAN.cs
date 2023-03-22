namespace QLKS.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TAIKHOAN")]
    public partial class TAIKHOAN
    {
        [Key]
        [StringLength(10)]
        public string id_TK { get; set; }

        [StringLength(30)]
        public string ten_TK { get; set; }

        [StringLength(30)]
        public string matkhau_TK { get; set; }

        [StringLength(50)]
        public string tenhienthi_TK { get; set; }

        [StringLength(20)]
        public string gioitinh { get; set; }

        [StringLength(11)]
        public string sdt { get; set; }

        [StringLength(50)]
        public string diachi { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [StringLength(1)]
        public string trangthai { get; set; }
    }
}
