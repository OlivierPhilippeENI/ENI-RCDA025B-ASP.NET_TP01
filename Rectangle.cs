using System;
using System.Collections.Generic;
using System.Text;

namespace TP01M02
{
    public class Rectangle : Forme
    {
        public virtual int Largeur { get; set; }
        public int Longueur { get; set; }

        public override double Aire => Largeur * Longueur;

        public override double Perimetre => 2 * Largeur + 2 * Longueur;
        public override string ToString()
        {
            return $"Rectangle de longueur={Longueur} et largeur={Largeur}" + base.ToString();
        }

    }
}
