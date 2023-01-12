using projet_csharp_l3.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_csharp_l3.views
{
    public interface IConsultationAnnuleView
    {
        string LabelSearch { get; set; }
       
      
        event EventHandler rechercherPatientEvent;
  
        void setRendezVBindingSourceS(BindingSource SecretList);
    
        void Show();
    }
}
