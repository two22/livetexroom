using NUnit.Framework;

namespace LiveTex
{
    namespace LiveTex
    {
        [TestFixture]
        public class TestSuit1
        {
            IRoom room;
            object obj;

            [SetUp]
            public void SetUp()
            {
                room = new Room();
                obj = new object();
            }

            [Test]
            public void Test1()
            {
                room.addObject(obj);
                Assert.AreEqual(true, room.getObject().Equals(obj));
            }

            [Test]
            [ExpectedException("RoomIsEmptyException")]
            public void Test2()
            {
                room.removeObject();
            }
        }
    }
}
