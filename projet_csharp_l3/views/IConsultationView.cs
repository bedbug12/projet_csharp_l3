using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_csharp_l3.views
{
    public interface IConsultationView
    {
        string LblNom { get; set; }
        string LblCode { get; set; }
        string LblAnteced { get; set; }
        string LblDate { get; set; }
        string LblType { get; set; }

        event EventHandler showOrdenanceViewEvent;

        void Show();

    }
}
