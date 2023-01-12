using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_csharp_l3.dto
{
    public class MedecinDto
    {
        private int id;
        private string nomComplet;
        private string grade;

        public int Id { get => id; set => id = value; }
        public string NomComplet { get => nomComplet; set => nomComplet = value; }
        public string Grade { get => grade; set => grade = value; }

        public override string ToString()
        {
            return NomComplet;
        }
    }
}
