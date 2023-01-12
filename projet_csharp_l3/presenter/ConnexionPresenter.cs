using projet_csharp_l3.core;
using projet_csharp_l3.models;
using projet_csharp_l3.services;
using projet_csharp_l3.views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_csharp_l3.presenter
{
    public class ConnexionPresenter:IConnexionPresenter
    {
        private IUserService service;
        private IConnexionView view;
        private IRendezVView rendezVView;
        public ConnexionPresenter(IConnexionView view, IRendezVView rendezVView)
        {
            this.view = view;
            service = FabriqueService.getUserService();
            this.view.ConnexionEvent += ConnexionHandler;
            this.rendezVView = rendezVView;
            view.Show();
        }

        private void ConnexionHandler(object sender, EventArgs e)
        {
            string login = view.Login;
            string password = view.Password;
            try
            {
                ModelValidator.validate(new User() { Login = login, Password = password });
                User user = service.SeConnecter(login, password);
                if (user != null)
                {
                    view.IsLoggedIn = true;
                    IMenuView menuView = MenuForm.showView();
                    menuView.UserConnect = user;
                   
                    IMenuPresenter menuPresenter = new MenuPresenter(menuView,rendezVView);
                    view.Hide();
                }
                else
                {
                    view.IsLoggedIn = false;
                    view.Message = "login ou mot de passe incorrect";
                }
            }
            catch (Exception ex)
            {
                view.IsLoggedIn = false;
                view.Message = ex.Message;

            }
           
        }
    }
}
