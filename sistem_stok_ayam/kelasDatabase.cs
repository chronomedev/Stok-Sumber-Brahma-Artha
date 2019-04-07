using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace sistem_stok_ayam
{
    class kelasDatabase
    {
        private SqlConnection koneksi;
        public kelasDatabase(SqlConnection koneksi_pass)
        {
            koneksi = koneksi_pass;
        }

        public String[] ambilProduk()
        {
            String[] list_produk = new string[1];
            SqlCommand komenSQL = new SqlCommand("select kode_barang, nama_barang from Ms_Barang;", koneksi);
            koneksi.Open();
            SqlDataReader baca = komenSQL.ExecuteReader();
            int indeks_produk = 0;
            while (baca.Read())
            {
                String produk_and_id = baca["kode_barang"].ToString() + " " + baca["nama_barang"].ToString();
                list_produk[indeks_produk] = produk_and_id;
                //Console.WriteLine(produk_and_id);
                indeks_produk = indeks_produk + 1;
                Array.Resize(ref list_produk, indeks_produk+1);
            }
            koneksi.Close();
            Array.Resize(ref list_produk, list_produk.Length - 1);
            Console.WriteLine("LIST PRODUKNYA INDEKS 28:::::" + list_produk[28]);
            Console.WriteLine("PANJANG ARRAY::::" + list_produk.Length);
            return list_produk;
        }

        public void ambilCustomer()
        {

        }
    }
}
