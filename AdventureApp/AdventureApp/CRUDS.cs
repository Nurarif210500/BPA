using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventureApp
{
    class CRUDS
    {

        public void read(DataGridView dgv)
        {
            string koneksi = "Data source = DESKTOP-LFLIEA4; Initial Catalog=Adventure;" +
                        "User ID = sa; password=123";
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM dbPenyewaan ORDER BY noktp DESC", koneksi);
            DataSet ds = new DataSet();
            sda.Fill(ds, "dbPenyewan");                                        
            dgv.DataSource = ds.Tables["dbPenyewan"].DefaultView;
        }
        public void add(string Noktp, string Nama, string Alamat, string Notelp, string Namabarang, string Tglsewa, string Tglkembali, string Jumlah)
        {   
            string str = "Insert into dbPenyewaan values (@noktp,@nama,@alamat,@notelp,@namabarang,@tanggalsewa,@tanggalkembali,@jumlah)";

            string koneksi = "Data source = DESKTOP-LFLIEA4; Initial Catalog=Adventure;" +
                        "User ID = sa; password=123";
            SqlConnection sc = new SqlConnection();
            sc.ConnectionString = koneksi;

            //if ((Noktp == "") || (Nama == "") || (Alamat == "") || (Notelp == "") || (Namabarang == "") || (Jumlah == "")) 
            //{
            //    MessageBox.Show("Silahkan isi semua kolom!");
            //}
            //else
            //{
                sc.Open();

                SqlCommand cmd = new SqlCommand(str, sc);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add(new SqlParameter("noktp", Noktp));
                cmd.Parameters.Add(new SqlParameter("nama", Nama));
                cmd.Parameters.Add(new SqlParameter("alamat", Alamat));
                cmd.Parameters.Add(new SqlParameter("notelp", Notelp));
                cmd.Parameters.Add(new SqlParameter("namabarang", Namabarang));
                cmd.Parameters.Add(new SqlParameter("tanggalsewa", Tglsewa));
                cmd.Parameters.Add(new SqlParameter("tanggalkembali", Tglkembali));
                cmd.Parameters.Add(new SqlParameter("jumlah", Jumlah));
                cmd.ExecuteNonQuery();

             //   sc.Close();
           // }
        }
        public void updateData(string Noktp, string Nama, string Alamat, string Notelp, string Namabarang, string Tglsewa, string Tglkembali, string Jumlah)
        {
            string str = "Update dbPenyewaan set nama=@nama, alamat=@alamat, notelp=@notelp, namabarang=@namabarang,tanggalsewa=@tanggalsewa,tanggalkembali=@tanggalkembali,jumlah=@jumlah where noktp=@noktp";

            string koneksi = "Data source = DESKTOP-LFLIEA4; Initial Catalog=Adventure;" + "User ID = sa; password=123";
            SqlConnection sc = new SqlConnection();
            sc.ConnectionString = koneksi;

            sc.Open();

            SqlCommand cmd = new SqlCommand(str, sc);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("noktp", Noktp));
            cmd.Parameters.Add(new SqlParameter("nama", Nama));
            cmd.Parameters.Add(new SqlParameter("alamat", Alamat));
            cmd.Parameters.Add(new SqlParameter("notelp", Notelp));
            cmd.Parameters.Add(new SqlParameter("namabarang", Namabarang));
            cmd.Parameters.Add(new SqlParameter("tanggalsewa", Tglsewa));
            cmd.Parameters.Add(new SqlParameter("tanggalkembali", Tglkembali));
            cmd.Parameters.Add(new SqlParameter("jumlah", Jumlah));
            cmd.ExecuteNonQuery();

            sc.Close();
        }
        public void search(string cari, DataGridView dgv)
        {
            string str = "SELECT * FROM dbPenyewaan WHERE noktp LIKE '%" + cari + "%' OR nama LIKE '%" + cari + "%' OR alamat LIKE '%" + cari + "%' OR notelp LIKE '%" + cari + "%' OR namabarang LIKE '%" + cari + "%'";
            using (SqlConnection sc = new SqlConnection("Data source = DESKTOP-LFLIEA4; Initial Catalog=Adventure;" + "User ID = sa; password=123"))
            using (SqlCommand cmd = new SqlCommand(str, sc))
            {
                sc.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(ds);
                dgv.DataSource = ds.Tables[0];
            }
        }

        public void deleteData(string noktp)
        {
            string str = "delete dbPenyewaan where noktp=@noktp";
            string strKoneksi = "Data source = DESKTOP-LFLIEA4; Initial Catalog=Adventure;" + "User ID = sa; password=123";
            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = strKoneksi;
            DialogResult dialogResult = MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                koneksi.Open();
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("noktp", noktp));
                cmd.ExecuteNonQuery();
                koneksi.Close();
            }
                else if(dialogResult == DialogResult.No)
            {
                return;
            }
        }
    }
}
