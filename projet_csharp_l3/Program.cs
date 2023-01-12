using projet_csharp_l3.presenter;
using projet_csharp_l3.views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_csharp_l3
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            IConnexionView view = new ConnexionForm();
            IRendezVView rendezVView = new RendezVForm();
            IConnexionPresenter connexionPresenter = new ConnexionPresenter(view,rendezVView);
            Application.Run(view as ConnexionForm);
        }
    }
}
