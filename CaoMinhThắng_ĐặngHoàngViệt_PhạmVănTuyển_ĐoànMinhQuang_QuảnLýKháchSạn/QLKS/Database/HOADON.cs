namespace QLKS.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data;
    using System.Data.Entity.Spatial;

    [Table("HOADON")]
    public partial class HOADON
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOADON()
        {
            CHITIETHOADON = new HashSet<CHITIETHOADON>();
        }

        [Key]
        public int id_HD { get; set; }

        [StringLength(10)]
        public string id_KH { get; set; }

        [Column(TypeName = "date")]
        public DateTime ngayvao { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngaytra { get; set; }

        public int tinhtrang { get; set; }

        [StringLength(10)]
        public string id_P { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETHOADON> CHITIETHOADON { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }

        public virtual PHONG PHONG { get; set; }

        public HOADON(int id_HD, string id_KH, DateTime ngayvao, DateTime? ngaytra, string id_P, int tinhtrang)
        {
            this.id_HD = id_HD;
            this.id_KH = id_KH;
            this.ngayvao = ngayvao;
            this.ngaytra = ngaytra;
            this.id_P = id_P;
            this.tinhtrang = tinhtrang;
        }

        public HOADON(DataRow row)
        {

            this.id_KH = (string)row["id_KH"];
            this.id_HD = (int)row["id_HD"];
            this.ngayvao = (DateTime)row["ngayvao"];

            var dateCheckOutTemp = row["ngaytra"];
            if (dateCheckOutTemp.ToString() != "")
                this.ngaytra = (DateTime?)dateCheckOutTemp;
            this.tinhtrang = (int)row["tinhtrang"];
            this.id_P = (string)row["id_P"];
        }
    }
}
