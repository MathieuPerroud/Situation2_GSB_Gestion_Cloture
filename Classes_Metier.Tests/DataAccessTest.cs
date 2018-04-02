using MySql.Data.MySqlClient;
using System;
using Classes_Metier;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Classes_Metier.Tests
{
    /// <summary>Cette classe contient des tests unitaires paramétrables pour DataAccess</summary>
    [TestClass]
    [PexClass(typeof(DataAccess))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class DataAccessTest
    {

        /// <summary>Stub de test pour ConnexionDB()</summary>
        [PexMethod]
        public void ConnexionDBTest([PexAssumeUnderTest]DataAccess target)
        {
            target.ConnexionDB();
            // TODO: ajouter des assertions à méthode DataAccessTest.ConnexionDBTest(DataAccess)
        }

        /// <summary>Stub de test pour QuerySelect(String)</summary>
        [PexMethod]
        public MySqlDataReader QuerySelectTest([PexAssumeUnderTest]DataAccess target, string theQuery)
        {
            MySqlDataReader result = target.QuerySelect(theQuery);
            return result;
            // TODO: ajouter des assertions à méthode DataAccessTest.QuerySelectTest(DataAccess, String)
        }

        /// <summary>Stub de test pour QueryAdministrative(String)</summary>
        [PexMethod]
        public int QueryAdministrativeTest([PexAssumeUnderTest]DataAccess target, string theQuery)
        {
            int result = target.QueryAdministrative(theQuery);
            return result;
            // TODO: ajouter des assertions à méthode DataAccessTest.QueryAdministrativeTest(DataAccess, String)
        }
    }
}
