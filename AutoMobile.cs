using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas2
{
    internal class AutoMobile
    {
        public string merek;
        public string warna;
        public string tipe;

    }
    class MobilSedan: AutoMobile
    {
        public void setMobilSedan(string merek,string warna,string tipe)
        {
            this.merek = merek;
            this.warna = warna;
            this.tipe = tipe;
        }
        public (string, string, string ) getMobilSedan()
        {
            return (merek,warna,tipe);
        }
    }
}
