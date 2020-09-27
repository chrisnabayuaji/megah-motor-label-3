namespace Megah_Motor_Label_3_Kolom
{
  partial class frmMain
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
      this.panel1 = new System.Windows.Forms.Panel();
      this.lblAddress = new System.Windows.Forms.Label();
      this.lblTitle = new System.Windows.Forms.Label();
      this.panel2 = new System.Windows.Forms.Panel();
      this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
      this.btnSetting = new System.Windows.Forms.Button();
      this.tblLayoutMain = new System.Windows.Forms.TableLayoutPanel();
      this.label6 = new System.Windows.Forms.Label();
      this.txtHurufMandarin = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.txtKodeJual = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.txtTipeMobil = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtNamaBarang = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.lblAsalBarang = new System.Windows.Forms.Label();
      this.txtAsalBarang = new System.Windows.Forms.TextBox();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.txtKodeMandarin = new System.Windows.Forms.TextBox();
      this.btnKonversi = new System.Windows.Forms.Button();
      this.numJumlahCetak = new System.Windows.Forms.NumericUpDown();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.btnCetak = new System.Windows.Forms.Button();
      this.btnReset = new System.Windows.Forms.Button();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.tableLayoutPanel3.SuspendLayout();
      this.tblLayoutMain.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numJumlahCetak)).BeginInit();
      this.tableLayoutPanel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
      this.panel1.Controls.Add(this.lblAddress);
      this.panel1.Controls.Add(this.lblTitle);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(919, 72);
      this.panel1.TabIndex = 0;
      // 
      // lblAddress
      // 
      this.lblAddress.AutoSize = true;
      this.lblAddress.ForeColor = System.Drawing.Color.White;
      this.lblAddress.Location = new System.Drawing.Point(15, 40);
      this.lblAddress.Name = "lblAddress";
      this.lblAddress.Size = new System.Drawing.Size(543, 13);
      this.lblAddress.TabIndex = 1;
      this.lblAddress.Text = "Jl. Brigjen Katamso No.9, Prawirodirjan, Kec. Gondomanan, Kota Yogyakarta, Daerah" +
    " Istimewa Yogyakarta 55121";
      // 
      // lblTitle
      // 
      this.lblTitle.AutoSize = true;
      this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTitle.ForeColor = System.Drawing.Color.White;
      this.lblTitle.Location = new System.Drawing.Point(12, 9);
      this.lblTitle.Name = "lblTitle";
      this.lblTitle.Size = new System.Drawing.Size(683, 31);
      this.lblTitle.TabIndex = 0;
      this.lblTitle.Text = "PROGRAM CETAK LABEL 3 KOLOM MEGAH MOTOR";
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.tableLayoutPanel3);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel2.Location = new System.Drawing.Point(0, 72);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(919, 45);
      this.panel2.TabIndex = 1;
      // 
      // tableLayoutPanel3
      // 
      this.tableLayoutPanel3.ColumnCount = 2;
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
      this.tableLayoutPanel3.Controls.Add(this.btnSetting, 1, 0);
      this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel3.Name = "tableLayoutPanel3";
      this.tableLayoutPanel3.RowCount = 2;
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.11111F));
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.88889F));
      this.tableLayoutPanel3.Size = new System.Drawing.Size(919, 45);
      this.tableLayoutPanel3.TabIndex = 0;
      // 
      // btnSetting
      // 
      this.btnSetting.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnSetting.Location = new System.Drawing.Point(830, 3);
      this.btnSetting.Name = "btnSetting";
      this.btnSetting.Size = new System.Drawing.Size(86, 25);
      this.btnSetting.TabIndex = 0;
      this.btnSetting.Text = "Setting Printer";
      this.btnSetting.UseVisualStyleBackColor = true;
      this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
      // 
      // tblLayoutMain
      // 
      this.tblLayoutMain.ColumnCount = 3;
      this.tblLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.72144F));
      this.tblLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.15887F));
      this.tblLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
      this.tblLayoutMain.Controls.Add(this.label6, 0, 6);
      this.tblLayoutMain.Controls.Add(this.txtHurufMandarin, 1, 5);
      this.tblLayoutMain.Controls.Add(this.label5, 0, 5);
      this.tblLayoutMain.Controls.Add(this.label4, 0, 4);
      this.tblLayoutMain.Controls.Add(this.txtKodeJual, 1, 3);
      this.tblLayoutMain.Controls.Add(this.label3, 0, 3);
      this.tblLayoutMain.Controls.Add(this.txtTipeMobil, 1, 2);
      this.tblLayoutMain.Controls.Add(this.label2, 0, 2);
      this.tblLayoutMain.Controls.Add(this.txtNamaBarang, 1, 1);
      this.tblLayoutMain.Controls.Add(this.label1, 0, 1);
      this.tblLayoutMain.Controls.Add(this.lblAsalBarang, 0, 0);
      this.tblLayoutMain.Controls.Add(this.txtAsalBarang, 1, 0);
      this.tblLayoutMain.Controls.Add(this.tableLayoutPanel1, 1, 4);
      this.tblLayoutMain.Controls.Add(this.numJumlahCetak, 1, 6);
      this.tblLayoutMain.Controls.Add(this.tableLayoutPanel2, 1, 7);
      this.tblLayoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tblLayoutMain.Location = new System.Drawing.Point(0, 117);
      this.tblLayoutMain.Name = "tblLayoutMain";
      this.tblLayoutMain.RowCount = 9;
      this.tblLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
      this.tblLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
      this.tblLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
      this.tblLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
      this.tblLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
      this.tblLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
      this.tblLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
      this.tblLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
      this.tblLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tblLayoutMain.Size = new System.Drawing.Size(919, 414);
      this.tblLayoutMain.TabIndex = 3;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(3, 270);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(212, 45);
      this.label6.TabIndex = 12;
      this.label6.Text = "JUMLAH CETAK";
      this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txtHurufMandarin
      // 
      this.txtHurufMandarin.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txtHurufMandarin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtHurufMandarin.Location = new System.Drawing.Point(221, 228);
      this.txtHurufMandarin.Name = "txtHurufMandarin";
      this.txtHurufMandarin.Size = new System.Drawing.Size(602, 38);
      this.txtHurufMandarin.TabIndex = 11;
      this.txtHurufMandarin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtHurufMandarin_KeyDown);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(3, 225);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(212, 45);
      this.label5.TabIndex = 10;
      this.label5.Text = "HURUF MANDARIN";
      this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(3, 180);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(212, 45);
      this.label4.TabIndex = 8;
      this.label4.Text = "KODE MANDARIN";
      this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txtKodeJual
      // 
      this.txtKodeJual.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txtKodeJual.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtKodeJual.Location = new System.Drawing.Point(221, 138);
      this.txtKodeJual.Name = "txtKodeJual";
      this.txtKodeJual.Size = new System.Drawing.Size(602, 38);
      this.txtKodeJual.TabIndex = 7;
      this.txtKodeJual.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKodeJual_KeyDown);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(3, 135);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(212, 45);
      this.label3.TabIndex = 6;
      this.label3.Text = "KODE JUAL";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txtTipeMobil
      // 
      this.txtTipeMobil.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txtTipeMobil.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtTipeMobil.Location = new System.Drawing.Point(221, 93);
      this.txtTipeMobil.Name = "txtTipeMobil";
      this.txtTipeMobil.Size = new System.Drawing.Size(602, 38);
      this.txtTipeMobil.TabIndex = 5;
      this.txtTipeMobil.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTipeMobil_KeyDown);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(3, 90);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(212, 45);
      this.label2.TabIndex = 4;
      this.label2.Text = "TIPE MOBIL";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txtNamaBarang
      // 
      this.txtNamaBarang.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txtNamaBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtNamaBarang.Location = new System.Drawing.Point(221, 48);
      this.txtNamaBarang.Name = "txtNamaBarang";
      this.txtNamaBarang.Size = new System.Drawing.Size(602, 38);
      this.txtNamaBarang.TabIndex = 3;
      this.txtNamaBarang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNamaBarang_KeyDown);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(3, 45);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(212, 45);
      this.label1.TabIndex = 2;
      this.label1.Text = "NAMA BARANG";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // lblAsalBarang
      // 
      this.lblAsalBarang.AutoSize = true;
      this.lblAsalBarang.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lblAsalBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblAsalBarang.Location = new System.Drawing.Point(3, 0);
      this.lblAsalBarang.Name = "lblAsalBarang";
      this.lblAsalBarang.Size = new System.Drawing.Size(212, 45);
      this.lblAsalBarang.TabIndex = 0;
      this.lblAsalBarang.Text = "ASAL BARANG";
      this.lblAsalBarang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txtAsalBarang
      // 
      this.txtAsalBarang.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txtAsalBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtAsalBarang.Location = new System.Drawing.Point(221, 3);
      this.txtAsalBarang.Name = "txtAsalBarang";
      this.txtAsalBarang.Size = new System.Drawing.Size(602, 38);
      this.txtAsalBarang.TabIndex = 1;
      this.txtAsalBarang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAsalBarang_KeyDown);
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
      this.tableLayoutPanel1.Controls.Add(this.txtKodeMandarin, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.btnKonversi, 1, 0);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(218, 180);
      this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 1;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(608, 45);
      this.tableLayoutPanel1.TabIndex = 9;
      // 
      // txtKodeMandarin
      // 
      this.txtKodeMandarin.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txtKodeMandarin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtKodeMandarin.Location = new System.Drawing.Point(3, 3);
      this.txtKodeMandarin.Name = "txtKodeMandarin";
      this.txtKodeMandarin.Size = new System.Drawing.Size(442, 38);
      this.txtKodeMandarin.TabIndex = 8;
      this.txtKodeMandarin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKodeMandarin_KeyDown);
      // 
      // btnKonversi
      // 
      this.btnKonversi.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnKonversi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnKonversi.Location = new System.Drawing.Point(451, 3);
      this.btnKonversi.Name = "btnKonversi";
      this.btnKonversi.Size = new System.Drawing.Size(154, 39);
      this.btnKonversi.TabIndex = 9;
      this.btnKonversi.Text = "KONVERSI";
      this.btnKonversi.UseVisualStyleBackColor = true;
      this.btnKonversi.Click += new System.EventHandler(this.btnKonversi_Click);
      // 
      // numJumlahCetak
      // 
      this.numJumlahCetak.Dock = System.Windows.Forms.DockStyle.Fill;
      this.numJumlahCetak.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.numJumlahCetak.Location = new System.Drawing.Point(221, 273);
      this.numJumlahCetak.Name = "numJumlahCetak";
      this.numJumlahCetak.Size = new System.Drawing.Size(602, 38);
      this.numJumlahCetak.TabIndex = 13;
      this.numJumlahCetak.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numJumlahCetak_KeyDown);
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.ColumnCount = 3;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
      this.tableLayoutPanel2.Controls.Add(this.btnCetak, 0, 0);
      this.tableLayoutPanel2.Controls.Add(this.btnReset, 1, 0);
      this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel2.Location = new System.Drawing.Point(218, 315);
      this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 1;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(608, 45);
      this.tableLayoutPanel2.TabIndex = 14;
      // 
      // btnCetak
      // 
      this.btnCetak.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnCetak.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnCetak.Location = new System.Drawing.Point(3, 3);
      this.btnCetak.Name = "btnCetak";
      this.btnCetak.Size = new System.Drawing.Size(176, 39);
      this.btnCetak.TabIndex = 0;
      this.btnCetak.Text = "CETAK";
      this.btnCetak.UseVisualStyleBackColor = true;
      this.btnCetak.Click += new System.EventHandler(this.btnCetak_Click);
      // 
      // btnReset
      // 
      this.btnReset.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnReset.Location = new System.Drawing.Point(185, 3);
      this.btnReset.Name = "btnReset";
      this.btnReset.Size = new System.Drawing.Size(176, 39);
      this.btnReset.TabIndex = 1;
      this.btnReset.Text = "RESET";
      this.btnReset.UseVisualStyleBackColor = true;
      this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
      // 
      // frmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(919, 531);
      this.Controls.Add(this.tblLayoutMain);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "frmMain";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "PROGRAM CETAK LABEL 3 KOLOM MEGAH MOTOR";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.tableLayoutPanel3.ResumeLayout(false);
      this.tblLayoutMain.ResumeLayout(false);
      this.tblLayoutMain.PerformLayout();
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numJumlahCetak)).EndInit();
      this.tableLayoutPanel2.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblAddress;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.TableLayoutPanel tblLayoutMain;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox txtHurufMandarin;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtKodeJual;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtTipeMobil;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtNamaBarang;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label lblAsalBarang;
    private System.Windows.Forms.TextBox txtAsalBarang;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.TextBox txtKodeMandarin;
    private System.Windows.Forms.Button btnKonversi;
    private System.Windows.Forms.NumericUpDown numJumlahCetak;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.Button btnCetak;
    private System.Windows.Forms.Button btnReset;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    private System.Windows.Forms.Button btnSetting;
  }
}

