using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_csharp_l3.views
{
    public interface IConnexionView
    {
        string Login { get; set; }
        string Password { get; set; }
        string Message { get; set; }
        bool IsLoggedIn { get; set; }

        void Hide();
        void Show();

        event EventHandler ConnexionEvent;
    }
}
