using projet_csharp_l3.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_csharp_l3.models
{
    public enum Etat { nonValide, Valide }
    public enum Type { Consultation, Prestation }


    public class RendezV
    {
        private int id;
        private string date;
        private Patient patient;
        private Consultation consultation;
        private Prestation prestation;
        private Medecin medecin;
        private Etat etat;
        private Type type;

        public int Id { get => id; set => id = value; }
        public string Date { get => date; set => date = value; }
        public Patient Patient { get => patient; set => patient = value; }
        public Consultation Consultation { get => consultation; set => consultation = value; }
        public Prestation Prestation { get => prestation; set => prestation = value; }
        public Medecin Medecin { get => medecin; set => medecin = value; }
        public Etat Etat { get => etat; set => etat = value; }
        public Type Type { get => type; set => type = value; }

        public RendezVDto toRendezVDto()
        {
            return new RendezVDto()
            {
                Id = id,
                Date = date,
                Patient = patient,
                Medecin = medecin,
                Etat = etat,
                Type = type,
            };
        }

    }
}
