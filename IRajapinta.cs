using System;

namespace lisatehtava
{
    interface IRajapinta
    {
        DateTime GetPvm();
        string GetAloitus();
        string GetLopetus();
        double GetAjanpituus();
    }
}
