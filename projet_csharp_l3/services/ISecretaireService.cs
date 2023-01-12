using projet_csharp_l3.dto;
using projet_csharp_l3.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_csharp_l3.services
{
    public interface ISecretaireService
    {
        void ajouterRV(RendezV rdv);
      
        List<RendezV> listerRV();
        List<RendezV> listerRVM(string date);
        List<RendezV> listerRVRP(string date);
        List<RendezV> listerRV(string date);
        List<RendezVDto> listerRVMDto(string date);
        List<RendezVDto> listerRVRPDto(string date);
        List<RendezVDto> listerRVDto(string date);
        RendezV listerRV(string date,int id);
        List<RendezV> listerRVPatient(Patient patient);
        void annulerRV(RendezV rdv);
        void validerRV(RendezV rdv);
        void medecinDisponibleJour(string date);
        void prestationDuJour(string date);
        List<RendezV> consultationAnnulerDuJour(string date);
        List<RendezVDto> consultationAnnulerDuJourDto(string date);
    }
}
