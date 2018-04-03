using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classe_Metier;
using MySql.Data.MySqlClient;

namespace Classe_Metier
{
    public class DataAccess
    {
        MySqlConnection cnx;
        MySqlCommand cmd;
        /// Résumé :
        ///     <summary>
        ///         Méthode utilisée pour connecter son utilisateur à la base de donnée GSB_frais.
        ///     </summary>
        ///     <returns>
        ///     Un System.String contenant un message relatif à la connexion ou non à la base de donnée.
        ///     </returns>
        public string ConnexionDB()
        {
            try
            {
                cnx = new MySqlConnection("database=gsb_frais; server=localhost; UID=root; pwd =''");
                cnx.Open();
                return "Connexion à la base réussie";
            }
            catch (Exception e)
            {
                return "Erreur lors de la connexion à la base : " + e;
            }

        }
        //
        /// Résumé :
        ///     <summary>
        ///         Méthode utilisée pour executer des requêtes de type SELECT.
        ///     </summary>
        ///
        /// Paramètres :
        ///     <param name="theQuery">
        ///         Un System.String qui contient la requête SELECT à executer.
        ///     </param>
        ///
        /// Retourne :
        ///     <returns>
        ///         Un MySql.Data.MySqlClient.MySqlDataReader contenant les lignes de la requête sous forme
        ///         d'un tableau associatif.
        ///     </returns>
        ///     
        public MySqlDataReader QuerySelect(string theQuery)
        {
            cnx.Close();
            cnx.Open();
            cmd = cnx.CreateCommand();
            cmd.CommandText = theQuery;
            return cmd.ExecuteReader();
        }
        /// Résumé :
        ///     <summary>
        ///         Méthode utilisée pour executer des requêtes de type INSERT INTO, UPDATE et DELETE FROM.
        ///     </summary>
        ///
        /// Paramètres :
        ///     <param name="theQuery">
        ///         Un System.String qui contient la requête INSERT INTO, UPDATE ou DELETE FROM à executer.
        ///     </param>
        ///
        /// Retourne :
        ///     <returns>
        ///         Un System.Int égal à 1 si la requête a bien été executée. 
        ///     </returns>
        ///     
        public int QueryAdministrative(string theQuery)
        {
            cnx.Close();
            cnx.Open();
            cmd = cnx.CreateCommand();
            cmd.CommandText = theQuery;
            return cmd.ExecuteNonQuery();
        }
        /// Résumé :
        ///     <summary>
        ///         Change l'état de toutes les fiches de frais du mois précédent à un autre état.
        ///     </summary>
        ///
        /// Paramètres :
        ///     <param name="etatAChanger">
        ///         Un System.String qui contient l'état des fiches de frais à changer.
        ///     </param>
        ///     <param name="nouvelEtat">
        ///         Un System.String qui contient le nouvel état de ces fiches de frais.
        ///     </param>   
        public void ChangerEtat(string etatAChanger, string nouvelEtat)
        {
            string moisPrecedent = DateManagement.GetMoisPrecedent();
            MySqlDataReader reader = QuerySelect(String.Format(
                "SELECT idvisiteur "
                + "FROM fichefrais "
                + "WHERE mois LIKE '%{0}' "
                + "AND idetat = '{1}'", moisPrecedent, etatAChanger));
            List<string> lignes = new List<string>();
            while (reader.Read())
            {
                lignes.Add((string)reader["idVisiteur"]);
            }
            foreach (string ligne in lignes)
            {
                QueryAdministrative(String.Format(
                    "UPDATE fichefrais "
                    + "SET idetat = '{0}' "
                    + "WHERE idvisiteur ='{1}' "
                    + "AND mois LIKE '%{2}'", nouvelEtat, ligne, moisPrecedent));
            }

        }

    }
}
