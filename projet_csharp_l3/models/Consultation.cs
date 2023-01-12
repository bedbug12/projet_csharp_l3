using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_csharp_l3.models
{
    public class Consultation:RendezV
    {
       
        
        private Ordenance ordenance;
        private string constante;

      
        
        public Ordenance Ordenance { get => ordenance; set => ordenance = value; }
        public string Constante { get => constante; set => constante = value; }
    }
}
