
namespace QLKS
{
    partial class fHoaDon
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
            this.btnThue = new DevComponents.DotNetBar.ButtonX();
            this.dtgvHoadon = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbbLoaiphong = new System.Windows.Forms.ComboBox();
            this.cbbPhong = new System.Windows.Forms.ComboBox();
            this.cbbKhachhang = new System.Windows.Forms.ComboBox();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.btnTrove = new DevComponents.DotNetBar.ButtonX();
            this.pnlDangNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDangNhap
            // 
            this.pnlDangNhap.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlDangNhap.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlDangNhap.Controls.Add(this.btnTrove);
            this.pnlDangNhap.Controls.Add(this.btnThue);
            this.pnlDangNhap.Controls.Add(this.dtgvHoadon);
            this.pnlDangNhap.Controls.Add(this.cbbLoaiphong);
            this.pnlDangNhap.Controls.Add(this.cbbPhong);
            this.pnlDangNhap.Controls.Add(this.cbbKhachhang);
            this.pnlDangNhap.Controls.Add(this.labelX1);
            this.pnlDangNhap.Controls.Add(this.labelX2);
            this.pnlDangNhap.Controls.Add(this.labelX4);
            this.pnlDangNhap.Controls.Add(this.labelX3);
            this.pnlDangNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.pnlDangNhap.Location = new System.Drawing.Point(13, 12);
            this.pnlDangNhap.Name = "pnlDangNhap";
            this.pnlDangNhap.Size = new System.Drawing.Size(839, 468);
            this.pnlDangNhap.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlDangNhap.Style.BackColor1.Color = System.Drawing.Color.White;
            this.pnlDangNhap.Style.BackColor2.Color = System.Drawing.Color.White;
            this.pnlDangNhap.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnlDangNhap.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlDangNhap.Style.BorderWidth = 5;
            this.pnlDangNhap.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnlDangNhap.Style.ForeColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlDangNhap.Style.GradientAngle = 90;
            this.pnlDangNhap.TabIndex = 52;
            // 
            // btnThue
            // 
            this.btnThue.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThue.BackColor = System.Drawing.Color.White;
            this.btnThue.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnThue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThue.Location = new System.Drawing.Point(696, 35);
            this.btnThue.Name = "btnThue";
            this.btnThue.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnThue.Size = new System.Drawing.Size(84, 30);
            this.btnThue.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThue.TabIndex = 58;
            this.btnThue.Text = "Thuê";
            this.btnThue.Click += new System.EventHandler(this.btnThue_Click);
            // 
            // dtgvHoadon
            // 
            this.dtgvHoadon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvHoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvHoadon.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvHoadon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dtgvHoadon.Location = new System.Drawing.Point(14, 114);
            this.dtgvHoadon.Name = "dtgvHoadon";
            this.dtgvHoadon.ReadOnly = true;
            this.dtgvHoadon.RowHeadersWidth = 51;
            this.dtgvHoadon.RowTemplate.Height = 24;
            this.dtgvHoadon.Size = new System.Drawing.Size(803, 301);
            this.dtgvHoadon.TabIndex = 26;
            this.dtgvHoadon.TabStop = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Phòng";
            this.Column1.HeaderText = "Phòng";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Khách hàng";
            this.Column2.HeaderText = "Khách hàng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "CMND";
            this.Column3.HeaderText = "CMND";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Ngày vào";
            this.Column4.HeaderText = "Ngày vào";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Loại phòng";
            this.Column5.HeaderText = "Loại phòng";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Giá phòng";
            this.Column6.HeaderText = "Giá phòng";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // cbbLoaiphong
            // 
            this.cbbLoaiphong.FormattingEnabled = true;
            this.cbbLoaiphong.Location = new System.Drawing.Point(486, 22);
            this.cbbLoaiphong.Name = "cbbLoaiphong";
            this.cbbLoaiphong.Size = new System.Drawing.Size(152, 31);
            this.cbbLoaiphong.TabIndex = 1;
            this.cbbLoaiphong.SelectedIndexChanged += new System.EventHandler(this.cbbLoaiphong_SelectedIndexChanged);
            // 
            // cbbPhong
            // 
            this.cbbPhong.FormattingEnabled = true;
            this.cbbPhong.Location = new System.Drawing.Point(486, 59);
            this.cbbPhong.Name = "cbbPhong";
            this.cbbPhong.Size = new System.Drawing.Size(152, 31);
            this.cbbPhong.TabIndex = 1;
            // 
            // cbbKhachhang
            // 
            this.cbbKhachhang.FormattingEnabled = true;
            this.cbbKhachhang.Location = new System.Drawing.Point(154, 49);
            this.cbbKhachhang.Name = "cbbKhachhang";
            this.cbbKhachhang.Size = new System.Drawing.Size(152, 31);
            this.cbbKhachhang.TabIndex = 1;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(346, 23);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(134, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Loại:";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(346, 60);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(134, 23);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "Phòng:";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(14, 53);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(134, 23);
            this.labelX3.TabIndex = 0;
            this.labelX3.Text = "Khách hàng:";
            this.labelX3.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.ForeColor = System.Drawing.Color.Black;
            this.labelX4.Location = new System.Drawing.Point(71, 20);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(184, 23);
            this.labelX4.TabIndex = 0;
            this.labelX4.Text = "Thông tin phòng";
            this.labelX4.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // btnTrove
            // 
            this.btnTrove.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTrove.BackColor = System.Drawing.Color.White;
            this.btnTrove.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnTrove.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTrove.Location = new System.Drawing.Point(733, 421);
            this.btnTrove.Name = "btnTrove";
            this.btnTrove.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnTrove.Size = new System.Drawing.Size(84, 30);
            this.btnTrove.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTrove.TabIndex = 58;
            this.btnTrove.Text = "Trở về";
            this.btnTrove.Click += new System.EventHandler(this.btnTrove_Click);
            // 
            // fHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 492);
            this.Controls.Add(this.pnlDangNhap);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hoá Đơn";
            this.pnlDangNhap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHoadon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx pnlDangNhap;
        private System.Windows.Forms.ComboBox cbbKhachhang;
        private System.Windows.Forms.ComboBox cbbPhong;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dtgvHoadon;
        private DevComponents.DotNetBar.ButtonX btnThue;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.ComboBox cbbLoaiphong;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private DevComponents.DotNetBar.ButtonX btnTrove;
        private DevComponents.DotNetBar.LabelX labelX4;
    }
}