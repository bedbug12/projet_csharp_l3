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
    public partial class MenuForm : Form,IMenuView
    {
        public MenuForm()
        {
            InitializeComponent();
            btnConsultation.Click += delegate { showConsultationViewEvent.Invoke(this, EventArgs.Empty); };
            btnConsultationAnnuler.Click += delegate { showConsultationAnnulertViewEvent.Invoke(this, EventArgs.Empty); };
            btnPatient.Click += delegate { showPatientViewEvent.Invoke(this, EventArgs.Empty); };
            mcalDate.DateChanged+= delegate { selectedDateEvent.Invoke(this, EventArgs.Empty); };
            btnDeconnexion.Click += delegate { deconnxionEvent.Invoke(this, EventArgs.Empty); };

        }

        public string UserLabel { get => lblUser.Text; set => lblUser.Text=value; }
        public User UserConnect { get; set ; }


        public string Day {get => mcalDate.SelectionStart.Day.ToString();}
        public string Month { get => mcalDate.SelectionStart.Month.ToString(); }
        public string Year { get => mcalDate.SelectionStart.Year.ToString(); }

        public string SelectedDate { get => Year + "-" + Month + "-" + Day; set => throw new NotImplementedException(); }

        public event EventHandler showConsultationViewEvent;
        public event EventHandler showPatientViewEvent;
        public event EventHandler showConsultationAnnulertViewEvent;
        public event EventHandler selectedDateEvent;
        public event EventHandler deconnxionEvent;


        private static MenuForm view = null;
        public static MenuForm showView()
        {
        
            if (view == null)
            {
                view = new MenuForm();
              
            }

            return view;
        }
    }
}
