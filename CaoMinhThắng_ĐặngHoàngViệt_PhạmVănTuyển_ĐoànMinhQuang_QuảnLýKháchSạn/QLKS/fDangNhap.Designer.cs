namespace QLKS
{
    partial class fDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDangNhap));
            this.txtDangNhap = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMatkhau = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.panelEx3 = new DevComponents.DotNetBar.PanelEx();
            this.chkHienthi = new System.Windows.Forms.CheckBox();
            this.lbDangNhap = new DevComponents.DotNetBar.LabelX();
            this.lbEyes = new DevComponents.DotNetBar.LabelX();
            this.btnDangnhap = new DevComponents.DotNetBar.ButtonX();
            this.btnThoat = new DevComponents.DotNetBar.ButtonX();
            this.pnlDangNhap = new DevComponents.DotNetBar.PanelEx();
            this.pnlDangNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDangNhap
            // 
            // 
            // 
            // 
            this.txtDangNhap.Border.BackColor2 = System.Drawing.Color.White;
            this.txtDangNhap.Border.BorderColor = System.Drawing.Color.Transparent;
            this.txtDangNhap.Border.Class = "TextBoxBorder";
            this.txtDangNhap.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDangNhap.Location = new System.Drawing.Point(110, 100);
            this.txtDangNhap.Name = "txtDangNhap";
            this.txtDangNhap.Size = new System.Drawing.Size(263, 30);
            this.txtDangNhap.TabIndex = 1;
            this.txtDangNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDangNhap.WatermarkText = "Tài khoản";
            // 
            // txtMatkhau
            // 
            // 
            // 
            // 
            this.txtMatkhau.Border.BackColor2 = System.Drawing.Color.White;
            this.txtMatkhau.Border.BorderColor = System.Drawing.Color.Transparent;
            this.txtMatkhau.Border.Class = "TextBoxBorder";
            this.txtMatkhau.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMatkhau.Location = new System.Drawing.Point(110, 181);
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.Size = new System.Drawing.Size(263, 30);
            this.txtMatkhau.TabIndex = 2;
            this.txtMatkhau.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMatkhau.UseSystemPasswordChar = true;
            this.txtMatkhau.WatermarkText = "Mật khẩu";
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Location = new System.Drawing.Point(77, 133);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(332, 2);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 15;
            // 
            // panelEx3
            // 
            this.panelEx3.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx3.Location = new System.Drawing.Point(77, 214);
            this.panelEx3.Name = "panelEx3";
            this.panelEx3.Size = new System.Drawing.Size(332, 2);
            this.panelEx3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx3.Style.GradientAngle = 90;
            this.panelEx3.TabIndex = 16;
            // 
            // chkHienthi
            // 
            this.chkHienthi.AutoSize = true;
            this.chkHienthi.Location = new System.Drawing.Point(77, 222);
            this.chkHienthi.Name = "chkHienthi";
            this.chkHienthi.Size = new System.Drawing.Size(182, 27);
            this.chkHienthi.TabIndex = 17;
            this.chkHienthi.TabStop = false;
            this.chkHienthi.Text = "Ghi nhớ mật khẩu";
            this.chkHienthi.UseVisualStyleBackColor = true;
            this.chkHienthi.CheckedChanged += new System.EventHandler(this.chkHienthi_CheckedChanged);
            // 
            // lbDangNhap
            // 
            // 
            // 
            // 
            this.lbDangNhap.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbDangNhap.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDangNhap.Location = new System.Drawing.Point(134, 27);
            this.lbDangNhap.Name = "lbDangNhap";
            this.lbDangNhap.Size = new System.Drawing.Size(229, 67);
            this.lbDangNhap.TabIndex = 0;
            this.lbDangNhap.Text = "ĐĂNG NHẬP";
            // 
            // lbEyes
            // 
            // 
            // 
            // 
            this.lbEyes.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbEyes.Location = new System.Drawing.Point(379, 181);
            this.lbEyes.Name = "lbEyes";
            this.lbEyes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbEyes.Size = new System.Drawing.Size(30, 27);
            this.lbEyes.Symbol = "";
            this.lbEyes.SymbolSize = 12F;
            this.lbEyes.TabIndex = 18;
            this.lbEyes.TextAlignment = System.Drawing.StringAlignment.Center;
            this.lbEyes.Click += new System.EventHandler(this.lbEyes_Click);
            // 
            // btnDangnhap
            // 
            this.btnDangnhap.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDangnhap.BackColor = System.Drawing.Color.White;
            this.btnDangnhap.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnDangnhap.Location = new System.Drawing.Point(77, 268);
            this.btnDangnhap.Name = "btnDangnhap";
            this.btnDangnhap.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnDangnhap.Size = new System.Drawing.Size(161, 30);
            this.btnDangnhap.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDangnhap.TabIndex = 3;
            this.btnDangnhap.Text = "Đăng Nhập";
            this.btnDangnhap.Click += new System.EventHandler(this.btnDangnhap_Click_1);
            // 
            // btnThoat
            // 
            this.btnThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThoat.BackColor = System.Drawing.Color.White;
            this.btnThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Location = new System.Drawing.Point(248, 268);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnThoat.Size = new System.Drawing.Size(161, 30);
            this.btnThoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // pnlDangNhap
            // 
            this.pnlDangNhap.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlDangNhap.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlDangNhap.Controls.Add(this.btnThoat);
            this.pnlDangNhap.Controls.Add(this.btnDangnhap);
            this.pnlDangNhap.Controls.Add(this.lbEyes);
            this.pnlDangNhap.Controls.Add(this.lbDangNhap);
            this.pnlDangNhap.Controls.Add(this.chkHienthi);
            this.pnlDangNhap.Controls.Add(this.panelEx3);
            this.pnlDangNhap.Controls.Add(this.panelEx1);
            this.pnlDangNhap.Controls.Add(this.txtMatkhau);
            this.pnlDangNhap.Controls.Add(this.txtDangNhap);
            this.pnlDangNhap.Location = new System.Drawing.Point(12, 12);
            this.pnlDangNhap.Name = "pnlDangNhap";
            this.pnlDangNhap.Size = new System.Drawing.Size(478, 336);
            this.pnlDangNhap.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlDangNhap.Style.BackColor1.Color = System.Drawing.Color.White;
            this.pnlDangNhap.Style.BackColor2.Color = System.Drawing.Color.White;
            this.pnlDangNhap.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnlDangNhap.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlDangNhap.Style.BorderWidth = 5;
            this.pnlDangNhap.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnlDangNhap.Style.ForeColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlDangNhap.Style.GradientAngle = 90;
            this.pnlDangNhap.TabIndex = 14;
            // 
            // fDangNhap
            // 
            this.AcceptButton = this.btnDangnhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(502, 360);
            this.Controls.Add(this.pnlDangNhap);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm Quản lý khách sạn ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fDangNhap_FormClosing_1);
            this.pnlDangNhap.ResumeLayout(false);
            this.pnlDangNhap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txtDangNhap;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMatkhau;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.PanelEx panelEx3;
        private System.Windows.Forms.CheckBox chkHienthi;
        private DevComponents.DotNetBar.LabelX lbDangNhap;
        private DevComponents.DotNetBar.LabelX lbEyes;
        private DevComponents.DotNetBar.ButtonX btnDangnhap;
        private DevComponents.DotNetBar.ButtonX btnThoat;
        private DevComponents.DotNetBar.PanelEx pnlDangNhap;
    }
}

