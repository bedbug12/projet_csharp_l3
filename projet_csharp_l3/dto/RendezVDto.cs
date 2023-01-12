using projet_csharp_l3.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_csharp_l3.dto
{
    public class RendezVDto
    {
        private int id;
        private string date;
        private Patient patient;
        private Medecin medecin;
        private models.Type type;
        private Etat etat;
        
        public int Id { get => id; set => id = value; }
        public string Date { get => date; set => date = value; }
        public Patient Patient { get => patient; set => patient = value; }
        public Medecin Medecin { get => medecin; set => medecin = value; }
        public Etat Etat { get => etat; set => etat = value; }
        public models.Type Type { get => type; set => type = value; }
    }
}
