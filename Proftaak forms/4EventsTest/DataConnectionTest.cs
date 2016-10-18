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
            bool Bool = DatabaseConnectie.OpenConnection();                                              
            Assert.AreEqual(true, Bool);

        }

        [TestMethod]
        public void DataNameTest()
        {
            string Bool = DatabaseLogin.GetString(1, "Gebruikersnaam");
            Assert.AreEqual("Lin", Bool);

            string Bool2 = DatabaseLogin.GetString(1, "Naam");
            Assert.AreEqual("Lin Lin", Bool2);

        }
    }
}
