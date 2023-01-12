using projet_csharp_l3.repository;
using projet_csharp_l3.repositories;
using projet_csharp_l3.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_csharp_l3.services
{
    public static class FabriqueService
    {
        private static string connexionString = "Data Source=DESKTOP-D4IPSNO;Initial Catalog=ProjetCSharp;Integrated Security=True";
        private static ISecretaireService secretaireService=null;
        private static IRendezVRepository rendezVRepository = new RendezVRepository(connexionString);
        public static IMedecinService medecinService = null;
        private static IUserRepository userRepository = new UserRepository(connexionString);
        private static IConsultationAnnuleRepository consultationAnnuleRepository = new ConsultationAnnuleRepository(connexionString);
        public static IUserService userService = null;
        public static ISecretaireService getSecretaireService()
        {
            return secretaireService==null?new SecretaireService(rendezVRepository, consultationAnnuleRepository) :secretaireService;
        }

       /* public static IMedecinService getMedecinService()
        {
            return medecinService == null ? new MedecinService(userRepository) : medecinService;
        }*/

        public static IUserService getUserService()
        {
            return userService == null ? new UserService(userRepository) : userService;
        }
    }
}
