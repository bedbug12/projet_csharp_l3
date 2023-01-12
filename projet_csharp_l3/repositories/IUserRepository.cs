
using projet_csharp_l3.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_csharp_l3.repository
{
    public interface IUserRepository
    {
        void Add(Patient user);
        User findByLogin(string login);
        Patient findPatientByCode(string code);
        Patient findByIdP(int id);
        Medecin findByIdM(int id);
        List<Medecin> findByDate(string date);

        List<Patient> findAllPatient();
        List<Patient> findAllPatient(string nomComplet);
    }
}
