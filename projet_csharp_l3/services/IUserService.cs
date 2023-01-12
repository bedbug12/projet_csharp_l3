using projet_csharp_l3.dto;
using projet_csharp_l3.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_csharp_l3.services
{
    public interface IUserService
    {

        void ajouterPatient(Patient user);
        List<MedecinDto> listerMedecinDispo(string date);
        User SeConnecter(string login, string password);
        Patient searchPatient(string code);
        PatientDto searchPatientDto(string code);
        Patient findPatient(int id);
        Medecin findMedecin(int id);
        List<Patient> GetPatients();
        List<PatientDto> GetPatientsDto();
        List<Patient> GetPatients(string nomComplet);
    }
}
