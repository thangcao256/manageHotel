namespace QLKS.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data;
    using System.Data.Entity.Spatial;

    [Table("LOAIPHONG")]
    public partial class LOAIPHONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOAIPHONG()
        {
            PHONG = new HashSet<PHONG>();
        }

        [Key]
        [StringLength(10)]
        public string id_LP { get; set; }

        [StringLength(30)]
        public string ten_LP { get; set; }

        public int? succhua { get; set; }

        public float? giaphong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHONG> PHONG { get; set; }

        public LOAIPHONG(string id_LP, string ten_LP, int succhua, float giaphong )
        {
            this.id_LP = id_LP;
            this.ten_LP = ten_LP;
            this.succhua = succhua;
            this.giaphong = giaphong;
        }

        public LOAIPHONG(DataRow row)
        {
            this.id_LP = row["id_LP"].ToString();
            this.ten_LP = row["ten_LP"].ToString();
            this.succhua = (int)row["succhua"];
            this.giaphong = (float)Convert.ToDouble(row["giaphong"].ToString());
        }
    }
}
