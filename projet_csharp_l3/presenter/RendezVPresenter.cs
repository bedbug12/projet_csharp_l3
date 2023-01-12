using projet_csharp_l3.services;
using projet_csharp_l3.models;
using projet_csharp_l3.views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projet_csharp_l3.dto;

namespace projet_csharp_l3.presenter
{
    public class RendezVPresenter:IRendezVPresenter
    {
         IRendezVView view;
         IMenuView menuView;
        

        public RendezVPresenter(IRendezVView view, IMenuView menuView)
        {
            this.view = view;
            this.menuView = menuView;
            
            initialize();
            callBackEvent();
            view.Show();
            
        }

        
        BindingSource secretListBinding = new BindingSource();
        BindingSource medDispListBinding = new BindingSource();

        RendezV rendezV = new RendezV();
        RendezVDto rendezVSelect;
        string date;



        void isMedecin()
        {
            date = menuView.SelectedDate;
            secretListBinding.DataSource = FabriqueService.getSecretaireService().listerRVMDto(date);
           
            view.setRendezVBindingSourceS(secretListBinding,medDispListBinding);
            view.BtnValide.Enabled= false;
            view.BtnView.Enabled = true;
            view.BtnAdd.Enabled = true;
            view.DataGridMedDispo.Visible = false;
        }
        void isSecret()
        {
            date = menuView.SelectedDate;
            secretListBinding.DataSource = FabriqueService.getSecretaireService().listerRVDto(date);
            medDispListBinding.DataSource = FabriqueService.getUserService().listerMedecinDispo(date);
            view.setRendezVBindingSourceS(secretListBinding,medDispListBinding);
            view.BtnView.Enabled = false;
            view.BtnValide.Enabled = true;
            view.BtnAdd.Enabled = true;
            view.DataGridMedDispo.Visible=true;
        }
        void isRP()
        {
            date = menuView.SelectedDate;
            secretListBinding.DataSource = FabriqueService.getSecretaireService().listerRVRPDto(date);
            view.setRendezVBindingSourceS(secretListBinding, medDispListBinding);
            view.BtnView.Enabled = false;
            view.BtnValide.Enabled = false;
            view.BtnAdd.Enabled = false;
            view.DataGridMedDispo.Visible = false;
        }



      
        void initialize()
        {
            if (menuView.UserConnect.Role==Role.Medecin)
            {
                isMedecin();
            }
            if (menuView.UserConnect.Role == Role.Secretaire)
            {
                isSecret();
            }
            if (menuView.UserConnect.Role == Role.RP)
            {
                isRP();
            }
            view.RendezV = rendezV;

        }

        void callBackEvent()
        {
            view.validerRVEvent += validerRVHandle;
            view.selectionLigneDtgvEvent += selectionLigneDtgvHandle;
            view.rechercherPatientEvent += rechercherPatientHandle;
            view.annulerRVEvent += annulerRVHandle;
            view.planifierRVEvent += planifierRVHandle;
            view.showConsultationViewEvent += showConsultationViewHandle;
        }
       
        private void showConsultationViewHandle(object sender, EventArgs e)
        {
           
            IConsultationView consultationView = ConsultationForm.showView();
            IConsultationPresenter consultationPresenter = new ConsultationPresenter(consultationView, view);
        }

        private void planifierRVHandle(object sender, EventArgs e)
        {
            IAddRVView addRVView = AddRVForm.showView();
            IAddRVPresenter addRVPresenter = new AddRVPresenter(addRVView,menuView);
        }

        private void annulerRVHandle(object sender, EventArgs e)
        {
            try
            {
                FabriqueService.getSecretaireService().annulerRV(view.RendezV);
                MessageBox.Show("Rendez-vous annulé avec succés");
                secretListBinding.RemoveCurrent();
               


            }
            catch (Exception ex)
            {

                throw ex ;
            }
            
        }

        private void rechercherPatientHandle(object sender, EventArgs e)
        {

            List<RendezV> rendezVs=new List<RendezV>();
            if (!string.IsNullOrWhiteSpace(view.LabelSearch))
            {
                List<Patient> patients = FabriqueService.getUserService().GetPatients(view.LabelSearch);
               
                foreach (var patient in patients)
                {
                    rendezVs.Add(FabriqueService.getSecretaireService().listerRV(date,patient.Id));
                }
                secretListBinding.DataSource = rendezVs;
            }
            else
            {
                secretListBinding.DataSource = FabriqueService.getSecretaireService().listerRV(date);
            }
            view.setRendezVBindingSourceS(secretListBinding, medDispListBinding);

        }

        private void selectionLigneDtgvHandle(object sender, EventArgs e)
        {
            rendezVSelect=secretListBinding.Current as RendezVDto;
            if (rendezVSelect != null)
            {
                view.RendezV.Id = rendezVSelect.Id;
                view.RendezV.Date = rendezVSelect.Date;
                view.RendezV.Patient = rendezVSelect.Patient;
                view.RendezV.Medecin = rendezVSelect.Medecin;
                view.RendezV.Etat = rendezVSelect.Etat;
                view.RendezV.Type = rendezVSelect.Type;
            }
           

        }

        private void validerRVHandle(object sender, EventArgs e)
        {
            try
            {
                FabriqueService.getSecretaireService().validerRV(view.RendezV);
                MessageBox.Show("Rendez-vous validé avec succés");
                initialize();
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
