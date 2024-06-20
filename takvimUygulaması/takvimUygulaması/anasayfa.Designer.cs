
namespace takvimUygulaması
{
    partial class anasayfa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anasayfa));
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.notlarTableAdapter = new takvimUygulaması.takvimDataSet1TableAdapters.notlarTableAdapter();
            this.kaydet_buton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bitisDakikaBilgi = new System.Windows.Forms.NumericUpDown();
            this.bitisSaatBilgi = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.sil_Buton = new System.Windows.Forms.Button();
            this.guncelle_buton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dakikaBilgi = new System.Windows.Forms.NumericUpDown();
            this.saatBİlgi = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.takvimDataSet1 = new takvimUygulaması.takvimDataSet1();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.açToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bitisDakikaBilgi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitisSaatBilgi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dakikaBilgi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saatBİlgi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.takvimDataSet1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notlarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.monthCalendar1.Location = new System.Drawing.Point(18, 18);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.MonthlyBoldedDates = new System.DateTime[] {
        new System.DateTime(2023, 5, 6, 17, 52, 52, 0)};
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 273);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(755, 344);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kaydedilmiş Notlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AntiqueWhite;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(7, 33);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridView1.Size = new System.Drawing.Size(745, 296);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // notlarTableAdapter
            // 
            this.notlarTableAdapter.ClearBeforeFill = true;
            // 
            // kaydet_buton
            // 
            this.kaydet_buton.Location = new System.Drawing.Point(14, 193);
            this.kaydet_buton.Name = "kaydet_buton";
            this.kaydet_buton.Size = new System.Drawing.Size(68, 33);
            this.kaydet_buton.TabIndex = 2;
            this.kaydet_buton.Text = "Not Ekle";
            this.kaydet_buton.UseVisualStyleBackColor = true;
            this.kaydet_buton.Click += new System.EventHandler(this.kaydet_buton_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.bitisDakikaBilgi);
            this.panel2.Controls.Add(this.bitisSaatBilgi);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.sil_Buton);
            this.panel2.Controls.Add(this.guncelle_buton);
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Controls.Add(this.dakikaBilgi);
            this.panel2.Controls.Add(this.saatBİlgi);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.kaydet_buton);
            this.panel2.Location = new System.Drawing.Point(264, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(503, 239);
            this.panel2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Bitiş Saati:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Başlangıç Saati :";
            // 
            // bitisDakikaBilgi
            // 
            this.bitisDakikaBilgi.Location = new System.Drawing.Point(148, 68);
            this.bitisDakikaBilgi.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.bitisDakikaBilgi.Name = "bitisDakikaBilgi";
            this.bitisDakikaBilgi.Size = new System.Drawing.Size(45, 20);
            this.bitisDakikaBilgi.TabIndex = 13;
            // 
            // bitisSaatBilgi
            // 
            this.bitisSaatBilgi.Location = new System.Drawing.Point(97, 68);
            this.bitisSaatBilgi.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.bitisSaatBilgi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bitisSaatBilgi.Name = "bitisSaatBilgi";
            this.bitisSaatBilgi.Size = new System.Drawing.Size(45, 20);
            this.bitisSaatBilgi.TabIndex = 12;
            this.bitisSaatBilgi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Toplantı",
            "İlaç",
            "Seminer",
            "Sınav"});
            this.comboBox1.Location = new System.Drawing.Point(14, 94);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(178, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // sil_Buton
            // 
            this.sil_Buton.Enabled = false;
            this.sil_Buton.Location = new System.Drawing.Point(162, 193);
            this.sil_Buton.Name = "sil_Buton";
            this.sil_Buton.Size = new System.Drawing.Size(52, 33);
            this.sil_Buton.TabIndex = 10;
            this.sil_Buton.Text = "Sil";
            this.sil_Buton.UseVisualStyleBackColor = true;
            this.sil_Buton.Click += new System.EventHandler(this.sil_Buton_Click);
            // 
            // guncelle_buton
            // 
            this.guncelle_buton.Enabled = false;
            this.guncelle_buton.Location = new System.Drawing.Point(88, 193);
            this.guncelle_buton.Name = "guncelle_buton";
            this.guncelle_buton.Size = new System.Drawing.Size(68, 33);
            this.guncelle_buton.TabIndex = 9;
            this.guncelle_buton.Text = "Güncelle";
            this.guncelle_buton.UseVisualStyleBackColor = true;
            this.guncelle_buton.Click += new System.EventHandler(this.guncelle_buton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(220, 14);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(274, 212);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // dakikaBilgi
            // 
            this.dakikaBilgi.Location = new System.Drawing.Point(148, 43);
            this.dakikaBilgi.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.dakikaBilgi.Name = "dakikaBilgi";
            this.dakikaBilgi.Size = new System.Drawing.Size(45, 20);
            this.dakikaBilgi.TabIndex = 7;
            // 
            // saatBİlgi
            // 
            this.saatBİlgi.Location = new System.Drawing.Point(97, 43);
            this.saatBİlgi.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.saatBİlgi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.saatBİlgi.Name = "saatBİlgi";
            this.saatBİlgi.Size = new System.Drawing.Size(45, 20);
            this.saatBİlgi.TabIndex = 6;
            this.saatBİlgi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(14, 14);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(178, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // takvimDataSet1
            // 
            this.takvimDataSet1.DataSetName = "takvimDataSet1";
            this.takvimDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.açToolStripMenuItem,
            this.kapatToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(105, 48);
            // 
            // açToolStripMenuItem
            // 
            this.açToolStripMenuItem.Name = "açToolStripMenuItem";
            this.açToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.açToolStripMenuItem.Text = "Aç";
            this.açToolStripMenuItem.Click += new System.EventHandler(this.açToolStripMenuItem_Click);
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.kapatToolStripMenuItem.Text = "Kapat";
            this.kapatToolStripMenuItem.Click += new System.EventHandler(this.kapatToolStripMenuItem_Click);
            // 
            // notlarBindingSource
            // 
            this.notlarBindingSource.DataMember = "notlar";
            // 
            // anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(783, 629);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.monthCalendar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(799, 668);
            this.MinimumSize = new System.Drawing.Size(799, 668);
            this.Name = "anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anasayfa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.anasayfa_FormClosing);
            this.Load += new System.EventHandler(this.anasayfa_Load);
            this.Resize += new System.EventHandler(this.anasayfa_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bitisDakikaBilgi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitisSaatBilgi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dakikaBilgi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saatBİlgi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.takvimDataSet1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.notlarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource notlarBindingSource;
        private takvimDataSet1TableAdapters.notlarTableAdapter notlarTableAdapter;
        private System.Windows.Forms.Button kaydet_buton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.NumericUpDown saatBİlgi;
        private System.Windows.Forms.NumericUpDown dakikaBilgi;
        private System.Windows.Forms.Button sil_Buton;
        private System.Windows.Forms.Button guncelle_buton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.NumericUpDown bitisDakikaBilgi;
        private System.Windows.Forms.NumericUpDown bitisSaatBilgi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private takvimDataSet1 takvimDataSet1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem açToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
    }
}