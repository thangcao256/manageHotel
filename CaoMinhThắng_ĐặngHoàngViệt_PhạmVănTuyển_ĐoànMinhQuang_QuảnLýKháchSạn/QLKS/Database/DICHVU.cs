namespace QLKS.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data;
    using System.Data.Entity.Spatial;
    using DAO;

    [Table("DICHVU")]
    public partial class DICHVU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DICHVU()
        {
            CHITIETHOADON = new HashSet<CHITIETHOADON>();
        }

        [Key]
        [StringLength(10)]
        public string id_DV { get; set; }

        [StringLength(30)]
        public string ten_DV { get; set; }

        public int? gia_DV { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETHOADON> CHITIETHOADON { get; set; }

        public DICHVU(DataRow row) //lấy từ các trường dữ liệu trong sql
        {
            this.id_DV = (String)row["id_DV"];
            this.ten_DV = row["ten_DV"].ToString();
            this.gia_DV = (int)row["gia_DV"];
        }

        public DICHVU(string id_DV, string ten_DV, int gia_DV)
        {
            this.id_DV = id_DV;
            this.ten_DV = ten_DV;
            this.gia_DV = gia_DV;
        }

    }
}
