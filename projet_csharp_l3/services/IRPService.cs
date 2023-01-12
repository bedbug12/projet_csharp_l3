using projet_csharp_l3.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_csharp_l3.services
{
    public interface IRPService
    {
        void annulerRVPrestation();
        void prestationDuJour(string date);
        void prestationDuJour();
        void voirDetailsPrest();
    }
}
