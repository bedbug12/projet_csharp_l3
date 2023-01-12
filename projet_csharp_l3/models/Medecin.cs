using projet_csharp_l3.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_csharp_l3.models
{
    public class Medecin:User
    {
        private string grade;
        public string Grade { get => grade; set => grade = value; }


        public MedecinDto toMedecinDto()
        {
            return new MedecinDto()
            {
                Id = this.Id,
                NomComplet=this.NomComplet,
                Grade=this.Grade,

            };
        }

        public override string ToString()
        {
            return NomComplet;
        }
    }
}
