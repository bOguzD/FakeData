using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeData
{
    class Veriler
    {
        Random rnd = new Random();
        public string isimGetir()
        {
            string[] isimler = { "ayşe", "stefan", "john", "amy", "brain", "ahmet", "susan", "agnieszka", "franzi", "fran" };
            int rndm = rnd.Next(0, 10);
            return isimler[rndm];
        }
        public string SoyisimGetir()
        {
            string[] soyisimler = { "can", "ztef", "yerf", "brown", "shou", "sütçü", "prart", "fake", "susan", "holly" };
            int rndm = rnd.Next(0, 10);
            return soyisimler[rndm];
        }
        public string UlkeGetir()
        {
            string[] ulkeler = { "Türkiye", "Polonya", "Almanya", "Romanya", "Litvanya", "Fransa", "Belçika", "Slovakya", "Arnavutluk", "Letonya" };
            int rndm = rnd.Next(0, 10);
            return ulkeler[rndm];
        }
        public int PuanGetir()
        {
            int[] puanlar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int rndm = rnd.Next(0, 10);
            return puanlar[rndm];
        }
    }
}
