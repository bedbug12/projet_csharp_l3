using projet_csharp_l3.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_csharp_l3.views
{
    public partial class RendezVForm : Form,IRendezVView
    {
        public RendezVForm()
        {
            InitializeComponent();
            btnAddRV.Click += delegate { planifierRVEvent.Invoke(this, EventArgs.Empty); };
            btnValide.Click += delegate { validerRVEvent.Invoke(this, EventArgs.Empty); };
            btnRM.Click += delegate { annulerRVEvent.Invoke(this, EventArgs.Empty); };
            btnFiltre.Click += delegate { rechercherPatientEvent.Invoke(this, EventArgs.Empty); };
            dtgvRV.SelectionChanged += delegate { selectionLigneDtgvEvent.Invoke(this, EventArgs.Empty); };
            btnView.Click += delegate { showConsultationViewEvent.Invoke(this, EventArgs.Empty); };
        }



        public string LabelSearch { get => txtSearch.Text; set => throw new NotImplementedException(); }
        public RendezV RendezV { get ; set; }
        public Button BtnAdd { get => btnAddRV; set => throw new NotImplementedException(); }
        public Button BtnValide { get => btnValide; set => throw new NotImplementedException(); }
        public Button BtnRM { get => btnRM; set => throw new NotImplementedException(); }
        public Button BtnFiltre { get => btnFiltre; set => throw new NotImplementedException(); }
        public Button BtnView { get => btnView; set => throw new NotImplementedException(); }
        public DataGridView DataGridMedDispo { get => dtgvMedDisp; set => throw new NotImplementedException(); }

        public event EventHandler validerRVEvent;
        public event EventHandler planifierRVEvent;
        public event EventHandler annulerRVEvent;
        public event EventHandler rechercherPatientEvent;
        public event EventHandler selectionLigneDtgvEvent;
        public event EventHandler showConsultationViewEvent;

        private static RendezVForm view = null;
        public static RendezVForm showView(Form parent)
        {
            if (parent.ActiveMdiChild != null)
            {
                parent.ActiveMdiChild.Hide();
            }
            if (view == null)
            {
                view = new RendezVForm();
                view.MdiParent = parent;
            }

            return view;
        }




        public void setRendezVBindingSourceM(BindingSource medecinList)
        {
            dtgvRV.DataSource=medecinList;
        }

        public void setRendezVBindingSourceS(BindingSource SecretList, BindingSource medecinDispo)
        {
            dtgvRV.DataSource = SecretList;
            dtgvMedDisp.DataSource = medecinDispo;
        }

        public void setRendezVBindingSourceRP(BindingSource RPList)
        {
            dtgvRV.DataSource = RPList;
        }
    }
}
