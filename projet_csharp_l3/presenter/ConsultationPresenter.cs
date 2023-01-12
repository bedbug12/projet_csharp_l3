using projet_csharp_l3.views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_csharp_l3.presenter
{
    public class ConsultationPresenter:IConsultationPresenter
    {
        IConsultationView view;
        private IRendezVView rendezVView;

        public ConsultationPresenter(IConsultationView view, IRendezVView rendezVView)
        {
            this.view = view;
            this.rendezVView = rendezVView;
            iniatilize();
            view.Show();
        }

        void iniatilize()
        {
            view.LblDate=rendezVView.RendezV.Date;
            view.LblNom = rendezVView.RendezV.Patient.NomComplet;
            view.LblAnteced = rendezVView.RendezV.Patient.Antecedent.ToString() ;
            view.LblCode = rendezVView.RendezV.Patient.Code;
            view.LblType = rendezVView.RendezV.Type.ToString();
            view.showOrdenanceViewEvent += showOrdenanceViewHanlde;

        }

        private void showOrdenanceViewHanlde(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
