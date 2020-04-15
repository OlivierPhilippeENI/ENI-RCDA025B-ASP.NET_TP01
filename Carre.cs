using System;
using System.Collections.Generic;
using System.Text;

namespace TP01M02
{
    public class Carre : Rectangle {
        public override int Largeur { get; set; }

        public override string ToString() {
            return $"Carré de coté={Longueur}" + base.ToString();
        }
    }
}
