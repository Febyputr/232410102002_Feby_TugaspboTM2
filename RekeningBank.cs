using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas2
{
    internal class RekeningBank
    {
        public string nama;
        public long norek;
    }
    class Mandiri : RekeningBank
    {
        public void setMandiri(string nama, long norek)
        {
            this.nama = nama;
            this.norek = norek;
        }
        public (string,long) getMandiri()
        {
            return (nama, norek);
        }

    }
    class Bri : RekeningBank
    {
        public void setBri(string nama, long norek)
        {
            this.nama = nama;
            this.norek = norek;
        }
        public (string, long) getBri()
        {
            return (nama, norek);
        }
    }
}
