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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView_QLHS = new System.Windows.Forms.DataGridView();
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_QLHS)).BeginInit();
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
            this.dataGridView_QLHS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_QLHS.Location = new System.Drawing.Point(7, 27);
            this.dataGridView_QLHS.Name = "dataGridView_QLHS";
            this.dataGridView_QLHS.RowHeadersWidth = 51;
            this.dataGridView_QLHS.RowTemplate.Height = 24;
            this.dataGridView_QLHS.Size = new System.Drawing.Size(889, 236);
            this.dataGridView_QLHS.TabIndex = 0;
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
            this.Ho_lb.Click += new System.EventHandler(this.Ho_lb_Click);
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
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            // 
            // MaLop_txb
            // 
            this.MaLop_txb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaLop_txb.Location = new System.Drawing.Point(155, 218);
            this.MaLop_txb.Name = "MaLop_txb";
            this.MaLop_txb.Size = new System.Drawing.Size(100, 27);
            this.MaLop_txb.TabIndex = 3;
            this.MaLop_txb.TextChanged += new System.EventHandler(this.MaLop_txb_TextChanged);
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
            this.button1.Text = "Thông tin học sinh ";
            this.button1.UseVisualStyleBackColor = false;
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
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_QLHS)).EndInit();
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
    }
}