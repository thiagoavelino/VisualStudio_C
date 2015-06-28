using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VisualStudio_C.Generics;

namespace UnitTestProject1 {
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        public void Owerwrites_When_More_Than_Capacity() {
            var buffer = new CircularBuffer(capacity: 3);
            var values = new[] { 1.0, 2.0, 3.0, 4.0, 5.0 };
            foreach(var value in values) {
                buffer.Write(value);
            }
            Assert.IsTrue(buffer.IsFull);
            Assert.AreEqual(values[2], buffer.Read());
            Assert.AreEqual(values[3], buffer.Read());
            Assert.AreEqual(values[4], buffer.Read());
            Assert.IsTrue(buffer.IsEmpty);
        }
    }
}
