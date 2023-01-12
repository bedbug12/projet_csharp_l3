using projet_csharp_l3.repository;
using projet_csharp_l3.services;
using projet_csharp_l3.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_csharp_l3.repositories
{
    public class ConsultationAnnuleRepository :BaseRepository,IConsultationAnnuleRepository
    {
        private readonly string SQL_SELECT_ALL = "SELECT * FROM consultation_annule";
        private readonly string SQL_INSERT = "INSERT INTO consultation_annule (date,patient_id,medecin_id,type,etat,consultation_id,prestation_id) VALUES (@date,@patient_id,@medecin_id,@type,@etat,NULL,NULL)";
        private readonly string SQL_SELECT_BY_DATE = "SELECT * FROM consultation_annule WHERE date like @date";


        public ConsultationAnnuleRepository(string connexionString)
        {
            ConnexionString = connexionString;    
        }

        public void deleteById(int id)
        {
            throw new NotImplementedException();
        }

        public List<RendezV> findAll()
        {
            List<RendezV> rendezVs = new List<RendezV>();
            using (var connexion = new SqlConnection(ConnexionString))
            using (var command = new SqlCommand())
            {
                try
                {
                    connexion.Open();
                    command.Connection = connexion;
                    command.CommandText = SQL_SELECT_ALL;
                    SqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        RendezV rendezV = new RendezV()
                        {
                            Id = (int)dr[0],
                            Date = dr[1].ToString(),
                        };
                        Enum.TryParse(dr[4].ToString(), out models.Type type);
                        Enum.TryParse(dr[5].ToString(), out Etat etat);
                        rendezV.Type = type;
                        rendezV.Etat = etat;
                        rendezVs.Add(rendezV);
                    }
                    dr.Close();
                }
                catch (Exception ex)
                {
                    throw ex;

                }
                finally
                {
                    command.Dispose();
                    connexion.Close();
                }

            }
            return rendezVs;
        }

        public List<RendezV> findByDate(string date)
        {
            List<RendezV> rendezVs = new List<RendezV>();
            using (var connexion = new SqlConnection(ConnexionString))
            using (var command = new SqlCommand())
            {
                try
                {
                    connexion.Open();
                    command.Connection = connexion;
                    command.CommandText = SQL_SELECT_BY_DATE;
                    command.Parameters.Add("@date", SqlDbType.Date).Value = date;
                    SqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        RendezV rendezV = new RendezV()
                        {
                            Id = (int)dr[0],
                            Date = dr[1].ToString(),

                        };
                        rendezV.Patient = FabriqueService.getUserService().findPatient((int)dr[2]);
                        Enum.TryParse(dr[4].ToString(), out models.Type type);
                        Enum.TryParse(dr[5].ToString(), out Etat etat);
                        rendezV.Type = type;
                        rendezV.Etat = etat;
                        rendezVs.Add(rendezV);
                    }
                    dr.Close();
                }
                catch (Exception ex)
                {
                    throw ex;

                }
                finally
                {
                    command.Dispose();
                    connexion.Close();
                }

            }
            return rendezVs;
        }

        public RendezV findById(int id)
        {
            throw new NotImplementedException();
        }

        public void save(RendezV rdv)
        {
            using (var connexion = new SqlConnection(ConnexionString))
            using (var command = new SqlCommand())
            {
                try
                {
                    connexion.Open();
                    command.Connection = connexion;
                    command.CommandText = SQL_INSERT;
                    command.Parameters.Add("@date", SqlDbType.Date).Value = rdv.Date;
                    command.Parameters.Add("@patient_id", SqlDbType.Int).Value = rdv.Patient.Id;
                    command.Parameters.Add("@medecin_id", SqlDbType.Int).Value = 1;
                    command.Parameters.Add("@type", SqlDbType.NVarChar).Value = rdv.Type.ToString();
                    command.Parameters.Add("@etat", SqlDbType.NVarChar).Value = rdv.Etat.ToString();
                    command.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    command.Dispose();
                    connexion.Close();
                }

            }
        }

        public void update(RendezV entity)
        {
            throw new NotImplementedException();
        }
    }
}
