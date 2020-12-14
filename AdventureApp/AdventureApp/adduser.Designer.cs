namespace AdventureApp
{
    partial class adduser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adduser));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.datekembali = new System.Windows.Forms.DateTimePicker();
            this.datesewa = new System.Windows.Forms.DateTimePicker();
            this.btnsave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnmbarang = new System.Windows.Forms.TextBox();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.txtalamat = new System.Windows.Forms.TextBox();
            this.txtnotelp = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtjumlah = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnedit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnoktp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnback = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.datekembali);
            this.groupBox1.Controls.Add(this.datesewa);
            this.groupBox1.Controls.Add(this.btnsave);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtnmbarang);
            this.groupBox1.Controls.Add(this.txtnama);
            this.groupBox1.Controls.Add(this.txtalamat);
            this.groupBox1.Controls.Add(this.txtnotelp);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtjumlah);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnedit);
            this.groupBox1.Controls.Add(this.btndelete);
            this.groupBox1.Controls.Add(this.btnadd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtnoktp);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Goudy Stout", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1250, 429);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ADD CUSTOMER";
            // 
            // datekembali
            // 
            this.datekembali.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datekembali.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datekembali.Location = new System.Drawing.Point(788, 151);
            this.datekembali.Name = "datekembali";
            this.datekembali.Size = new System.Drawing.Size(200, 28);
            this.datekembali.TabIndex = 73;
            // 
            // datesewa
            // 
            this.datesewa.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datesewa.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datesewa.Location = new System.Drawing.Point(788, 105);
            this.datesewa.Name = "datesewa";
            this.datesewa.Size = new System.Drawing.Size(200, 28);
            this.datesewa.TabIndex = 72;
            // 
            // btnsave
            // 
            this.btnsave.Image = ((System.Drawing.Image)(resources.GetObject("btnsave.Image")));
            this.btnsave.Location = new System.Drawing.Point(551, 325);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(59, 58);
            this.btnsave.TabIndex = 71;
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(618, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 21);
            this.label6.TabIndex = 67;
            this.label6.Text = "Tanggal Sewa";
            // 
            // txtnmbarang
            // 
            this.txtnmbarang.Font = new System.Drawing.Font("High Tower Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnmbarang.Location = new System.Drawing.Point(788, 44);
            this.txtnmbarang.Multiline = true;
            this.txtnmbarang.Name = "txtnmbarang";
            this.txtnmbarang.Size = new System.Drawing.Size(253, 32);
            this.txtnmbarang.TabIndex = 65;
            // 
            // txtnama
            // 
            this.txtnama.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnama.Location = new System.Drawing.Point(239, 105);
            this.txtnama.Multiline = true;
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(253, 32);
            this.txtnama.TabIndex = 63;
            // 
            // txtalamat
            // 
            this.txtalamat.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtalamat.Location = new System.Drawing.Point(239, 168);
            this.txtalamat.Multiline = true;
            this.txtalamat.Name = "txtalamat";
            this.txtalamat.Size = new System.Drawing.Size(253, 32);
            this.txtalamat.TabIndex = 62;
            // 
            // txtnotelp
            // 
            this.txtnotelp.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnotelp.Location = new System.Drawing.Point(239, 226);
            this.txtnotelp.Multiline = true;
            this.txtnotelp.Name = "txtnotelp";
            this.txtnotelp.Size = new System.Drawing.Size(253, 32);
            this.txtnotelp.TabIndex = 61;
            this.txtnotelp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnotelp_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(618, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 21);
            this.label9.TabIndex = 60;
            this.label9.Text = "Tanggal Kembali";
            // 
            // txtjumlah
            // 
            this.txtjumlah.Font = new System.Drawing.Font("High Tower Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtjumlah.Location = new System.Drawing.Point(788, 223);
            this.txtjumlah.Multiline = true;
            this.txtjumlah.Name = "txtjumlah";
            this.txtjumlah.Size = new System.Drawing.Size(86, 35);
            this.txtjumlah.TabIndex = 59;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(618, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 21);
            this.label8.TabIndex = 57;
            this.label8.Text = "Jumlah";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(618, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 21);
            this.label5.TabIndex = 55;
            this.label5.Text = "Nama Barang";
            // 
            // btnedit
            // 
            this.btnedit.Image = ((System.Drawing.Image)(resources.GetObject("btnedit.Image")));
            this.btnedit.Location = new System.Drawing.Point(346, 325);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(67, 58);
            this.btnedit.TabIndex = 39;
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btndelete
            // 
            this.btndelete.Image = ((System.Drawing.Image)(resources.GetObject("btndelete.Image")));
            this.btndelete.Location = new System.Drawing.Point(239, 325);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(59, 58);
            this.btndelete.TabIndex = 38;
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnadd
            // 
            this.btnadd.Image = ((System.Drawing.Image)(resources.GetObject("btnadd.Image")));
            this.btnadd.Location = new System.Drawing.Point(451, 325);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(65, 58);
            this.btnadd.TabIndex = 5;
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 33;
            this.label1.Text = "No KTP";
            // 
            // txtnoktp
            // 
            this.txtnoktp.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnoktp.Location = new System.Drawing.Point(239, 43);
            this.txtnoktp.Multiline = true;
            this.txtnoktp.Name = "txtnoktp";
            this.txtnoktp.Size = new System.Drawing.Size(253, 32);
            this.txtnoktp.TabIndex = 28;
            this.txtnoktp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnoktp_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(81, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 21);
            this.label7.TabIndex = 37;
            this.label7.Text = "Nama ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 21);
            this.label3.TabIndex = 35;
            this.label3.Text = "No Telp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 21);
            this.label2.TabIndex = 34;
            this.label2.Text = "Alamat";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView);
            this.groupBox4.Controls.Add(this.btnsearch);
            this.groupBox4.Controls.Add(this.txtsearch);
            this.groupBox4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(24, 473);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1250, 297);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "VIEW DATA";
            // 
            // dataGridView
            // 
            this.dataGridView.Location = new System.Drawing.Point(61, 73);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1150, 196);
            this.dataGridView.TabIndex = 3;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            // 
            // btnsearch
            // 
            this.btnsearch.Image = ((System.Drawing.Image)(resources.GetObject("btnsearch.Image")));
            this.btnsearch.Location = new System.Drawing.Point(871, 27);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(37, 38);
            this.btnsearch.TabIndex = 2;
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(380, 37);
            this.txtsearch.Multiline = true;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(476, 30);
            this.txtsearch.TabIndex = 1;
            // 
            // btnback
            // 
            this.btnback.Image = global::AdventureApp.Properties.Resources.previous;
            this.btnback.Location = new System.Drawing.Point(-2, -4);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(43, 36);
            this.btnback.TabIndex = 7;
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // adduser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1298, 786);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "adduser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adduser";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnoktp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtnmbarang;
        private System.Windows.Forms.TextBox txtnama;
        private System.Windows.Forms.TextBox txtalamat;
        private System.Windows.Forms.TextBox txtnotelp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtjumlah;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.DateTimePicker datekembali;
        private System.Windows.Forms.DateTimePicker datesewa;
        private System.Windows.Forms.Button btnback;
    }
}