using System;
using NUnit.Framework;

namespace LiveTex
{
    [TestFixture]
    public class TestSuit2
    {
        IRoom room;
        Object obj;

        [SetUp]
        public void SetUp()
        {
            room = new Room();
            obj = new Object();
            room.addObject(obj);
        }

        [Test]
        [ExpectedException("RoomIsNotEmptyException")]
        public void Test1()
        {
            room.addObject(new object());
        }

        [Test]
        public void Test2()
        {
            room.removeObject();
            Assert.AreEqual(true, room.isEmpty());
        }
    }
}
