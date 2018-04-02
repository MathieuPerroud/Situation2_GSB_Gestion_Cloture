using Classes_Metier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GSB_Cloture_App
{
    class Program
    {
        static void Main(string[] args)
        {
            DataAccess da = new DataAccess();
            da.ConnexionDB();
            if (DateManagement.entre(1, 10, DateTime.Now))
            {
                da.ChangerEtat("CR", "CL");
            }
            else
            {
                if (DateManagement.entre(20, 31, DateTime.Now))
                {
                    da.ChangerEtat("VA", "RB");
                }
            }
        }
    }
}
