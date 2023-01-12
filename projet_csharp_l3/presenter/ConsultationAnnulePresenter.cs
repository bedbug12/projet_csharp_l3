using projet_csharp_l3.services;
using projet_csharp_l3.models;
using projet_csharp_l3.views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_csharp_l3.presenter
{
    public class ConsultationAnnulePresenter:IConsultationAnnulePresenter
    {
        IConsultationAnnuleView view;
        IMenuView menuView;


        public ConsultationAnnulePresenter(IConsultationAnnuleView view, IMenuView menuView)
        {
            this.view = view;
            this.menuView = menuView;

            initialize();
            callBackEvent();
            view.Show();

        }       
        BindingSource secretListBinding = new BindingSource();
       

        string date;
        void initialize()
        {
          
            date = menuView.SelectedDate;
            secretListBinding.DataSource = FabriqueService.getSecretaireService().consultationAnnulerDuJourDto(date);
            view.setRendezVBindingSourceS(secretListBinding);



        }

        void callBackEvent()
        {
            view.rechercherPatientEvent += rechercherPatientHandle;
        }

       

        private void rechercherPatientHandle(object sender, EventArgs e)
        {

            List<RendezV> rendezVs = new List<RendezV>();
            if (!string.IsNullOrWhiteSpace(view.LabelSearch))
            {
                List<Patient> patients = FabriqueService.getUserService().GetPatients(view.LabelSearch);

                foreach (var patient in patients)
                {
                    rendezVs.Add(FabriqueService.getSecretaireService().listerRV(date, patient.Id));
                }
                secretListBinding.DataSource = rendezVs;
            }
            else
            {
                secretListBinding.DataSource = FabriqueService.getSecretaireService().listerRV(date);
            }
            view.setRendezVBindingSourceS(secretListBinding);

        }

    }
}
