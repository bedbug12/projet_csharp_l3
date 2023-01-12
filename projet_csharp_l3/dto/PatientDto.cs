using projet_csharp_l3.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_csharp_l3.dto
{
    public class PatientDto
    {
        private int id;
        private string code;
        private string nomComplet;
        private Antecedent antecedent;

        public int Id { get => id; set => id = value; }
        public string Code { get => code; set => code = value; }
        public string NomComplet { get => nomComplet; set => nomComplet = value; }
        public Antecedent Antecedent { get => antecedent; set => antecedent = value; }

        public override string ToString()
        {
            return NomComplet;
        }
    }
}
