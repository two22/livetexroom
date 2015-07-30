using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace LiveTex
{
    [TestFixture]
    public class SmokeTest
    {
        IRoom room;

        [SetUp]
        public void SetUp()
        {
            room = new Room();
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(true, room.isEmpty());
        }

        [Test]
        public void Test2()
        {
            room.addObject(new object());
            Assert.AreEqual(false, room.isEmpty());
        }

        [Test]
        [ExpectedException("RoomClosedException")]
        public void Test3()
        {
            room.close();
            room.isEmpty();
        }
    }
}
