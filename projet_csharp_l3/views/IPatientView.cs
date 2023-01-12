using projet_csharp_l3.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_csharp_l3.views
{
    public interface IPatientView
    {
        string LabelSearch { get; set; }
        Patient Patient { get; set; }


        event EventHandler showPatientViewEvent;
        event EventHandler selectionLigneDtgvEvent;
        event EventHandler rechercherPatientEvent;
        void setPatientBindingSourceM(BindingSource medecinList);
      

        void Show();
    }
}
