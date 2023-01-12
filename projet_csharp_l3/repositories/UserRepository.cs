using projet_csharp_l3.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projet_csharp_l3.services;

namespace projet_csharp_l3.repository
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        private readonly string SQL_INSERT = "INSERT INTO users (nomComplet,login,password,role,grade,code,antecedent) VALUES (@nomComplet,NULL,NULL,@role,NULL,@code,@antecedent)";
        private readonly string SQL_SELECT_BY_LOGIN = "SELECT * FROM users WHERE login LIKE @login";
        private readonly string SQL_SELECT_MEDECIN_DISPO= "SELECT u.* FROM users u,medecin_dispo m WHERE u.id=m.id and m.date=@date";
        private readonly string SQL_SELECT_BY_CODE = "SELECT * FROM users WHERE code LIKE @code";
        private readonly string SQL_SELECT_BY_NAME = @"SELECT * FROM users WHERE nomComplet LIKE '%' +@nomComplet + '%'";
        private readonly string SQL_SELECT_BY_ID = "SELECT * FROM users WHERE id LIKE @id";
        private readonly string SQL_SELECT_BY_ROLE = "SELECT * FROM users WHERE role LIKE 'Patient'";
        public UserRepository(string connexionString)
        {
            ConnexionString = connexionString;
        }

        public void Add(Patient user)
        {
            using (var connexion = new SqlConnection(ConnexionString))
            using (var command = new SqlCommand())
            {
                try
                {
                    connexion.Open();
                    command.Connection = connexion;
                    command.CommandText = SQL_INSERT;
                    command.Parameters.Add("@nomComplet", SqlDbType.NVarChar).Value = user.NomComplet;
                    command.Parameters.Add("@role", SqlDbType.NVarChar).Value = Role.Patient.ToString();
                    command.Parameters.Add("@code", SqlDbType.NVarChar).Value = user.Code;
                    command.Parameters.Add("@antecedent", SqlDbType.NVarChar).Value = user.Antecedent.ToString();

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

        public List<Patient> findAllPatient()
        {
            List<Patient> patients = new List<Patient>();
            using (var connexion = new SqlConnection(ConnexionString))
            using (var command = new SqlCommand())
            {
                try
                {
                    connexion.Open();
                    command.Connection = connexion;
                    command.CommandText = SQL_SELECT_BY_ROLE;
                    SqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        Patient patient = new Patient()
                        {
                            Id = (int)dr[0],
                            NomComplet = dr[1].ToString(),
                            Code = dr[6].ToString(),
                        };
                        Enum.TryParse(dr[7].ToString(), out Antecedent antecedent);
                        patient.Antecedent = antecedent;
                        patients.Add(patient);
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
            return patients;
        }

        public List<Patient> findAllPatient(string nomComplet)
        {
            List<Patient> patients = new List<Patient>();
            using (var connexion = new SqlConnection(ConnexionString))
            using (var command = new SqlCommand())
            {
                try
                {
                    connexion.Open();
                    command.Connection = connexion;
                    command.CommandText = SQL_SELECT_BY_NAME;
                    command.Parameters.Add("@nomComplet", SqlDbType.NVarChar).Value = nomComplet;
                    SqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        Patient patient = new Patient()
                        {
                            Id = (int)dr[0],
                            NomComplet = dr[1].ToString(),
                            Code = dr[6].ToString(),
                        };
                        Enum.TryParse(dr[7].ToString(), out Antecedent antecedent);
                        patient.Antecedent = antecedent;
                        patients.Add(patient);
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
            return patients;
        }

        public List<Medecin> findByDate(string date)
        {
            List<Medecin> medecins = new List<Medecin>();
            using (var connexion = new SqlConnection(ConnexionString))
            using (var command = new SqlCommand())
            {
                try
                {
                    connexion.Open();
                    command.Connection = connexion;
                    command.CommandText = SQL_SELECT_MEDECIN_DISPO;
                    command.Parameters.Add("@date", SqlDbType.Date).Value = date;
                    SqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        Medecin medecin = new Medecin()
                        {
                            Id = (int)dr[0],
                            NomComplet = dr[1].ToString(),
                            Grade = dr[5].ToString(),

                        };
                        medecins.Add(medecin);
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
            return medecins;
        }

        public Medecin findByIdM(int id)
        {
            Medecin medecin = null;
            using (var connexion = new SqlConnection(ConnexionString))
            using (var command = new SqlCommand())
            {
                try
                {
                    connexion.Open();
                    command.Connection = connexion;
                    command.CommandText = SQL_SELECT_BY_ID;
                    command.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
                    SqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        medecin = new Medecin()
                        {
                            Id = (int)dr[0],
                            NomComplet = dr[1].ToString(),
                            Grade=dr[5].ToString(),

                        };
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
            return medecin;
        }

        public Patient findByIdP(int id)
        {
            Patient patient = null;
            using (var connexion = new SqlConnection(ConnexionString))
            using (var command = new SqlCommand())
            {
                try
                {
                    connexion.Open();
                    command.Connection = connexion;
                    command.CommandText = SQL_SELECT_BY_ID;
                    command.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
                    SqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        patient = new Patient()
                        {
                            Id = (int)dr[0],
                            NomComplet = dr[1].ToString(),
                            Code = dr[6].ToString(),

                        };
                        Enum.TryParse(dr[7].ToString(), out Antecedent antecedent);
                        patient.Antecedent = antecedent;
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
            return patient;
        }

        public User findByLogin(string login)
        {
            User user = null;
            using (var connexion = new SqlConnection(ConnexionString))
            using (var command = new SqlCommand())
            {
                try
                {
                    connexion.Open();
                    command.Connection = connexion;
                    command.CommandText = SQL_SELECT_BY_LOGIN;
                    command.Parameters.Add("@login", SqlDbType.NVarChar).Value = login;
                    SqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                         user = new User()
                        {
                            Id = (int)dr[0],
                            NomComplet = dr[1].ToString(),
                            Login = dr[2].ToString(),
                            Password = dr[3].ToString(),
                        };
                        Enum.TryParse(dr[4].ToString(), out Role role);
                        user.Role=role;
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
            return user;
        }

        public Patient findPatientByCode(string code)
        {
            Patient patient = null;
            using (var connexion = new SqlConnection(ConnexionString))
            using (var command = new SqlCommand())
            {
                try
                {
                    connexion.Open();
                    command.Connection = connexion;
                    command.CommandText = SQL_SELECT_BY_CODE;
                    command.Parameters.Add("@code", SqlDbType.NVarChar).Value = code;
                    SqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        patient = new Patient()
                        {
                            Id = (int)dr[0],
                            NomComplet = dr[1].ToString(),
                            Code = code,
                           
                    };
                        Enum.TryParse(dr[7].ToString(), out Antecedent antecedent);
                        patient.Antecedent = antecedent;
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
            return patient;
        }






    }
}
