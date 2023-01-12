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
    public partial class ConnexionForm : Form,IConnexionView
    {
        public ConnexionForm()
        {
            InitializeComponent();
            btnConnexion.Click += delegate { ConnexionEvent.Invoke(this,EventArgs.Empty);
                if (!IsLoggedIn)
                {
                    MessageBox.Show(Message);
                }
            };
        }

        public string Login { get => txtLogin.Text.Trim(); set => txtLogin.Text=value; }
        public string Password { get => txtPassword.Text.Trim(); set => txtPassword.Text = value; }
        public string Message { get ; set ; }
        public bool IsLoggedIn { get; set; }

        public event EventHandler ConnexionEvent;


        private static ConnexionForm view = null;
        public static ConnexionForm showView()
        {

            if (view == null)
            {
                view = new ConnexionForm();

            }

            return view;
        }

        private void FormConnexion_Load(object sender, EventArgs e)
        {

        }
    }
}
