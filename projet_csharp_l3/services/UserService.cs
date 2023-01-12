using projet_csharp_l3.repository;
using projet_csharp_l3.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projet_csharp_l3.dto;
using projet_csharp_l3.repositories;

namespace projet_csharp_l3.services
{
    public class UserService:IUserService
    {
        IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public void ajouterPatient(Patient user)
        {
            userRepository.Add(user);
        }

        public Medecin findMedecin(int id)
        {
            return userRepository.findByIdM(id);
        }

        public Patient findPatient(int id)
        {
            return userRepository.findByIdP(id);
        }

        public List<Patient> GetPatients()
        {
            return userRepository.findAllPatient();
        }

        public List<Patient> GetPatients(string nomComplet)
        {
            return userRepository.findAllPatient(nomComplet);
        }

        public List<PatientDto> GetPatientsDto()
        {
            List<Patient> patients = userRepository.findAllPatient();
            List<PatientDto> patientDtos = new List<PatientDto>();
            foreach (var patient in patients)
            {
                PatientDto patientDto = patient.toPatientDto();
                patientDtos.Add(patientDto);
            }
            return patientDtos;
        }

        public List<MedecinDto> listerMedecinDispo(string date)
        {
            List<Medecin> medecins = userRepository.findByDate(date);
            List<MedecinDto> medecinDtos = new List<MedecinDto>();
            foreach (var medecin in medecins)
            {
                MedecinDto medecinDto = medecin.toMedecinDto();
                medecinDtos.Add(medecinDto);
            }
            return medecinDtos;
        }

        public Patient searchPatient(string code)
        {
            return userRepository.findPatientByCode(code);
        }

        public PatientDto searchPatientDto(string code)
        {
            return userRepository.findPatientByCode(code).toPatientDto();
        }

        public User SeConnecter(string login, string password)
        {
            User user = userRepository.findByLogin(login);
            return (user == null || user.Password != password) ? null : user;
        }


    }
}
