using System;

namespace lisatehtava
{
    class UI : Tyoaika
    {
        public void SyotaPaivamaara()
        {
            Console.Write("Syötä päivämäärä (DD-MM-YYYY): ");
            base.SetPvm(Console.ReadLine());
        }

        public void SyotaKellonajat()
        {
            Console.Write("Syötä aloitusaika (00:00-23:59): ");
            base.SetAloitus(Console.ReadLine());

            Console.Write("Syötä lopetusaika (00:00-23:59): ");
            base.SetLopetus(Console.ReadLine());
        }

        public void TyopaivanPituus()
        {
            if(GetAjanpituus() < 0 && GetLopetus() != null && GetAloitus() != null)
            {
                Console.WriteLine("Työaika tulee syöttää kronologisessa järjestyksessä");
            } else if (GetLopetus() != null && GetAloitus() != null)
            {
                Console.WriteLine($"Työpäivä alkaa {GetPvm().Add(TimeSpan.Parse(GetAloitus()))}");
                Console.WriteLine($"Työpäivän pituus on {GetAjanpituus()} tuntia.");
            }
        }
        public override DateTime GetPvm()
        {
            return pvm;
        }
        public override string GetAloitus()
        {
            return aloitus;
        }
        public override string GetLopetus()
        {
            return lopetus;
        }
        public override double GetAjanpituus()
        {
            return tyoajan_pituus;
        }
    }
}
