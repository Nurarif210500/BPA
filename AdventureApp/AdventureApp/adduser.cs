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

namespace AdventureApp
{
    public partial class adduser : Form
    {

        CRUDS db = new CRUDS();

        SqlConnection conn = new SqlConnection("Data source = DESKTOP-LFLIEA4; Initial Catalog=Adventure;" +
                        "User ID = sa; password=123");
        //SqlConnection command;

        public adduser()
        {
            InitializeComponent();
            db.read(dataGridView);
            txtnoktp.Enabled = false;
            txtnama.Enabled = false;
            txtalamat.Enabled = false;
            txtnotelp.Enabled = false;
            txtnmbarang.Enabled = false;
            txtjumlah.Enabled = false;
            datekembali.Enabled = false;
            datesewa.Enabled = false;

            btnedit.Enabled = false;
            btndelete.Enabled = false;
            btnsave.Enabled = false;
            
        }
        public void refresh()
        {
            txtnoktp.Text = "";
            txtnama.Text = "";
            txtalamat.Text = "";
            txtnotelp.Text = "";
            txtnmbarang.Text = "";
            txtjumlah.Text = "";

            db.read(dataGridView);
        }


        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string noktp = Convert.ToString(dataGridView.Rows[e.RowIndex].Cells[0].Value);
            string nama = Convert.ToString(dataGridView.Rows[e.RowIndex].Cells[1].Value);
            string alamat = Convert.ToString(dataGridView.Rows[e.RowIndex].Cells[2].Value);
            string notelp = Convert.ToString(dataGridView.Rows[e.RowIndex].Cells[3].Value);
            string nmbarang = Convert.ToString(dataGridView.Rows[e.RowIndex].Cells[4].Value);
            string tglsewa = Convert.ToString(dataGridView.Rows[e.RowIndex].Cells[5].Value);
            string tglkembali = Convert.ToString(dataGridView.Rows[e.RowIndex].Cells[6].Value);
            string jumlah = Convert.ToString(dataGridView.Rows[e.RowIndex].Cells[7].Value);
            //byte[] img = (byte[])(reader[5]);


            txtnoktp.Text = noktp;
            txtnama.Text = nama;
            txtalamat.Text = alamat;
            txtnotelp.Text = notelp;
            txtnmbarang.Text = nmbarang;
            datesewa.Text = tglsewa;
            datekembali.Text = tglkembali;
            txtjumlah.Text = jumlah;

            btnadd.Enabled = false;
            btndelete.Enabled = true;
            btnedit.Enabled = true;
            btnsave.Enabled = false;



            txtnoktp.Enabled = false;
            txtnama.Enabled = true;
            txtalamat.Enabled = true;
            txtnotelp.Enabled = true;
            txtnmbarang.Enabled = true;
            txtjumlah.Enabled = true;
            datesewa.Enabled = true;
            datekembali.Enabled = true;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string Noktp = txtnoktp.Text.ToString();
            string Nama = txtnama.Text.ToString();
            string Alamat = txtalamat.Text.ToString();
            string Notelp = txtnotelp.Text.ToString();
            string Nmbarang = txtnmbarang.Text.ToString();
            string tglsewa = datesewa.Text.ToString();
            string tglkembali = datekembali.Text.ToString();
            string Jumlah = txtjumlah.Text.ToString();


            txtnoktp.Enabled = true;
            txtnama.Enabled = true;
            txtalamat.Enabled = true;
            txtnotelp.Enabled = true;
            txtnmbarang.Enabled = true;
            txtjumlah.Enabled = true;
            datekembali.Enabled = true;
            datesewa.Enabled = true;

            btnsave.Enabled = true;
            btnedit.Enabled = true;
            btndelete.Enabled = true;
            refresh();

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string Noktp = txtnoktp.Text.ToString();
            string Nama = txtnama.Text.ToString();
            string Alamat = txtalamat.Text.ToString();
            string Notelp = txtnotelp.Text.ToString();
            string Nmbarang = txtnmbarang.Text.ToString();
            string tglsewa = datesewa.Text.ToString();
            string tglkembali = datekembali.Text.ToString();
            string Jumlah = txtjumlah.Text.ToString();


            DialogResult dialogResult = MessageBox.Show("Apakah anda yakin?", "add data", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                db.add(Noktp, Nama, Alamat, Notelp, Nmbarang, tglsewa, tglkembali, Jumlah);
                db.read(dataGridView);

                txtnoktp.Enabled = false;
                txtnama.Enabled = false;
                txtalamat.Enabled = false;
                txtnotelp.Enabled = false;
                txtnmbarang.Enabled = false;
                txtjumlah.Enabled = false;


                btnedit.Enabled = false;
                btndelete.Enabled = false;
                btnsave.Enabled = false;

                refresh();
            }else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string noktp = txtnoktp.Text.ToString();
            db.deleteData(noktp);
            db.read(dataGridView);


            refresh();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string cari = txtsearch.Text.ToString();
            db.search(cari, dataGridView);
            
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            string Noktp = txtnoktp.Text.ToString();
            string Nama = txtnama.Text.ToString();
            string Alamat = txtalamat.Text.ToString();
            string Notelp = txtnotelp.Text.ToString();
            string Nmbarang = txtnmbarang.Text.ToString();
            string tglsewa = datesewa.Text.ToString();
            string tglkembali = datekembali.Text.ToString();
            string Jumlah = txtjumlah.Text.ToString();

            DialogResult dialogResult = MessageBox.Show("Apakah anda yakin?", " data", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                db.updateData(Noktp, Nama, Alamat, Notelp, Nmbarang, tglsewa, tglkembali, Jumlah);
                db.read(dataGridView);

                txtnoktp.Enabled = false;
                txtnama.Enabled = false;
                txtalamat.Enabled = false;
                txtnotelp.Enabled = false;
                txtnmbarang.Enabled = false;
                txtjumlah.Enabled = false;


                btnedit.Enabled = false;
                btndelete.Enabled = false;
                btnsave.Enabled = false;
                btnadd.Enabled = true;

                refresh();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }

        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void txtnoktp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtnotelp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Menu hm = new Menu();
            this.Hide();
            hm.Show();
        }
    }
}
