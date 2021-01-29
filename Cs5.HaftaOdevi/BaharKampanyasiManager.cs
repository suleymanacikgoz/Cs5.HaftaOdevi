using System;
using System.Collections.Generic;
using System.Text;

namespace Cs5.HaftaOdevi
{
    class BaharKampanyasiManager : IKampanyaServiceInterface
    {
        public void IadeEt(Gamer gamer)
        {
            Console.WriteLine(gamer.Adi+" adlı oyuncu bahar kampanyasından alışveriş yaptı");
        }

        public void SatisYap(Gamer gamer)
        {
            Console.WriteLine(gamer.Adi + " adlı oyuncu bahar kampanyasından iade işlemi yaptı");

        }
    }
}
