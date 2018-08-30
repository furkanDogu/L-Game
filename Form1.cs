using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {

        public DataGridViewCell oncekiCell;
        public DataGridViewCell baslangicNoktasi;
        public int counter=0;
        public string Map;
        public DateTime baslangicZamani;
        public TimeSpan toplamSure;
        public string kullaniciIsmi;
        public PriorityQueue besties;
              
        public Form1()
        {
            besties = new PriorityQueue(999);
            InitializeComponent(); 
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                                      

        }
        public void beyazaCevir()// bir önceki adımdan kalan sarı yerleri tekrar beyaza çeviriyoruz ki doğru alanlar yeniden sarı yapılabilsin.
        {
            for (int i = 0; i < grdOyunAlanı.RowCount; i++) 
            {
                for (int j = 0; j < grdOyunAlanı.ColumnCount; j++)
                {
                    if (grdOyunAlanı.Rows[i].Cells[j].Style.BackColor != Color.GreenYellow)
                        grdOyunAlanı.Rows[i].Cells[j].Style.BackColor = Color.White;
                }
            }
        }
        public void uygunNoktalar(int row, int column) // gidilebilen kareleri belirliyoruz
        {

            beyazaCevir();

            if (row -2 >= 0 && column - 1 >= 0 && grdOyunAlanı.Rows[row - 2].Cells[column - 1].Style.BackColor!=Color.GreenYellow)
                grdOyunAlanı.Rows[row - 2].Cells[column - 1].Style.BackColor = Color.Yellow;

            if (row - 2 >= 0 && column + 1 <= grdOyunAlanı.ColumnCount - 1 && grdOyunAlanı.Rows[row - 2].Cells[column + 1].Style.BackColor!=Color.GreenYellow)
                grdOyunAlanı.Rows[row - 2].Cells[column + 1].Style.BackColor = Color.Yellow;

            if (row + 2 <=grdOyunAlanı.RowCount-1 && column - 1 >=0 && grdOyunAlanı.Rows[row + 2].Cells[column - 1].Style.BackColor!=Color.GreenYellow)
                grdOyunAlanı.Rows[row + 2].Cells[column - 1].Style.BackColor = Color.Yellow;

            if (row + 2 <= grdOyunAlanı.RowCount - 1 && column + 1 <= grdOyunAlanı.ColumnCount - 1 && grdOyunAlanı.Rows[row + 2].Cells[column + 1].Style.BackColor!=Color.GreenYellow)
                grdOyunAlanı.Rows[row + 2].Cells[column + 1].Style.BackColor = Color.Yellow;

            if (row -1 >= 0 && column + 2 <= grdOyunAlanı.ColumnCount - 1 && grdOyunAlanı.Rows[row + -1].Cells[column + 2].Style.BackColor!=Color.GreenYellow)
                grdOyunAlanı.Rows[row + -1].Cells[column + 2].Style.BackColor = Color.Yellow;

            if (row + 1 <= grdOyunAlanı.RowCount - 1 && column + 2 <= grdOyunAlanı.ColumnCount - 1 && grdOyunAlanı.Rows[row + 1].Cells[column + 2].Style.BackColor!=Color.GreenYellow)
                grdOyunAlanı.Rows[row + 1].Cells[column + 2].Style.BackColor = Color.Yellow;

            if (row - 1 >= 0 && column -2 >= 0 && grdOyunAlanı.Rows[row - 1].Cells[column - 2].Style.BackColor!= Color.GreenYellow)
                grdOyunAlanı.Rows[row - 1].Cells[column -2].Style.BackColor = Color.Yellow;

            if (row + 1 <= grdOyunAlanı.RowCount - 1 && column -2 >= 0 && grdOyunAlanı.Rows[row + 1].Cells[column - 2].Style.BackColor!=Color.GreenYellow)
                grdOyunAlanı.Rows[row + 1].Cells[column -2].Style.BackColor = Color.Yellow;

        }
        private void grdOyunAlanı_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int row = grdOyunAlanı.CurrentCell.RowIndex;
            int column = grdOyunAlanı.CurrentCell.ColumnIndex;

            if (baslangicNoktasi != null && grdOyunAlanı.CurrentCell.Style.BackColor == Color.Yellow) // İlk basılan alan için yazı rengini ayarlıyoruz.
            {

                baslangicNoktasi.Style.ForeColor = Color.Red;
                baslangicNoktasi = null;
            }
            else if(grdOyunAlanı.CurrentCell.Style.BackColor == Color.Yellow && baslangicNoktasi==null) // eski adımın font color özelliğini siyah yapıyoruz.
                oncekiCell.Style.ForeColor = Color.Black;
            

            if (grdOyunAlanı.CurrentCell.Style.BackColor == Color.Yellow) // eğer tıklanan hücre sarı ise rakamı yazıp rengini kırmızı yapıyor.
            {              
                this.counter++;
                grdOyunAlanı.CurrentCell.Style.ForeColor = Color.Red;
                grdOyunAlanı.CurrentCell.Style.BackColor = Color.GreenYellow;
                grdOyunAlanı.CurrentCell.Value = counter;
                uygunNoktalar(row, column);
                oncekiCell = grdOyunAlanı.CurrentCell;
            }
            if(oyunBittiMi())
            {
                MessageBox.Show(this.kullaniciIsmi+", oyun bitti lütfen yeniden başlat " + Environment.NewLine + "Skorun : " + counter);
                toplamSure = DateTime.Now.Subtract(this.baslangicZamani);
                besties.Insert(new Skor(counter, this.kullaniciIsmi, toplamSure.ToString(@"hh\:mm\:ss"),this.Map)); 


            }
                
        }
        public bool oyunBittiMi() // alanda sarı alan kalıp kalmadığını kontrol ediyor
        {
            bool isFinished = true;
            for(int i=0;i<grdOyunAlanı.ColumnCount;i++)
            {
                for(int j=0;j<grdOyunAlanı.RowCount;j++)
                {
                    if(grdOyunAlanı.Rows[i].Cells[j].Style.BackColor==Color.Yellow)
                    {
                        isFinished = false;
                        break;
                    }
                }
            }

            return isFinished;
        }
        public void baslangicNoktasiBelirle(int rowCount, int columnCount)
        {
            rowCount = rowCount / 2;  
            columnCount = columnCount / 2;
            grdOyunAlanı.Rows[rowCount].Cells[columnCount].Selected = true;
            grdOyunAlanı.Rows[rowCount].Cells[columnCount].Style.BackColor =Color.Yellow; // başlangıç noktası olarak sarı bir alan açıyoruz.
            this.baslangicNoktasi = grdOyunAlanı.Rows[rowCount].Cells[columnCount]; 

        }

        private void grdOyunAlanı_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            
                if (e.Cell == null || e.StateChanged != DataGridViewElementStates.Selected)
                    return;
            if (e.Cell.Style.BackColor != Color.White) // Seçme rengimiz beyaz olduğu için bizim seçerek yeşil yaptığımız alanların yeşil kalmasını sağlıyoruz.
                e.Cell.Selected = false;
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            this.toplamSure = TimeSpan.Zero;
            this.baslangicZamani = DateTime.Now;
            this.kullaniciIsmi = txtIsim.Text;
            this.counter = 0;
            var checkedButton = grpHarita.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if(checkedButton==null || txtIsim.Text=="")
                MessageBox.Show("Lütfen harita ölçüsü seçip isminizi yazınız !");
            else
                haritayıOlustur(checkedButton.Text);

        }
        public void haritayıOlustur(string whichSize) 
        {
            grdOyunAlanı.Rows.Clear(); // Oyun haritasını temizleyip yeniliyoruz.
            grdOyunAlanı.Refresh();
            int row=0, column=0;
            this.Map = whichSize;
            switch(whichSize)
            {
                case "5x5":
                    row = 5;
                    column = 5;
                    break;
                case "6x6":
                    row = 6;
                    column = 6;
                    break;
                case "7x7":
                    row = 7;
                    column = 7;
                    break;
                case "8x8":
                    row = 8;
                    column = 8;
                    break;
                case "9x9":
                    row = 9;
                    column = 9;
                    break;
                    
            }
            grdOyunAlanı.ColumnCount = column;
            grdOyunAlanı.RowCount = row;
            grdOyunAlanı.Rows[0].Cells[0].Selected = false; // default seçili gelen hücreyi iptal ediyoruz.

            baslangicNoktasiBelirle(grdOyunAlanı.RowCount, grdOyunAlanı.ColumnCount);

            for (int i = 0; i < grdOyunAlanı.Columns.Count; i++) // oyun alanındaki her bir hücrenin ölçüsünü belirliyoruz.
            {
                grdOyunAlanı.Columns[i].Width = 35;
                grdOyunAlanı.Rows[i].Height = 35;
            }
        }

        private void btnSkor_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.besties.tumSkorlariGoster());
        }
    }
}
