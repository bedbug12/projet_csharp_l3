using projet_csharp_l3.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_csharp_l3.views
{
    public interface IRendezVView
    {

        string LabelSearch { get; set; }
        RendezV RendezV { get; set; }
        DataGridView  DataGridMedDispo { get; set; }

        Button BtnAdd { get; set; }
        Button BtnValide { get; set; }
        Button BtnRM { get; set; }
        Button BtnFiltre { get; set; }
        Button BtnView { get; set; }


        event EventHandler validerRVEvent;
        event EventHandler planifierRVEvent;
        event EventHandler annulerRVEvent;
        event EventHandler rechercherPatientEvent;
        event EventHandler selectionLigneDtgvEvent; 
        event EventHandler showConsultationViewEvent;

        void setRendezVBindingSourceM(BindingSource medecinList);
        void setRendezVBindingSourceS(BindingSource SecretList, BindingSource medecinDispo);
        void setRendezVBindingSourceRP(BindingSource RPList);

        void Show();
    }
}
