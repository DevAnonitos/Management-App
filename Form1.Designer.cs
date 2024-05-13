namespace QuanLyLop
{
    partial class QLLop_Form
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
            this.MaLop_tb = new System.Windows.Forms.TextBox();
            this.TenLop_tb = new System.Windows.Forms.TextBox();
            this.TenGV_tb = new System.Windows.Forms.TextBox();
            this.SLHS_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ten_lb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Them_btn = new System.Windows.Forms.Button();
            this.Xoa_btn = new System.Windows.Forms.Button();
            this.Sua_btn = new System.Windows.Forms.Button();
            this.QLSV_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.QuanLyLop_gridView = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyLop_gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MaLop_tb
            // 
            this.MaLop_tb.Location = new System.Drawing.Point(192, 32);
            this.MaLop_tb.Name = "MaLop_tb";
            this.MaLop_tb.Size = new System.Drawing.Size(194, 22);
            this.MaLop_tb.TabIndex = 1;
            // 
            // TenLop_tb
            // 
            this.TenLop_tb.Location = new System.Drawing.Point(192, 79);
            this.TenLop_tb.Name = "TenLop_tb";
            this.TenLop_tb.Size = new System.Drawing.Size(194, 22);
            this.TenLop_tb.TabIndex = 2;
            // 
            // TenGV_tb
            // 
            this.TenGV_tb.Location = new System.Drawing.Point(192, 125);
            this.TenGV_tb.Name = "TenGV_tb";
            this.TenGV_tb.Size = new System.Drawing.Size(194, 22);
            this.TenGV_tb.TabIndex = 2;
            // 
            // SLHS_tb
            // 
            this.SLHS_tb.Location = new System.Drawing.Point(240, 162);
            this.SLHS_tb.Name = "SLHS_tb";
            this.SLHS_tb.Size = new System.Drawing.Size(41, 22);
            this.SLHS_tb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // ten_lb
            // 
            this.ten_lb.AutoSize = true;
            this.ten_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ten_lb.Location = new System.Drawing.Point(28, 38);
            this.ten_lb.Name = "ten_lb";
            this.ten_lb.Size = new System.Drawing.Size(91, 25);
            this.ten_lb.TabIndex = 4;
            this.ten_lb.Text = "Mã Lớp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên Lớp:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên Giáo Viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số Lượng Học Sinh:";
            // 
            // Them_btn
            // 
            this.Them_btn.AutoSize = true;
            this.Them_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Them_btn.Location = new System.Drawing.Point(451, 140);
            this.Them_btn.Name = "Them_btn";
            this.Them_btn.Size = new System.Drawing.Size(119, 44);
            this.Them_btn.TabIndex = 5;
            this.Them_btn.Text = "Thêm";
            this.Them_btn.UseVisualStyleBackColor = true;
            // 
            // Xoa_btn
            // 
            this.Xoa_btn.AutoSize = true;
            this.Xoa_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xoa_btn.Location = new System.Drawing.Point(757, 140);
            this.Xoa_btn.Name = "Xoa_btn";
            this.Xoa_btn.Size = new System.Drawing.Size(119, 44);
            this.Xoa_btn.TabIndex = 5;
            this.Xoa_btn.Text = "Xóa";
            this.Xoa_btn.UseVisualStyleBackColor = true;
            // 
            // Sua_btn
            // 
            this.Sua_btn.AutoSize = true;
            this.Sua_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sua_btn.Location = new System.Drawing.Point(610, 140);
            this.Sua_btn.Name = "Sua_btn";
            this.Sua_btn.Size = new System.Drawing.Size(119, 44);
            this.Sua_btn.TabIndex = 5;
            this.Sua_btn.Text = "Sửa";
            this.Sua_btn.UseVisualStyleBackColor = true;
            this.Sua_btn.Click += new System.EventHandler(this.Sua_btn_Click);
            // 
            // QLSV_btn
            // 
            this.QLSV_btn.AutoSize = true;
            this.QLSV_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QLSV_btn.Location = new System.Drawing.Point(814, 32);
            this.QLSV_btn.Name = "QLSV_btn";
            this.QLSV_btn.Size = new System.Drawing.Size(184, 44);
            this.QLSV_btn.TabIndex = 5;
            this.QLSV_btn.Text = "QL Học Sinh";
            this.QLSV_btn.UseVisualStyleBackColor = true;
            this.QLSV_btn.Click += new System.EventHandler(this.Sua_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.QuanLyLop_gridView);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 269);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1042, 360);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Lớp:";
            // 
            // QuanLyLop_gridView
            // 
            this.QuanLyLop_gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QuanLyLop_gridView.Location = new System.Drawing.Point(-1, 40);
            this.QuanLyLop_gridView.Name = "QuanLyLop_gridView";
            this.QuanLyLop_gridView.RowHeadersWidth = 51;
            this.QuanLyLop_gridView.RowTemplate.Height = 24;
            this.QuanLyLop_gridView.Size = new System.Drawing.Size(1029, 314);
            this.QuanLyLop_gridView.TabIndex = 0;
            // 
            // QLLop_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1053, 641);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.QLSV_btn);
            this.Controls.Add(this.Sua_btn);
            this.Controls.Add(this.Xoa_btn);
            this.Controls.Add(this.Them_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ten_lb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SLHS_tb);
            this.Controls.Add(this.TenGV_tb);
            this.Controls.Add(this.TenLop_tb);
            this.Controls.Add(this.MaLop_tb);
            this.Name = "QLLop_Form";
            this.Text = "QL_Lop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyLop_gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox MaLop_tb;
        private System.Windows.Forms.TextBox TenLop_tb;
        private System.Windows.Forms.TextBox TenGV_tb;
        private System.Windows.Forms.TextBox SLHS_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ten_lb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Them_btn;
        private System.Windows.Forms.Button Xoa_btn;
        private System.Windows.Forms.Button Sua_btn;
        private System.Windows.Forms.Button QLSV_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView QuanLyLop_gridView;
    }
}

