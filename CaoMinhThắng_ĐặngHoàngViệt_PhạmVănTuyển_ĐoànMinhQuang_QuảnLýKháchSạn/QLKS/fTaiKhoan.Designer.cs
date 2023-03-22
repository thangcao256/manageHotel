
namespace QLKS
{
    partial class fTaiKhoan
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
            this.btnTrove = new DevComponents.DotNetBar.ButtonX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSua = new DevComponents.DotNetBar.ButtonX();
            this.cbbGioitinh = new System.Windows.Forms.ComboBox();
            this.btnXoa = new DevComponents.DotNetBar.ButtonX();
            this.btnThem = new DevComponents.DotNetBar.ButtonX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.txtMatk = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnXem = new DevComponents.DotNetBar.ButtonX();
            this.btnTim = new DevComponents.DotNetBar.ButtonX();
            this.txtTentk = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtEmail = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDiachi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.txtSdt = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.txtTen = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX13 = new DevComponents.DotNetBar.LabelX();
            this.txtMatkhau = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.gvTaikhoan = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnlDangNhap.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvTaikhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDangNhap
            // 
            this.pnlDangNhap.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlDangNhap.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlDangNhap.Controls.Add(this.btnTrove);
            this.pnlDangNhap.Controls.Add(this.groupBox1);
            this.pnlDangNhap.Controls.Add(this.gvTaikhoan);
            this.pnlDangNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.pnlDangNhap.Location = new System.Drawing.Point(11, 12);
            this.pnlDangNhap.Name = "pnlDangNhap";
            this.pnlDangNhap.Size = new System.Drawing.Size(1178, 640);
            this.pnlDangNhap.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlDangNhap.Style.BackColor1.Color = System.Drawing.Color.White;
            this.pnlDangNhap.Style.BackColor2.Color = System.Drawing.Color.White;
            this.pnlDangNhap.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnlDangNhap.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlDangNhap.Style.BorderWidth = 5;
            this.pnlDangNhap.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnlDangNhap.Style.ForeColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlDangNhap.Style.GradientAngle = 90;
            this.pnlDangNhap.TabIndex = 20;
            // 
            // btnTrove
            // 
            this.btnTrove.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTrove.BackColor = System.Drawing.Color.White;
            this.btnTrove.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnTrove.Location = new System.Drawing.Point(1056, 596);
            this.btnTrove.Name = "btnTrove";
            this.btnTrove.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnTrove.Size = new System.Drawing.Size(89, 30);
            this.btnTrove.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTrove.TabIndex = 14;
            this.btnTrove.Text = "Trở về";
            this.btnTrove.Click += new System.EventHandler(this.btnTrove_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.cbbGioitinh);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.labelX8);
            this.groupBox1.Controls.Add(this.txtMatk);
            this.groupBox1.Controls.Add(this.btnXem);
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.txtTentk);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtDiachi);
            this.groupBox1.Controls.Add(this.labelX11);
            this.groupBox1.Controls.Add(this.txtSdt);
            this.groupBox1.Controls.Add(this.labelX12);
            this.groupBox1.Controls.Add(this.txtTen);
            this.groupBox1.Controls.Add(this.labelX13);
            this.groupBox1.Controls.Add(this.txtMatkhau);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.labelX9);
            this.groupBox1.Controls.Add(this.labelX10);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Location = new System.Drawing.Point(27, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1118, 268);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tài khoản:";
            // 
            // btnSua
            // 
            this.btnSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSua.BackColor = System.Drawing.Color.White;
            this.btnSua.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnSua.Location = new System.Drawing.Point(593, 224);
            this.btnSua.Name = "btnSua";
            this.btnSua.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnSua.Size = new System.Drawing.Size(89, 30);
            this.btnSua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // cbbGioitinh
            // 
            this.cbbGioitinh.FormattingEnabled = true;
            this.cbbGioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cbbGioitinh.Location = new System.Drawing.Point(789, 80);
            this.cbbGioitinh.Name = "cbbGioitinh";
            this.cbbGioitinh.Size = new System.Drawing.Size(80, 31);
            this.cbbGioitinh.TabIndex = 6;
            // 
            // btnXoa
            // 
            this.btnXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoa.BackColor = System.Drawing.Color.White;
            this.btnXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnXoa.Location = new System.Drawing.Point(498, 224);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnXoa.Size = new System.Drawing.Size(89, 30);
            this.btnXoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThem.BackColor = System.Drawing.Color.White;
            this.btnThem.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnThem.Location = new System.Drawing.Point(403, 224);
            this.btnThem.Name = "btnThem";
            this.btnThem.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnThem.Size = new System.Drawing.Size(89, 30);
            this.btnThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX8.Location = new System.Drawing.Point(91, 44);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(146, 23);
            this.labelX8.TabIndex = 0;
            this.labelX8.Text = "Mã tài khoản:";
            this.labelX8.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txtMatk
            // 
            // 
            // 
            // 
            this.txtMatk.Border.Class = "TextBoxBorder";
            this.txtMatk.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMatk.Location = new System.Drawing.Point(253, 44);
            this.txtMatk.Name = "txtMatk";
            this.txtMatk.Size = new System.Drawing.Size(218, 30);
            this.txtMatk.TabIndex = 1;
            // 
            // btnXem
            // 
            this.btnXem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXem.BackColor = System.Drawing.Color.White;
            this.btnXem.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnXem.Location = new System.Drawing.Point(308, 224);
            this.btnXem.Name = "btnXem";
            this.btnXem.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnXem.Size = new System.Drawing.Size(89, 30);
            this.btnXem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXem.TabIndex = 9;
            this.btnXem.Text = "Xem";
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnTim
            // 
            this.btnTim.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTim.BackColor = System.Drawing.Color.White;
            this.btnTim.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnTim.Location = new System.Drawing.Point(498, 44);
            this.btnTim.Name = "btnTim";
            this.btnTim.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnTim.Size = new System.Drawing.Size(89, 30);
            this.btnTim.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTim.TabIndex = 13;
            this.btnTim.Text = "Tìm";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTentk
            // 
            // 
            // 
            // 
            this.txtTentk.Border.Class = "TextBoxBorder";
            this.txtTentk.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTentk.Location = new System.Drawing.Point(253, 80);
            this.txtTentk.Name = "txtTentk";
            this.txtTentk.Size = new System.Drawing.Size(218, 30);
            this.txtTentk.TabIndex = 2;
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.Border.Class = "TextBoxBorder";
            this.txtEmail.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtEmail.Location = new System.Drawing.Point(789, 116);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(218, 30);
            this.txtEmail.TabIndex = 7;
            // 
            // txtDiachi
            // 
            // 
            // 
            // 
            this.txtDiachi.Border.Class = "TextBoxBorder";
            this.txtDiachi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDiachi.Location = new System.Drawing.Point(789, 152);
            this.txtDiachi.Multiline = true;
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(218, 30);
            this.txtDiachi.TabIndex = 8;
            // 
            // labelX11
            // 
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX11.Location = new System.Drawing.Point(628, 78);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(144, 23);
            this.labelX11.TabIndex = 0;
            this.labelX11.Text = "Giới tính:";
            this.labelX11.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txtSdt
            // 
            // 
            // 
            // 
            this.txtSdt.Border.Class = "TextBoxBorder";
            this.txtSdt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSdt.Location = new System.Drawing.Point(253, 152);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(218, 30);
            this.txtSdt.TabIndex = 4;
            // 
            // labelX12
            // 
            // 
            // 
            // 
            this.labelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX12.Location = new System.Drawing.Point(92, 152);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(146, 23);
            this.labelX12.TabIndex = 0;
            this.labelX12.Text = "SDT:";
            this.labelX12.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txtTen
            // 
            // 
            // 
            // 
            this.txtTen.Border.Class = "TextBoxBorder";
            this.txtTen.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTen.Location = new System.Drawing.Point(253, 116);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(218, 30);
            this.txtTen.TabIndex = 3;
            // 
            // labelX13
            // 
            // 
            // 
            // 
            this.labelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX13.Location = new System.Drawing.Point(628, 152);
            this.labelX13.Name = "labelX13";
            this.labelX13.Size = new System.Drawing.Size(146, 23);
            this.labelX13.TabIndex = 0;
            this.labelX13.Text = "Địa chỉ:";
            this.labelX13.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txtMatkhau
            // 
            // 
            // 
            // 
            this.txtMatkhau.Border.Class = "TextBoxBorder";
            this.txtMatkhau.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMatkhau.Location = new System.Drawing.Point(789, 44);
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.Size = new System.Drawing.Size(218, 30);
            this.txtMatkhau.TabIndex = 5;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX2.Location = new System.Drawing.Point(628, 123);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(144, 23);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "Email:";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX9
            // 
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX9.Location = new System.Drawing.Point(92, 80);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(146, 23);
            this.labelX9.TabIndex = 0;
            this.labelX9.Text = "Tên tài khoản: ";
            this.labelX9.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX10
            // 
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX10.Location = new System.Drawing.Point(628, 44);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(145, 23);
            this.labelX10.TabIndex = 0;
            this.labelX10.Text = "Mật khẩu:";
            this.labelX10.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX1.Location = new System.Drawing.Point(91, 116);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(146, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Tên hiển thị:";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // gvTaikhoan
            // 
            this.gvTaikhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvTaikhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTaikhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvTaikhoan.DefaultCellStyle = dataGridViewCellStyle1;
            this.gvTaikhoan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gvTaikhoan.Location = new System.Drawing.Point(27, 301);
            this.gvTaikhoan.Name = "gvTaikhoan";
            this.gvTaikhoan.RowHeadersWidth = 51;
            this.gvTaikhoan.RowTemplate.Height = 24;
            this.gvTaikhoan.Size = new System.Drawing.Size(1118, 287);
            this.gvTaikhoan.TabIndex = 25;
            this.gvTaikhoan.TabStop = false;
            this.gvTaikhoan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvTaikhoan_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id_TK";
            this.Column1.HeaderText = "Mã tài khoản";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ten_TK";
            this.Column3.HeaderText = "Tên tài khoản";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "matkhau_TK";
            this.Column4.HeaderText = "Mật khẩu";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "tenhienthi_TK";
            this.Column5.HeaderText = "Tên hiển thị";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "gioitinh";
            this.Column6.HeaderText = "Giới tính";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 90;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "sdt";
            this.Column7.HeaderText = "Số điện thoại";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "diachi";
            this.Column8.HeaderText = "Địa chỉ";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 175;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "email";
            this.Column9.HeaderText = "Email";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 175;
            // 
            // fTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 664);
            this.Controls.Add(this.pnlDangNhap);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý tài khoản";
            this.Load += new System.EventHandler(this.fTaiKhoan_Load);
            this.pnlDangNhap.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvTaikhoan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx pnlDangNhap;
        private DevComponents.DotNetBar.ButtonX btnXoa;
        private DevComponents.DotNetBar.ButtonX btnThem;
        private DevComponents.DotNetBar.ButtonX btnTim;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTentk;
        private DevComponents.DotNetBar.Controls.TextBoxX txtEmail;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDiachi;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSdt;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTen;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMatkhau;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMatk;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX13;
        private DevComponents.DotNetBar.LabelX labelX12;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.Controls.DataGridViewX gvTaikhoan;
        private System.Windows.Forms.ComboBox cbbGioitinh;
        private DevComponents.DotNetBar.ButtonX btnSua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevComponents.DotNetBar.ButtonX btnTrove;
        private DevComponents.DotNetBar.ButtonX btnXem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}