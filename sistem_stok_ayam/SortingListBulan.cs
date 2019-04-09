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
/// Monthly Sort Dialog
/// Created by HSD 2019 
/// </summary>

namespace sistem_stok_ayam
{
    public partial class SortingListBulan : Form
    {
        public String bulan;
        public void fillBulan()
        {
            list_bulan.AddItem("Januari");
            list_bulan.AddItem("Februari");
            list_bulan.AddItem("Maret");
            list_bulan.AddItem("April");
            list_bulan.AddItem("Mei");
            list_bulan.AddItem("Juni");
            list_bulan.AddItem("Juli");
            list_bulan.AddItem("Agustus");
            list_bulan.AddItem("September");
            list_bulan.AddItem("Oktober");
            list_bulan.AddItem("November");
            list_bulan.AddItem("Desember");
        }
        public SortingListBulan()
        {
            InitializeComponent();
        }

        private void SortingListBulan_Load(object sender, EventArgs e)
        {
            fillBulan();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            list_bulan.selectedIndex = 0;
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            bulan = list_bulan.selectedValue;

        }
    }
}
