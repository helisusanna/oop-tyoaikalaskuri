using System;
using System.Text.RegularExpressions;

namespace lisatehtava
{
    abstract class Tyoaika : IRajapinta
    {
        protected DateTime pvm;
        protected string aloitus;
        protected string lopetus;
        protected double tyoajan_pituus;

        Regex tarkista_aika = new Regex(@"^(([0-1][0-9])|([2][0-3])):([0-5][0-9])$");

        protected void SetPvm(string newPvm)
        {
            pvm = new Validointi().Validoi(newPvm);
        }

        protected void SetAloitus(string newAloitus)
        {
            if (tarkista_aika.IsMatch(newAloitus))
            {
                aloitus = newAloitus;
            }   
        }
         
        protected void SetLopetus(string newLopetus)
        {
            if (tarkista_aika.IsMatch(newLopetus))
            {
                lopetus = newLopetus;
            }

            if(aloitus != null && lopetus != null)
            {
                SetAjanpituus(aloitus, lopetus);
            }
            else
            {
                Console.WriteLine("Ajat ovat annettava muodossa HH:MM");
            }
        }

        protected void SetAjanpituus(string aloitus, string lopetus)
        {
            var validi_tyoaika = new Validointi().Validoi(aloitus, lopetus);
            if (validi_tyoaika)
            {
                tyoajan_pituus = new Validointi().LaskeAika(aloitus, lopetus);
            }
            else
            {
                tyoajan_pituus = -1;
            }
        }

        public abstract DateTime GetPvm();
        public abstract string GetAloitus();
        public abstract string GetLopetus(); 
        public abstract double GetAjanpituus();
    }
}
