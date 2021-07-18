using System;

namespace lisatehtava
{
    /*
     Ohjelma kertoo työajan pituuden käyttäjän antamien kellonaikojen perusteella.
    */
    class Program
    {
        static void Main(string[] args)
        {
            UI tyopaiva = new UI();
            tyopaiva.SyotaPaivamaara();
            tyopaiva.SyotaKellonajat();
            tyopaiva.TyopaivanPituus();
        }
    }
}
