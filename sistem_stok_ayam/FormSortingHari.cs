using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Stock Management Application System for CV Sumber Brahma Artha
/// Dialy Sort list Dialog
/// Created by HSD 2019 
/// </summary>
namespace sistem_stok_ayam
{
    public partial class FormSortingHari : Form
    {

        public String passing_tanggal;
        public FormSortingHari()
        {
            InitializeComponent();
        }

        public String pilah_bulan(int angka_bulan)
        {
            String[] bulan = { "Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Okober", "November", "Desember" };
            return bulan[angka_bulan - 1];
        }

        private void FormSortingHari_Load(object sender, EventArgs e)
        {
            //this.FormBorderStyle = FormBorderStyle.None;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void bunifuThinButton22_Click_1(object sender, EventArgs e)
        {
            //this.DialogResult = DialogResult.None;
            this.Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            
            String passing_bulan = bunifuDatepicker2.Value.ToString("dd-M-yyy");

            String[] pecah = passing_bulan.Split(new String[] { "-" }, StringSplitOptions.None);
            String ekstrak_bulan = pilah_bulan(Convert.ToInt16(pecah[1]));

            passing_tanggal = pecah[0] + " " + ekstrak_bulan + " " +pecah[2];
            
            
            
            Console.WriteLine("VALUE DATE PILIHAN SORTING:::::" + ekstrak_bulan);
            this.DialogResult = DialogResult.OK;
            
        }
    }
}
