using gestion_ecole.repository;
using projet_csharp_l3.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_csharp_l3.repositories
{
    public interface IRendezVRepository:IRepository<RendezV>
    {
        List<RendezV> findByDate(string date);
        List<RendezV> findByDateM(string date);
        List<RendezV> findByDateRP(string date);
        RendezV findByDateAndNom(string date,int id);
        List<RendezV> findByPatient(Patient patient);
    }
}
