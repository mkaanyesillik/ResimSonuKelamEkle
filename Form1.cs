using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Data.OleDb;

namespace ResimSonuKelamEkle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKlasorSec_Click(object sender, EventArgs e)
        {
            DialogResult secilen;
            secilen = KlasorYolu.ShowDialog();
            btnDosyaSonuEkle.Enabled = true;
            Directory.CreateDirectory(KlasorYolu.SelectedPath + "\\Temp");


        }

        int b = 0;
        int c = 0;

        void DosyaAdiDegistir()
        {
            DirectoryInfo dosya = new DirectoryInfo(KlasorYolu.SelectedPath);
            FileInfo[] belge = dosya.GetFiles("*.*");
            for (int i = 0; i < belge.Length - 1; i++)
            {

                // MessageBox.Show(item.Name);
                //MessageBox.Show(dataGridView1.Rows[b].Cells[0].Value.ToString() + item.Extension);

                for (int ii = 0; ii < dataGridView1.RowCount - 1; ii++)
                {
                    if (belge[i].Name == dataGridView1.Rows[ii].Cells[0].Value.ToString() + belge[i].Extension)
                    {
                        try
                        {
                            // MessageBox.Show(belge[i].Name + " " + dataGridView1.Rows[ii].Cells[0].Value.ToString() + belge[i].Extension+ dataGridView1.Rows[ii].Cells[1].Value.ToString());
                            File.Move(belge[i].FullName, belge[i].DirectoryName + "\\Temp\\" + dataGridView1.Rows[ii].Cells[1].Value.ToString() + belge[i].Extension);
                            break;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Hata" + ex.ToString(), "Hata");
                        }
                    }
                }
            }

            //foreach (DataGridViewRow item in dataGridView1.Rows)
            //{
            //    try
            //    {
            //        foreach (var eleman in belge)
            //        {
            //            try
            //            {
            //                if (item.Cells[c].Value.ToString() + eleman.Extension == eleman.Name)
            //                {
            //                    if (File.Exists(eleman.DirectoryName + "\\Temp\\" + dataGridView1.Rows[b].Cells[1].Value.ToString() + eleman.Extension))
            //                    {
            //                        
            //                        b++;

            //                    }
            //                    else
            //                    {
            //                        label2.Text = "Dosya Var" + eleman.DirectoryName + "\\Temp\\" + dataGridView1.Rows[b].Cells[1].Value.ToString() + eleman.Extension;
            //                        b++;

            //                    }

            //                }
            //                else
            //                {
            //                    if (b >= dataGridView1.RowCount)
            //                    {
            //                        b = 0;

            //                    }
            //                    else
            //                    {
            //                        b++;
            //                    }
            //                }
            //            }
            //            catch (Exception ex)
            //            {
            //                label2.Text = "Dosya Hatası" + ex;
            //            }

            //        }



            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex + "");
            //        label2.Text = "Dosya Var" + "\\Temp\\" + dataGridView1.Rows[b].Cells[1].Value.ToString();
            //    }

            //}



            //b++;
            // File.Move(eleman.FullName, eleman.FullName + "3");
        }




        private void btnDosyaSonuEkle_Click(object sender, EventArgs e)
        {
            DosyaAdiDegistir();

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Excel Dosyası |*.xlsx";
            file.Title = "Excel Dosyası Seçiniz..";
            if (file.ShowDialog() == DialogResult.OK)
            {
                string DosyaYolu = file.FileName;
                string DosyaAdi = file.SafeFileName;
                try
                {
                    DataTable test = getDataFromXLS(DosyaYolu);
                    if (test != null)
                        dataGridView1.DataSource = test;
                }

                catch
                {

                    MessageBox.Show("Sayfa Adını Kontrol Ediniz");
                }

                btnKlasorSec.Enabled = true;
            }

        }
        private DataTable getDataFromXLS(string strFilePath)
        {

            string strConnectionString = "";
            strConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + strFilePath + ";Extended Properties=\"Excel 12.0 Xml;HDR=YES\"";
            OleDbConnection cnCSV = new OleDbConnection(strConnectionString);
            cnCSV.Open();

            OleDbCommand cmdSelect = new OleDbCommand(@"SELECT * FROM [" + txtSayfaAdi.Text + "$]", cnCSV);
            OleDbDataAdapter daCSV = new OleDbDataAdapter(); daCSV.SelectCommand = cmdSelect;
            DataTable dtCSV = new DataTable();
            daCSV.Fill(dtCSV);
            cnCSV.Close();
            daCSV = null;
            return dtCSV;




        }

        private void btnUzantiDuzenle_Click(object sender, EventArgs e)
        {
            DirectoryInfo dosya = new DirectoryInfo(KlasorYolu.SelectedPath);
            FileInfo[] belge = dosya.GetFiles("*.*");
            foreach (var item in belge)
            {

                try
                {
                    // MessageBox.Show(belge[i].Name + " " + dataGridView1.Rows[ii].Cells[0].Value.ToString() + belge[i].Extension+ dataGridView1.Rows[ii].Cells[1].Value.ToString());
                    File.Move(item.FullName, item.FullName.Replace(txtAranacak.Text, txtDegisecek.Text));

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata" + ex.ToString(), "Hata");
                }


            }


        }

        private void btnBirinciKlasor_Click(object sender, EventArgs e)
        {
            DialogResult secilen;
            secilen = birinciklasor.ShowDialog();

            DirectoryInfo dosya = new DirectoryInfo(birinciklasor.SelectedPath);

            FileInfo[] belge = dosya.GetFiles("*.*");
            int c = 0;
            for (int i = 0; i < belge.Length - 1; i++)
            {
                if (belge[i].Name == "")
                {
                    //MessageBox.Show(belge[i].Name + belge2[c].Name);
                    label3.Text = "Dosya Bulundu" + belge[i].Name;
                    c++;

                }
                else
                {
                    dataGridView1.Rows.Add(belge[i].Name);
                }
            }
        }

        private void btnIkinciKlasor_Click(object sender, EventArgs e)
        {
            DialogResult secilen;
            secilen = ikinciklasor.ShowDialog();
        }

        private void btnFark_Click(object sender, EventArgs e)
        {
            DirectoryInfo dosya = new DirectoryInfo(ikinciklasor.SelectedPath);
            FileInfo[] belge = dosya.GetFiles("*.*");
            for (int i = 0; i < belge.Length - 1; i++)
            {

                // MessageBox.Show(item.Name);
                //MessageBox.Show(dataGridView1.Rows[b].Cells[0].Value.ToString() + item.Extension);

                for (int ii = 0; ii < dataGridView1.RowCount - 1; ii++)
                {
                    if (belge[i].Name !=dataGridView1.Rows[ii].Cells[0].Value.ToString())
                    {
                        try
                        {
                            MessageBox.Show(belge[i].Name);
                                                    // MessageBox.Show(belge[i].Name + " " + dataGridView1.Rows[ii].Cells[0].Value.ToString() + belge[i].Extension+ dataGridView1.Rows[ii].Cells[1].Value.ToString());
                                                    // File.Move(belge[i].FullName, belge[i].DirectoryName + "\\Temp\\" + dataGridView1.Rows[ii].Cells[0].Value.ToString() + belge[i].Extension);
                            break;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Hata" + ex.ToString(), "Hata");
                        }
                    }
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult secilen;
            secilen = KlasorYolu.ShowDialog();
            btnDosyaSonuEkle.Enabled = true;
            Directory.CreateDirectory(KlasorYolu.SelectedPath + "\\Temp");
        }

        private void btnSonaKelimeEkle_Click(object sender, EventArgs e)
        {
            DialogResult secilen;
            secilen = KlasorYolu.ShowDialog();
            btnDosyaSonuEkle.Enabled = true;
            Directory.CreateDirectory(KlasorYolu.SelectedPath + "\\Temp");
        }

        private void btnSonaKelimeEkleBaslat_Click(object sender, EventArgs e)
        {
            if (txtSonaEklenecekKelime.Text==""||txtSonaEklenecekKelime.Text== "Sona Eklenecek Kelimeyi Buraya Yaz")
            {
                MessageBox.Show("Dosyaların Tümünün Sonuna Eklenecek Kelimeyi Yazınız.","Dosya İşlemleri");
            }
            else
            {
                DirectoryInfo dosya = new DirectoryInfo(KlasorYolu.SelectedPath);
                FileInfo[] belge = dosya.GetFiles("*.*");
                foreach (var item in belge)
                {
                    MessageBox.Show(item.FullName + " " + item.FullName.Remove(item.FullName.Length - item.Extension.Length) + txtSonaEklenecekKelime.Text + item.Extension);
                    //File.Move(item.FullName, item.Name + txtSonaEklenecekKelime.Text + item.Extension);
                }
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
