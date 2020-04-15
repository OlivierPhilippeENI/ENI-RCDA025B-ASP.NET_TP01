using System;
using System.Collections.Generic;
using System.Text;

namespace TP01M02
{
    public abstract class Forme
    {
        public abstract double Aire { get; }
        public abstract double Perimetre { get; }
        public override string ToString()
        {
            return $"Aire = {Aire} Périmètre = {Perimetre}";
        }
    }
}
