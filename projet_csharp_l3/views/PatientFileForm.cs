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
    public partial class PatientFileForm : Form,IPatientFileView
    {
        public PatientFileForm()
        {
            InitializeComponent();
            btnView.Click += delegate { showConsultationViewEvent.Invoke(this, EventArgs.Empty); };
            dtgvRV.SelectionChanged += delegate { selectionLigneDtgvEvent.Invoke(this, EventArgs.Empty); };
        }


        public string LblNom { get => lblNom.Text; set => lblNom.Text = value; }
        public string LblCode { get => lblCode.Text; set => lblCode.Text = value; }
        public string LblAnteced { get => lblAnteced.Text; set => lblAnteced.Text = value; }
       
        public RendezV RendezV { get; set; }

        public event EventHandler showConsultationViewEvent;
        public event EventHandler selectionLigneDtgvEvent;


        public void setRendezVBindingSourceM(BindingSource rvList)
        {
            dtgvRV.DataSource = rvList;
        }



        private static PatientFileForm view = null;

            public static PatientFileForm showView()
            {
                if (view == null)
                {
                    view = new PatientFileForm();
                }
                if (view.IsDisposed)
                {
                    view = new PatientFileForm();
                }
                return view;
            }
    }
}
