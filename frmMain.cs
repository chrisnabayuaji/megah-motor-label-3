using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zebra.Sdk.Comm;

namespace Megah_Motor_Label_3_Kolom
{
  public partial class frmMain : Form
  {
    public frmMain()
    {
      InitializeComponent();
    }

    private String angka_cina(int angka)
    {
      String[] digits = { "零", "一", "二", "三", "四", "五", "六", "七", "八", "九" };
      String[] positions = { "", "十", "百", "千", "万", "十万", "百万", "千万", "亿", "十亿", "百亿", "千亿" };
      Char[] charArray = angka.ToString().ToCharArray();
      String result = "";
      bool prevIsZero = false;

      for (int i = 0; i < charArray.Length; i++)
      {
        Char ch = charArray[i];
        if (ch != '0' && !prevIsZero)
        {
          result += digits[(int)Char.GetNumericValue(ch)] + positions[charArray.Length - i - 1];
        }
        else if (ch == '0')
        {
          prevIsZero = true;
        }
        else if (ch != '0' && prevIsZero)
        {
          result += '零' + digits[(int)Char.GetNumericValue(ch)] + positions[charArray.Length - i - 1];
        };

      }
      return result;
    }

    private void txtAsalBarang_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
      {
        txtNamaBarang.Focus();
      }
    }

    private void txtNamaBarang_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Escape)
      {
        txtAsalBarang.Text = "";
        txtAsalBarang.Focus();
      }
      if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
      {
        txtTipeMobil.Focus();
      }
    }

    private void txtTipeMobil_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
      {
        txtKodeJual.Focus();
      }
    }

    private void txtKodeMandarin_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
      {
        txtHurufMandarin.Focus();
      }
    }

    private void txtHurufMandarin_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
      {
        numJumlahCetak.Focus();
      }
    }

    private void btnKonversi_Click(object sender, EventArgs e)
    {
      String kodeMandarin = txtKodeMandarin.Text;
      int value;
      if (int.TryParse(kodeMandarin, out value))
      {
        txtHurufMandarin.Text = angka_cina(int.Parse(kodeMandarin));
      }
      else
      {
        MessageBox.Show("Konversi hanya berupa angka!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }

    private void txtKodeJual_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
      {
        txtKodeMandarin.Focus();
      }
    }

    private void numJumlahCetak_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
      {
        btnCetak.Focus();
      }
    }

    private void btnCetak_Click(object sender, EventArgs e)
    {
      DialogResult result = MessageBox.Show("Apakah anda yakin untuk mencetak?", "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
      if (result == DialogResult.Yes)
      {
        for (int i = 0; i < numJumlahCetak.Value; i++)
        {
          cetak_data();
        }
      }
      reset_data();
    }

    private void cetak_data()
    {
      try
      {
        string text = System.IO.File.ReadAllText("./settings.txt");
        var thePrinterConn = ConnectionBuilder.Build(text);
        try
        {
          // Open the connection - physical connection is established here.
          thePrinterConn.Open();

          // This example prints "This is a ZPL test." near the top of the label.
          string zplData = "^XA" +
            //item id
            "^FO015,21^A0,34,24^FD" + txtKodeJual.Text + "^FS" +
            "^FO300,21^A0,34,24^FD" + txtKodeJual.Text + "^FS" +
            "^FO590,21^A0,34,24^FD" + txtKodeJual.Text + "^FS" +
            //item name 1
            "^FO015,55^A0,34,24^FD" + txtAsalBarang.Text + "^FS" +
            "^FO300,55^A0,34,24^FD" + txtAsalBarang.Text + "^FS" +
            "^FO590,55^A0,34,24^FD" + txtAsalBarang.Text + "^FS" +
            //item name 2
            "^FO015,89^A0,34,24^FD" + txtNamaBarang.Text + "^FS" +
            "^FO300,89^A0,34,24^FD" + txtNamaBarang.Text + "^FS" +
            "^FO590,89^A0,34,24^FD" + txtNamaBarang.Text + "^FS" +
            //item name 3
            "^FO015,123^A0,34,24^FD" + txtTipeMobil.Text + "^FS" +
            "^FO300,123^A0,34,24^FD" + txtTipeMobil.Text + "^FS" +
            "^FO590,123^A0,34,24^FD" + txtTipeMobil.Text + "^FS" +
            //item chinese
            "^FO015,156^CI28^A@N,36,30,E:SIMSUN.FNT^FD" + txtHurufMandarin.Text + "^FS" +
            "^FO300,156^CI28^A@N,36,30,E:SIMSUN.FNT^FD" + txtHurufMandarin.Text + "^FS" +
            "^FO590,156^CI28^A@N,36,30,E:SIMSUN.FNT^FD" + txtHurufMandarin.Text + "^FS" +
            "^XZ";

          // Send the data to printer as a byte array.
          thePrinterConn.Write(Encoding.UTF8.GetBytes(zplData));
        }
        catch (ConnectionException ex)
        {
          // Handle communications error here.
          Console.WriteLine(ex.ToString());
        }
        finally
        {
          // Close the connection to release resources.
          thePrinterConn.Close();
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.ToString(), "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }

    private void btnSetting_Click(object sender, EventArgs e)
    {
      string text = System.IO.File.ReadAllText("./settings.txt");
      string input = Interaction.InputBox("Masukkan nama printer", "Setting Printer", text);
      string dirParameter = AppDomain.CurrentDomain.BaseDirectory + @"\settings.txt";
      FileStream fParameter = new FileStream(dirParameter, FileMode.Create, FileAccess.Write);
      StreamWriter m_WriterParameter = new StreamWriter(fParameter);
      m_WriterParameter.BaseStream.Seek(0, SeekOrigin.End);
      m_WriterParameter.Write(input);
      m_WriterParameter.Flush();
      m_WriterParameter.Close();
    }

    private void btnReset_Click(object sender, EventArgs e)
    {
      reset_data();
    }

    private void reset_data()
    {
      //txtAsalBarang.Text = "";
      txtNamaBarang.Text = "";
      txtTipeMobil.Text = "";
      txtKodeJual.Text = "";
      txtKodeMandarin.Text = "";
      txtHurufMandarin.Text = "";
      numJumlahCetak.Value = 0;
      txtNamaBarang.Focus();
    }
  }
}
