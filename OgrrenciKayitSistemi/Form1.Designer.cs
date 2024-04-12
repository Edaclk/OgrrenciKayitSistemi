namespace OgrrenciKayitSistemi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtimeDogum = new System.Windows.Forms.DateTimePicker();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtimeKayit = new System.Windows.Forms.DateTimePicker();
            this.cmbSinif = new System.Windows.Forms.ComboBox();
            this.txtBolum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogrenciNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciDogDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciBolumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciSinifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciKayitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblOgrenciKayitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ogrenciVeriTabaniDataSet1 = new OgrrenciKayitSistemi.OgrenciVeriTabaniDataSet1();
            this.tbl_OgrenciKayitTableAdapter = new OgrrenciKayitSistemi.OgrenciVeriTabaniDataSet1TableAdapters.Tbl_OgrenciKayitTableAdapter();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOgrenciKayitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciVeriTabaniDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMail);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dtimeDogum);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.txtNo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(2, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 303);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Bilgileri";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(158, 213);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(178, 32);
            this.txtMail.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(77, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 24);
            this.label9.TabIndex = 8;
            this.label9.Text = "Email :";
            // 
            // dtimeDogum
            // 
            this.dtimeDogum.Location = new System.Drawing.Point(158, 261);
            this.dtimeDogum.Name = "dtimeDogum";
            this.dtimeDogum.Size = new System.Drawing.Size(178, 32);
            this.dtimeDogum.TabIndex = 7;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(158, 159);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(178, 32);
            this.txtSoyad.TabIndex = 6;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(158, 105);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(178, 32);
            this.txtAd.TabIndex = 5;
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(158, 41);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(178, 32);
            this.txtNo.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Doğum Tarihi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Soyad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Öğrenci No :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Adı :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtimeKayit);
            this.groupBox2.Controls.Add(this.cmbSinif);
            this.groupBox2.Controls.Add(this.txtBolum);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(446, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(403, 303);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Okul Bilgileri ";
            // 
            // dtimeKayit
            // 
            this.dtimeKayit.Location = new System.Drawing.Point(138, 193);
            this.dtimeKayit.Name = "dtimeKayit";
            this.dtimeKayit.Size = new System.Drawing.Size(179, 32);
            this.dtimeKayit.TabIndex = 5;
            // 
            // cmbSinif
            // 
            this.cmbSinif.FormattingEnabled = true;
            this.cmbSinif.Items.AddRange(new object[] {
            "Hazırlık",
            "1.Sınıf",
            "2.Sınıf",
            "3.Sınıf",
            "4.Sınıf"});
            this.cmbSinif.Location = new System.Drawing.Point(138, 121);
            this.cmbSinif.Name = "cmbSinif";
            this.cmbSinif.Size = new System.Drawing.Size(179, 32);
            this.cmbSinif.TabIndex = 4;
            // 
            // txtBolum
            // 
            this.txtBolum.Location = new System.Drawing.Point(138, 41);
            this.txtBolum.Name = "txtBolum";
            this.txtBolum.Size = new System.Drawing.Size(179, 32);
            this.txtBolum.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 24);
            this.label8.TabIndex = 2;
            this.label8.Text = "Kayıt Tarihi :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "Sınıf :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Bölüm :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(320, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 76);
            this.label1.TabIndex = 2;
            this.label1.Text = "Öğrenci Kayıt Sistemi";
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnListele.Location = new System.Drawing.Point(896, 87);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(170, 43);
            this.btnListele.TabIndex = 3;
            this.btnListele.Text = "Listele ";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEkle.Location = new System.Drawing.Point(896, 145);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(170, 43);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnGuncelle.Location = new System.Drawing.Point(896, 207);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(170, 43);
            this.btnGuncelle.TabIndex = 5;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnTemizle.Location = new System.Drawing.Point(896, 267);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(170, 43);
            this.btnTemizle.TabIndex = 6;
            this.btnTemizle.Text = "Temizle ";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSil.Location = new System.Drawing.Point(896, 334);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(170, 43);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(12, 403);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1064, 222);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kayıtlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrenciNoDataGridViewTextBoxColumn,
            this.ogrenciAdDataGridViewTextBoxColumn,
            this.ogrenciSoyadDataGridViewTextBoxColumn,
            this.ogrenciMailDataGridViewTextBoxColumn,
            this.ogrenciDogDataGridViewTextBoxColumn,
            this.ogrenciBolumDataGridViewTextBoxColumn,
            this.ogrenciSinifDataGridViewTextBoxColumn,
            this.ogrenciKayitDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblOgrenciKayitBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1058, 194);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // ogrenciNoDataGridViewTextBoxColumn
            // 
            this.ogrenciNoDataGridViewTextBoxColumn.DataPropertyName = "OgrenciNo";
            this.ogrenciNoDataGridViewTextBoxColumn.HeaderText = "OgrenciNo";
            this.ogrenciNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrenciNoDataGridViewTextBoxColumn.Name = "ogrenciNoDataGridViewTextBoxColumn";
            this.ogrenciNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.ogrenciNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrenciAdDataGridViewTextBoxColumn
            // 
            this.ogrenciAdDataGridViewTextBoxColumn.DataPropertyName = "OgrenciAd";
            this.ogrenciAdDataGridViewTextBoxColumn.HeaderText = "OgrenciAd";
            this.ogrenciAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrenciAdDataGridViewTextBoxColumn.Name = "ogrenciAdDataGridViewTextBoxColumn";
            this.ogrenciAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrenciSoyadDataGridViewTextBoxColumn
            // 
            this.ogrenciSoyadDataGridViewTextBoxColumn.DataPropertyName = "OgrenciSoyad";
            this.ogrenciSoyadDataGridViewTextBoxColumn.HeaderText = "OgrenciSoyad";
            this.ogrenciSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrenciSoyadDataGridViewTextBoxColumn.Name = "ogrenciSoyadDataGridViewTextBoxColumn";
            this.ogrenciSoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrenciMailDataGridViewTextBoxColumn
            // 
            this.ogrenciMailDataGridViewTextBoxColumn.DataPropertyName = "OgrenciMail";
            this.ogrenciMailDataGridViewTextBoxColumn.HeaderText = "OgrenciMail";
            this.ogrenciMailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrenciMailDataGridViewTextBoxColumn.Name = "ogrenciMailDataGridViewTextBoxColumn";
            this.ogrenciMailDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrenciDogDataGridViewTextBoxColumn
            // 
            this.ogrenciDogDataGridViewTextBoxColumn.DataPropertyName = "OgrenciDog";
            this.ogrenciDogDataGridViewTextBoxColumn.HeaderText = "OgrenciDog";
            this.ogrenciDogDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrenciDogDataGridViewTextBoxColumn.Name = "ogrenciDogDataGridViewTextBoxColumn";
            this.ogrenciDogDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrenciBolumDataGridViewTextBoxColumn
            // 
            this.ogrenciBolumDataGridViewTextBoxColumn.DataPropertyName = "OgrenciBolum";
            this.ogrenciBolumDataGridViewTextBoxColumn.HeaderText = "OgrenciBolum";
            this.ogrenciBolumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrenciBolumDataGridViewTextBoxColumn.Name = "ogrenciBolumDataGridViewTextBoxColumn";
            this.ogrenciBolumDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrenciSinifDataGridViewTextBoxColumn
            // 
            this.ogrenciSinifDataGridViewTextBoxColumn.DataPropertyName = "OgrenciSinif";
            this.ogrenciSinifDataGridViewTextBoxColumn.HeaderText = "OgrenciSinif";
            this.ogrenciSinifDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrenciSinifDataGridViewTextBoxColumn.Name = "ogrenciSinifDataGridViewTextBoxColumn";
            this.ogrenciSinifDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrenciKayitDataGridViewTextBoxColumn
            // 
            this.ogrenciKayitDataGridViewTextBoxColumn.DataPropertyName = "OgrenciKayit";
            this.ogrenciKayitDataGridViewTextBoxColumn.HeaderText = "OgrenciKayit";
            this.ogrenciKayitDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrenciKayitDataGridViewTextBoxColumn.Name = "ogrenciKayitDataGridViewTextBoxColumn";
            this.ogrenciKayitDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblOgrenciKayitBindingSource
            // 
            this.tblOgrenciKayitBindingSource.DataMember = "Tbl_OgrenciKayit";
            this.tblOgrenciKayitBindingSource.DataSource = this.ogrenciVeriTabaniDataSet1;
            // 
            // ogrenciVeriTabaniDataSet1
            // 
            this.ogrenciVeriTabaniDataSet1.DataSetName = "OgrenciVeriTabaniDataSet1";
            this.ogrenciVeriTabaniDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_OgrenciKayitTableAdapter
            // 
            this.tbl_OgrenciKayitTableAdapter.ClearBeforeFill = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(813, 628);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(253, 24);
            this.label10.TabIndex = 9;
            this.label10.Text = "Belemir Eda Çolak 222503049";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1116, 654);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOgrenciKayitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciVeriTabaniDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtimeDogum;
        private System.Windows.Forms.DateTimePicker dtimeKayit;
        private System.Windows.Forms.ComboBox cmbSinif;
        private System.Windows.Forms.TextBox txtBolum;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private OgrenciVeriTabaniDataSet1 ogrenciVeriTabaniDataSet1;
        private System.Windows.Forms.BindingSource tblOgrenciKayitBindingSource;
        private OgrenciVeriTabaniDataSet1TableAdapters.Tbl_OgrenciKayitTableAdapter tbl_OgrenciKayitTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciDogDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciBolumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciSinifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciKayitDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label10;
    }
}

