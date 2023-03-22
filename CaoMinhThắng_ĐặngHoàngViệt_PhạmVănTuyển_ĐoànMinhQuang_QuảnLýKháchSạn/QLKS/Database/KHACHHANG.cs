using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.Entity.Spatial;
namespace QLKS.Database
{
    

    [Table("KHACHHANG")]
    public partial class KHACHHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHACHHANG()
        {
            HOADON = new HashSet<HOADON>();
        }

        [Key]
        [StringLength(10)]
        public string id_KH { get; set; }

        [StringLength(50)]
        public string ten { get; set; }

        [StringLength(30)]
        public string ngaysinh { get; set; }

        [StringLength(20)]
        public string gioitinh { get; set; }

        [StringLength(10)]
        public string cmnd { get; set; }

        [StringLength(30)]
        public string quoctich { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADON> HOADON { get; set; }

        public KHACHHANG(string id_KH, string ten, string ngaysinh, string gioitinh, string cmnd, string quoctich)
        {
            this.id_KH = id_KH;
            this.ten = ten;
            this.ngaysinh = ngaysinh;
            this.gioitinh = gioitinh;
            this.cmnd = cmnd;
            this.quoctich = quoctich;
        }
        public KHACHHANG(DataRow row) //lấy từ các trường dữ liệu trong sql
        {
            this.id_KH = (string)row["id_KH"];
            this.ten = (string)row["Tên KH"];
            this.ngaysinh = (string)row["Ngày sinh"];
            this.gioitinh = row["Giới tính"].ToString();
            this.cmnd = row["Số CM"].ToString();
            this.quoctich = row["Quốc tịch"].ToString();
        }
    }
}
