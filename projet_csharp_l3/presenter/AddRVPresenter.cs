using projet_csharp_l3.services;
using projet_csharp_l3.models;
using projet_csharp_l3.views;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_csharp_l3.presenter
{
    public class AddRVPresenter:IAddRVPresenter
    {
        private IAddRVView view;
        private IMenuView menu;

        public AddRVPresenter(IAddRVView view,IMenuView menu)
        {
            this.view = view;
            this.menu = menu;
            intialize();
            view.Show();
        }
        BindingSource antecetdentBinding=new BindingSource();
        BindingSource typeBinding = new BindingSource();
        BindingSource etatBinding = new BindingSource();
        List<string> antecetdentList=new List<string>()
        {
            "Non", "Diabete", "Hypertension", "Hepatite"
        };
        List<string> typeList = new List<string>()
        {
           "Consultation", "Prestation"
        };
        List<string> etatList = new List<string>()
        {
            "NonValide", "Valide"
        };

        void intialize()
        {
            antecetdentBinding.DataSource = antecetdentList;
            typeBinding.DataSource = typeList;
            etatBinding.DataSource = etatList;
            view.setAntecedentBinding(antecetdentBinding,typeBinding,etatBinding);
           
            view.recherhcerPatientEvent += recherhcerPatientHandle;
            view.enregistrerRVEvent += enregistrerRVHandle;

            view.TxtMedcin = menu.UserConnect.NomComplet;
            view.TxtBoxMedcin.Enabled = false;
        }

        private void enregistrerRVHandle(object sender, EventArgs e)
        {
            Medecin medecin = menu.UserConnect as Medecin;
           
            string date = view.TxtDate;
            view.TxtDateFormat.CustomFormat = "yyyy-MM-dd";
            string code = view.TxtCode;
            Patient patient = FabriqueService.getUserService().searchPatient(code);
            if (patient != null)
            {
                view.TxtNom = patient.NomComplet;
                view.CbAntecedent = patient.Antecedent.ToString();
            }else 
            {
                string nomComplet = view.TxtNom;
                string antecedent = view.CbAntecedent.ToString();
                patient = new Patient()
                {
                 NomComplet = nomComplet,
                 Code = code,
                 Role=Role.Patient,
                
                };
                Enum.TryParse(antecedent, out Antecedent antecedent2);
                patient.Antecedent=antecedent2;
                FabriqueService.getUserService().ajouterPatient(patient);
            }
            string type = view.TxtType;
            string etat = view.TxtEtat;

            RendezV rdv=new RendezV()
            {
                Date = date,
                Patient = patient,
                Medecin = medecin,
            };
            Enum.TryParse(type, out models.Type type2);
            Enum.TryParse(etat, out Etat etat2);
            rdv.Etat = etat2;
            rdv.Type = type2;
            FabriqueService.getSecretaireService().ajouterRV(rdv);
            view.TxtDateFormat.CustomFormat = "dd/MM/yyyy";
            MessageBox.Show("Rendez-vous ajouté avec succés");
            view.Hide();
        }
        
        private void recherhcerPatientHandle(object sender, EventArgs e)
        {
            string code = view.TxtCode;
            Patient patient = FabriqueService.getUserService().searchPatient(code);

            if (patient!=null)
            {
                view.TxtNom = patient.NomComplet;
                view.CbAntecedent = patient.Antecedent.ToString();
            }
           
        }
    }
}
