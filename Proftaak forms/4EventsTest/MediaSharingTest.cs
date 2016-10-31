using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Forms_version_1._0;
using Forms_version_1._0.Classes;
using Forms_version_1._0.Classes.Database.TimelineManagement;
using System.Collections.Generic;

namespace _4EventsTest
{
    [TestClass]
    public class MediaSharingTest
    {
        [TestMethod]
        public void CreatePostTest()
        {
            Post posttest = new Post("Posttest", "Muziek", 1, 1, 0);
            Assert.AreEqual(true, DatabaseAddPost.AddPost(posttest));
        }//Tests the creating a post method

        [TestMethod]
        public void CreateReactionTest()
        {
            Post posttest = new Post("Posttest", "Muziek", 1, 1, 0, "1");
            Assert.AreEqual(true, DatabaseAddPost.AddReaction(posttest));
        }//Test the creatign a reaction method

        [TestMethod]
        public void ConstructorTestPost()
        {
            Account Account = new Account(1, "Lin Lin", "Lin", "1", Function.Beheerder, null);
            Post posttest = new Post(99, "Posttest", "Muziek", 1, 1, 0, Account, null, "None", null);

            Assert.AreEqual(99, posttest.ID);
            Assert.AreEqual("Posttest", posttest.Text);
            Assert.AreEqual("Muziek", posttest.Category);
            Assert.AreEqual(1, posttest.AccountID);
            Assert.AreEqual(1, posttest.TimeLineID);
            Assert.AreEqual(0, posttest.Likes);
            Assert.AreEqual(Account, posttest.Account);
            Assert.AreEqual(null, posttest.File);
            Assert.AreEqual("None", posttest.Attachment);
            Assert.AreEqual(null, posttest.PostID);
        }//Tests the Post constructor

        [TestMethod]
        public void ConstructorTestTimeline()
        {
            TimeLine timelinetest = new TimeLine(1);

            Assert.AreEqual(1, timelinetest.TimelineID);
        }//Tests the Timeline constructor
    }
}
