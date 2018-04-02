using Microsoft.VisualStudio.TestTools.UnitTesting;
using Classes_Metier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Classes_Metier.Tests
{
    [TestClass()]
    public class DateManagementTests
    {
        [TestMethod()]
        public void entreTest1()
        {
            Assert.AreEqual(false, DateManagement.entre(10, 20, 5));
        }
        [TestMethod()]
        public void entreTest2()
        {
            Assert.AreEqual(true, DateManagement.entre(10, 20, 10));
        }
        [TestMethod()]
        public void entreTest3()
        {
            Assert.AreEqual(true, DateManagement.entre(10, 20, 15));
        }
        [TestMethod()]
        public void entreTest4()
        {
            Assert.AreEqual(true, DateManagement.entre(10, 20, 20));
        }
        [TestMethod()]
        public void entreTest5()
        {
            Assert.AreEqual(false, DateManagement.entre(10, 20, 25));
        }
        [TestMethod()]
        public void entreTest6()
        {
            Assert.AreEqual(false, DateManagement.entre(10, 20, 30));
        }

        [TestMethod()]
        public void GetMoisSuivantTest1()
        {
            Assert.AreEqual("01", DateManagement.GetMoisSuivant(12));
        }
        [TestMethod()]
        public void GetMoisSuivantTest2()
        {
            Assert.AreEqual("02", DateManagement.GetMoisSuivant(1));
        }
        [TestMethod()]
        public void GetMoisSuivantTest3()
        {
            Assert.AreEqual("03", DateManagement.GetMoisSuivant(2));
        }
        [TestMethod()]
        public void GetMoisSuivantTest4()
        {
            Assert.AreEqual("04", DateManagement.GetMoisSuivant(3));
        }
        [TestMethod()]
        public void GetMoisSuivantTest5()
        {
            Assert.AreEqual("05", DateManagement.GetMoisSuivant(4));
        }
        [TestMethod()]
        public void GetMoisSuivantTest6()
        {
            Assert.AreEqual("06", DateManagement.GetMoisSuivant(5));
        }
        [TestMethod()]
        public void GetMoisSuivantTest7()
        {
            Assert.AreEqual("07", DateManagement.GetMoisSuivant(6));
        }
        [TestMethod()]
        public void GetMoisSuivantTest8()
        {
            Assert.AreEqual("08", DateManagement.GetMoisSuivant(7));
        }
        [TestMethod()]
        public void GetMoisSuivantTest9()
        {
            Assert.AreEqual("09", DateManagement.GetMoisSuivant(8));
        }
        [TestMethod()]
        public void GetMoisSuivantTest10()
        {
            Assert.AreEqual("10", DateManagement.GetMoisSuivant(9));
        }
        [TestMethod()]
        public void GetMoisSuivantTest11()
        {
            Assert.AreEqual("11", DateManagement.GetMoisSuivant(10));
        }
        [TestMethod()]
        public void GetMoisSuivantTest12()
        {
            Assert.AreEqual("12", DateManagement.GetMoisSuivant(11));
        }
        [TestMethod()]
        public void GetMoisSuivantTest13()
        {
            Assert.AreNotEqual("13", DateManagement.GetMoisSuivant(12));
        }

        [TestMethod()]
        public void GetMoisPrecedentTest1()
        {
            Assert.AreEqual("01", DateManagement.GetMoisPrecedent(2));
        }
        [TestMethod()]
        public void GetMoisPrecedentTest2()
        {
            Assert.AreEqual("02", DateManagement.GetMoisPrecedent(3));
        }
        [TestMethod()]
        public void GetMoisPrecedentTest3()
        {
            Assert.AreEqual("03", DateManagement.GetMoisPrecedent(4));
        }
        [TestMethod()]
        public void GetMoisPrecedentTest4()
        {
            Assert.AreEqual("04", DateManagement.GetMoisPrecedent(5));
        }
        [TestMethod()]
        public void GetMoisPrecedentTest5()
        {
            Assert.AreEqual("05", DateManagement.GetMoisPrecedent(6));
        }
        [TestMethod()]
        public void GetMoisPrecedentTest6()
        {
            Assert.AreEqual("06", DateManagement.GetMoisPrecedent(7));
        }
        [TestMethod()]
        public void GetMoisPrecedentTest7()
        {
            Assert.AreEqual("07", DateManagement.GetMoisPrecedent(8));
        }
        [TestMethod()]
        public void GetMoisPrecedentTest8()
        {
            Assert.AreEqual("08", DateManagement.GetMoisPrecedent(9));
        }
        [TestMethod()]
        public void GetMoisPrecedentTest9()
        {
            Assert.AreEqual("09", DateManagement.GetMoisPrecedent(10));
        }
        [TestMethod()]
        public void GetMoisPrecedentTest10()
        {
            Assert.AreEqual("10", DateManagement.GetMoisPrecedent(11));
        }
        [TestMethod()]
        public void GetMoisPrecedentTest11()
        {
            Assert.AreEqual("11", DateManagement.GetMoisPrecedent(12));
        }
        [TestMethod()]
        public void GetMoisPrecedentTest12()
        {
            Assert.AreEqual("12", DateManagement.GetMoisPrecedent(1));
        }
        [TestMethod()]
        public void GetMoisPrecedentTest13()
        {
            Assert.AreNotEqual("00", DateManagement.GetMoisPrecedent(1));
        }
    }
}