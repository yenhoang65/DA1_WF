namespace DA1_WF
{
    partial class frmSanPham
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
            this.dgSP = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTimKiemSP = new Guna.UI2.WinForms.Guna2Button();
            this.txtTkTenSP = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGiaBanSP = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSoLuongSP = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenSP = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaSanPham = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtXuatXuSP = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThemSP = new Guna.UI2.WinForms.Guna2Button();
            this.btnSuaSP = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoaSP = new Guna.UI2.WinForms.Guna2Button();
            this.btnLamMoiSP = new Guna.UI2.WinForms.Guna2Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgSP)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            this.SuspendLayout();
            // 
            // dgSP
            // 
            this.dgSP.BackgroundColor = System.Drawing.Color.White;
            this.dgSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSP.Location = new System.Drawing.Point(186, 42);
            this.dgSP.Margin = new System.Windows.Forms.Padding(4);
            this.dgSP.Name = "dgSP";
            this.dgSP.RowHeadersWidth = 51;
            this.dgSP.RowTemplate.Height = 24;
            this.dgSP.Size = new System.Drawing.Size(3645, 1021);
            this.dgSP.TabIndex = 21;
            this.dgSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSP_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTimKiemSP);
            this.groupBox2.Controls.Add(this.txtTkTenSP);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(2804, 1119);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1027, 685);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm Sản phẩm";
            // 
            // btnTimKiemSP
            // 
            this.btnTimKiemSP.AutoRoundedCorners = true;
            this.btnTimKiemSP.BorderRadius = 40;
            this.btnTimKiemSP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiemSP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiemSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimKiemSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimKiemSP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnTimKiemSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTimKiemSP.ForeColor = System.Drawing.Color.White;
            this.btnTimKiemSP.Location = new System.Drawing.Point(376, 381);
            this.btnTimKiemSP.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiemSP.Name = "btnTimKiemSP";
            this.btnTimKiemSP.Size = new System.Drawing.Size(552, 83);
            this.btnTimKiemSP.TabIndex = 14;
            this.btnTimKiemSP.Text = "Tìm kiếm";
            this.btnTimKiemSP.Click += new System.EventHandler(this.btnTimKiemSP_Click);
            // 
            // txtTkTenSP
            // 
            this.txtTkTenSP.AutoRoundedCorners = true;
            this.txtTkTenSP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtTkTenSP.BorderRadius = 40;
            this.txtTkTenSP.BorderThickness = 2;
            this.txtTkTenSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTkTenSP.DefaultText = "";
            this.txtTkTenSP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTkTenSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTkTenSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTkTenSP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTkTenSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTkTenSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTkTenSP.ForeColor = System.Drawing.Color.Black;
            this.txtTkTenSP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTkTenSP.Location = new System.Drawing.Point(376, 198);
            this.txtTkTenSP.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtTkTenSP.Name = "txtTkTenSP";
            this.txtTkTenSP.PasswordChar = '\0';
            this.txtTkTenSP.PlaceholderText = "";
            this.txtTkTenSP.SelectedText = "";
            this.txtTkTenSP.Size = new System.Drawing.Size(552, 83);
            this.txtTkTenSP.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(87, 221);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 32);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tên sản phẩm:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGiaBanSP);
            this.groupBox1.Controls.Add(this.txtSoLuongSP);
            this.groupBox1.Controls.Add(this.txtTenSP);
            this.groupBox1.Controls.Add(this.txtMaSanPham);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtXuatXuSP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(186, 1119);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(2431, 685);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sản phẩm";
            // 
            // txtGiaBanSP
            // 
            this.txtGiaBanSP.AutoRoundedCorners = true;
            this.txtGiaBanSP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtGiaBanSP.BorderRadius = 40;
            this.txtGiaBanSP.BorderThickness = 2;
            this.txtGiaBanSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiaBanSP.DefaultText = "";
            this.txtGiaBanSP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGiaBanSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGiaBanSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaBanSP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaBanSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiaBanSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGiaBanSP.ForeColor = System.Drawing.Color.Black;
            this.txtGiaBanSP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiaBanSP.Location = new System.Drawing.Point(1670, 381);
            this.txtGiaBanSP.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtGiaBanSP.Name = "txtGiaBanSP";
            this.txtGiaBanSP.PasswordChar = '\0';
            this.txtGiaBanSP.PlaceholderText = "";
            this.txtGiaBanSP.SelectedText = "";
            this.txtGiaBanSP.Size = new System.Drawing.Size(543, 83);
            this.txtGiaBanSP.TabIndex = 12;
            // 
            // txtSoLuongSP
            // 
            this.txtSoLuongSP.AutoRoundedCorners = true;
            this.txtSoLuongSP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtSoLuongSP.BorderRadius = 40;
            this.txtSoLuongSP.BorderThickness = 2;
            this.txtSoLuongSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoLuongSP.DefaultText = "";
            this.txtSoLuongSP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoLuongSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoLuongSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoLuongSP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoLuongSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoLuongSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSoLuongSP.ForeColor = System.Drawing.Color.Black;
            this.txtSoLuongSP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoLuongSP.Location = new System.Drawing.Point(461, 475);
            this.txtSoLuongSP.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtSoLuongSP.Name = "txtSoLuongSP";
            this.txtSoLuongSP.PasswordChar = '\0';
            this.txtSoLuongSP.PlaceholderText = "";
            this.txtSoLuongSP.SelectedText = "";
            this.txtSoLuongSP.Size = new System.Drawing.Size(543, 82);
            this.txtSoLuongSP.TabIndex = 11;
            // 
            // txtTenSP
            // 
            this.txtTenSP.AutoRoundedCorners = true;
            this.txtTenSP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtTenSP.BorderRadius = 43;
            this.txtTenSP.BorderThickness = 2;
            this.txtTenSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenSP.DefaultText = "";
            this.txtTenSP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenSP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenSP.ForeColor = System.Drawing.Color.Black;
            this.txtTenSP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenSP.Location = new System.Drawing.Point(461, 302);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.PasswordChar = '\0';
            this.txtTenSP.PlaceholderText = "";
            this.txtTenSP.SelectedText = "";
            this.txtTenSP.Size = new System.Drawing.Size(543, 88);
            this.txtTenSP.TabIndex = 10;
            // 
            // txtMaSanPham
            // 
            this.txtMaSanPham.AutoRoundedCorners = true;
            this.txtMaSanPham.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtMaSanPham.BorderRadius = 40;
            this.txtMaSanPham.BorderThickness = 2;
            this.txtMaSanPham.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaSanPham.DefaultText = "";
            this.txtMaSanPham.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaSanPham.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaSanPham.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaSanPham.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaSanPham.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaSanPham.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaSanPham.ForeColor = System.Drawing.Color.Black;
            this.txtMaSanPham.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaSanPham.Location = new System.Drawing.Point(461, 113);
            this.txtMaSanPham.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtMaSanPham.Name = "txtMaSanPham";
            this.txtMaSanPham.PasswordChar = '\0';
            this.txtMaSanPham.PlaceholderText = "";
            this.txtMaSanPham.SelectedText = "";
            this.txtMaSanPham.Size = new System.Drawing.Size(543, 83);
            this.txtMaSanPham.TabIndex = 9;
            this.txtMaSanPham.TextChanged += new System.EventHandler(this.txtMaSanPham_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(177, 503);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "Số lượng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1489, 406);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Giá bán:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(177, 333);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên sản phẩm:";
            // 
            // txtXuatXuSP
            // 
            this.txtXuatXuSP.AutoRoundedCorners = true;
            this.txtXuatXuSP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtXuatXuSP.BorderRadius = 40;
            this.txtXuatXuSP.BorderThickness = 2;
            this.txtXuatXuSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtXuatXuSP.DefaultText = "";
            this.txtXuatXuSP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtXuatXuSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtXuatXuSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtXuatXuSP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtXuatXuSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtXuatXuSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtXuatXuSP.ForeColor = System.Drawing.Color.Black;
            this.txtXuatXuSP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtXuatXuSP.Location = new System.Drawing.Point(1670, 198);
            this.txtXuatXuSP.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtXuatXuSP.Name = "txtXuatXuSP";
            this.txtXuatXuSP.PasswordChar = '\0';
            this.txtXuatXuSP.PlaceholderText = "";
            this.txtXuatXuSP.SelectedText = "";
            this.txtXuatXuSP.Size = new System.Drawing.Size(543, 83);
            this.txtXuatXuSP.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1489, 221);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Xuất xứ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 145);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sản phẩm:";
            // 
            // btnThemSP
            // 
            this.btnThemSP.AutoRoundedCorners = true;
            this.btnThemSP.BorderRadius = 38;
            this.btnThemSP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemSP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemSP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnThemSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThemSP.ForeColor = System.Drawing.Color.White;
            this.btnThemSP.Location = new System.Drawing.Point(368, 1879);
            this.btnThemSP.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(452, 78);
            this.btnThemSP.TabIndex = 15;
            this.btnThemSP.Text = "Thêm";
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // btnSuaSP
            // 
            this.btnSuaSP.AutoRoundedCorners = true;
            this.btnSuaSP.BorderRadius = 37;
            this.btnSuaSP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaSP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSuaSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSuaSP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSuaSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSuaSP.ForeColor = System.Drawing.Color.White;
            this.btnSuaSP.Location = new System.Drawing.Point(1252, 1879);
            this.btnSuaSP.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuaSP.Name = "btnSuaSP";
            this.btnSuaSP.Size = new System.Drawing.Size(452, 77);
            this.btnSuaSP.TabIndex = 22;
            this.btnSuaSP.Text = "Sửa";
            this.btnSuaSP.Click += new System.EventHandler(this.btnSuaSP_Click);
            // 
            // btnXoaSP
            // 
            this.btnXoaSP.AutoRoundedCorners = true;
            this.btnXoaSP.BorderRadius = 36;
            this.btnXoaSP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaSP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaSP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnXoaSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXoaSP.ForeColor = System.Drawing.Color.White;
            this.btnXoaSP.Location = new System.Drawing.Point(2247, 1884);
            this.btnXoaSP.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.Size = new System.Drawing.Size(452, 75);
            this.btnXoaSP.TabIndex = 23;
            this.btnXoaSP.Text = "Xóa";
            this.btnXoaSP.Click += new System.EventHandler(this.btnXoaSP_Click);
            // 
            // btnLamMoiSP
            // 
            this.btnLamMoiSP.AutoRoundedCorners = true;
            this.btnLamMoiSP.BorderRadius = 37;
            this.btnLamMoiSP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLamMoiSP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLamMoiSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLamMoiSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLamMoiSP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnLamMoiSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLamMoiSP.ForeColor = System.Drawing.Color.White;
            this.btnLamMoiSP.Location = new System.Drawing.Point(3280, 1879);
            this.btnLamMoiSP.Margin = new System.Windows.Forms.Padding(4);
            this.btnLamMoiSP.Name = "btnLamMoiSP";
            this.btnLamMoiSP.Size = new System.Drawing.Size(452, 77);
            this.btnLamMoiSP.TabIndex = 24;
            this.btnLamMoiSP.Text = "Làm mới";
            this.btnLamMoiSP.Click += new System.EventHandler(this.btnLamMoiSP_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // frmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(3844, 2124);
            this.Controls.Add(this.btnLamMoiSP);
            this.Controls.Add(this.btnXoaSP);
            this.Controls.Add(this.btnSuaSP);
            this.Controls.Add(this.btnThemSP);
            this.Controls.Add(this.dgSP);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSanPham";
            this.Load += new System.EventHandler(this.frmSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSP)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgSP;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2Button btnTimKiemSP;
        private Guna.UI2.WinForms.Guna2TextBox txtTkTenSP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtXuatXuSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtGiaBanSP;
        private Guna.UI2.WinForms.Guna2TextBox txtSoLuongSP;
        private Guna.UI2.WinForms.Guna2TextBox txtTenSP;
        private Guna.UI2.WinForms.Guna2TextBox txtMaSanPham;
        private Guna.UI2.WinForms.Guna2Button btnThemSP;
        private Guna.UI2.WinForms.Guna2Button btnSuaSP;
        private Guna.UI2.WinForms.Guna2Button btnXoaSP;
        private Guna.UI2.WinForms.Guna2Button btnLamMoiSP;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider4;
    }
}