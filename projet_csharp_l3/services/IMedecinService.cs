using projet_csharp_l3.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_csharp_l3.services
{
    public interface IMedecinService
    {
        void planifierRV();
        void listerRVConsultation();
        void listerConsultation();
        void annulerConsultation();
        void listerRVConsultation(string date);
        void annulerRVConsultation();
        void searchPatientFile(int id);

       // Patient searchPatient(string code);

        void voirDetailsConsultation();
    }
}
