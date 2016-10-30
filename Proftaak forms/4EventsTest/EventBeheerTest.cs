using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Forms_version_1._0;
using Forms_version_1._0.Classes;


namespace _4EventsTest
{
    /// <summary>
    /// Summary description for EventTest
    /// </summary>
    [TestClass]
    public class EventBeheerTest
    {
        [TestMethod]
        public void EventEditTestMethod()
        {
            DateTime Date = new DateTime(2016, 4, 4);
            Event Event = new Event(1, "Hello", "Nieuw", "Tilburg", 50, Date);
            Assert.AreEqual(true, Event.EditEvent(Event));
        }

        [TestMethod]
        public void EventCreateTestMethod()
        {
            Account Account = new Account(1, "Lin Lin", "Lin", "1", Function.Beheerder, null);
            DateTime Date = new DateTime(2016, 4, 4);
            List<Material> MaterialList = new List<Material>();

            Event Event = new Event("2016 event","Vet feest", "Tilburg", 50, Date, Account, MaterialList);
            Assert.AreEqual(true, Event.CreateEvent(Event));
        }

        [TestMethod]
        public void EventCheckDateTestMethod()
        {
            Account Account = new Account(1, "Lin Lin", "Lin", "1", Function.Beheerder, null);
            DateTime Date = new DateTime(2017, 4, 4);
            List<Material> MaterialList = new List<Material>();
            Event Event = new Event("2016 event", "Vet feest", "Tilburg", 50, Date, Account, MaterialList);

            Assert.AreEqual(true, Event.CheckDateOutOfRange());
        }

        [TestMethod]
        public void EventGetCampingTestMethod()
        {
            Account Account = new Account(1, "Lin Lin", "Lin", "1", Function.Beheerder, null);
            DateTime Date = new DateTime(2017, 4, 4);
            List<Material> MaterialList = new List<Material>();
            Event Event = new Event("2016 event", "Vet feest", "Tilburg", 50, Date, Account, MaterialList);

            Assert.AreEqual(true, Event.GetCamping());
        }

        [TestMethod]
        public void EventCreateTimelineTestMethod()
        {
            Account Account = new Account(1, "Lin Lin", "Lin", "1", Function.Beheerder, null);
            DateTime Date = new DateTime(2017, 4, 4);
            List<Material> MaterialList = new List<Material>();
            Event Event = new Event("2016 event", "Vet feest", "Tilburg", 50, Date, Account, MaterialList);

            Assert.AreEqual(true, Event.CreateTimeLine());
        }




    }
}
