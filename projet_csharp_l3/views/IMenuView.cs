using projet_csharp_l3.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_csharp_l3.views
{
    public interface IMenuView
    {
        string UserLabel { get; set; }

        String SelectedDate { get; set; }

        User UserConnect { get; set; }

        event EventHandler showConsultationViewEvent;
        event EventHandler showPatientViewEvent;
        event EventHandler showConsultationAnnulertViewEvent;
        event EventHandler selectedDateEvent;
        event EventHandler deconnxionEvent;
        void Show();
        void Hide();
    }
}
