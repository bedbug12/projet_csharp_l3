using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_csharp_l3.repository
{
    public class BaseRepository
    {
        private string connexionString;

        public string ConnexionString { get => connexionString; set => connexionString = value; }
    }
}
