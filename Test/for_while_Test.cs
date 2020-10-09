using NUnit.Framework;

namespace Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestFor4()
        {
            int a = 1;
            int b = 4;
            int rez = 24;
            int rez8 = popa.for_while.For8(a,b);
            Assert.AreEqual(rez, rez8);
        }
        [Test]
        public void TestFor16()
        {
            int N=3;
            double rez = 2.4024;
            double rez12 = popa.for_while.For12(N);
            Assert.AreEqual(rez, rez12);
        }
        [Test]
        public void TestWhile1()
        {
            int A = 5;
            int B = 2;
            int rez = 1;
            int rez12 = popa.for_while.While1(A, B);
            Assert.AreEqual(rez, rez12);
        }
        [Test]
        public void TestWhile8()
        {
            int N = 6;
            int rez = 0;
            int rez4 = popa.for_while.while4(N);
            Assert.AreEqual(rez, rez4);
        }
    }
}
