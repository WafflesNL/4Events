using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Forms_version_1._0;
using Forms_version_1._0.Classes;


namespace _4EventsTest
{
    //event TestMethods

    /// <summary>
    /// Summary description for EventTest
    /// </summary>
    [TestClass]
    public class EventBeheerTest
    {
        /// <summary>
        /// Tests if event can be correctly changed in the database
        /// </summary>
        [TestMethod]
        public void EventEditTestMethod()
        {
            DateTime Date = new DateTime(2016, 4, 4);
            Event Event = new Event(1, "Hello", "Nieuw", "Tilburg", 50, Date);
            Assert.AreEqual(true, Event.EditEvent(Event));
        }

        /// <summary>
        /// Tests if event can be correctly created in the database
        /// </summary>
        [TestMethod]
        public void EventCreateTestMethod()
        {
            Account Account = new Account(1, "Lin Lin", "Lin", "1", Function.Beheerder, null);
            DateTime Date = new DateTime(2016, 4, 4);
            List<Material> MaterialList = new List<Material>();

            Event Event = new Event("2016 event","Vet feest", "Tilburg", 50, Date, Account, MaterialList);
            Assert.AreEqual(true, Event.CreateEvent(Event));
        }

        /// <summary>
        /// Tests if the date isn't out of range
        /// </summary>
        [TestMethod]
        public void EventCheckDateTestMethod()
        {
            Account Account = new Account(1, "Lin Lin", "Lin", "1", Function.Beheerder, null);
            DateTime Date = new DateTime(2017, 4, 4);
            List<Material> MaterialList = new List<Material>();
            Event Event = new Event("2016 event", "Vet feest", "Tilburg", 50, Date, Account, MaterialList);

            Assert.AreEqual(true, Event.CheckDateOutOfRange());
        }

        /// <summary>
        /// Gets a camping to add to the Event
        /// </summary>
        [TestMethod]
        public void EventGetCampingTestMethod()
        {
            Account Account = new Account(1, "Lin Lin", "Lin", "1", Function.Beheerder, null);
            DateTime Date = new DateTime(2017, 4, 4);
            List<Material> MaterialList = new List<Material>();
            Event Event = new Event("2016 event", "Vet feest", "Tilburg", 50, Date, Account, MaterialList);

            Assert.AreEqual(true, Event.GetCamping());
        }

        /// <summary>
        /// Creates a new timeline for an event
        /// </summary>
        [TestMethod]
        public void EventCreateTimelineTestMethod()
        {
            Account Account = new Account(1, "Lin Lin", "Lin", "1", Function.Beheerder, null);
            DateTime Date = new DateTime(2017, 4, 4);
            List<Material> MaterialList = new List<Material>();
            Event Event = new Event("2016 event", "Vet feest", "Tilburg", 50, Date, Account, MaterialList);

            Assert.AreEqual(true, Event.CreateTimeLine());
        }

        //Account TestMethods

        /// <summary>
        /// Tests if Account can be correctly recieved from the database
        /// </summary>
        [TestMethod]
        public void LoginTestMethod()
        {               
            Assert.AreEqual(true, CurrentAccount.Login("1", "Lin"));
            Assert.AreEqual(true, CurrentAccount.Login("3", "Henk-Jan"));
            Assert.AreEqual(true, CurrentAccount.Login("4", "Jamal"));
        }

        /// <summary>
        /// Tests if event can be correctly changed in the database
        /// </summary>
        [TestMethod]
        public void TranslateFunctionTestMethod()
        {
            Assert.AreEqual(Function.Beheerder, CurrentAccount.TranslateFunction("Beheerder"));
            Assert.AreEqual(Function.Bezoeker, CurrentAccount.TranslateFunction("Bezoeker"));
            Assert.AreEqual(Function.Medewerker, CurrentAccount.TranslateFunction("Medewerker"));
            Assert.AreEqual(Function.Accountbeheerder, CurrentAccount.TranslateFunction("Accountbeheerder"));
        }




    }
}
