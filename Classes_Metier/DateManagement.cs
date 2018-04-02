using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Metier
{
    public abstract class DateManagement
    {
        ///     <summary>
        ///         Méthode qui retourne le mois précédent.
        ///     </summary>
        ///     <returns>
        ///         Un System.String des deux chiffres du mois précédent. 
        ///     </returns>
        public static string GetMoisPrecedent()
        {
            return GetMoisPrecedent(DateTime.Now.Month);
        }
        ///     <summary>
        ///         Méthode qui retourne le mois précédent.
        ///     </summary>
        ///     <param name="date">
        ///         Un System.DateTime qui contient la date à partir de laquelle le mois précédent va être récupéré.
        ///     </param>
        ///     <returns>
        ///         Un System.String des deux chiffres du mois précédent. 
        ///     </returns>
        public static string GetMoisPrecedent(DateTime date)
        {
            return GetMoisPrecedent(date.Month);
        }
        ///     <summary>
        ///         Méthode qui retourne le mois précédent.
        ///     </summary>
        ///     <param name="mois">
        ///         Un System.Int qui contient le mois à partir duquel le mois précédent va être récupéré.
        ///     </param>
        ///     <returns>
        ///         Un System.String des deux chiffres du mois précédent. 
        ///     </returns>
        public static string GetMoisPrecedent(int mois)
        {
            string moisPrecedent;
            if (mois == 1)
            {
                moisPrecedent = "12";
            }
            else
            {
                if (mois <= 10)
                {
                    moisPrecedent = "0" + (mois - 1).ToString();
                }
                else
                {
                    moisPrecedent = (mois - 1).ToString();
                }
            }
            return moisPrecedent;
        }
        ///     <summary>
        ///         Méthode qui retourne le mois suivant.
        ///     </summary>
        ///     <returns>
        ///         Un System.String des deux chiffres du mois suivant. 
        ///     </returns>
        public static string GetMoisSuivant()
        {
            return GetMoisSuivant(DateTime.Now.Month);
        }
        ///     <summary>
        ///         Méthode qui retourne le mois suivant.
        ///     </summary>
        ///     <param name="date">
        ///         Un System.DateTime qui contient la date à partir de laquelle le mois suivant va être récupéré.
        ///     </param>
        ///     <returns>
        ///         Un System.String des deux chiffres du mois suivant. 
        ///     </returns>
        public static string GetMoisSuivant(DateTime date)
        {
            return GetMoisSuivant(date.Month);
        }
        ///     <summary>
        ///         Méthode qui retourne le mois suivant.
        ///     </summary>
        ///     <param name="mois">
        ///         Un System.Int qui contient le mois à partir duquel le mois suivant va être récupéré.
        ///     </param>
        ///     <returns>
        ///         Un System.String des deux chiffres du mois suivant. 
        ///     </returns>
        public static string GetMoisSuivant(int mois)
        {
            string moisSuivant;
            if (mois == 12)
            {
                moisSuivant = "01";
            }
            else
            {
                if (mois < 9)
                {
                    moisSuivant = "0" + (mois + 1).ToString();
                }
                else
                {
                    moisSuivant = (mois + 1).ToString();
                }
            }
            return moisSuivant;
        }
        ///     <summary>
        ///         Méthode qui vérifie si la date actuelle se situe entre deux jours.
        ///     </summary>
        ///     <param name="jour1">
        ///         Un System.Int qui contient le premier jour de l'entre deux.
        ///     </param>
        ///     <param name="jour2">
        ///         Un System.Int qui contient le dernier jour de l'entre deux.
        ///     </param>
        ///     <returns>
        ///         Un System.Boolean true si la date est entre ces deux jours. 
        ///     </returns>
        public static bool entre(int jour1, int jour2)
        {
            return entre(jour1, jour2, DateTime.Now.Day);
        }
        ///     <summary>
        ///         Méthode qui vérifie si une date se situe entre deux jours.
        ///     </summary>
        ///     <param name="jour1">
        ///         Un System.Int qui contient le premier jour de l'entre deux.
        ///     </param>
        ///     <param name="jour2">
        ///         Un System.Int qui contient le dernier jour de l'entre deux.
        ///     </param>
        ///     <param name="date">
        ///         Un System.DateTime qui contient la date à vérifier.
        ///     </param>
        ///     <returns>
        ///         Un System.Boolean true si la date est entre ces deux jours. 
        ///     </returns>
        public static bool entre(int jour1, int jour2, DateTime date)
        {
            return entre(jour1,jour2,date.Day);
        }
        ///     <summary>
        ///         Méthode qui vérifie si un jour testé se situe entre deux jours.
        ///     </summary>
        ///     <param name="jour1">
        ///         Un System.Int qui contient le premier jour de l'entre deux.
        ///     </param>
        ///     <param name="jour2">
        ///         Un System.Int qui contient le dernier jour de l'entre deux.
        ///     </param>
        ///     <param name="jourTest">
        ///         Un System.Int qui contient le jour à vérifier.
        ///     </param>
        ///     <returns>
        ///         Un System.Boolean true si le jour testé est entre ces deux jours. 
        ///     </returns>

        public static bool entre(int jour1, int jour2, int jourTest)
        {
            bool res = false;
            if (jour1 <= jourTest && jourTest <= jour2)
            {
                res = true;
            }
            return res;
        }
    }
}
