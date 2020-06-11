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
    public partial class LTH : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-TA85D1G\SQLEXPRESS;Initial Catalog=QLPhongMay;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void hienthi()
        {
            command = connection.CreateCommand();
            command.CommandText = "select MALTH N'Mã lịch thực hành',ngayTH N'Ngày thực hành',noidungTH N'Nội dung thực hành' FROM LICHTHUCHANH";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            DTV_LTH.DataSource = table;
        }
        
        public LTH()
        {
            InitializeComponent();
        }
        private void LTH_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            hienthi();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            frmLTH a = new frmLTH();
            a.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2();
            a.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlINSERT = "INSERT INTO LICHTHUCHANH(MALTH,ngayTH,noidungTH) VALUES (@MALTH,@ngayTH,@noidungTH)";
            command = new SqlCommand(sqlINSERT, connection);
            command.Parameters.AddWithValue("MALTH", txtmlth.Text);
            command.Parameters.AddWithValue("ngayTH", txtnth.Text);
            command.Parameters.AddWithValue("noidungTH", txtndth.Text);
           

            command.ExecuteNonQuery();

            hienthi();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sqlEDIT = "UPDATE LICHTHUCHANH SET MALTH=@MALTH,ngayTH=@ngayTH,noidungTH=@noidungTH WHERE MALTH=@MALTH";
            command = new SqlCommand(sqlEDIT, connection);
            command.Parameters.AddWithValue("MALTH", txtmlth.Text);
            command.Parameters.AddWithValue("ngayTH", txtnth.Text);
            command.Parameters.AddWithValue("noidungTH", txtndth.Text);
            command.ExecuteNonQuery();

            hienthi();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sqlDELETE = "DELETE FROM LICHTHUCHANH WHERE MALTH=@MALTH";
            command = new SqlCommand(sqlDELETE, connection);
            command.Parameters.AddWithValue("MALTH", txtmlth.Text);
            command.Parameters.AddWithValue("ngayTH", txtnth.Text);
            command.Parameters.AddWithValue("noidungTH", txtndth.Text);
            command.ExecuteNonQuery();

            hienthi();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sqlSEARCH = "select MALTH N'Mã lịch thực hành',ngayTH N'Ngày thực hành',noidungTH N'Nội dung thực hành' FROM LICHTHUCHANH WHERE MALTH=@MALTH";
            command = new SqlCommand(sqlSEARCH, connection);

            command.Parameters.AddWithValue("MALTH", txttk.Text);


            command.ExecuteNonQuery();

            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            DTV_LTH.DataSource = table;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            hienthi();
        }
    }
}
