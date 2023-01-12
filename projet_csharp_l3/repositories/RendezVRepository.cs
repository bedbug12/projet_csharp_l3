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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace projet_csharp_l3.repositories
{
    public class RendezVRepository : BaseRepository, IRendezVRepository
    {
        private readonly string SQL_SELECT_ALL = "SELECT * FROM rdv";
        private readonly string SQL_INSERT= "INSERT INTO rdv (date,patient_id,medecin_id,type,etat,consultation_id,prestation_id) VALUES (@date,@patient_id,@medecin_id,@type,@etat,NULL,NULL)";
        private readonly string SQL_SELECT_BY_DATE = "SELECT * FROM rdv WHERE date like @date";
        private readonly string SQL_SELECT_BY_DATE_AND_PRESTATION = "SELECT * FROM rdv WHERE date LIKE @date AND type LIKE 'Prestation'";
        private readonly string SQL_SELECT_BY_DATE_AND_CONSULTATION = "SELECT * FROM rdv WHERE date LIKE @date AND type LIKE 'Consultation'";
        private readonly string SQL_SELECT_BY_DATE_AND_PATIENT = "SELECT * FROM rdv WHERE date like @date AND patient_id = @id ";
        private readonly string SQL_SELECT_BY_PATIENT = "SELECT * FROM rdv WHERE patient_id = @id";
        private readonly string SQL_DELETE_ID = "DELETE FROM rdv WHERE id = @id";
        private readonly string SQL_UPDATE_ETAT = "UPDATE rdv SET etat = 'Valide' WHERE id = @id";
        



        public RendezVRepository(string connexionString)
        {
            ConnexionString = connexionString;
        }

        public void deleteById(int id)
        {
            using (var connexion = new SqlConnection(ConnexionString))
            using (var command = new SqlCommand())
            {
                try
                {
                    connexion.Open();
                    command.Connection = connexion;
                    command.CommandText = SQL_DELETE_ID;
                    command.Parameters.Add("@id", SqlDbType.Int).Value =id;
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
                            Medecin = FabriqueService.getUserService().findMedecin((int)dr[3]),


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

        public RendezV findByDateAndNom(string date, int id)
        {
            RendezV rendezV = null;
            using (var connexion = new SqlConnection(ConnexionString))
            using (var command = new SqlCommand())
            {
                try
                {
                    connexion.Open();
                    command.Connection = connexion;
                    command.CommandText = SQL_SELECT_BY_DATE_AND_PATIENT;
                    command.Parameters.Add("@date", SqlDbType.Date).Value = date;
                    command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    SqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        rendezV = new RendezV()
                        {
                            Id = (int)dr[0],
                            Date = dr[1].ToString(),
                            Medecin = FabriqueService.getUserService().findMedecin((int)dr[3]),

                        };
                        rendezV.Patient = FabriqueService.getUserService().findPatient((int)dr[2]);
                        Enum.TryParse(dr[4].ToString(), out models.Type type);
                        Enum.TryParse(dr[5].ToString(), out Etat etat);
                        rendezV.Type = type;
                        rendezV.Etat = etat;
                       
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
            return rendezV;
        }

        public List<RendezV> findByDateM(string date)
        {
            List<RendezV> rendezVs = new List<RendezV>();
            using (var connexion = new SqlConnection(ConnexionString))
            using (var command = new SqlCommand())
            {
                try
                {
                    connexion.Open();
                    command.Connection = connexion;
                    command.CommandText = SQL_SELECT_BY_DATE_AND_CONSULTATION;
                    command.Parameters.Add("@date", SqlDbType.Date).Value = date;
                    SqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        RendezV rendezV = new RendezV()
                        {
                            Id = (int)dr[0],
                            Date = dr[1].ToString(),
                            Medecin = FabriqueService.getUserService().findMedecin((int)dr[3]),

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

        public List<RendezV> findByDateRP(string date)
        {
            List<RendezV> rendezVs = new List<RendezV>();
            using (var connexion = new SqlConnection(ConnexionString))
            using (var command = new SqlCommand())
            {
                try
                {
                    connexion.Open();
                    command.Connection = connexion;
                    command.CommandText = SQL_SELECT_BY_DATE_AND_PRESTATION;
                    command.Parameters.Add("@date", SqlDbType.Date).Value = date;
                    SqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        RendezV rendezV = new RendezV()
                        {
                            Id = (int)dr[0],
                            Date = dr[1].ToString(),
                            Medecin = FabriqueService.getUserService().findMedecin((int)dr[3]),
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

        public List<RendezV> findByPatient(Patient patient)
        {
            List<RendezV> rendezVs = new List<RendezV>();
            using (var connexion = new SqlConnection(ConnexionString))
            using (var command = new SqlCommand())
            {
                try
                {
                    connexion.Open();
                    command.Connection = connexion;
                    command.CommandText = SQL_SELECT_BY_PATIENT;
                    command.Parameters.Add("@id", SqlDbType.Int).Value = patient.Id;
                    SqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        RendezV rendezV = new RendezV()
                        {
                            Id = (int)dr[0],
                            Date = dr[1].ToString(),
                            Patient = patient,
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
                    command.Parameters.Add("@medecin_id", SqlDbType.Int).Value = rdv.Medecin.Id;
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

        public void update(RendezV rdv)
        {
            using (var connexion = new SqlConnection(ConnexionString))
            using (var command = new SqlCommand())
            {
                try
                {
                    connexion.Open();
                    command.Connection = connexion;
                    command.CommandText = SQL_UPDATE_ETAT;
                    command.Parameters.Add("@id", SqlDbType.Int).Value = rdv.Id;
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
    }
}
