using System;
using System.Collections.Generic;
using System.Text;

namespace TP01M02
{
    public class Cercle : Forme
    {
        public int Rayon { get; set; }

        public override double Aire => Math.PI * Rayon * Rayon;

        public override double Perimetre => 2 * Math.PI * Rayon;

        public override string ToString()
        {
            return $"Cercle de rayon {Rayon}" + base.ToString();
        }
    }
}
