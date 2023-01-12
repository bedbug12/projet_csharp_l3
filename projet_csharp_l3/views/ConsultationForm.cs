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
    public partial class ConsultationForm : Form,IConsultationView
    {
        public ConsultationForm()
        {
            InitializeComponent();
            btnOrdenance.Click += delegate { showOrdenanceViewEvent.Invoke(this, EventArgs.Empty); };
        }

        public string LblNom { get => lblNom.Text; set => lblNom.Text=value; }
        public string LblCode { get => lblCode.Text; set => lblCode.Text=value; }
        public string LblAnteced { get => lblAnteced.Text; set => lblAnteced.Text=value; }
        public string LblDate { get => lblDate.Text; set => lblDate.Text=value; }
        public string LblType { get => lblType.Text; set => lblType.Text=value; }

        public event EventHandler showOrdenanceViewEvent;





        private static ConsultationForm view = null;

        public static ConsultationForm showView()
        {
            if (view == null)
            {
                view = new ConsultationForm();
            }
            if (view.IsDisposed)
            {
                view = new ConsultationForm();
            }
            return view;
        }

      
    }
}
