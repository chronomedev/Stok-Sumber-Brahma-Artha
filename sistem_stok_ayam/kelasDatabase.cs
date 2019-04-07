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
                String produk_and_id = baca["kode_barang"].ToString() + "  " + baca["nama_barang"].ToString();
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

        public String[] ambilCustomer()
        {
            String[] list_customer = new String[1];
            SqlCommand komenSQL = new SqlCommand("select kode_customer, nama_customer from Ms_Customer;", koneksi);
            koneksi.Open();
            SqlDataReader baca = komenSQL.ExecuteReader();
            int indeks_customer = 0;
            while (baca.Read())
            {
                String customer_ekstrak = baca["kode_customer"].ToString() + "  " + baca["nama_customer"].ToString();
                list_customer[indeks_customer] = customer_ekstrak;
                indeks_customer++;
                Array.Resize(ref list_customer, indeks_customer + 1);
                
            }
            koneksi.Close();
            Array.Resize(ref list_customer, list_customer.Length - 1);
            return list_customer;
        }


        public void tambahStokBarang(String id_barang, int kuantitas)
        {
            long stok_sekarang = ambilJumlahStok(id_barang);
            long stok_update = stok_sekarang + kuantitas;
            String querySQL = "update Ms_barang set qty_barang =" + stok_update + "where kode_barang ='" + id_barang + "';";
            SqlCommand komenSQL = new SqlCommand(querySQL, koneksi);
            koneksi.Open();
            komenSQL.ExecuteNonQuery();
            koneksi.Close();
        }

        public void kurangStokBarang(String id_barang, int kuantitas)
        {
            long stok_sekarang = ambilJumlahStok(id_barang);
            long stok_update = stok_sekarang - kuantitas;
            String querySQL = "update Ms_barang set qty_barang =" + stok_update + "where kode_barang ='" + id_barang + "';";
            SqlCommand komenSQL = new SqlCommand(querySQL, koneksi);
            koneksi.Open();
            komenSQL.ExecuteNonQuery();
            koneksi.Close();
        }

        public void tambahStokBarang_harga(String id_barang, long kuantitas)
        {
            long jumlah_harga_sekarang = ambilJumlahStok_harga(id_barang);
            long jumlah_harga_update = jumlah_harga_sekarang + kuantitas;
            String querySQL = "update Ms_barang set harga_barang =" + jumlah_harga_update + "where kode_barang ='" + id_barang + "';";
            SqlCommand komenSQL = new SqlCommand(querySQL, koneksi);
            koneksi.Open();
            komenSQL.ExecuteNonQuery();
            koneksi.Close();
  
        }

        public void kurangStokBarang_harga(String id_barang, long kuantitas)
        {
            long jumlah_harga_sekarang = ambilJumlahStok_harga(id_barang);
            long jumlah_harga_update = jumlah_harga_sekarang - kuantitas;
            String querySQL = "update Ms_barang set harga_barang =" + jumlah_harga_update + "where kode_barang ='" + id_barang + "';";
            SqlCommand komenSQL = new SqlCommand(querySQL, koneksi);
            koneksi.Open();
            komenSQL.ExecuteNonQuery();
            koneksi.Close();
        }

        public long ambilJumlahStok_harga(String id_barang)
        {
            long jumlah_harga = 0;
            String querySQL = "select harga_barang from Ms_Barang where kode_barang = '"+ id_barang+"';";
            SqlCommand komenSQL = new SqlCommand(querySQL, koneksi);
            koneksi.Open();
            SqlDataReader baca = komenSQL.ExecuteReader();
            while (baca.Read())
            {
                if (baca["harga_barang"].ToString() != null)
                {
                    jumlah_harga = Convert.ToInt64(baca["harga_barang"].ToString());
                }
            }


            return jumlah_harga;
        }


        public long ambilJumlahStok(String id_barang)
        {
            long total_stok = 0;
            String querySQL = "select qty_barang from Ms_Barang where kode_barang = '" + id_barang + "';";
            SqlCommand komenSQL = new SqlCommand(querySQL, koneksi);
            koneksi.Open();
            SqlDataReader baca = komenSQL.ExecuteReader();
            while (baca.Read())
            {
                if(baca["qty_barang"] != null)
                {
                    total_stok = Convert.ToInt64(baca["qty_barang"].ToString());
                }
                
            }

            return total_stok;
        }



        public Boolean insertTransaksi(String kode_barang, String waktu, int qty_barang, String pergerakan_barang)
        {
            try
            {
                String querySQL = "insert into Ms_Pergerakan_Barang(kode_barang, tanggal, qty_barang, pergerakan_barang)values('" + kode_barang + "', '" + waktu + "', " + qty_barang + ", '" + pergerakan_barang + "');";
                SqlCommand komenSQL = new SqlCommand(querySQL, koneksi);
                koneksi.Open();
                komenSQL.ExecuteNonQuery();
                koneksi.Close();
                return true;

            } catch(Exception e)
            {
                Console.WriteLine("ERRROR WOI::::" + e);
                return false;
            }
           
        }
    }
}
