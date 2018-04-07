using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class PriorityQueue
    {
        public int front = -1;
        public int size;
        public int count;
        public Skor[] skorlar;
        

        public PriorityQueue(int size)
        {
            this.size = size;
            this.skorlar = new Skor[size];
            this.count = 0;
        }
        public void Insert(Skor skor)
        {
            if (count == size)
                throw new Exception("Skorlar dolu!");
            if (front == -1)
            {
                skorlar[++front] = skor;
            }
            else
            {
                int i;

                for(i=count-1;i>=0;i--)
                {
                    if (skor.Puan > skorlar[i].Puan)
                        skorlar[i + 1] = skorlar[i];
                    else break;
                }
                skorlar[i + 1] = skor;
                front++;
            }
            count++;
                           
        }      
        public string tumSkorlariGoster()
        {
            
            StringBuilder sp=new StringBuilder();
            sp.Append(" İSİM    SKOR   MAP  SURE"+Environment.NewLine);
            int i = 0;
            while(i<count)
            {
                sp.Append(skorlar[i].skorOzellikleriniYaz()+Environment.NewLine);            
                i ++;
            }

            return sp.ToString();
        }
    }
}
