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
    public class PatientFilePresenter:IPatientFilePresenter
    {
        IPatientFileView view;
        IRendezVView rendezVView;
        IPatientView patientView;

        public PatientFilePresenter(IPatientFileView view, IPatientView patientView, IRendezVView rendezVView)
        {
            this.view = view;
            this.rendezVView = rendezVView;
            this.patientView = patientView;
            iniatilize();
            view.Show();
        }
        BindingSource rvListBinding = new BindingSource();

        Patient patient;

        void iniatilize()
        {
           
            patient=patientView.Patient;
            rvListBinding.DataSource = FabriqueService.getSecretaireService().listerRVPatient(patient);
            view.setRendezVBindingSourceM(rvListBinding);

            view.LblNom = patientView.Patient.NomComplet;
            view.LblAnteced = patientView.Patient.Antecedent.ToString();
            view.LblCode = patientView.Patient.Code;
            view.showConsultationViewEvent += showConsultationViewHandle;
            view.selectionLigneDtgvEvent += selectionLigneDtgvHandle;

        }

        private void showConsultationViewHandle(object sender, EventArgs e)
        {

            IConsultationView consultationView = ConsultationForm.showView();
            IConsultationPresenter consultationPresenter = new ConsultationPresenter(consultationView, rendezVView);
        }

        RendezV rendezVSelect;
        private void selectionLigneDtgvHandle(object sender, EventArgs e)
        {
            rendezVSelect = rvListBinding.Current as RendezV;
            rendezVView.RendezV = rendezVSelect;

        }
    }
}
