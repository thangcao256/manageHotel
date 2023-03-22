
namespace QLKS
{
    partial class fQLPhong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlDangNhap = new DevComponents.DotNetBar.PanelEx();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSua = new DevComponents.DotNetBar.ButtonX();
            this.cbbTinhtrang = new System.Windows.Forms.ComboBox();
            this.btnXoa = new DevComponents.DotNetBar.ButtonX();
            this.btnDatphong = new DevComponents.DotNetBar.ButtonX();
            this.lblMaphong = new DevComponents.DotNetBar.LabelX();
            this.btnTimkiem = new DevComponents.DotNetBar.ButtonX();
            this.txtMaphong = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnXem = new DevComponents.DotNetBar.ButtonX();
            this.txtLoaiphong = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnThem = new DevComponents.DotNetBar.ButtonX();
            this.txtTenphong = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblTenphong = new DevComponents.DotNetBar.LabelX();
            this.lblTinhtrang = new DevComponents.DotNetBar.LabelX();
            this.lblLoaiphong = new DevComponents.DotNetBar.LabelX();
            this.dtgvDsphong = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTrove = new DevComponents.DotNetBar.ButtonX();
            this.pnlDangNhap.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDsphong)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDangNhap
            // 
            this.pnlDangNhap.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlDangNhap.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlDangNhap.Controls.Add(this.groupBox1);
            this.pnlDangNhap.Controls.Add(this.dtgvDsphong);
            this.pnlDangNhap.Controls.Add(this.btnTrove);
            this.pnlDangNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.pnlDangNhap.Location = new System.Drawing.Point(11, 13);
            this.pnlDangNhap.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDangNhap.Name = "pnlDangNhap";
            this.pnlDangNhap.Size = new System.Drawing.Size(976, 543);
            this.pnlDangNhap.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlDangNhap.Style.BackColor1.Color = System.Drawing.Color.White;
            this.pnlDangNhap.Style.BackColor2.Color = System.Drawing.Color.White;
            this.pnlDangNhap.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnlDangNhap.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlDangNhap.Style.BorderWidth = 5;
            this.pnlDangNhap.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnlDangNhap.Style.ForeColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlDangNhap.Style.GradientAngle = 90;
            this.pnlDangNhap.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.cbbTinhtrang);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnDatphong);
            this.groupBox1.Controls.Add(this.lblMaphong);
            this.groupBox1.Controls.Add(this.btnTimkiem);
            this.groupBox1.Controls.Add(this.txtMaphong);
            this.groupBox1.Controls.Add(this.btnXem);
            this.groupBox1.Controls.Add(this.txtLoaiphong);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.txtTenphong);
            this.groupBox1.Controls.Add(this.lblTenphong);
            this.groupBox1.Controls.Add(this.lblTinhtrang);
            this.groupBox1.Controls.Add(this.lblLoaiphong);
            this.groupBox1.Location = new System.Drawing.Point(20, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(930, 171);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phòng";
            // 
            // btnSua
            // 
            this.btnSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSua.BackColor = System.Drawing.Color.White;
            this.btnSua.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnSua.Location = new System.Drawing.Point(580, 130);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnSua.Size = new System.Drawing.Size(78, 28);
            this.btnSua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // cbbTinhtrang
            // 
            this.cbbTinhtrang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbTinhtrang.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbTinhtrang.FormattingEnabled = true;
            this.cbbTinhtrang.Items.AddRange(new object[] {
            "Sẵn sàng",
            "Đã thuê"});
            this.cbbTinhtrang.Location = new System.Drawing.Point(639, 79);
            this.cbbTinhtrang.Margin = new System.Windows.Forms.Padding(2);
            this.cbbTinhtrang.Name = "cbbTinhtrang";
            this.cbbTinhtrang.Size = new System.Drawing.Size(208, 31);
            this.cbbTinhtrang.TabIndex = 4;
            // 
            // btnXoa
            // 
            this.btnXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoa.BackColor = System.Drawing.Color.White;
            this.btnXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnXoa.Location = new System.Drawing.Point(497, 130);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnXoa.Size = new System.Drawing.Size(78, 28);
            this.btnXoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnDatphong
            // 
            this.btnDatphong.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDatphong.BackColor = System.Drawing.Color.White;
            this.btnDatphong.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnDatphong.Location = new System.Drawing.Point(783, 130);
            this.btnDatphong.Margin = new System.Windows.Forms.Padding(2);
            this.btnDatphong.Name = "btnDatphong";
            this.btnDatphong.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnDatphong.Size = new System.Drawing.Size(118, 28);
            this.btnDatphong.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDatphong.TabIndex = 8;
            this.btnDatphong.Text = "Đặt phòng";
            this.btnDatphong.Click += new System.EventHandler(this.btnDatphong_Click);
            // 
            // lblMaphong
            // 
            // 
            // 
            // 
            this.lblMaphong.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblMaphong.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMaphong.Location = new System.Drawing.Point(63, 46);
            this.lblMaphong.Margin = new System.Windows.Forms.Padding(2);
            this.lblMaphong.Name = "lblMaphong";
            this.lblMaphong.Size = new System.Drawing.Size(100, 22);
            this.lblMaphong.TabIndex = 0;
            this.lblMaphong.Text = "Mã phòng:";
            this.lblMaphong.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTimkiem.BackColor = System.Drawing.Color.White;
            this.btnTimkiem.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnTimkiem.Location = new System.Drawing.Point(414, 46);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnTimkiem.Size = new System.Drawing.Size(78, 28);
            this.btnTimkiem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTimkiem.TabIndex = 5;
            this.btnTimkiem.Text = "Tìm";
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // txtMaphong
            // 
            // 
            // 
            // 
            this.txtMaphong.Border.Class = "TextBoxBorder";
            this.txtMaphong.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaphong.Location = new System.Drawing.Point(177, 46);
            this.txtMaphong.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaphong.Name = "txtMaphong";
            this.txtMaphong.Size = new System.Drawing.Size(208, 30);
            this.txtMaphong.TabIndex = 1;
            // 
            // btnXem
            // 
            this.btnXem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXem.BackColor = System.Drawing.Color.White;
            this.btnXem.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnXem.Location = new System.Drawing.Point(331, 130);
            this.btnXem.Margin = new System.Windows.Forms.Padding(2);
            this.btnXem.Name = "btnXem";
            this.btnXem.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnXem.Size = new System.Drawing.Size(78, 28);
            this.btnXem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXem.TabIndex = 5;
            this.btnXem.Text = "Xem";
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // txtLoaiphong
            // 
            // 
            // 
            // 
            this.txtLoaiphong.Border.Class = "TextBoxBorder";
            this.txtLoaiphong.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtLoaiphong.Location = new System.Drawing.Point(639, 45);
            this.txtLoaiphong.Margin = new System.Windows.Forms.Padding(2);
            this.txtLoaiphong.Name = "txtLoaiphong";
            this.txtLoaiphong.Size = new System.Drawing.Size(208, 30);
            this.txtLoaiphong.TabIndex = 3;
            // 
            // btnThem
            // 
            this.btnThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThem.BackColor = System.Drawing.Color.White;
            this.btnThem.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnThem.Location = new System.Drawing.Point(414, 130);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnThem.Size = new System.Drawing.Size(78, 28);
            this.btnThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTenphong
            // 
            // 
            // 
            // 
            this.txtTenphong.Border.Class = "TextBoxBorder";
            this.txtTenphong.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenphong.Location = new System.Drawing.Point(177, 80);
            this.txtTenphong.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenphong.Name = "txtTenphong";
            this.txtTenphong.Size = new System.Drawing.Size(208, 30);
            this.txtTenphong.TabIndex = 2;
            // 
            // lblTenphong
            // 
            // 
            // 
            // 
            this.lblTenphong.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTenphong.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTenphong.Location = new System.Drawing.Point(63, 80);
            this.lblTenphong.Margin = new System.Windows.Forms.Padding(2);
            this.lblTenphong.Name = "lblTenphong";
            this.lblTenphong.Size = new System.Drawing.Size(100, 22);
            this.lblTenphong.TabIndex = 0;
            this.lblTenphong.Text = "Tên phòng:";
            this.lblTenphong.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // lblTinhtrang
            // 
            // 
            // 
            // 
            this.lblTinhtrang.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTinhtrang.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTinhtrang.Location = new System.Drawing.Point(522, 86);
            this.lblTinhtrang.Margin = new System.Windows.Forms.Padding(2);
            this.lblTinhtrang.Name = "lblTinhtrang";
            this.lblTinhtrang.Size = new System.Drawing.Size(112, 22);
            this.lblTinhtrang.TabIndex = 0;
            this.lblTinhtrang.Text = "Tình trạng:";
            this.lblTinhtrang.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // lblLoaiphong
            // 
            // 
            // 
            // 
            this.lblLoaiphong.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblLoaiphong.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLoaiphong.Location = new System.Drawing.Point(522, 46);
            this.lblLoaiphong.Margin = new System.Windows.Forms.Padding(2);
            this.lblLoaiphong.Name = "lblLoaiphong";
            this.lblLoaiphong.Size = new System.Drawing.Size(112, 22);
            this.lblLoaiphong.TabIndex = 0;
            this.lblLoaiphong.Text = "Loại phòng:";
            this.lblLoaiphong.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // dtgvDsphong
            // 
            this.dtgvDsphong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDsphong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvDsphong.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvDsphong.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dtgvDsphong.Location = new System.Drawing.Point(20, 194);
            this.dtgvDsphong.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvDsphong.Name = "dtgvDsphong";
            this.dtgvDsphong.RowHeadersWidth = 51;
            this.dtgvDsphong.RowTemplate.Height = 24;
            this.dtgvDsphong.Size = new System.Drawing.Size(930, 293);
            this.dtgvDsphong.TabIndex = 23;
            this.dtgvDsphong.TabStop = false;
            this.dtgvDsphong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDsphong_CellContentClick_1);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã phòng";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 250;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên phòng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 250;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Loại phòng";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 250;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tình trạng";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 260;
            // 
            // btnTrove
            // 
            this.btnTrove.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTrove.BackColor = System.Drawing.Color.White;
            this.btnTrove.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnTrove.Location = new System.Drawing.Point(434, 498);
            this.btnTrove.Margin = new System.Windows.Forms.Padding(2);
            this.btnTrove.Name = "btnTrove";
            this.btnTrove.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnTrove.Size = new System.Drawing.Size(78, 28);
            this.btnTrove.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTrove.TabIndex = 8;
            this.btnTrove.Text = "Trở về";
            this.btnTrove.Click += new System.EventHandler(this.btnTrove_Click);
            // 
            // fQLPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 565);
            this.Controls.Add(this.pnlDangNhap);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fQLPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Phòng";
            this.Load += new System.EventHandler(this.fQLPhong_Load);
            this.pnlDangNhap.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDsphong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx pnlDangNhap;
        private DevComponents.DotNetBar.ButtonX btnTrove;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.ButtonX btnSua;
        private System.Windows.Forms.ComboBox cbbTinhtrang;
        private DevComponents.DotNetBar.ButtonX btnXoa;
        private DevComponents.DotNetBar.LabelX lblMaphong;
        private DevComponents.DotNetBar.ButtonX btnTimkiem;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaphong;
        private DevComponents.DotNetBar.ButtonX btnXem;
        private DevComponents.DotNetBar.Controls.TextBoxX txtLoaiphong;
        private DevComponents.DotNetBar.ButtonX btnThem;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenphong;
        private DevComponents.DotNetBar.LabelX lblTenphong;
        private DevComponents.DotNetBar.LabelX lblTinhtrang;
        private DevComponents.DotNetBar.LabelX lblLoaiphong;
        private DevComponents.DotNetBar.Controls.DataGridViewX dtgvDsphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private DevComponents.DotNetBar.ButtonX btnDatphong;
    }
}