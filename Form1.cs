using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QuanLyLop
{
    public partial class QLLop_Form : Form
    {
        public QLLop_Form()
        {
            InitializeComponent();
        }

        Modify modify = new Modify();
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quản_lí_Lớp_và_Học_SinhDataSet.lOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter1.Fill(this.quản_lí_Lớp_và_Học_SinhDataSet.lOP);
            // TODO: This line of code loads data into the 'quản_lý_lớp_và_sinh_viênDataSet.Lop' table. You can move, or remove it, as needed.
            //this.lopTableAdapter.Fill(this.quản_lý_lớp_và_sinh_viênDataSet.Lop);          
            try
            {
                QuanLyLop_gridView.DataSource = modify.getLop();
            }
            catch (Exception ex)
            {
                MessageBox.Show("loi:" + ex.Message, "loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Sua_btn_Click(object sender, EventArgs e)
        {
            int maLop = Int32.Parse(MaLop_tb.Text);
            string tenGV = TenGV_tb.Text;
            string tenLop = TenLop_tb.Text;
            int soLHS = Int32.Parse(SLHS_tb.Text);


            Lop lop = new Lop(maLop, tenGV, tenLop, soLHS);

            if (modify.updateLop(lop))
            {
                QuanLyLop_gridView.DataSource = modify.getLop();
                MessageBox.Show("Da sua vao csdl ", "Thong Bao", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Khong sua vao duoc", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SLHS_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void QuanLyLop_gridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Them_btn_Click(object sender, EventArgs e)
        {
            int maLop  = Int32.Parse(MaLop_tb.Text);
            string tenGV =  TenGV_tb.Text;
            string tenLop = TenLop_tb.Text;
            int soLHS = Int32.Parse(SLHS_tb.Text);

            Lop lop = new Lop(maLop, tenGV, tenLop, soLHS);
            if (modify.insertLop(lop))
            {

                MessageBox.Show("Da them vao csdl ", "Thong Bao", MessageBoxButtons.OK);
                QuanLyLop_gridView.DataSource = modify.getLop();
            }
            else
            {
                MessageBox.Show("Loi" + "Khong them vao duoc", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void QLSV_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
            this.Close();
        }

        private void Xoa_btn_Click(object sender, EventArgs e)
        {
            int lop = Int32.Parse(QuanLyLop_gridView.SelectedRows[0].Cells[0].Value.ToString());

            if (modify.deleteLop(lop))
            {
                QuanLyLop_gridView.DataSource = modify.getLop();
                MessageBox.Show("Da xoa vao csdl", "Loi", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Khong the xoa vao csdl", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
