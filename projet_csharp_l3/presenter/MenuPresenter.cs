using projet_csharp_l3.views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_csharp_l3.presenter
{
    public class MenuPresenter:IMenuPresenter
    {
        IMenuView view;
        IRendezVView rendezVView;

        public MenuPresenter(IMenuView view, IRendezVView rendezVView)
        {
            this.view=view;
            this.rendezVView = rendezVView;
            iniialize();
            view.Show();
        }

        void iniialize()
        {
            view.UserLabel = view.UserConnect.NomComplet;
            view.showConsultationViewEvent += showConsultationViewHandle;
            view.showPatientViewEvent += showPatientViewHandle;
            view.selectedDateEvent += selectedDateHandle;
            view.deconnxionEvent += deconnxionHandle;
            view.showConsultationAnnulertViewEvent += showConsultationAnnulertViewHandle;
            showConsultationViewHandle(null, EventArgs.Empty);
        }

        private void deconnxionHandle(object sender, EventArgs e)
        {
            IConnexionView connexionView =ConnexionForm.showView();
            IRendezVView rendezVView=new RendezVForm();
            IConnexionPresenter connexionPresenter = new ConnexionPresenter(connexionView, rendezVView);
            view.Hide();
           
        }

        private void showConsultationAnnulertViewHandle(object sender, EventArgs e)
        {
            IConsultationAnnuleView consultationAnnuleView = ConsultationAnnuleForm.showView(view as Form);
            IConsultationAnnulePresenter consultationAnnulePresenter = new ConsultationAnnulePresenter(consultationAnnuleView, view);
        }

        private void showPatientViewHandle(object sender, EventArgs e)
        {
            IPatientView patientView = PatientForm.showView(view as Form);
            IPatientPresenter patientPresenter = new PatientPresenter(patientView,view,rendezVView);
        }

        private void selectedDateHandle(object sender, EventArgs e)
        {
            /*view.UserLabel=view.SelectedDate;*/
            showConsultationViewHandle(null,EventArgs.Empty);
        }

        private void showConsultationViewHandle(object sender, EventArgs e)
        {
            IRendezVView consultationView = RendezVForm.showView(view as Form);
            IRendezVPresenter consultationPresenter = new RendezVPresenter(consultationView,view);

        }
    }
}
