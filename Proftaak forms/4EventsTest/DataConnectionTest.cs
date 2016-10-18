using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Forms_version_1._0;



namespace _4EventsTest
{
    [TestClass]
    public class DataConnectionTest
    {
        [TestMethod]
        public void DatabaseConnectionTest()
        {
            bool Check = DatabaseConnectie.OpenConnection();                                              
            Assert.AreEqual(true, Check);

        }

        [TestMethod]
        public void DataNameTest()
        {
            string Check = DatabaseLogin.GetString(1, "Gebruikersnaam");
            Assert.AreEqual("Lin", Check);

            string Check2 = DatabaseLogin.GetString(1, "Naam");
            Assert.AreEqual("Lin Lin", Check2);

        }
    }
}
