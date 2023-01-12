using projet_csharp_l3.dto;
using projet_csharp_l3.models;
using projet_csharp_l3.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_csharp_l3.services
{
    internal class SecretaireService : ISecretaireService
    {
        private IRendezVRepository rendezVRepository;
        private IConsultationAnnuleRepository consultationAnnuleRepository;


        public SecretaireService(IRendezVRepository rendezVRepository, IConsultationAnnuleRepository consultationAnnuleRepository)
        {
            this.rendezVRepository = rendezVRepository;
            this.consultationAnnuleRepository = consultationAnnuleRepository;
        }

        public void ajouterRV(RendezV rdv)
        {

            rendezVRepository.save(rdv);
        }

        public void annulerRV(RendezV rdv)
        {
            consultationAnnuleRepository.save(rdv);
            rendezVRepository.deleteById(rdv.Id);
        }

        public List<RendezV> consultationAnnulerDuJour(string date)
        {
            return consultationAnnuleRepository.findByDate(date);
        }

        public List<RendezV> listerRV()
        {
            return rendezVRepository.findAll();
        }

        public List<RendezV> listerRV(string date)
        {
            return rendezVRepository.findByDate(date);
        }

        public List<RendezVDto> listerRVDto(string date)
        {
            List<RendezV> rendezVs = rendezVRepository.findByDate(date);
            List < RendezVDto > rendezVDtos = new List<RendezVDto>();
            foreach (var rendezV in rendezVs)
            {
                RendezVDto rendezVDto= rendezV.toRendezVDto();
                rendezVDtos.Add(rendezVDto);
            }
            return rendezVDtos;
            
        }

        public RendezV listerRV(string date, int id)
        {
            return rendezVRepository.findByDateAndNom(date,id);
        }

        public List<RendezV> listerRVM(string date)
        {
            return rendezVRepository.findByDateM(date);
        }

        public List<RendezV> listerRVPatient(Patient patient)
        {
            return rendezVRepository.findByPatient(patient);
        }

        public List<RendezV> listerRVRP(string date)
        {
            return rendezVRepository.findByDateRP(date);
        }

        public void medecinDisponibleJour(string date)
        {
            throw new NotImplementedException();
        }

        public void prestationDuJour(string date)
        {
            throw new NotImplementedException();
        }

        public void validerRV(RendezV rdv)
        {
            rendezVRepository.update(rdv);
        }

        public List<RendezVDto> listerRVMDto(string date)
        {
            List<RendezV> rendezVs = rendezVRepository.findByDateM(date);
            List<RendezVDto> rendezVDtos = new List<RendezVDto>();
            foreach (var rendezV in rendezVs)
            {
                RendezVDto rendezVDto = rendezV.toRendezVDto();
                rendezVDtos.Add(rendezVDto);
            }
            return rendezVDtos;
        }

        public List<RendezVDto> listerRVRPDto(string date)
        {
            List<RendezV> rendezVs = rendezVRepository.findByDateRP(date);
            List<RendezVDto> rendezVDtos = new List<RendezVDto>();
            foreach (var rendezV in rendezVs)
            {
                RendezVDto rendezVDto = rendezV.toRendezVDto();
                rendezVDtos.Add(rendezVDto);
            }
            return rendezVDtos;
        }

        List<RendezVDto> ISecretaireService.consultationAnnulerDuJourDto(string date)
        {
            List<RendezV> rendezVs = consultationAnnuleRepository.findByDate(date);
            List<RendezVDto> rendezVDtos = new List<RendezVDto>();
            foreach (var rendezV in rendezVs)
            {
                RendezVDto rendezVDto = rendezV.toRendezVDto();
                rendezVDtos.Add(rendezVDto);
            }
            return rendezVDtos;
        }
    }
}
