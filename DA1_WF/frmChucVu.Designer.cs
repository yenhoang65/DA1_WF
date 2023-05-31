namespace DA1_WF
{
    partial class frmChucVu
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgChucVu = new System.Windows.Forms.DataGridView();
            this.txtMoTaChucVu = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenChucVu = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaChucVu = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoatChucvu = new Guna.UI2.WinForms.Guna2Button();
            this.btnLamMoiChucvu = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoaChucVu = new Guna.UI2.WinForms.Guna2Button();
            this.btnSuaChucvu = new Guna.UI2.WinForms.Guna2Button();
            this.btnThemChucvu = new Guna.UI2.WinForms.Guna2Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgChucVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgChucVu
            // 
            this.dgChucVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgChucVu.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgChucVu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgChucVu.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgChucVu.Location = new System.Drawing.Point(30, 12);
            this.dgChucVu.Margin = new System.Windows.Forms.Padding(4);
            this.dgChucVu.Name = "dgChucVu";
            this.dgChucVu.RowHeadersWidth = 51;
            this.dgChucVu.RowTemplate.Height = 24;
            this.dgChucVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgChucVu.Size = new System.Drawing.Size(2133, 621);
            this.dgChucVu.TabIndex = 38;
            this.dgChucVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgChucVu_CellClick);
            // 
            // txtMoTaChucVu
            // 
            this.txtMoTaChucVu.AutoRoundedCorners = true;
            this.txtMoTaChucVu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtMoTaChucVu.BorderRadius = 34;
            this.txtMoTaChucVu.BorderThickness = 2;
            this.txtMoTaChucVu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMoTaChucVu.DefaultText = "";
            this.txtMoTaChucVu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMoTaChucVu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMoTaChucVu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMoTaChucVu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMoTaChucVu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMoTaChucVu.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.txtMoTaChucVu.ForeColor = System.Drawing.Color.Black;
            this.txtMoTaChucVu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMoTaChucVu.Location = new System.Drawing.Point(598, 864);
            this.txtMoTaChucVu.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtMoTaChucVu.Name = "txtMoTaChucVu";
            this.txtMoTaChucVu.PasswordChar = '\0';
            this.txtMoTaChucVu.PlaceholderText = "";
            this.txtMoTaChucVu.SelectedText = "";
            this.txtMoTaChucVu.Size = new System.Drawing.Size(1052, 71);
            this.txtMoTaChucVu.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(455, 883);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 39);
            this.label5.TabIndex = 29;
            this.label5.Text = "Mô tả:";
            // 
            // txtTenChucVu
            // 
            this.txtTenChucVu.AutoRoundedCorners = true;
            this.txtTenChucVu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtTenChucVu.BorderRadius = 33;
            this.txtTenChucVu.BorderThickness = 2;
            this.txtTenChucVu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenChucVu.DefaultText = "";
            this.txtTenChucVu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenChucVu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenChucVu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenChucVu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenChucVu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenChucVu.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.txtTenChucVu.ForeColor = System.Drawing.Color.Black;
            this.txtTenChucVu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenChucVu.Location = new System.Drawing.Point(1456, 699);
            this.txtTenChucVu.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtTenChucVu.Name = "txtTenChucVu";
            this.txtTenChucVu.PasswordChar = '\0';
            this.txtTenChucVu.PlaceholderText = "";
            this.txtTenChucVu.SelectedText = "";
            this.txtTenChucVu.Size = new System.Drawing.Size(437, 69);
            this.txtTenChucVu.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1219, 713);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 39);
            this.label2.TabIndex = 23;
            this.label2.Text = "Tên chức vụ:";
            // 
            // txtMaChucVu
            // 
            this.txtMaChucVu.AutoRoundedCorners = true;
            this.txtMaChucVu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtMaChucVu.BorderRadius = 33;
            this.txtMaChucVu.BorderThickness = 2;
            this.txtMaChucVu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaChucVu.DefaultText = "";
            this.txtMaChucVu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaChucVu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaChucVu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaChucVu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaChucVu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaChucVu.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.txtMaChucVu.ForeColor = System.Drawing.Color.Black;
            this.txtMaChucVu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaChucVu.Location = new System.Drawing.Point(448, 699);
            this.txtMaChucVu.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtMaChucVu.Name = "txtMaChucVu";
            this.txtMaChucVu.PasswordChar = '\0';
            this.txtMaChucVu.PlaceholderText = "";
            this.txtMaChucVu.SelectedText = "";
            this.txtMaChucVu.Size = new System.Drawing.Size(434, 69);
            this.txtMaChucVu.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 713);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 39);
            this.label1.TabIndex = 21;
            this.label1.Text = "Mã chức vụ:";
            // 
            // btnThoatChucvu
            // 
            this.btnThoatChucvu.AutoRoundedCorners = true;
            this.btnThoatChucvu.BorderRadius = 32;
            this.btnThoatChucvu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThoatChucvu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThoatChucvu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThoatChucvu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThoatChucvu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnThoatChucvu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThoatChucvu.ForeColor = System.Drawing.Color.White;
            this.btnThoatChucvu.Location = new System.Drawing.Point(1784, 1010);
            this.btnThoatChucvu.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoatChucvu.Name = "btnThoatChucvu";
            this.btnThoatChucvu.Size = new System.Drawing.Size(227, 67);
            this.btnThoatChucvu.TabIndex = 43;
            this.btnThoatChucvu.Text = "Thoát";
            this.btnThoatChucvu.Click += new System.EventHandler(this.btnThoatChucvu_Click);
            // 
            // btnLamMoiChucvu
            // 
            this.btnLamMoiChucvu.AutoRoundedCorners = true;
            this.btnLamMoiChucvu.BorderRadius = 32;
            this.btnLamMoiChucvu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLamMoiChucvu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLamMoiChucvu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLamMoiChucvu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLamMoiChucvu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnLamMoiChucvu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLamMoiChucvu.ForeColor = System.Drawing.Color.White;
            this.btnLamMoiChucvu.Location = new System.Drawing.Point(1381, 1010);
            this.btnLamMoiChucvu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLamMoiChucvu.Name = "btnLamMoiChucvu";
            this.btnLamMoiChucvu.Size = new System.Drawing.Size(227, 67);
            this.btnLamMoiChucvu.TabIndex = 42;
            this.btnLamMoiChucvu.Text = "Làm mới";
            this.btnLamMoiChucvu.Click += new System.EventHandler(this.btnLamMoiHDB_Click);
            // 
            // btnXoaChucVu
            // 
            this.btnXoaChucVu.AutoRoundedCorners = true;
            this.btnXoaChucVu.BorderRadius = 32;
            this.btnXoaChucVu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaChucVu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaChucVu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaChucVu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaChucVu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnXoaChucVu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXoaChucVu.ForeColor = System.Drawing.Color.White;
            this.btnXoaChucVu.Location = new System.Drawing.Point(965, 1010);
            this.btnXoaChucVu.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaChucVu.Name = "btnXoaChucVu";
            this.btnXoaChucVu.Size = new System.Drawing.Size(227, 67);
            this.btnXoaChucVu.TabIndex = 41;
            this.btnXoaChucVu.Text = "Xóa";
            this.btnXoaChucVu.Click += new System.EventHandler(this.btnXoaChucVu_Click);
            // 
            // btnSuaChucvu
            // 
            this.btnSuaChucvu.AutoRoundedCorners = true;
            this.btnSuaChucvu.BorderRadius = 32;
            this.btnSuaChucvu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaChucvu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaChucvu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSuaChucvu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSuaChucvu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSuaChucvu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSuaChucvu.ForeColor = System.Drawing.Color.White;
            this.btnSuaChucvu.Location = new System.Drawing.Point(541, 1010);
            this.btnSuaChucvu.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuaChucvu.Name = "btnSuaChucvu";
            this.btnSuaChucvu.Size = new System.Drawing.Size(227, 67);
            this.btnSuaChucvu.TabIndex = 40;
            this.btnSuaChucvu.Text = "Sửa";
            this.btnSuaChucvu.Click += new System.EventHandler(this.btnSuaChucvu_Click);
            // 
            // btnThemChucvu
            // 
            this.btnThemChucvu.AutoRoundedCorners = true;
            this.btnThemChucvu.BorderRadius = 32;
            this.btnThemChucvu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemChucvu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemChucvu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemChucvu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemChucvu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnThemChucvu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThemChucvu.ForeColor = System.Drawing.Color.White;
            this.btnThemChucvu.Location = new System.Drawing.Point(175, 1010);
            this.btnThemChucvu.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemChucvu.Name = "btnThemChucvu";
            this.btnThemChucvu.Size = new System.Drawing.Size(227, 67);
            this.btnThemChucvu.TabIndex = 39;
            this.btnThemChucvu.Text = "Thêm";
            this.btnThemChucvu.Click += new System.EventHandler(this.btnThemChucvu_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // frmChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(2164, 1174);
            this.Controls.Add(this.btnThoatChucvu);
            this.Controls.Add(this.btnLamMoiChucvu);
            this.Controls.Add(this.btnXoaChucVu);
            this.Controls.Add(this.btnSuaChucvu);
            this.Controls.Add(this.btnThemChucvu);
            this.Controls.Add(this.dgChucVu);
            this.Controls.Add(this.txtMoTaChucVu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTenChucVu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaChucVu);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmChucVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChucVu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmChucVu_FormClosed);
            this.Load += new System.EventHandler(this.frmChucVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgChucVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgChucVu;
        private Guna.UI2.WinForms.Guna2TextBox txtMoTaChucVu;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtTenChucVu;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtMaChucVu;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnThoatChucvu;
        private Guna.UI2.WinForms.Guna2Button btnLamMoiChucvu;
        private Guna.UI2.WinForms.Guna2Button btnXoaChucVu;
        private Guna.UI2.WinForms.Guna2Button btnSuaChucvu;
        private Guna.UI2.WinForms.Guna2Button btnThemChucvu;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}