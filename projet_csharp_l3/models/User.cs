using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_csharp_l3.models
{
    public enum Role{ Medecin,Patient,Secretaire,RP }
    public class User
    {
        private int id;
        private string nomComplet;
        private string login;
        private string password;
        private Role role;

        public int Id { get => id; set => id = value; }
        public string NomComplet { get => nomComplet; set => nomComplet = value; }
        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = value; }
        public Role Role { get => role; set => role = value; }
        
    }
}
