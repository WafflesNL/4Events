using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Forms_version_1._0.Classes;

namespace _4EventsTest
{
    [TestClass]
    public class ReserveringsTest
    {
        [TestMethod]
        public void ConstructorTest()
        {
            DateTime testDate = DateTime.Today;

            Event testEvent = new Event(1, "testEvent", "testBeschrijving", "testLocatie", 10, testDate);
            Payment testPayment = new Payment(10, false);
            Place testPlace = new Place(1, "Zand", 1, Forms_version_1._0.Categorie.Normal);

            Reservation reservering = new Reservation(1, testEvent, testPayment, testPlace);

            Assert.AreEqual(1, reservering.Event.ID);
            Assert.AreEqual("testEvent", reservering.Event.Name);
            Assert.AreEqual("testBeschrijving", reservering.Event.Discription);
            Assert.AreEqual("testLocatie", reservering.Event.Location);
            Assert.AreEqual(testDate, reservering.Event.Date);
            Assert.AreEqual(testPayment, reservering.Payment);
            Assert.AreEqual(testPlace, reservering.Place);
        }
    }
}
