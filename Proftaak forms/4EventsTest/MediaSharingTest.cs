using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Forms_version_1._0;
using Forms_version_1._0.Classes;
using Forms_version_1._0.Classes.Database.TimelineManagement;

namespace _4EventsTest
{
    [TestClass]
    class MediaSharingTest
    {
        [TestMethod]
        public void DataNameTest()
        {
            TimeLine timelinetest = new TimeLine(1);
            //Post Post1 = new Post("Goeie Toelie", "Check", 1, 1, 1, );
            //timelinetest.AddPost(Post1);
            DatabaseGetPost.GetPost();

        }
    }
}
