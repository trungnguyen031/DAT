using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-TA85D1G\SQLEXPRESS;Initial Catalog=QLPhongMay;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void hienthi()
        {
            command = connection.CreateCommand();
            command.CommandText = "select MALTH N'Mã lịch thực hành',MANV N' MÃ nhân viên',MAGV N'MÃ GIÁO VIÊN',NGAYTH N'NGÀY THỰC HÀNH',TENNV N'TÊN NHÂN VIÊN',HOTENGV N'HỌ TÊN GV',CA N'CA',GIOBD N'GIỜ BẮT ĐẦU',GIOKT N'GIỜ KẾT THÚC' FROM CT_LICHTHUCHANH";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            DTV_TH.DataSource = table;
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sqlDELETE = "DELETE FROM CT_LICHTHUCHANH WHERE maLTH=@maLTH";
            command = new SqlCommand(sqlDELETE, connection);
            command.Parameters.AddWithValue("maLTH", txtmlth.Text);
            command.Parameters.AddWithValue("maNV", txtmnv.Text);
            command.Parameters.AddWithValue("magv", txtmgv.Text);
            command.Parameters.AddWithValue("ngayTH", txtnth.Text);
            command.Parameters.AddWithValue("tenNV", txthtnv.Text);
            command.Parameters.AddWithValue("hotenGV", txthtgv.Text);
            command.Parameters.AddWithValue("ca", txtc.Text);
            command.Parameters.AddWithValue("gioBD", txtgbd.Text);
            command.Parameters.AddWithValue("gioKT", txtgkt.Text);

            command.ExecuteNonQuery();

            hienthi();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hienthi();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            hienthi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlINSERT = "INSERT INTO CT_LICHTHUCHANH(maLTH,maNV,maGV,ngayTH,tenNV,hotenGV,ca,gioBD,gioKT) VALUES(@maLTH,@maNV,@maGV,@ngayTH,@tenNV,@hotenGV,@ca,@gioBD,@gioKT)";
            command = new SqlCommand(sqlINSERT, connection);
            command.Parameters.AddWithValue("maLTH", txtmlth.Text);
            command.Parameters.AddWithValue("maNV", txtmnv.Text);
            command.Parameters.AddWithValue("magv", txtmgv.Text);
            command.Parameters.AddWithValue("ngayTH", txtnth.Text);
            command.Parameters.AddWithValue("tenNV", txthtnv.Text);
            command.Parameters.AddWithValue("hotenGV", txthtgv.Text);
            command.Parameters.AddWithValue("ca", txtc.Text);
            command.Parameters.AddWithValue("gioBD", txtgbd.Text);
            command.Parameters.AddWithValue("gioKT", txtgkt.Text);



            command.ExecuteNonQuery();

            hienthi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sqlEDIT = "UPDATE CT_LICHTHUCHANH SET maLTH=@maLTH, maNV=@maNV,maGV=@maGV,ngayTH=@ngayTH,tenNV=@tenNV,hotenGV=@hotenGV,ca=@ca,gioBD=@gioBD,gioKT=@gioKT WHERE maLTH=@maLTH";
            command = new SqlCommand(sqlEDIT, connection);
            command.Parameters.AddWithValue("maLTH", txtmlth.Text);
            command.Parameters.AddWithValue("maNV", txtmnv.Text);
            command.Parameters.AddWithValue("magv", txtmgv.Text);
            command.Parameters.AddWithValue("ngayTH", txtnth.Text);
            command.Parameters.AddWithValue("tenNV", txthtnv.Text);
            command.Parameters.AddWithValue("hotenGV", txthtgv.Text);
            command.Parameters.AddWithValue("ca", txtc.Text);
            command.Parameters.AddWithValue("gioBD", txtgbd.Text);
            command.Parameters.AddWithValue("gioKT", txtgkt.Text);



            command.ExecuteNonQuery();

            hienthi();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sqlSEARCH = "select MALTH N'Mã lịch thực hành',MANV N' MÃ nhân viên',MAGV N'MÃ GIÁO VIÊN',NGAYTH N'NGÀY THỰC HÀNH',TENNV N'TÊN NHÂN VIÊN',HOTENGV N'HỌ TÊN GV',CA N'CA',GIOBD N'GIỜ BẮT ĐẦU',GIOKT N'GIỜ KẾT THÚC' FROM CT_LICHTHUCHANH WHERE MALTH =@MALTH";
            command = new SqlCommand(sqlSEARCH, connection);

            command.Parameters.AddWithValue("MALTH", txttk.Text);


            command.ExecuteNonQuery();

            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            DTV_TH.DataSource = table;
        }
    }
}
