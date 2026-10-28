using System.Security.Cryptography.X509Certificates;
using Microsoft.Data.SqlClient; 

namespace bai4._1
{
    public partial class Form1 : Form
    {
        private string chuoiKetNoi =
    @"Server=LAPTOP-D2IAGK3D\SQLEXPRESS;Database=Bai41DB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
        public Form1()
        {
            InitializeComponent();
            this.AcceptButton = btnlogin;
            this.CancelButton = btnexit;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KiemTraKetNoi();
        }

        private void chkShowpassword_CheckedChanged(object sender, EventArgs e)
        {
            txtpassword.UseSystemPasswordChar = !chkShowpassword.Checked;
        }
        private void KiemTraKetNoi()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
                {
                    conn.Open();
                    MessageBox.Show("Ket noi database thanh cong!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi ket noi: " + ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string email = txtusername.Text.Trim();
            string matKhau = txtpassword.Text;

            if (email == "" || matKhau == "")
            {
                MessageBox.Show("Vui long nhap email va mat khau!");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
                {
                    conn.Open();

                    string sql = "INSERT INTO TaiKhoan (Email, MatKhau) VALUES (@Email, @MatKhau)";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@MatKhau", matKhau);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Dang ky thanh cong!");
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2601 || ex.Number == 2627)
                    MessageBox.Show("Email da duoc dang ky!");
                else
                    MessageBox.Show("Loi database: " + ex.Message);
            }
        }
        private void DangNhap()
        {
            string email = txtusername.Text.Trim();
            string matKhau = txtpassword.Text;

            if (email == "" || matKhau == "")
            {
                MessageBox.Show("Vui long nhap email va mat khau!");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
                {
                    conn.Open();

                    string sql = "SELECT COUNT(*) FROM TaiKhoan WHERE Email = @Email AND MatKhau = @MatKhau";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@MatKhau", matKhau);

                        int ketQua = (int)cmd.ExecuteScalar();

                        if (ketQua > 0)
                            MessageBox.Show("Dang nhap thanh cong!");
                        else
                            MessageBox.Show("Email hoac mat khau khong dung!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message);
            }
        }
    }
}
