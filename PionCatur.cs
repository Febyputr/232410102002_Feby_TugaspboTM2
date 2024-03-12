using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas2
{
    internal class PionCatur
    {
        public int jumlah;
        public string langkah;
    }
    class Raja : PionCatur
    {
        public void setRaja(int jumlah, string langkah)
        {
            this.jumlah = jumlah;
            this.langkah = langkah;
        }
        public (int, string) getRaja()
        {
            return (jumlah, langkah);
        }
    }
    class Menteri : PionCatur
    {
        public void setMenteri(int jumlah, string langkah)
        {
            this.jumlah = jumlah;
            this.langkah = langkah;
        }
        public (int, string) getMenteri()
        {
            return (jumlah, langkah);
        }
    }
    class Pion : PionCatur
    {
        public void setPion(int jumlah, string langkah)
        {
            this.jumlah = jumlah;
            this.langkah = langkah;
        }
        public (int, string) getPion()
        {
            return (jumlah, langkah);
        }
    }
    class Bishop : PionCatur
    {
        public void setBishop(int jumlah, string langkah)
        {
            this.jumlah = jumlah;
            this.langkah = langkah;
        }
        public (int, string) getBishop()
        {
            return (jumlah, langkah);
        }
    }
    class Kuda : PionCatur
    {
        public void setKuda(int jumlah, string langkah)
        {
            this.jumlah = jumlah;
            this.langkah = langkah;
        }
        public (int, string) getKuda()
        {
            return (jumlah, langkah);
        }
    }
    class Benteng : PionCatur
    {
        public void setBenteng(int jumlah, string langkah)
        {
            this.jumlah = jumlah;
            this.langkah = langkah;
        }
        public (int, string) getBenteng()
        {
            return (jumlah, langkah);
        }
    }
}