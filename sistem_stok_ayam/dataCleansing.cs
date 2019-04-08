using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistem_stok_ayam
{
    class dataCleansing
    {
        public String getID_clean(String product_detail)
        {

            String[] pecah = product_detail.Split(new String[] { "  " }, StringSplitOptions.None);
            return pecah[0];
        }

        public double calculateCOGS(double total_stok, double stok_keluar,  double total_harga)
        {
            double harga_avg = total_harga / total_stok;            
            return stok_keluar * harga_avg;
        }
    }
}
