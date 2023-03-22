namespace QLKS
{
    partial class fDichVu
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
            this.txtTendv = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMadv = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX14 = new DevComponents.DotNetBar.LabelX();
            this.labelX15 = new DevComponents.DotNetBar.LabelX();
            this.labelX16 = new DevComponents.DotNetBar.LabelX();
            this.dgvDichvu = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.id_DV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_DV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia_DV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlDangNhap = new DevComponents.DotNetBar.PanelEx();
            this.btnTrove = new DevComponents.DotNetBar.ButtonX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSua = new DevComponents.DotNetBar.ButtonX();
            this.btnXoa = new DevComponents.DotNetBar.ButtonX();
            this.btnThem = new DevComponents.DotNetBar.ButtonX();
            this.btnTim = new DevComponents.DotNetBar.ButtonX();
            this.txtDg = new DevComponents.DotNetBar.Controls.TextBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichvu)).BeginInit();
            this.pnlDangNhap.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTendv
            // 
            // 
            // 
            // 
            this.txtTendv.Border.Class = "TextBoxBorder";
            this.txtTendv.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTendv.Location = new System.Drawing.Point(192, 75);
            this.txtTendv.Name = "txtTendv";
            this.txtTendv.Size = new System.Drawing.Size(218, 30);
            this.txtTendv.TabIndex = 2;
            // 
            // txtMadv
            // 
            // 
            // 
            // 
            this.txtMadv.Border.Class = "TextBoxBorder";
            this.txtMadv.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMadv.Location = new System.Drawing.Point(192, 39);
            this.txtMadv.Name = "txtMadv";
            this.txtMadv.Size = new System.Drawing.Size(218, 30);
            this.txtMadv.TabIndex = 1;
            // 
            // labelX14
            // 
            // 
            // 
            // 
            this.labelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX14.Location = new System.Drawing.Point(26, 39);
            this.labelX14.Name = "labelX14";
            this.labelX14.Size = new System.Drawing.Size(146, 23);
            this.labelX14.TabIndex = 0;
            this.labelX14.Text = "Mã dịch vụ:";
            this.labelX14.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX15
            // 
            // 
            // 
            // 
            this.labelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX15.Location = new System.Drawing.Point(26, 75);
            this.labelX15.Name = "labelX15";
            this.labelX15.Size = new System.Drawing.Size(146, 23);
            this.labelX15.TabIndex = 0;
            this.labelX15.Text = "Tên dịch vụ:";
            this.labelX15.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX16
            // 
            // 
            // 
            // 
            this.labelX16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX16.Location = new System.Drawing.Point(73, 111);
            this.labelX16.Name = "labelX16";
            this.labelX16.Size = new System.Drawing.Size(99, 23);
            this.labelX16.TabIndex = 0;
            this.labelX16.Text = "Đơn giá:";
            this.labelX16.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // dgvDichvu
            // 
            this.dgvDichvu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDichvu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDichvu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_DV,
            this.ten_DV,
            this.gia_DV});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDichvu.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDichvu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvDichvu.Location = new System.Drawing.Point(18, 196);
            this.dgvDichvu.Name = "dgvDichvu";
            this.dgvDichvu.RowHeadersWidth = 51;
            this.dgvDichvu.RowTemplate.Height = 24;
            this.dgvDichvu.Size = new System.Drawing.Size(744, 279);
            this.dgvDichvu.TabIndex = 27;
            this.dgvDichvu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDichvu_CellContentClick);
            // 
            // id_DV
            // 
            this.id_DV.HeaderText = "Mã dịch vụ";
            this.id_DV.MinimumWidth = 6;
            this.id_DV.Name = "id_DV";
            this.id_DV.Width = 200;
            // 
            // ten_DV
            // 
            this.ten_DV.HeaderText = "Tên dịch vụ";
            this.ten_DV.MinimumWidth = 6;
            this.ten_DV.Name = "ten_DV";
            this.ten_DV.Width = 250;
            // 
            // gia_DV
            // 
            this.gia_DV.HeaderText = "Giá giá vụ";
            this.gia_DV.MinimumWidth = 6;
            this.gia_DV.Name = "gia_DV";
            this.gia_DV.Width = 240;
            // 
            // pnlDangNhap
            // 
            this.pnlDangNhap.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlDangNhap.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlDangNhap.Controls.Add(this.btnTrove);
            this.pnlDangNhap.Controls.Add(this.groupBox1);
            this.pnlDangNhap.Controls.Add(this.dgvDichvu);
            this.pnlDangNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.pnlDangNhap.Location = new System.Drawing.Point(12, 12);
            this.pnlDangNhap.Name = "pnlDangNhap";
            this.pnlDangNhap.Size = new System.Drawing.Size(787, 526);
            this.pnlDangNhap.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlDangNhap.Style.BackColor1.Color = System.Drawing.Color.White;
            this.pnlDangNhap.Style.BackColor2.Color = System.Drawing.Color.White;
            this.pnlDangNhap.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnlDangNhap.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlDangNhap.Style.BorderWidth = 5;
            this.pnlDangNhap.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnlDangNhap.Style.ForeColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlDangNhap.Style.GradientAngle = 90;
            this.pnlDangNhap.TabIndex = 29;
            // 
            // btnTrove
            // 
            this.btnTrove.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTrove.BackColor = System.Drawing.Color.White;
            this.btnTrove.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnTrove.Location = new System.Drawing.Point(673, 481);
            this.btnTrove.Name = "btnTrove";
            this.btnTrove.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnTrove.Size = new System.Drawing.Size(89, 30);
            this.btnTrove.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTrove.TabIndex = 30;
            this.btnTrove.Text = "Trở về";
            this.btnTrove.Click += new System.EventHandler(this.btnTrove_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.labelX14);
            this.groupBox1.Controls.Add(this.txtMadv);
            this.groupBox1.Controls.Add(this.labelX15);
            this.groupBox1.Controls.Add(this.txtDg);
            this.groupBox1.Controls.Add(this.txtTendv);
            this.groupBox1.Controls.Add(this.labelX16);
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(744, 172);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // btnSua
            // 
            this.btnSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSua.BackColor = System.Drawing.Color.White;
            this.btnSua.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnSua.Location = new System.Drawing.Point(639, 111);
            this.btnSua.Name = "btnSua";
            this.btnSua.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnSua.Size = new System.Drawing.Size(89, 30);
            this.btnSua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSua.TabIndex = 16;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoa.BackColor = System.Drawing.Color.White;
            this.btnXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnXoa.Location = new System.Drawing.Point(544, 111);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnXoa.Size = new System.Drawing.Size(89, 30);
            this.btnXoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXoa.TabIndex = 17;
            this.btnXoa.Text = "Xoá";
            // 
            // btnThem
            // 
            this.btnThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThem.BackColor = System.Drawing.Color.White;
            this.btnThem.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnThem.Location = new System.Drawing.Point(449, 111);
            this.btnThem.Name = "btnThem";
            this.btnThem.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnThem.Size = new System.Drawing.Size(89, 30);
            this.btnThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThem.TabIndex = 15;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTim
            // 
            this.btnTim.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTim.BackColor = System.Drawing.Color.White;
            this.btnTim.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnTim.Location = new System.Drawing.Point(448, 39);
            this.btnTim.Name = "btnTim";
            this.btnTim.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnTim.Size = new System.Drawing.Size(89, 30);
            this.btnTim.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTim.TabIndex = 14;
            this.btnTim.Text = "Tìm";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtDg
            // 
            // 
            // 
            // 
            this.txtDg.Border.Class = "TextBoxBorder";
            this.txtDg.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDg.Location = new System.Drawing.Point(193, 111);
            this.txtDg.Name = "txtDg";
            this.txtDg.Size = new System.Drawing.Size(218, 30);
            this.txtDg.TabIndex = 3;
            // 
            // fDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 552);
            this.Controls.Add(this.pnlDangNhap);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "fDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý dịch vụ";
            this.Load += new System.EventHandler(this.fDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichvu)).EndInit();
            this.pnlDangNhap.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.Controls.TextBoxX txtTendv;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMadv;
        private DevComponents.DotNetBar.LabelX labelX14;
        private DevComponents.DotNetBar.LabelX labelX15;
        private DevComponents.DotNetBar.LabelX labelX16;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvDichvu;
        private DevComponents.DotNetBar.PanelEx pnlDangNhap;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.ButtonX btnSua;
        private DevComponents.DotNetBar.ButtonX btnXoa;
        private DevComponents.DotNetBar.ButtonX btnThem;
        private DevComponents.DotNetBar.ButtonX btnTim;
        private DevComponents.DotNetBar.ButtonX btnTrove;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDg;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_DV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_DV;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia_DV;
    }
}