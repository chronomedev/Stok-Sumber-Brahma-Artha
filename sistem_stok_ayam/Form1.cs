using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Stock Management Application System for CV Sumber Brahma Artha
/// Main Window Application
/// Created by HSD 2019 
/// </summary>

namespace sistem_stok_ayam
{
    public partial class Form1 : Form
    {

        /////////UI management Functions//////////////////


        kelasDatabase libraryFungsi;
        dataCleansing dataLibrary;

        //Declare sorting variables
        int pilihan_bulan;
        String pilihan_tanggal_sort;

        public void uiListAll_en()
        {
            kontener_list_transaksi.Enabled = true;
            kontener_list_transaksi.Visible = true;
            kontener_sort1.Enabled = true;
            kontener_sort1.Visible = true;
            kontener_sort2.Enabled = true;
            kontener_sort2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            kontener_summary.Enabled = true;
            kontener_summary.Visible = true;
        }

        public void uiListAll_dis()
        {
            kontener_list_transaksi.Enabled = false;
            kontener_list_transaksi.Visible = false;
            kontener_sort1.Enabled = false;
            kontener_sort1.Visible = false;
            kontener_sort2.Enabled = false;
            kontener_sort2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            kontener_summary.Enabled = false;
            kontener_summary.Visible = false;
        }

        public void uiStok_dis()
        {
            //judul.Visible = false;
            label2.Visible = false;
            bunifuDatepicker1.Visible = false;
            bunifuDatepicker1.Enabled = false;
            label_barang.Visible = false;
            label_barang.Text = null;
            field_nama_barang.Enabled = false;
            field_nama_barang.Visible = false;
            field_kuantitas_barang.Enabled = false;
            field_kuantitas_barang.Visible = false;
            field_harga_barang.Enabled = false;
            field_harga_barang.Visible = false;
            field_nama_barang.Enabled = false;
            field_nama_barang.Visible = false;
            tombol_tambah_barang.Visible = false;
            tombol_tambah_barang.Enabled = false;
            tombol_kurang_barang.Enabled = false;
            tombol_kurang_barang.Visible = false;
            label5.Visible = false;
            field_list_customer.Enabled = false;
            field_list_customer.Visible = false;
        }
        public void uiStokMasuk_en() 
        {
            //judul.Visible = true;
            judul.Text = "PENAMBAHAN STOK";
            label2.Visible = true;
            bunifuDatepicker1.Visible = true;
            bunifuDatepicker1.Enabled = true;
            label_barang.Visible = true;
            label_barang.Text = "Barang Masuk";
            field_nama_barang.Enabled = true;
            field_nama_barang.Visible = true;
            field_kuantitas_barang.Location = new Point(275, 319);
            field_kuantitas_barang.Enabled = true;
            field_kuantitas_barang.Visible = true;
            field_harga_barang.Enabled = true;
            field_harga_barang.Visible = true;
            tombol_tambah_barang.Visible = true;
            tombol_tambah_barang.Enabled = true;
            tombol_kurang_barang.Enabled = false;
            tombol_kurang_barang.Visible = false;
            label5.Visible = false;
            field_list_customer.Enabled = false;
            field_list_customer.Visible = false;
        }

        public void uiStokKeluar_en()
        {
            //judul.Visible = true;
            judul.Text = "PENGURANGAN STOK";
            label2.Visible = true;
            bunifuDatepicker1.Visible = true;
            bunifuDatepicker1.Enabled = true;
            label_barang.Visible = true;
            label_barang.Text = "Barang Keluar";
            field_nama_barang.Enabled = true;
            field_nama_barang.Visible = true;
            field_kuantitas_barang.Location = new Point(270, 370);
            field_kuantitas_barang.Enabled = true;
            field_kuantitas_barang.Visible = true;
            
            field_harga_barang.Enabled = false;
            field_harga_barang.Visible = false;
            tombol_kurang_barang.Enabled = true;
            tombol_kurang_barang.Visible = true;
            tombol_tambah_barang.Enabled = false;
            tombol_tambah_barang.Visible = false;
            label5.Visible = true;
            field_list_customer.Enabled = true;
            field_list_customer.Visible = true;
        }


        public void fillProductList()
        {
            String[] list_produk = libraryFungsi.ambilProduk();
            for(int z = 0; z < list_produk.Length; z++)
            {
                field_nama_barang.AddItem(list_produk[z]);
            }
        }

        public void fillCustomerList()
        {
            String[] list_customer = libraryFungsi.ambilCustomer();
            for (int z = 0; z < list_customer.Length; z++)
            {
                field_list_customer.AddItem(list_customer[z]);
            }
        }

        public void fillListSort()
        {
            bunifuDropdown1.AddItem("Semua");
            bunifuDropdown1.AddItem("Masuk");
            bunifuDropdown1.AddItem("Keluar");
        }

        public void InterfaceManager(int request)
        {
            if (request == 1)
            {
                uiListAll_en();
                uiStok_dis();
                menu1.Normalcolor= Color.OrangeRed;
                menu2.Normalcolor = Color.FromArgb(64, 0, 0);
                menu3.Normalcolor = Color.FromArgb(64, 0, 0);

            }
            else if (request == 2)
            {
                uiStokMasuk_en();
                uiListAll_dis();
                menu1.Normalcolor = Color.FromArgb(64, 0, 0);
                menu2.Normalcolor = Color.OrangeRed;
                menu3.Normalcolor = Color.FromArgb(64, 0, 0);
            }
            else
            {
                uiListAll_dis();
                uiStokKeluar_en();
                menu1.Normalcolor = Color.FromArgb(64, 0, 0);
                menu2.Normalcolor = Color.FromArgb(64, 0, 0);
                menu3.Normalcolor = Color.OrangeRed;
            }
        }


        public void fillListTransaksi()
        {
            DataTable tabeldata = libraryFungsi.ambilData_list_Transaksi();
            grid_list_transaksi.DataSource = tabeldata;
            grid_list_transaksi.DefaultCellStyle.ForeColor = Color.Black;
        }

        ///////////////////////////////////////////////////////////////

        
        public Form1()
        {
            InitializeComponent();
            SqlConnection koneksi = new SqlConnection("Data Source=den1.mssql8.gear.host;Initial Catalog=sumberbrahma;Persist Security Info=True;User ID=sumberbrahma;Password=Fu2brX8rn!-1");
            libraryFungsi = new kelasDatabase(koneksi);
            dataLibrary = new dataCleansing();
            this.FormBorderStyle = FormBorderStyle.None;
            InterfaceManager(1);

            label1.Text = "Nama Barang           Kuantitas(Kg)           Nilai(Rp)";
            fillListTransaksi();
            //listBox1.Items.Add("BLD\t\t100\t\t7100000");
            //listBox1.Items.Add("Ampela\t\t100\t\t50000");
            //listBox1.Items.Add("BLP\t\t140\t\t9100000");
            //listBox1.Items.Add("hati\t\t37\t\t24430");


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fillListSort();
            fillProductList();
            fillCustomerList();
            bunifuDropdown1.selectedIndex = 0;
            bunifuDatepicker1.Value = DateTime.Today;

        }

        private void aaa1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            InterfaceManager(2);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            InterfaceManager(1);
            //uiStok_dis();
            //uiListAll_en();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {

            InterfaceManager(3);
            ////uiStokMasuk_dis();
            //uiStokKeluar_en();
        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            
        }

        private void bunifuDatepicker1_Enter(object sender, EventArgs e)
        {
            //bunifuDatepicker1.BackColor = Color.Maroon;
        }

        private void field_nama_barang_MouseHover(object sender, EventArgs e)
        {
            bunifuDatepicker1.BackColor = Color.Maroon;
        }

        private void field_nama_barang_MouseEnter(object sender, EventArgs e)
        {
            bunifuDatepicker1.BackColor = Color.Maroon;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDatepicker2_onValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {
            SortingListBulan dialok_bulan = new SortingListBulan();
            if(dialok_bulan.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            FormSortingHari dialokHari = new FormSortingHari();
            if(dialokHari.ShowDialog() == DialogResult.OK)
            {
                //label4.Text = dialokHari.passing;
            } 
        }

        //Update stok barang ada keluar
        private void tombol_kurang_barang_Click(object sender, EventArgs e)
        {
            String waktu = bunifuDatepicker1.Value.ToString("yyy-MM-dd");
            String id_produk_pilihan = dataLibrary.getID_clean(field_nama_barang.selectedValue.ToString());
            Console.WriteLine("PILIHAN BUAT BARANG KELUAR:::::" + id_produk_pilihan);
            String id_customer_pilihan = dataLibrary.getID_clean(field_list_customer.selectedValue.ToString());

            double kuantitas_kg = Convert.ToDouble(field_kuantitas_barang.Text);
            double total_stok = libraryFungsi.ambilJumlahStok(id_produk_pilihan);
            double stok_keluar = Convert.ToDouble(field_kuantitas_barang.Text);
            double total_harga_barang = libraryFungsi.ambilJumlahStok_harga(id_produk_pilihan);
            double cogs = dataLibrary.calculateCOGS(total_stok, stok_keluar, total_harga_barang);

            Console.WriteLine("NILAI COGS:::::" + cogs);

            libraryFungsi.kurangStokBarang(id_produk_pilihan, kuantitas_kg);
            libraryFungsi.kurangStokBarang_harga(id_produk_pilihan, cogs);
            libraryFungsi.insertTransaksi(id_produk_pilihan, waktu, stok_keluar, "keluar", cogs, id_customer_pilihan);
            MessageBox.Show("Berhasil melakukan update barang keluar");



        }

        //Update stok barang ada masuk
        private void tombol_tambah_barang_Click(object sender, EventArgs e)
        {
            //Ambil inputan dari field
            String waktu = bunifuDatepicker1.Value.ToString("yyy-MM-dd");
            Console.WriteLine("VARIABEL WAKTU::::::::" + waktu);
            String kode_produk = dataLibrary.getID_clean(field_nama_barang.selectedValue.ToString());

            double kuantitas_kg = Convert.ToDouble(field_kuantitas_barang.Text);
            double harga_masukan = Convert.ToDouble(field_harga_barang.Text);

            //Jalankan query database///////////
            libraryFungsi.tambahStokBarang(kode_produk, kuantitas_kg);
            libraryFungsi.tambahStokBarang_harga(kode_produk, harga_masukan);

            if(libraryFungsi.insertTransaksi(kode_produk, waktu, kuantitas_kg, "masuk", 0, null))
            {
                MessageBox.Show("Berhasil mencatat barang!");
            } else
            {
                MessageBox.Show("Tidak berhasil mencatat Barang");
            }


            Console.WriteLine("VALUE DATENYA::::" + waktu);
        }

        private void field_harga_barang_KeyPress(object sender, KeyPressEventArgs e)
        {
            
          
           if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar) && !e.KeyChar.Equals('.'))
           {
                MessageBox.Show("Masukan untuk harga barang harus berupa angka!");
                //Console.WriteLine("VALUE TITIK::::" + e.KeyChar);
                field_harga_barang.Text = String.Empty;
                
            } 
        }

        private void field_kuantitas_barang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Masukan untuk kuantitas barang harus berupa angka!");
                field_kuantitas_barang.Text = String.Empty;

            }
        }
    }
}
