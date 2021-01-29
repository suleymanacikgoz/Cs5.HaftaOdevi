using System;

namespace Cs5.HaftaOdevi
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer();
            gamer1.Adi = "Süleyman";
            gamer1.DogumYılı = 2000;
            gamer1.Id = 1;
            gamer1.level = 13;
            gamer1.Soyadi = "Açıkgöz";
            gamer1.nick = "Alaturca_Gamer";
            gamer1.TcNo = "22865212008";
            IKampanyaServiceInterface baharkampanyasi = new BaharKampanyasiManager();
            IKampanyaServiceInterface yazkampanyasi = new YazKampanyasiManager();
            EDevletSorgu edevletSorgu = new EDevletSorgu();

            yazkampanyasi.SatisYap(gamer1);
            edevletSorgu.Dogrulama(gamer1);

        }
    }
}
