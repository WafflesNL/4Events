using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Forms_version_1._0;



namespace _4EventsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DatabaseConnectionTest()
        {
            bool Bool = DatabaseConnectie.OpenConnection();                                              
            Assert.AreEqual(true, Bool);

        }
    }
}
