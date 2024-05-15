using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyLop
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Modify modify = new Modify();
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MaLop_txb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ho_txb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ho_lb_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quản_lí_Lớp_và_Học_SinhDataSet.HocSinh' table. You can move, or remove it, as needed.
            this.hocSinhTableAdapter1.Fill(this.quản_lí_Lớp_và_Học_SinhDataSet.HocSinh);
            // TODO: This line of code loads data into the 'quản_lý_lớp_và_sinh_viênDataSet.HocSinh' table. You can move, or remove it, as needed.
            //this.hocSinhTableAdapter.Fill(this.quản_lý_lớp_và_sinh_viênDataSet.HocSinh);
            Modify modyfy = new Modify();
            try
            {
                dataGridView_QLHS.DataSource = modyfy.getAllHocSinh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("loi:" + ex.Message, "loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            QLLop_Form form1 = new QLLop_Form();
            form1.ShowDialog();
            this.Close();
        }

        private void Them_btn_Click(object sender, EventArgs e)
        {
            int maLop = Int32.Parse(MaLop_txb.Text);
            string tenHS = Ten_txb.Text;
            string hoHS = Ho_txb.Text;
            int maHS = Int32.Parse(MaHS_txb.Text);
            string gioiTinh = GioiTinh_txb.Text;
            DateTime ngaySinh = dateTimePicker1.Value;


            HocSinh hocsinh = new HocSinh(tenHS, hoHS, gioiTinh, maHS, maLop, ngaySinh);
            if (modify.insertHS(hocsinh))
            {

                MessageBox.Show("Da them vao csdl ", "Thong Bao", MessageBoxButtons.OK);
                dataGridView_QLHS.DataSource = modify.getAllHocSinh();
            }
            else
            {
                MessageBox.Show("Loi" + "Khong them vao duoc", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void Sua_btn_Click(object sender, EventArgs e)
        {
            int maLop = Int32.Parse(MaLop_txb.Text);
            string tenHS = Ten_txb.Text;
            string hoHS = Ho_txb.Text;
            int maHS = Int32.Parse(MaHS_txb.Text);
            string gioiTinh = GioiTinh_txb.Text;
            DateTime ngaySinh = dateTimePicker1.Value;

            HocSinh hocsinh = new HocSinh(tenHS, hoHS, gioiTinh, maHS, maLop, ngaySinh);

            if (modify.updateHS(hocsinh))
            {
                dataGridView_QLHS.DataSource = modify.getAllHocSinh();
                MessageBox.Show("Da sua vao csdl ", "Thong Bao", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Khong sua vao duoc", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Xoa_btn_Click(object sender, EventArgs e)
        {
            int hocsinh = Int32.Parse(dataGridView_QLHS.SelectedRows[0].Cells[0].Value.ToString());

            if (modify.deleteHS(hocsinh))
            {
                dataGridView_QLHS.DataSource = modify.getAllHocSinh();
                MessageBox.Show("Da xoa vao csdl", "Loi", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Khong the xoa vao csdl", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
