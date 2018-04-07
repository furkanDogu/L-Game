using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Skor
    {
        public int Puan;
        public string Isim;
        public string Sure;
        public string Map;
        
        public Skor(int Puan,string Isim,string Sure,string Map)
        {
            this.Puan = Puan;
            this.Isim = Isim;
            this.Sure = Sure;
            this.Map = Map;
        }
        public string skorOzellikleriniYaz()
        {
            StringBuilder sp = new StringBuilder();
            sp.Append(this.Isim+"    ");
            sp.Append(this.Puan.ToString() + "      ");
            sp.Append(this.Map + "    ");
            sp.Append(this.Sure);
            return sp.ToString();
        }
    }
}
