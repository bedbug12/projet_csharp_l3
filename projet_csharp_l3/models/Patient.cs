using projet_csharp_l3.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_csharp_l3.models
{
    public enum Antecedent { Non, Diabete, Hypertension, Hepatite }
    public class Patient:User
    {
        private string code;
        private Antecedent antecedent;

        public string Code { get => code; set => code = value; }
        public Antecedent Antecedent { get => antecedent; set => antecedent = value; }

        public PatientDto toPatientDto()
        {
            return new PatientDto()
            {
                Id=this.Id,
                NomComplet=this.NomComplet,
                Code=this.Code,
                Antecedent=this.Antecedent,

            };
        }

        public override string ToString()
        {
            return NomComplet;
        }
    }
}
