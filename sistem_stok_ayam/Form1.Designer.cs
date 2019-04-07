namespace sistem_stok_ayam
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menu3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.menu2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.menu1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.field_list_customer = new Bunifu.Framework.UI.BunifuDropdown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kontener_sort2 = new System.Windows.Forms.GroupBox();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.kontener_summary = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.kontener_sort1 = new System.Windows.Forms.GroupBox();
            this.bunifuDropdown1 = new Bunifu.Framework.UI.BunifuDropdown();
            this.tombol_kurang_barang = new Bunifu.Framework.UI.BunifuThinButton2();
            this.field_harga_barang = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tombol_tambah_barang = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label_barang = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuDatepicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.judul = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.field_nama_barang = new Bunifu.Framework.UI.BunifuDropdown();
            this.field_kuantitas_barang = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.kontener_list_transaksi = new System.Windows.Forms.GroupBox();
            this.grid_list_transaksi = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.kontener_sort2.SuspendLayout();
            this.kontener_summary.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.kontener_sort1.SuspendLayout();
            this.kontener_list_transaksi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_list_transaksi)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = false;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Maroon;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(1183, 10);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(25, 25);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 4;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 20;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.menu3);
            this.panel1.Controls.Add(this.menu2);
            this.panel1.Controls.Add(this.menu1);
            this.panel1.Location = new System.Drawing.Point(-2, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 626);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // menu3
            // 
            this.menu3.Activecolor = System.Drawing.Color.OrangeRed;
            this.menu3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.menu3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu3.BorderRadius = 0;
            this.menu3.ButtonText = "Stok Keluar";
            this.menu3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menu3.DisabledColor = System.Drawing.Color.Gray;
            this.menu3.Iconcolor = System.Drawing.Color.Transparent;
            this.menu3.Iconimage = ((System.Drawing.Image)(resources.GetObject("menu3.Iconimage")));
            this.menu3.Iconimage_right = null;
            this.menu3.Iconimage_right_Selected = null;
            this.menu3.Iconimage_Selected = null;
            this.menu3.IconMarginLeft = 0;
            this.menu3.IconMarginRight = 0;
            this.menu3.IconRightVisible = true;
            this.menu3.IconRightZoom = 0D;
            this.menu3.IconVisible = true;
            this.menu3.IconZoom = 90D;
            this.menu3.IsTab = false;
            this.menu3.Location = new System.Drawing.Point(0, 357);
            this.menu3.Name = "menu3";
            this.menu3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.menu3.OnHovercolor = System.Drawing.Color.Coral;
            this.menu3.OnHoverTextColor = System.Drawing.Color.White;
            this.menu3.selected = false;
            this.menu3.Size = new System.Drawing.Size(246, 67);
            this.menu3.TabIndex = 2;
            this.menu3.Text = "Stok Keluar";
            this.menu3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.menu3.Textcolor = System.Drawing.Color.White;
            this.menu3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu3.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // menu2
            // 
            this.menu2.Activecolor = System.Drawing.Color.OrangeRed;
            this.menu2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.menu2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu2.BorderRadius = 0;
            this.menu2.ButtonText = "Stok Masuk";
            this.menu2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menu2.DisabledColor = System.Drawing.Color.Gray;
            this.menu2.Iconcolor = System.Drawing.Color.Transparent;
            this.menu2.Iconimage = ((System.Drawing.Image)(resources.GetObject("menu2.Iconimage")));
            this.menu2.Iconimage_right = null;
            this.menu2.Iconimage_right_Selected = null;
            this.menu2.Iconimage_Selected = null;
            this.menu2.IconMarginLeft = 0;
            this.menu2.IconMarginRight = 0;
            this.menu2.IconRightVisible = true;
            this.menu2.IconRightZoom = 0D;
            this.menu2.IconVisible = true;
            this.menu2.IconZoom = 90D;
            this.menu2.IsTab = false;
            this.menu2.Location = new System.Drawing.Point(0, 258);
            this.menu2.Name = "menu2";
            this.menu2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.menu2.OnHovercolor = System.Drawing.Color.Coral;
            this.menu2.OnHoverTextColor = System.Drawing.Color.White;
            this.menu2.selected = false;
            this.menu2.Size = new System.Drawing.Size(244, 67);
            this.menu2.TabIndex = 1;
            this.menu2.Text = "Stok Masuk";
            this.menu2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.menu2.Textcolor = System.Drawing.Color.White;
            this.menu2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // menu1
            // 
            this.menu1.Activecolor = System.Drawing.Color.OrangeRed;
            this.menu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.menu1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu1.BorderRadius = 0;
            this.menu1.ButtonText = "List Pergerakan Barang";
            this.menu1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menu1.DisabledColor = System.Drawing.Color.Gray;
            this.menu1.Iconcolor = System.Drawing.Color.Transparent;
            this.menu1.Iconimage = ((System.Drawing.Image)(resources.GetObject("menu1.Iconimage")));
            this.menu1.Iconimage_right = null;
            this.menu1.Iconimage_right_Selected = null;
            this.menu1.Iconimage_Selected = null;
            this.menu1.IconMarginLeft = 0;
            this.menu1.IconMarginRight = 0;
            this.menu1.IconRightVisible = true;
            this.menu1.IconRightZoom = 0D;
            this.menu1.IconVisible = true;
            this.menu1.IconZoom = 90D;
            this.menu1.IsTab = false;
            this.menu1.Location = new System.Drawing.Point(0, 167);
            this.menu1.Name = "menu1";
            this.menu1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.menu1.OnHovercolor = System.Drawing.Color.Coral;
            this.menu1.OnHoverTextColor = System.Drawing.Color.White;
            this.menu1.selected = false;
            this.menu1.Size = new System.Drawing.Size(244, 67);
            this.menu1.TabIndex = 0;
            this.menu1.Text = "List Pergerakan Barang";
            this.menu1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.menu1.Textcolor = System.Drawing.Color.White;
            this.menu1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Peru;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.field_list_customer);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.kontener_sort2);
            this.panel2.Controls.Add(this.kontener_summary);
            this.panel2.Controls.Add(this.kontener_sort1);
            this.panel2.Controls.Add(this.tombol_kurang_barang);
            this.panel2.Controls.Add(this.field_harga_barang);
            this.panel2.Controls.Add(this.tombol_tambah_barang);
            this.panel2.Controls.Add(this.label_barang);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.bunifuDatepicker1);
            this.panel2.Controls.Add(this.judul);
            this.panel2.Controls.Add(this.field_nama_barang);
            this.panel2.Controls.Add(this.field_kuantitas_barang);
            this.panel2.Controls.Add(this.kontener_list_transaksi);
            this.panel2.Location = new System.Drawing.Point(263, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(944, 626);
            this.panel2.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(269, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Nama Customer";
            // 
            // field_list_customer
            // 
            this.field_list_customer.BackColor = System.Drawing.Color.Sienna;
            this.field_list_customer.BorderRadius = 3;
            this.field_list_customer.DisabledColor = System.Drawing.Color.Gray;
            this.field_list_customer.ForeColor = System.Drawing.Color.White;
            this.field_list_customer.Items = new string[0];
            this.field_list_customer.Location = new System.Drawing.Point(271, 318);
            this.field_list_customer.Name = "field_list_customer";
            this.field_list_customer.NomalColor = System.Drawing.Color.Sienna;
            this.field_list_customer.onHoverColor = System.Drawing.Color.Maroon;
            this.field_list_customer.selectedIndex = -1;
            this.field_list_customer.Size = new System.Drawing.Size(404, 35);
            this.field_list_customer.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(703, 562);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 24);
            this.label4.TabIndex = 19;
            this.label4.Text = "25 APRIL 2019";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(699, 526);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Catatan dalam rentang waktu:";
            // 
            // kontener_sort2
            // 
            this.kontener_sort2.Controls.Add(this.bunifuFlatButton2);
            this.kontener_sort2.Controls.Add(this.bunifuFlatButton1);
            this.kontener_sort2.ForeColor = System.Drawing.Color.White;
            this.kontener_sort2.Location = new System.Drawing.Point(272, 523);
            this.kontener_sort2.Name = "kontener_sort2";
            this.kontener_sort2.Size = new System.Drawing.Size(319, 98);
            this.kontener_sort2.TabIndex = 16;
            this.kontener_sort2.TabStop = false;
            this.kontener_sort2.Text = "Tampil List Berdasarakan Rentang waktu";
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.OrangeRed;
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Per Bulan";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = null;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(163, 40);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.Coral;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(140, 35);
            this.bunifuFlatButton2.TabIndex = 21;
            this.bunifuFlatButton2.Text = "Per Bulan";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click_1);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.OrangeRed;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Per Hari";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(17, 40);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Coral;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(140, 35);
            this.bunifuFlatButton1.TabIndex = 20;
            this.bunifuFlatButton1.Text = "Per Hari";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click_1);
            // 
            // kontener_summary
            // 
            this.kontener_summary.Controls.Add(this.tabControl1);
            this.kontener_summary.ForeColor = System.Drawing.Color.White;
            this.kontener_summary.Location = new System.Drawing.Point(597, 127);
            this.kontener_summary.Name = "kontener_summary";
            this.kontener_summary.Size = new System.Drawing.Size(339, 392);
            this.kontener_summary.TabIndex = 16;
            this.kontener_summary.TabStop = false;
            this.kontener_summary.Text = "SUMMARY";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(6, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(327, 367);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(319, 341);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Stok Sekarang";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "a";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(7, 22);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(319, 342);
            this.listBox1.TabIndex = 0;
            this.listBox1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox1_DrawItem);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(319, 341);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Stok Masuk";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(319, 341);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Stok Keluar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // kontener_sort1
            // 
            this.kontener_sort1.Controls.Add(this.bunifuDropdown1);
            this.kontener_sort1.ForeColor = System.Drawing.Color.White;
            this.kontener_sort1.Location = new System.Drawing.Point(12, 523);
            this.kontener_sort1.Name = "kontener_sort1";
            this.kontener_sort1.Size = new System.Drawing.Size(250, 98);
            this.kontener_sort1.TabIndex = 15;
            this.kontener_sort1.TabStop = false;
            this.kontener_sort1.Text = "Tampilkan List Transaksi Barang berdasarkan";
            // 
            // bunifuDropdown1
            // 
            this.bunifuDropdown1.BackColor = System.Drawing.Color.Sienna;
            this.bunifuDropdown1.BorderRadius = 3;
            this.bunifuDropdown1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDropdown1.ForeColor = System.Drawing.Color.White;
            this.bunifuDropdown1.Items = new string[0];
            this.bunifuDropdown1.Location = new System.Drawing.Point(15, 39);
            this.bunifuDropdown1.Name = "bunifuDropdown1";
            this.bunifuDropdown1.NomalColor = System.Drawing.Color.Sienna;
            this.bunifuDropdown1.onHoverColor = System.Drawing.Color.Maroon;
            this.bunifuDropdown1.selectedIndex = -1;
            this.bunifuDropdown1.Size = new System.Drawing.Size(215, 35);
            this.bunifuDropdown1.TabIndex = 18;
            // 
            // tombol_kurang_barang
            // 
            this.tombol_kurang_barang.ActiveBorderThickness = 1;
            this.tombol_kurang_barang.ActiveCornerRadius = 20;
            this.tombol_kurang_barang.ActiveFillColor = System.Drawing.Color.Maroon;
            this.tombol_kurang_barang.ActiveForecolor = System.Drawing.Color.White;
            this.tombol_kurang_barang.ActiveLineColor = System.Drawing.Color.Maroon;
            this.tombol_kurang_barang.BackColor = System.Drawing.Color.Peru;
            this.tombol_kurang_barang.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tombol_kurang_barang.BackgroundImage")));
            this.tombol_kurang_barang.ButtonText = "Update Barang";
            this.tombol_kurang_barang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tombol_kurang_barang.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombol_kurang_barang.ForeColor = System.Drawing.Color.White;
            this.tombol_kurang_barang.IdleBorderThickness = 1;
            this.tombol_kurang_barang.IdleCornerRadius = 20;
            this.tombol_kurang_barang.IdleFillColor = System.Drawing.Color.Sienna;
            this.tombol_kurang_barang.IdleForecolor = System.Drawing.Color.White;
            this.tombol_kurang_barang.IdleLineColor = System.Drawing.Color.Maroon;
            this.tombol_kurang_barang.Location = new System.Drawing.Point(389, 425);
            this.tombol_kurang_barang.Margin = new System.Windows.Forms.Padding(5);
            this.tombol_kurang_barang.Name = "tombol_kurang_barang";
            this.tombol_kurang_barang.Size = new System.Drawing.Size(181, 41);
            this.tombol_kurang_barang.TabIndex = 8;
            this.tombol_kurang_barang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tombol_kurang_barang.Click += new System.EventHandler(this.tombol_kurang_barang_Click);
            // 
            // field_harga_barang
            // 
            this.field_harga_barang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.field_harga_barang.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.field_harga_barang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.field_harga_barang.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.field_harga_barang.HintText = "Harga (Rp)";
            this.field_harga_barang.isPassword = false;
            this.field_harga_barang.LineFocusedColor = System.Drawing.Color.Red;
            this.field_harga_barang.LineIdleColor = System.Drawing.Color.Sienna;
            this.field_harga_barang.LineMouseHoverColor = System.Drawing.Color.Red;
            this.field_harga_barang.LineThickness = 3;
            this.field_harga_barang.Location = new System.Drawing.Point(275, 360);
            this.field_harga_barang.Margin = new System.Windows.Forms.Padding(4);
            this.field_harga_barang.Name = "field_harga_barang";
            this.field_harga_barang.Size = new System.Drawing.Size(401, 33);
            this.field_harga_barang.TabIndex = 7;
            this.field_harga_barang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tombol_tambah_barang
            // 
            this.tombol_tambah_barang.ActiveBorderThickness = 1;
            this.tombol_tambah_barang.ActiveCornerRadius = 20;
            this.tombol_tambah_barang.ActiveFillColor = System.Drawing.Color.Maroon;
            this.tombol_tambah_barang.ActiveForecolor = System.Drawing.Color.White;
            this.tombol_tambah_barang.ActiveLineColor = System.Drawing.Color.Maroon;
            this.tombol_tambah_barang.BackColor = System.Drawing.Color.Peru;
            this.tombol_tambah_barang.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tombol_tambah_barang.BackgroundImage")));
            this.tombol_tambah_barang.ButtonText = "Tambah Barang";
            this.tombol_tambah_barang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tombol_tambah_barang.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombol_tambah_barang.ForeColor = System.Drawing.Color.White;
            this.tombol_tambah_barang.IdleBorderThickness = 1;
            this.tombol_tambah_barang.IdleCornerRadius = 20;
            this.tombol_tambah_barang.IdleFillColor = System.Drawing.Color.Sienna;
            this.tombol_tambah_barang.IdleForecolor = System.Drawing.Color.White;
            this.tombol_tambah_barang.IdleLineColor = System.Drawing.Color.Maroon;
            this.tombol_tambah_barang.Location = new System.Drawing.Point(389, 425);
            this.tombol_tambah_barang.Margin = new System.Windows.Forms.Padding(5);
            this.tombol_tambah_barang.Name = "tombol_tambah_barang";
            this.tombol_tambah_barang.Size = new System.Drawing.Size(181, 41);
            this.tombol_tambah_barang.TabIndex = 6;
            this.tombol_tambah_barang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_barang
            // 
            this.label_barang.AutoSize = true;
            this.label_barang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_barang.ForeColor = System.Drawing.Color.White;
            this.label_barang.Location = new System.Drawing.Point(272, 232);
            this.label_barang.Name = "label_barang";
            this.label_barang.Size = new System.Drawing.Size(99, 17);
            this.label_barang.TabIndex = 4;
            this.label_barang.Text = "Barang Masuk";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(272, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tanggal";
            // 
            // bunifuDatepicker1
            // 
            this.bunifuDatepicker1.BackColor = System.Drawing.Color.Sienna;
            this.bunifuDatepicker1.BorderRadius = 0;
            this.bunifuDatepicker1.ForeColor = System.Drawing.Color.White;
            this.bunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bunifuDatepicker1.FormatCustom = null;
            this.bunifuDatepicker1.Location = new System.Drawing.Point(272, 167);
            this.bunifuDatepicker1.Name = "bunifuDatepicker1";
            this.bunifuDatepicker1.Size = new System.Drawing.Size(404, 36);
            this.bunifuDatepicker1.TabIndex = 2;
            this.bunifuDatepicker1.Value = new System.DateTime(2019, 4, 4, 23, 2, 13, 9);
            this.bunifuDatepicker1.Enter += new System.EventHandler(this.bunifuDatepicker1_Enter);
            // 
            // judul
            // 
            this.judul.AutoSize = true;
            this.judul.BackColor = System.Drawing.Color.Transparent;
            this.judul.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.judul.ForeColor = System.Drawing.Color.White;
            this.judul.Location = new System.Drawing.Point(264, 13);
            this.judul.Name = "judul";
            this.judul.Size = new System.Drawing.Size(436, 46);
            this.judul.TabIndex = 1;
            this.judul.Text = "PENAMBAHAN STOK";
            // 
            // field_nama_barang
            // 
            this.field_nama_barang.BackColor = System.Drawing.Color.Sienna;
            this.field_nama_barang.BorderRadius = 3;
            this.field_nama_barang.DisabledColor = System.Drawing.Color.Gray;
            this.field_nama_barang.ForeColor = System.Drawing.Color.White;
            this.field_nama_barang.Items = new string[0];
            this.field_nama_barang.Location = new System.Drawing.Point(272, 255);
            this.field_nama_barang.Name = "field_nama_barang";
            this.field_nama_barang.NomalColor = System.Drawing.Color.Sienna;
            this.field_nama_barang.onHoverColor = System.Drawing.Color.Maroon;
            this.field_nama_barang.selectedIndex = -1;
            this.field_nama_barang.Size = new System.Drawing.Size(404, 35);
            this.field_nama_barang.TabIndex = 0;
            this.field_nama_barang.MouseEnter += new System.EventHandler(this.field_nama_barang_MouseEnter);
            this.field_nama_barang.MouseHover += new System.EventHandler(this.field_nama_barang_MouseHover);
            // 
            // field_kuantitas_barang
            // 
            this.field_kuantitas_barang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.field_kuantitas_barang.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.field_kuantitas_barang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.field_kuantitas_barang.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.field_kuantitas_barang.HintText = "Kuantitas (Kg)";
            this.field_kuantitas_barang.isPassword = false;
            this.field_kuantitas_barang.LineFocusedColor = System.Drawing.Color.Red;
            this.field_kuantitas_barang.LineIdleColor = System.Drawing.Color.Sienna;
            this.field_kuantitas_barang.LineMouseHoverColor = System.Drawing.Color.Red;
            this.field_kuantitas_barang.LineThickness = 3;
            this.field_kuantitas_barang.Location = new System.Drawing.Point(275, 319);
            this.field_kuantitas_barang.Margin = new System.Windows.Forms.Padding(4);
            this.field_kuantitas_barang.Name = "field_kuantitas_barang";
            this.field_kuantitas_barang.Size = new System.Drawing.Size(401, 33);
            this.field_kuantitas_barang.TabIndex = 5;
            this.field_kuantitas_barang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.field_kuantitas_barang.Enter += new System.EventHandler(this.bunifuMaterialTextbox1_Enter);
            // 
            // kontener_list_transaksi
            // 
            this.kontener_list_transaksi.Controls.Add(this.grid_list_transaksi);
            this.kontener_list_transaksi.ForeColor = System.Drawing.Color.White;
            this.kontener_list_transaksi.Location = new System.Drawing.Point(12, 127);
            this.kontener_list_transaksi.Name = "kontener_list_transaksi";
            this.kontener_list_transaksi.Size = new System.Drawing.Size(579, 393);
            this.kontener_list_transaksi.TabIndex = 17;
            this.kontener_list_transaksi.TabStop = false;
            this.kontener_list_transaksi.Text = "LIST TRANSAKSI";
            // 
            // grid_list_transaksi
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grid_list_transaksi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.grid_list_transaksi.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.grid_list_transaksi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_list_transaksi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_list_transaksi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grid_list_transaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_list_transaksi.DoubleBuffered = true;
            this.grid_list_transaksi.EnableHeadersVisualStyles = false;
            this.grid_list_transaksi.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.grid_list_transaksi.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.grid_list_transaksi.Location = new System.Drawing.Point(7, 18);
            this.grid_list_transaksi.Name = "grid_list_transaksi";
            this.grid_list_transaksi.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grid_list_transaksi.Size = new System.Drawing.Size(564, 369);
            this.grid_list_transaksi.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Sistem Stok - CV Sumber Brahma Artha";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(1220, 682);
            this.ControlBox = false;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.kontener_sort2.ResumeLayout(false);
            this.kontener_summary.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.kontener_sort1.ResumeLayout(false);
            this.kontener_list_transaksi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_list_transaksi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton menu1;
        private Bunifu.Framework.UI.BunifuFlatButton menu2;
        private Bunifu.Framework.UI.BunifuFlatButton menu3;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuDropdown field_nama_barang;
        private Bunifu.Framework.UI.BunifuCustomLabel judul;
        private Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker1;
        private System.Windows.Forms.Label label_barang;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox field_kuantitas_barang;
        private Bunifu.Framework.UI.BunifuThinButton2 tombol_tambah_barang;
        private Bunifu.Framework.UI.BunifuMaterialTextbox field_harga_barang;
        private Bunifu.Framework.UI.BunifuThinButton2 tombol_kurang_barang;
        private Bunifu.Framework.UI.BunifuCustomDataGrid grid_list_transaksi;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox kontener_sort1;
        private System.Windows.Forms.GroupBox kontener_summary;
        private System.Windows.Forms.GroupBox kontener_list_transaksi;
        private System.Windows.Forms.GroupBox kontener_sort2;
        private Bunifu.Framework.UI.BunifuDropdown bunifuDropdown1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuDropdown field_list_customer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

