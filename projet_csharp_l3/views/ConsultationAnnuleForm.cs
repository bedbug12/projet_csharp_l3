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
    public partial class ConsultationAnnuleForm : Form,IConsultationAnnuleView
    {
        public ConsultationAnnuleForm()
        {
            InitializeComponent();
           
            btnFiltre.Click += delegate { rechercherPatientEvent.Invoke(this, EventArgs.Empty); };
           
        }



        public string LabelSearch { get => txtSearch.Text; set => throw new NotImplementedException(); }
       


        public event EventHandler rechercherPatientEvent;
      
        private static ConsultationAnnuleForm view = null;
        public static ConsultationAnnuleForm showView(Form parent)
        {
            if (parent.ActiveMdiChild != null)
            {
                parent.ActiveMdiChild.Hide();

            }
            if (view == null)
            {
                view = new ConsultationAnnuleForm();
                view.MdiParent = parent;
            }
            return view;
        }


        public void setRendezVBindingSourceS(BindingSource SecretList)
        {
            dtgvRV.DataSource = SecretList;
        }
    }
}
