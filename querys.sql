use sumberbrahma;

select * from Ms_Pergerakan_Barang;

select * from Ms_Barang;

select Ms_Barang.kode_barang, Ms_Barang.nama_barang, Ms_Pergerakan_Barang.qty_barang, 
Ms_Customer.kode_customer, Ms_Customer.nama_customer, Ms_Pergerakan_Barang.pergerakan_barang, Ms_Pergerakan_Barang.tanggal, Ms_Pergerakan_Barang.cogs, Ms_Pergerakan_Barang.uang_masuk 
from Ms_Barang INNER JOIN Ms_Pergerakan_Barang on Ms_Barang.kode_barang = Ms_Pergerakan_Barang.kode_barang
INNER JOIN Ms_Customer on Ms_Pergerakan_Barang.kode_customer = Ms_Customer.kode_customer;

/* Query for all transaction */
select Ms_Pergerakan_Barang.tanggal, Ms_pergerakan_Barang.kode_barang, Ms_Barang.nama_barang, Ms_Pergerakan_Barang.pergerakan_barang, 
Ms_Pergerakan_Barang.kode_customer, Ms_Customer.nama_customer, Ms_Pergerakan_Barang.uang_masuk from Ms_Pergerakan_Barang 
LEFT JOIN Ms_Barang on Ms_Barang.kode_barang = Ms_Pergerakan_barang.kode_barang LEFT JOIN Ms_Customer on Ms_Pergerakan_Barang.kode_customer = Ms_Customer.kode_customer;