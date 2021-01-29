using System;

namespace Cs5.HaftaOdevi
{
    class YazKampanyasiManager : IKampanyaServiceInterface
    {
        public void SatisYap(Gamer gamer)
        {
            Console.WriteLine(gamer.Adi + " adlı oyuncu bahar kampanyasından alışveriş yaptı");
        }

        public void IadeEt(Gamer gamer)
        {
            Console.WriteLine(gamer.Adi + " adlı oyuncu bahar kampanyasından iade işlemi yaptı");

        }
    }
}
