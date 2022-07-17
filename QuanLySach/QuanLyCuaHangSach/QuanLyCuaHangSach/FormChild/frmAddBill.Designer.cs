
namespace QuanLyCuaHangSach.FormChild
{
    partial class frmAddBill
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
            this.txtSoTien = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbKhach = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoTienTra = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGiamGia = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.dataGridViewBill = new System.Windows.Forms.DataGridView();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.dataGridViewBook = new System.Windows.Forms.DataGridView();
            this.txtSoHoaDon = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenSach = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInBill = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnCreateBill = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBill)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBook)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSoTien
            // 
            this.txtSoTien.BorderRadius = 8;
            this.txtSoTien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoTien.DefaultText = "";
            this.txtSoTien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoTien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoTien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoTien.DisabledState.Parent = this.txtSoTien;
            this.txtSoTien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoTien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoTien.FocusedState.Parent = this.txtSoTien;
            this.txtSoTien.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSoTien.ForeColor = System.Drawing.Color.Black;
            this.txtSoTien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoTien.HoverState.Parent = this.txtSoTien;
            this.txtSoTien.Location = new System.Drawing.Point(739, 614);
            this.txtSoTien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.PasswordChar = '\0';
            this.txtSoTien.PlaceholderText = "";
            this.txtSoTien.ReadOnly = true;
            this.txtSoTien.SelectedText = "";
            this.txtSoTien.ShadowDecoration.Parent = this.txtSoTien;
            this.txtSoTien.Size = new System.Drawing.Size(368, 42);
            this.txtSoTien.TabIndex = 59;
            this.txtSoTien.TextChanged += new System.EventHandler(this.txtSoTien_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(734, 582);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 28);
            this.label6.TabIndex = 58;
            this.label6.Text = "Số tiền:";
            // 
            // cbbKhach
            // 
            this.cbbKhach.BackColor = System.Drawing.Color.Transparent;
            this.cbbKhach.BorderRadius = 8;
            this.cbbKhach.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbKhach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbKhach.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbKhach.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbKhach.FocusedState.Parent = this.cbbKhach;
            this.cbbKhach.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbKhach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbKhach.HoverState.Parent = this.cbbKhach;
            this.cbbKhach.ItemHeight = 30;
            this.cbbKhach.ItemsAppearance.Parent = this.cbbKhach;
            this.cbbKhach.Location = new System.Drawing.Point(40, 614);
            this.cbbKhach.Name = "cbbKhach";
            this.cbbKhach.ShadowDecoration.Parent = this.cbbKhach;
            this.cbbKhach.Size = new System.Drawing.Size(406, 36);
            this.cbbKhach.TabIndex = 57;
            this.cbbKhach.SelectedIndexChanged += new System.EventHandler(this.cbbKhach_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(35, 583);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 28);
            this.label5.TabIndex = 56;
            this.label5.Text = "Tên khách:";
            // 
            // txtSoTienTra
            // 
            this.txtSoTienTra.BorderRadius = 8;
            this.txtSoTienTra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoTienTra.DefaultText = "";
            this.txtSoTienTra.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoTienTra.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoTienTra.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoTienTra.DisabledState.Parent = this.txtSoTienTra;
            this.txtSoTienTra.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoTienTra.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoTienTra.FocusedState.Parent = this.txtSoTienTra;
            this.txtSoTienTra.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSoTienTra.ForeColor = System.Drawing.Color.Black;
            this.txtSoTienTra.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoTienTra.HoverState.Parent = this.txtSoTienTra;
            this.txtSoTienTra.Location = new System.Drawing.Point(739, 702);
            this.txtSoTienTra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSoTienTra.Name = "txtSoTienTra";
            this.txtSoTienTra.PasswordChar = '\0';
            this.txtSoTienTra.PlaceholderText = "";
            this.txtSoTienTra.ReadOnly = true;
            this.txtSoTienTra.SelectedText = "";
            this.txtSoTienTra.ShadowDecoration.Parent = this.txtSoTienTra;
            this.txtSoTienTra.Size = new System.Drawing.Size(368, 42);
            this.txtSoTienTra.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(734, 670);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 28);
            this.label4.TabIndex = 54;
            this.label4.Text = "Tiền phải trả:";
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.BorderRadius = 8;
            this.txtGiamGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiamGia.DefaultText = "";
            this.txtGiamGia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGiamGia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGiamGia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiamGia.DisabledState.Parent = this.txtGiamGia;
            this.txtGiamGia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiamGia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiamGia.FocusedState.Parent = this.txtGiamGia;
            this.txtGiamGia.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtGiamGia.ForeColor = System.Drawing.Color.Black;
            this.txtGiamGia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiamGia.HoverState.Parent = this.txtGiamGia;
            this.txtGiamGia.Location = new System.Drawing.Point(40, 702);
            this.txtGiamGia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.PasswordChar = '\0';
            this.txtGiamGia.PlaceholderText = "";
            this.txtGiamGia.SelectedText = "";
            this.txtGiamGia.ShadowDecoration.Parent = this.txtGiamGia;
            this.txtGiamGia.Size = new System.Drawing.Size(406, 42);
            this.txtGiamGia.TabIndex = 53;
            this.txtGiamGia.TextChanged += new System.EventHandler(this.txtGiamGia_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(34, 670);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 28);
            this.label3.TabIndex = 52;
            this.label3.Text = "Giảm giá:";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.dataGridViewBill);
            this.guna2Panel2.Location = new System.Drawing.Point(618, 142);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(573, 406);
            this.guna2Panel2.TabIndex = 49;
            // 
            // dataGridViewBill
            // 
            this.dataGridViewBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBill.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewBill.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewBill.Name = "dataGridViewBill";
            this.dataGridViewBill.RowHeadersWidth = 51;
            this.dataGridViewBill.RowTemplate.Height = 24;
            this.dataGridViewBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBill.Size = new System.Drawing.Size(573, 406);
            this.dataGridViewBill.TabIndex = 0;
            this.dataGridViewBill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBill_CellClick);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.dataGridViewBook);
            this.guna2Panel1.Location = new System.Drawing.Point(42, 142);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(403, 406);
            this.guna2Panel1.TabIndex = 48;
            // 
            // dataGridViewBook
            // 
            this.dataGridViewBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBook.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewBook.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewBook.Name = "dataGridViewBook";
            this.dataGridViewBook.RowHeadersWidth = 51;
            this.dataGridViewBook.RowTemplate.Height = 24;
            this.dataGridViewBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBook.Size = new System.Drawing.Size(403, 406);
            this.dataGridViewBook.TabIndex = 0;
            this.dataGridViewBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBook_CellClick);
            // 
            // txtSoHoaDon
            // 
            this.txtSoHoaDon.BorderRadius = 8;
            this.txtSoHoaDon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoHoaDon.DefaultText = "";
            this.txtSoHoaDon.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoHoaDon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoHoaDon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoHoaDon.DisabledState.Parent = this.txtSoHoaDon;
            this.txtSoHoaDon.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoHoaDon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoHoaDon.FocusedState.Parent = this.txtSoHoaDon;
            this.txtSoHoaDon.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSoHoaDon.ForeColor = System.Drawing.Color.Black;
            this.txtSoHoaDon.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoHoaDon.HoverState.Parent = this.txtSoHoaDon;
            this.txtSoHoaDon.Location = new System.Drawing.Point(881, 70);
            this.txtSoHoaDon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSoHoaDon.Name = "txtSoHoaDon";
            this.txtSoHoaDon.PasswordChar = '\0';
            this.txtSoHoaDon.PlaceholderText = "";
            this.txtSoHoaDon.SelectedText = "";
            this.txtSoHoaDon.ShadowDecoration.Parent = this.txtSoHoaDon;
            this.txtSoHoaDon.Size = new System.Drawing.Size(310, 42);
            this.txtSoHoaDon.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(876, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 28);
            this.label2.TabIndex = 45;
            this.label2.Text = "Số hóa đơn:";
            // 
            // txtTenSach
            // 
            this.txtTenSach.BorderRadius = 8;
            this.txtTenSach.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenSach.DefaultText = "";
            this.txtTenSach.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenSach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenSach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenSach.DisabledState.Parent = this.txtTenSach;
            this.txtTenSach.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenSach.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenSach.FocusedState.Parent = this.txtTenSach;
            this.txtTenSach.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTenSach.ForeColor = System.Drawing.Color.Black;
            this.txtTenSach.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenSach.HoverState.Parent = this.txtTenSach;
            this.txtTenSach.Location = new System.Drawing.Point(42, 70);
            this.txtTenSach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.PasswordChar = '\0';
            this.txtTenSach.PlaceholderText = "";
            this.txtTenSach.SelectedText = "";
            this.txtTenSach.ShadowDecoration.Parent = this.txtTenSach;
            this.txtTenSach.Size = new System.Drawing.Size(406, 42);
            this.txtTenSach.TabIndex = 44;
            this.txtTenSach.TextChanged += new System.EventHandler(this.txtTenSach_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(37, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 28);
            this.label1.TabIndex = 43;
            this.label1.Text = "Tên sách :";
            // 
            // btnInBill
            // 
            this.btnInBill.BorderRadius = 8;
            this.btnInBill.BorderThickness = 1;
            this.btnInBill.CheckedState.Parent = this.btnInBill;
            this.btnInBill.CustomImages.Parent = this.btnInBill;
            this.btnInBill.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInBill.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInBill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInBill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInBill.DisabledState.Parent = this.btnInBill;
            this.btnInBill.FillColor = System.Drawing.Color.Transparent;
            this.btnInBill.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInBill.ForeColor = System.Drawing.Color.Black;
            this.btnInBill.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnInBill.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnInBill.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnInBill.HoverState.Parent = this.btnInBill;
            this.btnInBill.Image = global::QuanLyCuaHangSach.Properties.Resources.bill__2_;
            this.btnInBill.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnInBill.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnInBill.ImageSize = new System.Drawing.Size(25, 25);
            this.btnInBill.Location = new System.Drawing.Point(481, 636);
            this.btnInBill.Name = "btnInBill";
            this.btnInBill.PressedColor = System.Drawing.Color.Transparent;
            this.btnInBill.ShadowDecoration.Parent = this.btnInBill;
            this.btnInBill.Size = new System.Drawing.Size(193, 78);
            this.btnInBill.TabIndex = 60;
            this.btnInBill.Text = "IN BILL";
            this.btnInBill.Click += new System.EventHandler(this.btnInBill_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BorderRadius = 8;
            this.btnAdd.BorderThickness = 1;
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.DisabledState.Parent = this.btnAdd;
            this.btnAdd.FillColor = System.Drawing.Color.Transparent;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAdd.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Image = global::QuanLyCuaHangSach.Properties.Resources.plus__1_;
            this.btnAdd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAdd.Location = new System.Drawing.Point(451, 308);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.PressedColor = System.Drawing.Color.Transparent;
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(161, 62);
            this.btnAdd.TabIndex = 51;
            this.btnAdd.Text = "THÊM";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BorderRadius = 8;
            this.btnDelete.BorderThickness = 1;
            this.btnDelete.CheckedState.Parent = this.btnDelete;
            this.btnDelete.CustomImages.Parent = this.btnDelete;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.DisabledState.Parent = this.btnDelete;
            this.btnDelete.FillColor = System.Drawing.Color.Transparent;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnDelete.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnDelete.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnDelete.HoverState.Parent = this.btnDelete;
            this.btnDelete.Image = global::QuanLyCuaHangSach.Properties.Resources.bin;
            this.btnDelete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDelete.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnDelete.Location = new System.Drawing.Point(454, 388);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.PressedColor = System.Drawing.Color.Transparent;
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(161, 62);
            this.btnDelete.TabIndex = 50;
            this.btnDelete.Text = "XÓA";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCreateBill
            // 
            this.btnCreateBill.BorderRadius = 8;
            this.btnCreateBill.BorderThickness = 1;
            this.btnCreateBill.CheckedState.Parent = this.btnCreateBill;
            this.btnCreateBill.CustomImages.Parent = this.btnCreateBill;
            this.btnCreateBill.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateBill.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateBill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCreateBill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCreateBill.DisabledState.Parent = this.btnCreateBill;
            this.btnCreateBill.FillColor = System.Drawing.Color.Transparent;
            this.btnCreateBill.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateBill.ForeColor = System.Drawing.Color.Black;
            this.btnCreateBill.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnCreateBill.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCreateBill.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnCreateBill.HoverState.Parent = this.btnCreateBill;
            this.btnCreateBill.Image = global::QuanLyCuaHangSach.Properties.Resources.plus__1_;
            this.btnCreateBill.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCreateBill.Location = new System.Drawing.Point(618, 70);
            this.btnCreateBill.Name = "btnCreateBill";
            this.btnCreateBill.PressedColor = System.Drawing.Color.Transparent;
            this.btnCreateBill.ShadowDecoration.Parent = this.btnCreateBill;
            this.btnCreateBill.Size = new System.Drawing.Size(242, 42);
            this.btnCreateBill.TabIndex = 47;
            this.btnCreateBill.Text = "TẠO HÓA ĐƠN";
            this.btnCreateBill.Click += new System.EventHandler(this.btnCreateBill_Click);
            // 
            // frmAddBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1284, 777);
            this.Controls.Add(this.btnInBill);
            this.Controls.Add(this.txtSoTien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbbKhach);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSoTienTra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGiamGia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.btnCreateBill);
            this.Controls.Add(this.txtSoHoaDon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenSach);
            this.Controls.Add(this.label1);
            this.Name = "frmAddBill";
            this.Text = "frmAddBill";
            this.Load += new System.EventHandler(this.frmAddBill_Load);
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBill)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnInBill;
        private Guna.UI2.WinForms.Guna2TextBox txtSoTien;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ComboBox cbbKhach;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtSoTienTra;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtGiamGia;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnCreateBill;
        private Guna.UI2.WinForms.Guna2TextBox txtSoHoaDon;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtTenSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewBill;
        private System.Windows.Forms.DataGridView dataGridViewBook;
    }
}