namespace bai4_2;
using Microsoft.Data.SqlClient;

public partial class Form1 : Form
{
    private string chuoiKetNoi =
@"Server=LAPTOP-D2IAGK3D\SQLEXPRESS;Database=DangKyKhoaHoc;Integrated Security=True;TrustServerCertificate=True;";
    public Form1()
    {
        InitializeComponent();
        btndangki.Click += btndangky_Click;
        mtxtPhone.Mask = "(000) 000-0000";
        var khoahoc = new[]
        {
            new { Ma = "KH01", Ten = "Lap trinh C#" },
            new { Ma = "KH02", Ten = "Lap trinh Java" },
            new { Ma = "KH03", Ten = "Co so du lieu" }
        };

        cbokhoahoc.DataSource = khoahoc;
        cbokhoahoc.DisplayMember = "Ten";
        cbokhoahoc.ValueMember = "Ma";
        dtpBirthDate.Format = DateTimePickerFormat.Custom;
        dtpBirthDate.CustomFormat = "dd/MM/yyyy";

    }
    private void btndangky_Click(object sender, EventArgs e)
    {
        if (!mtxtPhone.MaskFull)
        {
            MessageBox.Show("Vui long nhap day du so dien thoai!");
            mtxtPhone.Focus();
            return;
        }

        DateTime ngaySinh = dtpBirthDate.Value;
        string soDienThoai = mtxtPhone.Text;
        string maKhoaHoc = cbokhoahoc.SelectedValue.ToString();

        string sql = @"INSERT INTO dbo.DangKyKhoaHoc
               (NgaySinh, SoDienThoai, MaKhoaHoc)
               VALUES (@NgaySinh, @SoDienThoai, @MaKhoaHoc)";

        try
        {
            using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh.Date);
                    cmd.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
                    cmd.Parameters.AddWithValue("@MaKhoaHoc", maKhoaHoc);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Dang ky va luu du lieu thanh cong!");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Loi: " + ex.Message);
        }
    }


    private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
    {

    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void btndangki_Click(object sender, EventArgs e)
    {

    }
}
