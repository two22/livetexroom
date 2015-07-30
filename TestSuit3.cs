using NUnit.Framework;

namespace LiveTex
{
    [TestFixture]
    public class TestSuit3
    {
        IRoom room;

        [SetUp]
        public void SetUp()
        {
            room = new Room();
            room.close();
        }

        [Test]
        public void Test1()
        {
            room.open();
            Assert.AreEqual(true, room.isEmpty());
        }

        [Test]
        [ExpectedException("RoomClosedException")]
        public void Test2()
        {
            room.addObject(new object());
        }

        [Test]
        [ExpectedException("RoomClosedException")]
        public void Test3()
        {
            room.getObject();
        }

        [Test]
        [ExpectedException("RoomClosedException")]
        public void Test4()
        {
            room.removeObject();
        }
    }
}
