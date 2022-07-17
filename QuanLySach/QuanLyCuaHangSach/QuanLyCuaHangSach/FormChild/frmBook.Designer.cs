
namespace QuanLyCuaHangSach.FormChild
{
    partial class frmBook
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgv_Book = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnReportSach = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Book)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.dgv_Book);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 148);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(1236, 438);
            this.guna2Panel2.TabIndex = 2;
            // 
            // dgv_Book
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_Book.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Book.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Book.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Book.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Book.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Book.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Book.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Book.ColumnHeadersHeight = 27;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Book.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Book.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Book.EnableHeadersVisualStyles = false;
            this.dgv_Book.GridColor = System.Drawing.Color.DodgerBlue;
            this.dgv_Book.Location = new System.Drawing.Point(0, 0);
            this.dgv_Book.Name = "dgv_Book";
            this.dgv_Book.RowHeadersVisible = false;
            this.dgv_Book.RowHeadersWidth = 51;
            this.dgv_Book.RowTemplate.Height = 24;
            this.dgv_Book.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Book.Size = new System.Drawing.Size(1236, 438);
            this.dgv_Book.TabIndex = 0;
            this.dgv_Book.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Book.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Book.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Blue;
            this.dgv_Book.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_Book.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_Book.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Book.ThemeStyle.GridColor = System.Drawing.Color.DodgerBlue;
            this.dgv_Book.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Red;
            this.dgv_Book.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Book.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_Book.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_Book.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_Book.ThemeStyle.HeaderStyle.Height = 27;
            this.dgv_Book.ThemeStyle.ReadOnly = false;
            this.dgv_Book.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Book.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Book.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_Book.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Book.ThemeStyle.RowsStyle.Height = 24;
            this.dgv_Book.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Book.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Book.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Book_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(52, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm:";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.btnReportSach);
            this.guna2Panel1.Controls.Add(this.btnDelete);
            this.guna2Panel1.Controls.Add(this.btnAdd);
            this.guna2Panel1.Controls.Add(this.btnUpdate);
            this.guna2Panel1.Controls.Add(this.txtSearch);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1236, 148);
            this.guna2Panel1.TabIndex = 1;
            // 
            // btnReportSach
            // 
            this.btnReportSach.BorderRadius = 8;
            this.btnReportSach.BorderThickness = 1;
            this.btnReportSach.CheckedState.Parent = this.btnReportSach;
            this.btnReportSach.CustomImages.Parent = this.btnReportSach;
            this.btnReportSach.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReportSach.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReportSach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReportSach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReportSach.DisabledState.Parent = this.btnReportSach;
            this.btnReportSach.FillColor = System.Drawing.Color.Transparent;
            this.btnReportSach.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportSach.ForeColor = System.Drawing.Color.Black;
            this.btnReportSach.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnReportSach.HoverState.FillColor = System.Drawing.Color.MediumTurquoise;
            this.btnReportSach.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnReportSach.HoverState.Parent = this.btnReportSach;
            this.btnReportSach.Image = global::QuanLyCuaHangSach.Properties.Resources.report;
            this.btnReportSach.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnReportSach.ImageOffset = new System.Drawing.Point(3, 0);
            this.btnReportSach.Location = new System.Drawing.Point(1034, 72);
            this.btnReportSach.Name = "btnReportSach";
            this.btnReportSach.PressedColor = System.Drawing.Color.Transparent;
            this.btnReportSach.ShadowDecoration.Parent = this.btnReportSach;
            this.btnReportSach.Size = new System.Drawing.Size(169, 48);
            this.btnReportSach.TabIndex = 30;
            this.btnReportSach.Text = "BÁO CÁO";
            this.btnReportSach.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnReportSach.Click += new System.EventHandler(this.btnReportSach_Click);
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
            this.btnDelete.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnDelete.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnDelete.HoverState.Parent = this.btnDelete;
            this.btnDelete.Image = global::QuanLyCuaHangSach.Properties.Resources.bin;
            this.btnDelete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDelete.ImageOffset = new System.Drawing.Point(3, 0);
            this.btnDelete.Location = new System.Drawing.Point(589, 72);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.PressedColor = System.Drawing.Color.Transparent;
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(161, 48);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Text = "XÓA";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.btnAdd.Location = new System.Drawing.Point(791, 72);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.PressedColor = System.Drawing.Color.Transparent;
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(220, 48);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "NHẬP SÁCH";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BorderRadius = 8;
            this.btnUpdate.BorderThickness = 1;
            this.btnUpdate.CheckedState.Parent = this.btnUpdate;
            this.btnUpdate.CustomImages.Parent = this.btnUpdate;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.DisabledState.Parent = this.btnUpdate;
            this.btnUpdate.FillColor = System.Drawing.Color.Transparent;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnUpdate.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnUpdate.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.HoverState.Parent = this.btnUpdate;
            this.btnUpdate.Image = global::QuanLyCuaHangSach.Properties.Resources.update;
            this.btnUpdate.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUpdate.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnUpdate.Location = new System.Drawing.Point(382, 72);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.PressedColor = System.Drawing.Color.Transparent;
            this.btnUpdate.ShadowDecoration.Parent = this.btnUpdate;
            this.btnUpdate.Size = new System.Drawing.Size(161, 48);
            this.btnUpdate.TabIndex = 27;
            this.btnUpdate.Text = "SỬA";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderRadius = 8;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.Parent = this.txtSearch;
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.FocusedState.Parent = this.txtSearch;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Red;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.HoverState.Parent = this.txtSearch;
            this.txtSearch.IconLeft = global::QuanLyCuaHangSach.Properties.Resources.search_interface_symbol;
            this.txtSearch.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtSearch.IconLeftSize = new System.Drawing.Size(25, 25);
            this.txtSearch.Location = new System.Drawing.Point(57, 72);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(291, 48);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // frmBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 586);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "frmBook";
            this.Text = "frmBook";
            this.Load += new System.EventHandler(this.frmBook_Load);
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Book)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_Book;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnReportSach;
    }
}