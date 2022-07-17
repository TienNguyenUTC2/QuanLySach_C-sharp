
namespace QuanLyCuaHangSach.FormChild
{
    partial class frmAccount
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgv_Account = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearchAcount = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Account)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.btnDelete);
            this.guna2Panel1.Controls.Add(this.btnAdd);
            this.guna2Panel1.Controls.Add(this.btnUpdate);
            this.guna2Panel1.Controls.Add(this.txtSearchAcount);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1059, 148);
            this.guna2Panel1.TabIndex = 0;
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
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.dgv_Account);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 148);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(1059, 403);
            this.guna2Panel2.TabIndex = 1;
            // 
            // dgv_Account
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_Account.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Account.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Account.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Account.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Account.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Account.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Account.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Account.ColumnHeadersHeight = 27;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Account.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Account.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Account.EnableHeadersVisualStyles = false;
            this.dgv_Account.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Account.Location = new System.Drawing.Point(0, 0);
            this.dgv_Account.Name = "dgv_Account";
            this.dgv_Account.RowHeadersVisible = false;
            this.dgv_Account.RowHeadersWidth = 51;
            this.dgv_Account.RowTemplate.Height = 24;
            this.dgv_Account.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Account.Size = new System.Drawing.Size(1059, 403);
            this.dgv_Account.TabIndex = 0;
            this.dgv_Account.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Account.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_Account.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_Account.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_Account.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_Account.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Account.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Account.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_Account.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Account.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_Account.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_Account.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_Account.ThemeStyle.HeaderStyle.Height = 27;
            this.dgv_Account.ThemeStyle.ReadOnly = false;
            this.dgv_Account.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Account.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Account.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_Account.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Account.ThemeStyle.RowsStyle.Height = 24;
            this.dgv_Account.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Account.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Account.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Account_CellClick);
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
            this.btnDelete.Location = new System.Drawing.Point(886, 72);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.PressedColor = System.Drawing.Color.Transparent;
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(161, 48);
            this.btnDelete.TabIndex = 26;
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
            this.btnAdd.Location = new System.Drawing.Point(493, 72);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.PressedColor = System.Drawing.Color.Transparent;
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(161, 48);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "THÊM";
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
            this.btnUpdate.Location = new System.Drawing.Point(690, 72);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.PressedColor = System.Drawing.Color.Transparent;
            this.btnUpdate.ShadowDecoration.Parent = this.btnUpdate;
            this.btnUpdate.Size = new System.Drawing.Size(161, 48);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "SỬA";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtSearchAcount
            // 
            this.txtSearchAcount.BorderRadius = 8;
            this.txtSearchAcount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchAcount.DefaultText = "";
            this.txtSearchAcount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchAcount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchAcount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchAcount.DisabledState.Parent = this.txtSearchAcount;
            this.txtSearchAcount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchAcount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchAcount.FocusedState.Parent = this.txtSearchAcount;
            this.txtSearchAcount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchAcount.ForeColor = System.Drawing.Color.Red;
            this.txtSearchAcount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchAcount.HoverState.Parent = this.txtSearchAcount;
            this.txtSearchAcount.IconLeft = global::QuanLyCuaHangSach.Properties.Resources.search_interface_symbol;
            this.txtSearchAcount.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtSearchAcount.IconLeftSize = new System.Drawing.Size(25, 25);
            this.txtSearchAcount.Location = new System.Drawing.Point(57, 72);
            this.txtSearchAcount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearchAcount.Name = "txtSearchAcount";
            this.txtSearchAcount.PasswordChar = '\0';
            this.txtSearchAcount.PlaceholderText = "";
            this.txtSearchAcount.SelectedText = "";
            this.txtSearchAcount.ShadowDecoration.Parent = this.txtSearchAcount;
            this.txtSearchAcount.Size = new System.Drawing.Size(403, 48);
            this.txtSearchAcount.TabIndex = 1;
            this.txtSearchAcount.TextChanged += new System.EventHandler(this.txtSearchAcount_TextChanged);
            // 
            // frmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 551);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "frmAccount";
            this.Text = "frmAccount";
            this.Load += new System.EventHandler(this.frmAccount_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Account)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchAcount;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_Account;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
    }
}