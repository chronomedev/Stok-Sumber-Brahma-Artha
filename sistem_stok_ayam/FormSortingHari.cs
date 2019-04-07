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

        public String passing;
        public FormSortingHari()
        {
            InitializeComponent();
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
            passing = "HOHOHOHHO";
            this.DialogResult = DialogResult.OK;
            
        }
    }
}
