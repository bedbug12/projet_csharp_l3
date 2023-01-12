using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_csharp_l3.models
{
    public class MedecinDispo
    {
        private int id;
        private string date;
        private Medecin medecin;

        public int Id { get => id; set => id = value; }
        public string Date { get => date; set => date = value; }
        public Medecin Medecin { get => medecin; set => medecin = value; }
    }
}
