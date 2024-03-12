using System;


namespace tugas2
{
    class Akses
    {
        static void Main(string[] args)
        {
            //akses object dan setvalue
            //Mobil sedan
            MobilSedan mobilSedan = new MobilSedan();
            mobilSedan.setMobilSedan("Toyota", "putih", "camry");

            //Ikan
            Ikanairlaut ikanairlaut = new Ikanairlaut();
            ikanairlaut.setIkanairlaut(" tongkol", "abu abu", 22000);

            //Pioncatur
            Pion pion = new Pion();
            pion.setPion(16, "1 Langkah kedepan");
            Kuda kuda = new Kuda();
            kuda.setKuda(4, "Langkah berbentuk seperti huruf L");
            Raja raja = new Raja();
            raja.setRaja(1, "melangkah 1 petak kemana saja");
            Menteri menteri = new Menteri();
            menteri.setMenteri(2,"langkah kemana saja");
            Bishop bishop = new Bishop();
            bishop.setBishop(4, "melangkah diagonal");
            Benteng benteng = new Benteng();
            benteng.setBenteng(4, "langkah horizontal dan vertikal");

            //RekeningBank
            Mandiri mandiri = new Mandiri();
            mandiri.setMandiri("Mandiri Feby", 1430012345678);
            Bri bri = new Bri();
            bri.setBri("Bri Feby", 002112345678910);

            //getvalue dan pemisah
            //MobilSedan
            (string,string,string) valuesmobilsedan= mobilSedan.getMobilSedan();
            string satumobilsedan = valuesmobilsedan.Item1;
            string duamobilsedan = valuesmobilsedan.Item2;
            string tigamobilsedan = valuesmobilsedan.Item3;

            //Ikan
            (string,string,int) valuesikan=ikanairlaut.getIkanairlaut();
            string satuikan = valuesikan.Item1;
            string duaikan = valuesikan.Item2;
            int tigaikan = valuesikan.Item3;

            // catur
            //pion
            (int, string) valuespion = pion.getPion();
            int satupion = valuespion.Item1;
            string duapion = valuespion.Item2;
            //Kuda
            (int, string) valueskuda = kuda.getKuda();
            int satukuda = valueskuda.Item1;
            string duakuda = valueskuda.Item2;
            //Raja
            (int, string) valuesraja = raja.getRaja();
            int saturaja = valuesraja.Item1;
            string duaraja = valuesraja.Item2;
            //Menteri
            (int, string) valuesmenteri = menteri.getMenteri();
            int satumenteri = valuesmenteri.Item1;
            string duamenteri = valuesmenteri.Item2;
            //Bishop
            (int, string) valuesbishop = bishop.getBishop();
            int satubishop = valuesbishop.Item1;
            string duabishop = valuesbishop.Item2;
            //Benteng
            (int, string) valuesbenteng = benteng.getBenteng();
            int satubenteng = valuesbenteng.Item1;
            string duabenteng = valuesbenteng.Item2;

            //RekeningBank
            //Mandiri
            (string, long) ValuesMandiri= mandiri.getMandiri(); 
            string satuMandiri = ValuesMandiri.Item1;
            long duaMandiri = ValuesMandiri.Item2;

            //Bri
            (string, long) valuesBri = bri.getBri();
            string satuBRI = valuesBri.Item1;
            long duaBRI = valuesBri.Item2;

            //menampilkan konsol
            //mobil sedan
            Console.WriteLine($"Mobil" +
                $"\nMobil Sedan" +
                $"\nMerek : {satumobilsedan}" +
                $"\nWarna : {duamobilsedan}" +
                $"\nTipe : {tigamobilsedan}" +
                $"\n\nIkan" +
                $"\nIkan Air Laut" +
                $"\nJenis : {satuikan}" +
                $"\nWarna : {duaikan}" +
                $"\nHarga : {tigaikan}" +
                $"\n\nCatur" +
                $"\nPion" +
                $"\nJumlah Pion : {satupion}" +
                $"\nLangkah Pion: {duapion}" +
                $"\nKuda" +
                $"\nJumlah Kuda: {satukuda}" +
                $"\nLangkah Kuda : {duakuda}" +
                $"\nRaja" +
                $"\nJumlah Raja : {saturaja}" +
                $"\nLangkah Raja : {duaraja}" +
                $"\nMenteri" +
                $"\nJumlah menteri : {satumenteri}" +
                $"\nLangkah menteri : {duamenteri}" +
                $"\nBishop" +
                $"\nJumlah Bishop : {satubishop}" +
                $"\nLangkah Bishop : {duabishop}" +
                $"\nBenteng" +
                $"\nJumlah Benteng : {satubenteng}" +
                $"\nJumlah Benteng : {duabenteng}" +
                $"\n\nMandiri" +
                $"\nNama : {satuMandiri}" +
                $"\nNorek : {duaMandiri}" +
                $"\nBri" +
                $"\nNama : {satuBRI}" +
                $"\nNorek : {duaBRI}");







        }
    }
}