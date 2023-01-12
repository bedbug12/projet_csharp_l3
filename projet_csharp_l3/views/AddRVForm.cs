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
    public partial class AddRVForm : Form,IAddRVView
    {
       
        public AddRVForm()
        {
            InitializeComponent();
            btnSave.Click += delegate { enregistrerRVEvent.Invoke(this, EventArgs.Empty); };
            btnSearch.Click += delegate { recherhcerPatientEvent.Invoke(this, EventArgs.Empty); };
        }

       

      
        public event EventHandler recherhcerPatientEvent;
        public event EventHandler enregistrerRVEvent;

     
        public string TxtNom { get => txtNom.Text; set => txtNom.Text=value; }
        public string TxtCode { get => txtCode.Text; set => txtCode.Text = value; }
        public string CbAntecedent { get => cbAntecedent.Text; set => cbAntecedent.Text = value; }
        public string TxtMedcin { get => txtMedcin.Text; set => txtMedcin.Text = value; }  
        public string TxtDate { get => dtpDate.Text; }
        public TextBox TxtBoxMedcin { get => txtMedcin; set => txtMedcin=value; }

    public DateTimePicker TxtDateFormat { get => dtpDate; }

        public string TxtType { get => cbType.Text; set => cbType.Text = value; }
        public string TxtEtat { get => cbEtat.Text; set => cbEtat.Text = value; }




        private static AddRVForm view = null;
        public static AddRVForm showView()
        {
            if (view == null)
            {
                view = new AddRVForm();
            }
            if (view.IsDisposed)
            {
                view = new AddRVForm();
            }
            return view;
        }





        private void AddRVForm_Load(object sender, EventArgs e)
        {

        }

        public void setAntecedentBinding(BindingSource antecedentList, BindingSource typeList, BindingSource etatList)
        {
            cbAntecedent.DataSource = antecedentList;
            cbType.DataSource = typeList;
            cbEtat.DataSource = etatList;
        }
    }
}
