using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_csharp_l3.views
{
    public interface IAddRVView
    {
        String TxtNom { get; set; }
        String TxtCode { get; set; }
        String CbAntecedent { get; set; }
        String TxtMedcin { get; set; }
        TextBox TxtBoxMedcin { get; set; }
        String TxtDate { get; }
        String TxtType { get; set; }
        String TxtEtat { get; set; }
        DateTimePicker TxtDateFormat { get; }


        void setAntecedentBinding(BindingSource antecedentList, BindingSource typeList, BindingSource etatList);
       
        event EventHandler recherhcerPatientEvent;
        event EventHandler enregistrerRVEvent;


        void Show();
        void Hide();
    }
}
