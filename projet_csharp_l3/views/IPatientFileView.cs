using projet_csharp_l3.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_csharp_l3.views
{
    public interface IPatientFileView
    {
        string LblNom { get; set; }
        string LblCode { get; set; }
        string LblAnteced { get; set; }
      
        RendezV RendezV { get; set; }

        event EventHandler showConsultationViewEvent;
        event EventHandler selectionLigneDtgvEvent;
        void setRendezVBindingSourceM(BindingSource rvList);

        void Show();
    }
}
