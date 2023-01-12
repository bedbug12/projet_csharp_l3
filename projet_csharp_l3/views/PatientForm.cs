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
    public partial class PatientForm : Form,IPatientView
    {
        public PatientForm()
        {
            InitializeComponent();
            dtgvPatient.SelectionChanged += delegate { selectionLigneDtgvEvent.Invoke(this, EventArgs.Empty); };
            btnView.Click += delegate { showPatientViewEvent.Invoke(this, EventArgs.Empty); };
            btnFiltre.Click += delegate { rechercherPatientEvent.Invoke(this, EventArgs.Empty); };
        }



   
        public string LabelSearch { get => txtSearch.Text; set => throw new NotImplementedException(); }
        public Patient Patient { get; set; }



        public event EventHandler showPatientViewEvent;
        public event EventHandler selectionLigneDtgvEvent;
        public event EventHandler rechercherPatientEvent;

        private static PatientForm view = null;
        public static PatientForm showView(Form parent)
        {
            if (parent.ActiveMdiChild != null)
            {
                parent.ActiveMdiChild.Hide();
            }
            if (view == null)
            {
                view = new PatientForm();
                view.MdiParent = parent;
            }
            return view;
        }






        public void setPatientBindingSourceM(BindingSource patientList)
        {
            dtgvPatient.DataSource = patientList;
        }








    }
}
