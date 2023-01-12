using gestion_ecole.repository;
using projet_csharp_l3.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_csharp_l3.services
{
    public class MedecinService : IMedecinService
    {
       /* IUserRepository userRepository;

        public MedecinService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }*/

        public void annulerConsultation()
        {
            throw new NotImplementedException();
        }

        public void annulerRVConsultation()
        {
            throw new NotImplementedException();
        }

        public void listerConsultation()
        {
            throw new NotImplementedException();
        }

        public void listerRVConsultation()
        {
            throw new NotImplementedException();
        }

        public void listerRVConsultation(string date)
        {
            throw new NotImplementedException();
        }

        public void planifierRV()
        {
            throw new NotImplementedException();
        }

      /*  public Patient searchPatient(string code)
        {
            return userRepository.findPatientByCode(code);
        }*/

        public void searchPatientFile(int id)
        {
            throw new NotImplementedException();
        }

        public void voirDetailsConsultation()
        {
            throw new NotImplementedException();
        }
    }
}
