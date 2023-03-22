namespace QLKS
{
    partial class fThongKe
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
            this.pnlDangNhap = new DevComponents.DotNetBar.PanelEx();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnTimphong = new DevComponents.DotNetBar.ButtonX();
            this.d2 = new System.Windows.Forms.DateTimePicker();
            this.d1 = new System.Windows.Forms.DateTimePicker();
            this.dtgvThongke = new System.Windows.Forms.DataGridView();
            this.pnlDangNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThongke)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDangNhap
            // 
            this.pnlDangNhap.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlDangNhap.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlDangNhap.Controls.Add(this.dtgvThongke);
            this.pnlDangNhap.Controls.Add(this.labelX3);
            this.pnlDangNhap.Controls.Add(this.labelX2);
            this.pnlDangNhap.Controls.Add(this.labelX1);
            this.pnlDangNhap.Controls.Add(this.comboBox1);
            this.pnlDangNhap.Controls.Add(this.btnTimphong);
            this.pnlDangNhap.Controls.Add(this.d2);
            this.pnlDangNhap.Controls.Add(this.d1);
            this.pnlDangNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.pnlDangNhap.Location = new System.Drawing.Point(10, 12);
            this.pnlDangNhap.Name = "pnlDangNhap";
            this.pnlDangNhap.Size = new System.Drawing.Size(972, 460);
            this.pnlDangNhap.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlDangNhap.Style.BackColor1.Color = System.Drawing.Color.White;
            this.pnlDangNhap.Style.BackColor2.Color = System.Drawing.Color.White;
            this.pnlDangNhap.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnlDangNhap.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlDangNhap.Style.BorderWidth = 5;
            this.pnlDangNhap.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnlDangNhap.Style.ForeColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlDangNhap.Style.GradientAngle = 90;
            this.pnlDangNhap.TabIndex = 18;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(89, 23);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(104, 30);
            this.labelX3.TabIndex = 29;
            this.labelX3.Text = "Thống kê:";
            this.labelX3.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(108, 66);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(85, 30);
            this.labelX2.TabIndex = 29;
            this.labelX2.Text = "Từ ngày";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(475, 66);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(56, 30);
            this.labelX1.TabIndex = 29;
            this.labelX1.Text = "đến";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(216, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(253, 31);
            this.comboBox1.TabIndex = 28;
            // 
            // btnTimphong
            // 
            this.btnTimphong.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTimphong.BackColor = System.Drawing.Color.White;
            this.btnTimphong.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnTimphong.Location = new System.Drawing.Point(216, 102);
            this.btnTimphong.Name = "btnTimphong";
            this.btnTimphong.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnTimphong.Size = new System.Drawing.Size(161, 30);
            this.btnTimphong.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTimphong.TabIndex = 27;
            this.btnTimphong.Text = "Thống kê";
            this.btnTimphong.Click += new System.EventHandler(this.btnTimphong_Click);
            // 
            // d2
            // 
            this.d2.Location = new System.Drawing.Point(538, 66);
            this.d2.Name = "d2";
            this.d2.Size = new System.Drawing.Size(253, 30);
            this.d2.TabIndex = 25;
            // 
            // d1
            // 
            this.d1.Location = new System.Drawing.Point(216, 66);
            this.d1.Name = "d1";
            this.d1.Size = new System.Drawing.Size(253, 30);
            this.d1.TabIndex = 26;
            // 
            // dtgvThongke
            // 
            this.dtgvThongke.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvThongke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvThongke.Location = new System.Drawing.Point(13, 147);
            this.dtgvThongke.Name = "dtgvThongke";
            this.dtgvThongke.RowHeadersWidth = 51;
            this.dtgvThongke.RowTemplate.Height = 24;
            this.dtgvThongke.Size = new System.Drawing.Size(944, 300);
            this.dtgvThongke.TabIndex = 30;
            // 
            // fThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 479);
            this.Controls.Add(this.pnlDangNhap);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê ";
            this.pnlDangNhap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThongke)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx pnlDangNhap;
        private DevComponents.DotNetBar.ButtonX btnTimphong;
        private System.Windows.Forms.DateTimePicker d2;
        private System.Windows.Forms.DateTimePicker d1;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dtgvThongke;
    }
}