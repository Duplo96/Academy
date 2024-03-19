using DB_Lez_01.Models;
using System.Data.SqlClient;

namespace DB_Lez_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            string credenziali = "Server=ACADEMY2024-15\\SQLEXPRESS;Database=Lez_22_citta;" +
                "User Id=academy;Password=Academy!;" +
                "MultipleActiveResultSets=true;Encrypt=false;" +
                "TrustServerCertificate=false";
            #region Citta
            List<Citta> elenco = new List<Citta>();

            //using (SqlConnection connessione = new SqlConnection(credenziali))
            //{

            //    string query = "SELECT cittaID,nome,prov FROM Citta";

            //    SqlCommand comando = new SqlCommand(query, connessione);

            //    try
            //    {


            //        connessione.Open();


            //        SqlDataReader reader = comando.ExecuteReader();
            //        while (reader.Read())
            //        {
            //            Console.WriteLine($"{reader[0]} {reader[1]} {reader[2]}");

            //            Citta citta = new Citta()
            //            {
            //                Id = Convert.ToInt32(reader[0]),
            //                Nome = reader[1].ToString(),
            //                Provincia = reader[2].ToString()
            //            };

            //            elenco.Add(citta);
            //        }
            //    }
            //    catch (Exception ex) 
            //    {
            //        Console.WriteLine($"ERRORE {ex.Message}");
            //    }
            //    finally 
            //    { 
            //        connessione.Close(); 
            //    }



            //}

            //foreach (Citta cit in elenco)
            //{
            //    Console.WriteLine($"CittaID: {cit.Id}\nNome: {cit.Nome}\nProvincia: {cit.Provincia}");
            //}
            #endregion




            #region Inserisci Citta
            //string nome = "pineto";
            //string prov = "PE";

            //using (SqlConnection con = new SqlConnection(credenziali))
            //{
            //    SqlCommand cmd = new SqlCommand();
            //    cmd.Connection = con;
            //    cmd.CommandText = "INSERT INTO Citta(nome,prov) VALUES (@nomeCitta, @provCitta)";
            //    cmd.Parameters.AddWithValue("@nomeCitta", nome);
            //    cmd.Parameters.AddWithValue("@provCitta", prov);

            //    con.Close();

            //    try
            //    {
            //        con.Open();
            //        int affRows = cmd.ExecuteNonQuery();
            //        if (affRows > 0)
            //            Console.WriteLine("APPOOOOO");
            //        else
            //            Console.WriteLine("Errore");
            //    }
            //    catch(SqlException sqlEx)
            //    {
            //        Console.WriteLine($"ERRORE, violazione vincolo! {sqlEx.Message}");

            //    }
            //    catch(Exception ex) 

            //    {

            //        Console.WriteLine(ex.Message);

            //    }
            //    finally 
            //    {
            //        Console.WriteLine("Connessione Chiusa");
            //        con.Close(); 
            //    }


            //}

            #endregion

            #region Elimina Citta
            //int idDaElminare = 3;

            //using(SqlConnection con = new SqlConnection(credenziali))
            //{
            //    SqlCommand cmd = new SqlCommand();
            //    cmd.Connection = con;
            //    cmd.CommandText = "DELETE FROM Citta WHERE cittaID = @idValue";
            //    cmd.Parameters.AddWithValue("@idValue", idDaElminare);


            //    try
            //    {
            //        con.Open();
            //        int affRows = cmd.ExecuteNonQuery();
            //        if (affRows > 0)
            //            Console.WriteLine("APPO");

            //        else

            //            Console.WriteLine("ERRORE");

            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine($"ERRORE {ex.Message}");

            //    }
            //    finally
            //    {
            //        con.Close();
            //    }
            //}
            #endregion

            #region Modificare Citta

           
            
            Citta citta = new Citta()
            {
                Id = 1,
                Provincia = "P"
            };


            using(SqlConnection con = new SqlConnection(credenziali))
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "UPDATE Citta SET prov=@provCitta WHERE cittaID = @IdValue";
                cmd.Parameters.AddWithValue("@provCitta", citta.Provincia);
                cmd.Parameters.AddWithValue("@idValue", citta.Id);

                try
                {
                    con.Open();

                    
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        Console.WriteLine("OK");

                    }
                    else
                    {
                        Console.WriteLine("ERRORE");
                    }

                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    con.Close();
                }
            }

            #endregion

        }
    }
}
