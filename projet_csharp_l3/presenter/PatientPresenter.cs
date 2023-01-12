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
    public class PatientPresenter:IPatientPresenter
    {
        IPatientView view;
        IMenuView menuView;
        IRendezVView rendezVView;

        public PatientPresenter(IPatientView view, IMenuView menuView, IRendezVView rendezVView)
        {
            this.view = view;
            this.menuView = menuView;
            this.rendezVView = rendezVView;
            initialize();
            callBackEvent();
            view.Show();

        }

        BindingSource patientListBinding=new BindingSource();
     

        PatientDto patientSelect;
        void initialize()
        {
          
            string date = menuView.SelectedDate;
            patientListBinding.DataSource = FabriqueService.getUserService().GetPatientsDto();

            
            view.setPatientBindingSourceM(patientListBinding);



        }

        void callBackEvent()
        {
            view.showPatientViewEvent += showPatientViewHandle;
            view.selectionLigneDtgvEvent += selectionLigneDtgvHandle;
            view.rechercherPatientEvent += rechercherPatientHandle;
        }

        private void rechercherPatientHandle(object sender, EventArgs e)
        {

            List<RendezV> rendezVs = new List<RendezV>();
            if (!string.IsNullOrWhiteSpace(view.LabelSearch))
            {
                PatientDto patient = FabriqueService.getUserService().searchPatientDto(view.LabelSearch);
                patientListBinding.DataSource = patient;
            }
            else
            {
                patientListBinding.DataSource = FabriqueService.getUserService().GetPatientsDto();
            }
            view.setPatientBindingSourceM(patientListBinding);
        }

        private void showPatientViewHandle(object sender, EventArgs e)
        {

            IPatientFileView patientFileView = PatientFileForm.showView();
            IPatientFilePresenter patientFilePresenter = new PatientFilePresenter(patientFileView,view,rendezVView);
        }

       

        private void selectionLigneDtgvHandle(object sender, EventArgs e)
        {
            patientSelect = patientListBinding.Current as PatientDto;
            if (patientSelect!=null)
            {
                view.Patient = new Patient
                {
                    Id = patientSelect.Id,
                    Code = patientSelect.Code,
                    NomComplet = patientSelect.NomComplet,
                    Antecedent = patientSelect.Antecedent,
                };
            }
         
        }

    
    
}
}
