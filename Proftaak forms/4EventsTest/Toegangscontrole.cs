using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Forms_version_1._0.Classes;
using Forms_version_1._0;
using System.Collections.Generic;

namespace _4EventsTest
{
    [TestClass]
    public class Toegangscontrole
    {
        Event testEvent = new Event(100, "TestEvent", "TestBeschrijving", "TestLocatie", 100, DateTime.Now);


        [TestMethod]
        public void GuestListTest()
        {
            List<Account> GuestList = new List<Account>();

            GuestList = testEvent.GetGuestList();

            Assert.AreNotEqual(null, GuestList);
        }
    }
}
