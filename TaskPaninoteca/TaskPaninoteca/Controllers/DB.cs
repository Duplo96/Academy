using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskPaninoteca.Controllers
{

    
    internal class DB
    {

        

        string credenziali = "Server=ACADEMY2024-15\\SQLEXPRESS;Database=TaskPaninoteca;" +
                "User Id=academy;Password=Academy!;" +
                "MultipleActiveResultSets=true;Encrypt=false;" +
                "TrustServerCertificate=false";
        /// <summary>
        /// Inserimento del panino tramite oggetto
        /// </summary>
        /// <param name="pan"></param>
        /// <returns></returns>
        public bool insert(Panino pan)
        {
            bool risultato=false;
        
            using (SqlConnection con = new SqlConnection(credenziali))
            {
                
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO Panino (nome,descrizione,prezzo,Isvegan) VALUES " +
                    "(@nomeValue,@descrizioneValue,@prezzoValue,@IsVeganValue)";
                cmd.Parameters.AddWithValue("@nomeValue", pan.Nome);
                cmd.Parameters.AddWithValue("@descrizioneValue", pan.Descrizione);
                cmd.Parameters.AddWithValue("@prezzoValue", pan.Prezzo);
                cmd.Parameters.AddWithValue("@IsVeganValue", pan.IsVegan);

                try
                {
                    con.Open();
                    if (cmd.ExecuteNonQuery()>0)
                    {
                        Console.WriteLine("AGGIUNTO");
                        risultato = true;   
                    }

                }
                catch (Exception ex)
                {

                    Console.WriteLine("Errore" + ex.Message);
                }
                finally
                {
                    Console.WriteLine("Connessione Chiusa");
                    con.Close();
                }
                return risultato;
            }
        }

        public List<Panino> findAll()
        {
            List<Panino> elenco = new List<Panino>();

            using (SqlConnection con = new SqlConnection(credenziali)) 
            
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT paninoID,nome,descrizione,prezzo,Isvegan FROM Panino";
                try
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {

                        elenco.Add(new Panino()
                        {
                            Id = Convert.ToInt32(reader["paninoID"]),
                            Nome = reader["nome"].ToString(),
                            Descrizione = reader["descrizione"].ToString(),
                            Prezzo = Convert.ToDecimal(reader["prezzo"]),
                            IsVegan = Convert.ToBoolean(reader["IsVegan"])
                        });
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                }
                finally { con.Close(); }
            
            }
            return elenco;
            

        }
    }
}
