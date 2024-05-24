namespace QuanLyLop
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView_QLHS = new System.Windows.Forms.DataGridView();
            this.maHSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenHSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoHSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hocSinhBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.quảnlíLớpvàHọcSinhDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quản_lí_Lớp_và_Học_SinhDataSet = new QuanLyLop.Quản_lí_Lớp_và_Học_SinhDataSet();
            this.hocSinhBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.Them_btn = new System.Windows.Forms.Button();
            this.Sua_btn = new System.Windows.Forms.Button();
            this.Xoa_btn = new System.Windows.Forms.Button();
            this.TenHS_lb = new System.Windows.Forms.Label();
            this.Ho_lb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MaHS_lb = new System.Windows.Forms.Label();
            this.NgaySinh_lb = new System.Windows.Forms.Label();
            this.MaLop_lb = new System.Windows.Forms.Label();
            this.Ten_txb = new System.Windows.Forms.TextBox();
            this.Ho_txb = new System.Windows.Forms.TextBox();
            this.GioiTinh_txb = new System.Windows.Forms.TextBox();
            this.MaHS_txb = new System.Windows.Forms.TextBox();
            this.MaLop_txb = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.hocSinhBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.quản_lý_lớp_và_sinh_viênDataSet = new QuanLyLop.Quản_lý_lớp_và_sinh_viênDataSet();
            this.hocSinhBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hocSinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hocSinhTableAdapter = new QuanLyLop.Quản_lý_lớp_và_sinh_viênDataSetTableAdapters.HocSinhTableAdapter();
            this.hocSinhTableAdapter1 = new QuanLyLop.Quản_lí_Lớp_và_Học_SinhDataSetTableAdapters.HocSinhTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_QLHS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocSinhBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quảnlíLớpvàHọcSinhDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quản_lí_Lớp_và_Học_SinhDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocSinhBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocSinhBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quản_lý_lớp_và_sinh_viênDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocSinhBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocSinhBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView_QLHS);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 285);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1024, 306);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Học Sinh:";
            // 
            // dataGridView_QLHS
            // 
            this.dataGridView_QLHS.AutoGenerateColumns = false;
            this.dataGridView_QLHS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_QLHS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_QLHS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHSDataGridViewTextBoxColumn,
            this.tenHSDataGridViewTextBoxColumn,
            this.hoHSDataGridViewTextBoxColumn,
            this.gioiTinhDataGridViewTextBoxColumn,
            this.ngaySinhDataGridViewTextBoxColumn,
            this.maLopDataGridViewTextBoxColumn});
            this.dataGridView_QLHS.DataSource = this.hocSinhBindingSource4;
            this.dataGridView_QLHS.Location = new System.Drawing.Point(6, 26);
            this.dataGridView_QLHS.Name = "dataGridView_QLHS";
            this.dataGridView_QLHS.RowHeadersWidth = 51;
            this.dataGridView_QLHS.RowTemplate.Height = 24;
            this.dataGridView_QLHS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_QLHS.Size = new System.Drawing.Size(884, 236);
            this.dataGridView_QLHS.TabIndex = 0;
            // 
            // maHSDataGridViewTextBoxColumn
            // 
            this.maHSDataGridViewTextBoxColumn.DataPropertyName = "MaHS";
            this.maHSDataGridViewTextBoxColumn.HeaderText = "MaHS";
            this.maHSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maHSDataGridViewTextBoxColumn.Name = "maHSDataGridViewTextBoxColumn";
            // 
            // tenHSDataGridViewTextBoxColumn
            // 
            this.tenHSDataGridViewTextBoxColumn.DataPropertyName = "TenHS";
            this.tenHSDataGridViewTextBoxColumn.HeaderText = "TenHS";
            this.tenHSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenHSDataGridViewTextBoxColumn.Name = "tenHSDataGridViewTextBoxColumn";
            // 
            // hoHSDataGridViewTextBoxColumn
            // 
            this.hoHSDataGridViewTextBoxColumn.DataPropertyName = "HoHS";
            this.hoHSDataGridViewTextBoxColumn.HeaderText = "HoHS";
            this.hoHSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hoHSDataGridViewTextBoxColumn.Name = "hoHSDataGridViewTextBoxColumn";
            // 
            // gioiTinhDataGridViewTextBoxColumn
            // 
            this.gioiTinhDataGridViewTextBoxColumn.DataPropertyName = "GioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.HeaderText = "GioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gioiTinhDataGridViewTextBoxColumn.Name = "gioiTinhDataGridViewTextBoxColumn";
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            this.ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.HeaderText = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            // 
            // maLopDataGridViewTextBoxColumn
            // 
            this.maLopDataGridViewTextBoxColumn.DataPropertyName = "MaLop";
            this.maLopDataGridViewTextBoxColumn.HeaderText = "MaLop";
            this.maLopDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maLopDataGridViewTextBoxColumn.Name = "maLopDataGridViewTextBoxColumn";
            // 
            // hocSinhBindingSource4
            // 
            this.hocSinhBindingSource4.DataMember = "HocSinh";
            this.hocSinhBindingSource4.DataSource = this.quảnlíLớpvàHọcSinhDataSetBindingSource;
            // 
            // quảnlíLớpvàHọcSinhDataSetBindingSource
            // 
            this.quảnlíLớpvàHọcSinhDataSetBindingSource.DataSource = this.quản_lí_Lớp_và_Học_SinhDataSet;
            this.quảnlíLớpvàHọcSinhDataSetBindingSource.Position = 0;
            // 
            // quản_lí_Lớp_và_Học_SinhDataSet
            // 
            this.quản_lí_Lớp_và_Học_SinhDataSet.DataSetName = "Quản_lí_Lớp_và_Học_SinhDataSet";
            this.quản_lí_Lớp_và_Học_SinhDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hocSinhBindingSource3
            // 
            this.hocSinhBindingSource3.DataMember = "HocSinh";
            this.hocSinhBindingSource3.DataSource = this.quản_lí_Lớp_và_Học_SinhDataSet;
            // 
            // Them_btn
            // 
            this.Them_btn.AutoSize = true;
            this.Them_btn.BackColor = System.Drawing.Color.LightGreen;
            this.Them_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Them_btn.Location = new System.Drawing.Point(354, 212);
            this.Them_btn.Name = "Them_btn";
            this.Them_btn.Size = new System.Drawing.Size(77, 35);
            this.Them_btn.TabIndex = 1;
            this.Them_btn.Text = "Thêm";
            this.Them_btn.UseVisualStyleBackColor = false;
            this.Them_btn.Click += new System.EventHandler(this.Them_btn_Click);
            // 
            // Sua_btn
            // 
            this.Sua_btn.AutoSize = true;
            this.Sua_btn.BackColor = System.Drawing.Color.SandyBrown;
            this.Sua_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sua_btn.Location = new System.Drawing.Point(659, 212);
            this.Sua_btn.Name = "Sua_btn";
            this.Sua_btn.Size = new System.Drawing.Size(77, 35);
            this.Sua_btn.TabIndex = 1;
            this.Sua_btn.Text = "Sửa";
            this.Sua_btn.UseVisualStyleBackColor = false;
            this.Sua_btn.Click += new System.EventHandler(this.Sua_btn_Click);
            // 
            // Xoa_btn
            // 
            this.Xoa_btn.AutoSize = true;
            this.Xoa_btn.BackColor = System.Drawing.Color.Tomato;
            this.Xoa_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xoa_btn.Location = new System.Drawing.Point(503, 212);
            this.Xoa_btn.Name = "Xoa_btn";
            this.Xoa_btn.Size = new System.Drawing.Size(77, 35);
            this.Xoa_btn.TabIndex = 1;
            this.Xoa_btn.Text = "Xóa";
            this.Xoa_btn.UseVisualStyleBackColor = false;
            this.Xoa_btn.Click += new System.EventHandler(this.Xoa_btn_Click);
            // 
            // TenHS_lb
            // 
            this.TenHS_lb.AutoSize = true;
            this.TenHS_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenHS_lb.Location = new System.Drawing.Point(25, 50);
            this.TenHS_lb.Name = "TenHS_lb";
            this.TenHS_lb.Size = new System.Drawing.Size(53, 25);
            this.TenHS_lb.TabIndex = 2;
            this.TenHS_lb.Text = "Tên:";
            // 
            // Ho_lb
            // 
            this.Ho_lb.AutoSize = true;
            this.Ho_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ho_lb.Location = new System.Drawing.Point(25, 92);
            this.Ho_lb.Name = "Ho_lb";
            this.Ho_lb.Size = new System.Drawing.Size(43, 25);
            this.Ho_lb.TabIndex = 2;
            this.Ho_lb.Text = "Họ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Giới tính:";
            // 
            // MaHS_lb
            // 
            this.MaHS_lb.AutoSize = true;
            this.MaHS_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaHS_lb.Location = new System.Drawing.Point(25, 179);
            this.MaHS_lb.Name = "MaHS_lb";
            this.MaHS_lb.Size = new System.Drawing.Size(124, 25);
            this.MaHS_lb.TabIndex = 2;
            this.MaHS_lb.Text = "Mã học sinh:";
            // 
            // NgaySinh_lb
            // 
            this.NgaySinh_lb.AutoSize = true;
            this.NgaySinh_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgaySinh_lb.Location = new System.Drawing.Point(349, 136);
            this.NgaySinh_lb.Name = "NgaySinh_lb";
            this.NgaySinh_lb.Size = new System.Drawing.Size(105, 25);
            this.NgaySinh_lb.TabIndex = 2;
            this.NgaySinh_lb.Text = "Ngày sinh:";
            // 
            // MaLop_lb
            // 
            this.MaLop_lb.AutoSize = true;
            this.MaLop_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaLop_lb.Location = new System.Drawing.Point(25, 220);
            this.MaLop_lb.Name = "MaLop_lb";
            this.MaLop_lb.Size = new System.Drawing.Size(77, 25);
            this.MaLop_lb.TabIndex = 2;
            this.MaLop_lb.Text = "Mã lớp:";
            // 
            // Ten_txb
            // 
            this.Ten_txb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ten_txb.Location = new System.Drawing.Point(104, 50);
            this.Ten_txb.Name = "Ten_txb";
            this.Ten_txb.Size = new System.Drawing.Size(151, 27);
            this.Ten_txb.TabIndex = 3;
            // 
            // Ho_txb
            // 
            this.Ho_txb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ho_txb.Location = new System.Drawing.Point(104, 90);
            this.Ho_txb.Name = "Ho_txb";
            this.Ho_txb.Size = new System.Drawing.Size(151, 27);
            this.Ho_txb.TabIndex = 3;
            this.Ho_txb.TextChanged += new System.EventHandler(this.Ho_txb_TextChanged);
            // 
            // GioiTinh_txb
            // 
            this.GioiTinh_txb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GioiTinh_txb.Location = new System.Drawing.Point(155, 134);
            this.GioiTinh_txb.Name = "GioiTinh_txb";
            this.GioiTinh_txb.Size = new System.Drawing.Size(100, 27);
            this.GioiTinh_txb.TabIndex = 3;
            // 
            // MaHS_txb
            // 
            this.MaHS_txb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaHS_txb.Location = new System.Drawing.Point(155, 177);
            this.MaHS_txb.Name = "MaHS_txb";
            this.MaHS_txb.Size = new System.Drawing.Size(100, 27);
            this.MaHS_txb.TabIndex = 3;
            this.MaHS_txb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MaHS_txb_KeyPress);
            // 
            // MaLop_txb
            // 
            this.MaLop_txb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaLop_txb.Location = new System.Drawing.Point(155, 218);
            this.MaLop_txb.Name = "MaLop_txb";
            this.MaLop_txb.Size = new System.Drawing.Size(100, 27);
            this.MaLop_txb.TabIndex = 3;
            this.MaLop_txb.TextChanged += new System.EventHandler(this.MaLop_txb_TextChanged);
            this.MaLop_txb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MaLop_txb_KeyPress);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(481, 139);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(255, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(354, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(382, 50);
            this.button1.TabIndex = 5;
            this.button1.Text = "Quản Lý Lớp";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // hocSinhBindingSource2
            // 
            this.hocSinhBindingSource2.DataMember = "HocSinh";
            this.hocSinhBindingSource2.DataSource = this.quản_lý_lớp_và_sinh_viênDataSet;
            // 
            // quản_lý_lớp_và_sinh_viênDataSet
            // 
            this.quản_lý_lớp_và_sinh_viênDataSet.DataSetName = "Quản_lý_lớp_và_sinh_viênDataSet";
            this.quản_lý_lớp_và_sinh_viênDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hocSinhBindingSource1
            // 
            this.hocSinhBindingSource1.DataMember = "HocSinh";
            this.hocSinhBindingSource1.DataSource = this.quản_lý_lớp_và_sinh_viênDataSet;
            // 
            // hocSinhBindingSource
            // 
            this.hocSinhBindingSource.DataMember = "HocSinh";
            this.hocSinhBindingSource.DataSource = this.quản_lý_lớp_và_sinh_viênDataSet;
            // 
            // hocSinhTableAdapter
            // 
            this.hocSinhTableAdapter.ClearBeforeFill = true;
            // 
            // hocSinhTableAdapter1
            // 
            this.hocSinhTableAdapter1.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 545);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.MaLop_txb);
            this.Controls.Add(this.MaHS_txb);
            this.Controls.Add(this.GioiTinh_txb);
            this.Controls.Add(this.Ho_txb);
            this.Controls.Add(this.Ten_txb);
            this.Controls.Add(this.NgaySinh_lb);
            this.Controls.Add(this.MaLop_lb);
            this.Controls.Add(this.MaHS_lb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Ho_lb);
            this.Controls.Add(this.TenHS_lb);
            this.Controls.Add(this.Xoa_btn);
            this.Controls.Add(this.Sua_btn);
            this.Controls.Add(this.Them_btn);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "QLHS_Form";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_QLHS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocSinhBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quảnlíLớpvàHọcSinhDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quản_lí_Lớp_và_Học_SinhDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocSinhBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocSinhBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quản_lý_lớp_và_sinh_viênDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocSinhBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocSinhBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView_QLHS;
        private System.Windows.Forms.Button Them_btn;
        private System.Windows.Forms.Button Sua_btn;
        private System.Windows.Forms.Button Xoa_btn;
        private System.Windows.Forms.Label TenHS_lb;
        private System.Windows.Forms.Label Ho_lb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label MaHS_lb;
        private System.Windows.Forms.Label NgaySinh_lb;
        private System.Windows.Forms.Label MaLop_lb;
        private System.Windows.Forms.TextBox Ten_txb;
        private System.Windows.Forms.TextBox Ho_txb;
        private System.Windows.Forms.TextBox GioiTinh_txb;
        private System.Windows.Forms.TextBox MaHS_txb;
        private System.Windows.Forms.TextBox MaLop_txb;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private Quản_lý_lớp_và_sinh_viênDataSet quản_lý_lớp_và_sinh_viênDataSet;
        private System.Windows.Forms.BindingSource hocSinhBindingSource;
        private Quản_lý_lớp_và_sinh_viênDataSetTableAdapters.HocSinhTableAdapter hocSinhTableAdapter;
        private System.Windows.Forms.BindingSource hocSinhBindingSource1;
        private System.Windows.Forms.BindingSource hocSinhBindingSource2;
        private Quản_lí_Lớp_và_Học_SinhDataSet quản_lí_Lớp_và_Học_SinhDataSet;
        private System.Windows.Forms.BindingSource hocSinhBindingSource3;
        private Quản_lí_Lớp_và_Học_SinhDataSetTableAdapters.HocSinhTableAdapter hocSinhTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoHSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLopDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource hocSinhBindingSource4;
        private System.Windows.Forms.BindingSource quảnlíLớpvàHọcSinhDataSetBindingSource;
    }
}