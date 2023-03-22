namespace QLKS.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data;
    using System.Data.Entity.Spatial;

    [Table("CHITIETHOADON")]
    public partial class CHITIETHOADON
    {
        [Key]
        public int id_CTHD { get; set; }

        public int? id_HD { get; set; }

        [StringLength(10)]
        public string id_DV { get; set; }

        public int? soluong { get; set; }

        [Column(TypeName = "date")]
        public DateTime ngaysudung { get; set; }

        public virtual DICHVU DICHVU { get; set; }

        public virtual HOADON HOADON { get; set; }

        public CHITIETHOADON(int id_CTHD, int id_HD, string id_DV, int soluong, DateTime ngaysudung)
        {
            this.id_CTHD = id_CTHD;
            this.id_HD = id_HD;
            this.id_DV = id_DV; ;
            this.soluong = soluong;
            this.ngaysudung = ngaysudung;

        }

        public CHITIETHOADON(DataRow row)
        {
            this.id_CTHD = (int)row["id_CTHD"];
            this.id_HD = (int)row["id_HD"];
            this.id_DV = (string)row["id_DV"];
            this.soluong = (int)row["soluong"];
            this.ngaysudung = (DateTime)row["ngaysudung"];
        }
    }
}
