using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_csharp_l3.models
{
    public class Ordenance
    {
        private int id;
        private Medoc medicaments;
        private string posologie;

        public int Id { get => id; set => id = value; }
        public Medoc Medicaments { get => medicaments; set => medicaments = value; }
        public string Posologie { get => posologie; set => posologie = value; }
    }
}
