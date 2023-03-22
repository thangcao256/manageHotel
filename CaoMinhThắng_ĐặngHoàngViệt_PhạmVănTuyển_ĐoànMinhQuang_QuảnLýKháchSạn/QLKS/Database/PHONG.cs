namespace QLKS.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data;
    using System.Data.Entity.Spatial;

    [Table("PHONG")]
    public partial class PHONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHONG()
        {
            HOADON = new HashSet<HOADON>();
        }

        [Key]
        [StringLength(10)]
        public string id_P { get; set; }

        [StringLength(30)]
        public string ten_P { get; set; }

        [StringLength(30)]
        public string tinhtrang { get; set; }

        [StringLength(10)]
        public string id_LP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADON> HOADON { get; set; }

        public virtual LOAIPHONG LOAIPHONG { get; set; }

        public PHONG(string id_P, string ten_P, string tinhtrang, string id_LP)
        {
            this.id_P = id_P;
            this.ten_P = ten_P;
            this.tinhtrang = tinhtrang;
            this.id_LP = id_LP;
        }
        public PHONG(DataRow row)
        {
            this.id_P = (string)row["id_P"];
            this.ten_P = row["ten_P"].ToString();
            this.tinhtrang = row["tinhtrang"].ToString();
            this.id_LP = (string)row["id_LP"];
        }
    }
}
