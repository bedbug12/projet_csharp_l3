using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_csharp_l3.models
{
    public enum TypePrestation { Analyse, Radio }
    public class Prestation:RendezV
    {
        private TypePrestation typePrestation;

        public TypePrestation TypePrestation { get => typePrestation; set => typePrestation = value; }
    }
}
