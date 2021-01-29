using System;
using System.Collections.Generic;
using System.Text;

namespace Cs5.HaftaOdevi
{
    class GamerManager : IGamerService
    {
        public void Ekle(Gamer user)
        {
            Console.WriteLine(user.Adi+" Adlı oyuncu eklendi");
        }

        public void Guncelle(Gamer user)
        {
            Console.WriteLine(user.Adi+" Adlı oyuncu güncellendi");
        }

        public void Sil(Gamer user)
        {
            Console.WriteLine(user.Adi+" adlı oyuncu silindi");
        }
    }
}
