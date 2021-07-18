using System;

namespace lisatehtava
{
    class Validointi 
    {
        public DateTime Pvm { get; private set; }

        public bool Validoi(string aloitus, string lopetus)
        {
            TimeSpan ts_aloitus = TimeSpan.Parse(aloitus);
            TimeSpan ts_lopetus = TimeSpan.Parse(lopetus);

            if (ts_aloitus < ts_lopetus)
            {
                return true;
            }
            else
            {
                return false; 
            }
        }
        public DateTime Validoi(string newPvm)
        {
            try
            {
                Pvm = DateTime.Parse(newPvm);
            }
            catch(Exception)
            {
                Pvm = DateTime.Now.Date;
            }

            return Pvm;

        }

        public double LaskeAika(string aloitus, string lopetus)
        {
            var laske_tyoajan_pituus = DateTime.Parse(lopetus) - DateTime.Parse(aloitus);
            var tyoajan_pituus = laske_tyoajan_pituus.TotalHours;
            return tyoajan_pituus;
        }

    }
}
