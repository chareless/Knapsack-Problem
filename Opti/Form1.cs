using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using dothings = Opti.DoThings;

namespace Opti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            tabloOlustur();
            cokButton.Text = "Çoklu Çalıştır (" + iterasyon.ToString() + ")";
        }
        private void tabloOlustur()
        {
            tabloBir();
            tabloIki();
            tabloUc();
        }

        private void tabloBir()
        {
            cantaListView.Columns.Add("Eşya Adı", 70);
            cantaListView.Columns.Add("Ağırlık", 70);
            cantaListView.Columns.Add("Değer", 70);
        }

        private void tabloIki()
        {
            secilenListView.Columns.Add("Eşya Adı", 70);
            secilenListView.Columns.Add("Ağırlık", 70);
            secilenListView.Columns.Add("Değer", 70);
            secilenListView.Columns.Add("Toplam Ağırlık", 120);
            secilenListView.Columns.Add("Toplam Değer", 120);
        }

        private void tabloUc()
        {
            karsilastirListView.Columns.Add("No", 40);
            karsilastirListView.Columns.Add("Eşyalar", 400);
            karsilastirListView.Columns.Add("Toplam Ağırlık", 120);
            karsilastirListView.Columns.Add("Toplam Değer", 120);
        }


        DoThings dothings = new DoThings();
        private int sinir;
        private static int count = 0;
        private static int no = 0;
        private static int iterasyon = 500;

        public class ListViewItemComparer : IComparer
        {
            private int col;
            private SortOrder order;
            public ListViewItemComparer()
            {
                col = 0;
                order = SortOrder.Ascending;
            }
            public ListViewItemComparer(int column, SortOrder order)
            {
                col = column;
                this.order = order;
            }
            public int Compare(object x, object y)
            {
                int returnVal = -1;
                int intx = 0, inty = 0;
                if (!Int32.TryParse(((ListViewItem)x).SubItems[col].Text, out intx)) intx = 0;
                if (!Int32.TryParse(((ListViewItem)y).SubItems[col].Text, out inty)) inty = 0;
                returnVal = intx.CompareTo(inty);
                if (order == SortOrder.Descending) returnVal *= -1;
                return returnVal;
            }
        }
        private int sortColumn = -1;

        private void randomEsya()
        {
            cantaListView.Clear();
            tabloBir();
            string[] satirlar;
            string[] hepsi = new string[dothings.cisimCount];
            for (int i = 0; i < dothings.cisimCount; i++)
            {
                hepsi[i] = dothings.cisim[i].name + " " + dothings.cisim[i].kg + " " + dothings.cisim[i].deger;
                satirlar = hepsi[i].Split('\n');
                foreach (string s in satirlar)
                {
                    string[] kelimeler = s.Split(' ');
                    var listView1Item = new ListViewItem(kelimeler);
                    cantaListView.Items.Add(listView1Item);
                }
            }
        }

        private void esyaEkle()
        {
            if (degerTextBox.Text != "" && isimTextBox.Text != "" && kiloTextBox.Text != "")
            {
                dothings.cisimOlustur(Convert.ToInt32(degerTextBox.Text), Convert.ToInt32(kiloTextBox.Text), isimTextBox.Text);
                string[] satirlar;
                string hepsi;
                hepsi = dothings.cisim[dothings.cisimCount - 1].name + " " + dothings.cisim[dothings.cisimCount - 1].kg + " " + dothings.cisim[dothings.cisimCount - 1].deger;
                satirlar = hepsi.Split('\n');
                foreach (string s in satirlar)
                {
                    string[] kelimeler = s.Split(' ');
                    var listView1Item = new ListViewItem(kelimeler);
                    cantaListView.Items.Add(listView1Item);
                }
            }
        }

        private void cokEsyaButton_Click(object sender, EventArgs e)
        {
            string[] satirlar;
            string hepsi;
            hepsi = richTextBox1.Text;
            satirlar = hepsi.Split('\n');
            foreach (string s in satirlar)
            {
                string[] kelimeler = s.Split(' ');
                var listViewItem = new ListViewItem(kelimeler);
                cantaListView.Items.Add(listViewItem);
            }
            for (int a = 0; a < cantaListView.Items.Count; a++)
            {
                dothings.cisimOlustur(Convert.ToInt32(cantaListView.Items[a].SubItems[2].Text), Convert.ToInt32(cantaListView.Items[a].SubItems[1].Text), cantaListView.Items[a].SubItems[0].Text);
            }
            richTextBox1.Text = "";
        }

        public void rastgeleSec()
        {
            int[] array = new int[dothings.cisimCount];
            int[] rArray = new int[dothings.cisimCount];
            for(int i=0;i<dothings.cisimCount;i++)
            {
                array[i] = -1;
                rArray[i] = -1;
            }
            int say = 0;
            int toplamkg = 0;
            int toplamd = 0;
            Random rand = new Random();
            bool kontrol = false;
            bool wKontrol = true;
            while(wKontrol)
            {
                while(say!=dothings.cisimCount)
                {
                    int random = rand.Next(0, dothings.cisimCount);

                    if (!rArray.Contains(random))
                    {
                        rArray[say] = random;
                        say++;
                        if (say + 1 == dothings.cisimCount)
                        {
                            wKontrol = false;
                        }
                    }
                }
               
                for(int i=0;i<dothings.cisimCount;i++)
                {
                    if (!array.Contains(rArray[i]))
                    {
                        if (count != dothings.cisimCount)
                        {
                            kontrol = true;
                            toplamd += dothings.cisim[rArray[i]].deger;
                            toplamkg += dothings.cisim[rArray[i]].kg;

                            if (toplamkg <= sinir)
                            {
                                array[count] = rArray[i];
                            }
                            else
                            {
                                toplamd -= dothings.cisim[rArray[i]].deger;
                                toplamkg -= dothings.cisim[rArray[i]].kg;
                                kontrol = false;
                            }
                        }

                        if (kontrol == true && toplamkg <= sinir && count != dothings.cisimCount)
                        {
                            string[] satirlar;
                            string[] hepsi = new string[dothings.cisimCount];
                            hepsi[count] = dothings.cisim[rArray[i]].name + " " + dothings.cisim[rArray[i]].kg + " " + dothings.cisim[rArray[i]].deger + " " + toplamkg + " " + toplamd;
                            satirlar = hepsi[count].Split('\n');
                            foreach (string s in satirlar)
                            {
                                string[] kelimeler = s.Split(' ');
                                var listView2Item = new ListViewItem(kelimeler);
                                secilenListView.Items.Add(listView2Item);
                            }
                            count++;
                        }
                    }
                }
            }
        }

        private void karsilastir()
        {
            string[] satirlar;
            string hepsi;
            string isimler = "";
            int kilolar = 0;
            int degerler = 0;

            for (int a = 0; a < secilenListView.Items.Count; a++)
            {
                no = karsilastirListView.Items.Count + 1;
                isimler += secilenListView.Items[a].SubItems[0].Text.ToString() + ",";
                kilolar += Convert.ToInt32(secilenListView.Items[a].SubItems[1].Text.ToString());
                degerler += Convert.ToInt32(secilenListView.Items[a].SubItems[2].Text.ToString());
            }

            hepsi = no + " " + isimler + " " + kilolar + " " + degerler;
            satirlar = hepsi.Split('\n');

            foreach (string s in satirlar)
            {
                string[] kelimeler = s.Split(' ');
                var listView3Item = new ListViewItem(kelimeler);
                karsilastirListView.Items.Add(listView3Item);
            }
            no++;
        }

        private void esyaSil()
        {
            dothings.cisim.Clear();
            dothings.cisimCount = 0;
            cantaListView.Clear();
            tabloBir();
            esyaEkleButton.Enabled = true;
            randomButton.Enabled = true;
        }

        private void sinirButton_Click(object sender, EventArgs e)
        {
            if (sinirTextBox.Text != "")
            {
                sinir = Convert.ToInt32(sinirTextBox.Text);
                hizliButton.Enabled = true;
                cokButton.Enabled = true;
            }
        }
        private void iterButton_Click(object sender, EventArgs e)
        {
            iterasyon = Convert.ToInt32(iterTextBox.Text);
            cokButton.Text = "Çoklu Çalıştır (" + iterasyon.ToString() + ")";
        }

        private void temizle()
        {
            secilenListView.Clear();
            count = 0;
            no = 0;
            tabloIki();
        }

        private void textBoxTemizle()
        {
            isimTextBox.Text = "";
            degerTextBox.Text = "";
            kiloTextBox.Text = "";
        }
        private void randomTextBoxTemizle()
        {
            rCountTextBox.Text = "";
            rKiloTextBox.Text = "";
            rDegerTextBox.Text = "";
        }

        private void hizliButton_Click(object sender, EventArgs e)
        {
            temizle();
            rastgeleSec();
            karsilastir();
        }

        private void cokButton_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < iterasyon; x++)
            {
                temizle();
                rastgeleSec();
                karsilastir();
            }
        }

        private void sifirlaButton_Click(object sender, EventArgs e)
        {
            esyaSil();
            temizle();
            karsilastirListView.Clear();
            tabloUc();
            textBoxTemizle();
            sinirTextBox.Enabled = true;
            sinirTextBox.Text = "";
            hizliButton.Enabled = false;
            cokButton.Enabled = false;
            richTextBox1.Text = "";
        }

        private void esyaEkleButton_Click(object sender, EventArgs e)
        {
            esyaEkle();
            textBoxTemizle();
        }
        private void randomButton_Click(object sender, EventArgs e)
        {
            if(rCountTextBox.Text!="" && rKiloTextBox.Text!="" && rDegerTextBox.Text!="")
            {
                dothings.randomCreate(Convert.ToInt32(rCountTextBox.Text),Convert.ToInt32(rKiloTextBox.Text),Convert.ToInt32(rDegerTextBox.Text));
                randomEsya();
                randomTextBoxTemizle();
            }
        }
        private void esyaSilButton_Click(object sender, EventArgs e)
        {
            esyaSil();
        }
        private void ListView_ColumnClick(object sender,System.Windows.Forms.ColumnClickEventArgs e)
        {
            if (e.Column != sortColumn)
            {
                sortColumn = e.Column;
                karsilastirListView.Sorting = SortOrder.Ascending;
            }
            else
            {
                if (karsilastirListView.Sorting == SortOrder.Ascending)
                    karsilastirListView.Sorting = SortOrder.Descending;
                else
                    karsilastirListView.Sorting = SortOrder.Ascending;
            }
            karsilastirListView.Sort();
            karsilastirListView.ListViewItemSorter = new ListViewItemComparer(e.Column, karsilastirListView.Sorting);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_bosluk_giremez_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

       
    }
}