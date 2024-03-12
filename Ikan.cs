using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas2
{
    internal class Ikan
    {
        public string jenis;
        public string warna;
        public int harga;
    }
    class Ikanairlaut : Ikan
    {
        public void setIkanairlaut(string jenis, string warna, int harga)
        {
            this.jenis = jenis;
            this.warna = warna;
            this.harga = harga;
        }
        public (string, string, int) getIkanairlaut()
        {
            return (jenis, warna, harga);
        }
    }
   
}
