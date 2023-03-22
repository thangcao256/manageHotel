using QLKS.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS
{
    public partial class fThongKe : Form
    {
        public fThongKe()
        {
            InitializeComponent();
            LoadNgayTheoTimePicker();
        }

        private void btnTimphong_Click(object sender, EventArgs e)
        {
            LoadThongke(d1.Value, d2.Value);
        }

        void LoadThongke(DateTime ngayvao, DateTime ngaytra)
        {
            dtgvThongke.DataSource = HOADONDAO.Instance.GetBillListByDate(ngayvao, ngaytra);
        }

        void LoadNgayTheoTimePicker()
        {
            DateTime today = DateTime.Now;
            d1.Value = new DateTime(today.Year, today.Month, 1);
            d2.Value = d1.Value.AddMonths(1).AddDays(-1);
        }
    }
}
