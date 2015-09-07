using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsForm;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculateProgress_max()
        {
            WindowsForm.Utils ut = new Utils();
            Assert.AreEqual(ut.CalculateProgress(10), 0);


        }
        [TestMethod]
        public void CalculateProgress_middle()
        {
            WindowsForm.Utils ut = new Utils();
            for (int i = 0; i <= 9; i++)
                Assert.AreEqual(ut.CalculateProgress(i), i+1);
        }

        [TestMethod]
        public void CalculateProgress_min()
        {
            WindowsForm.Utils ut = new Utils();
            Assert.AreEqual(ut.CalculateProgress(0), 1);

        }

        [TestMethod]
        public void CalculateProgress_Exception()
        {
            WindowsForm.Utils ut = new Utils();
            Assert.AreEqual(ut.CalculateProgress(-5), 1);

        }

    }
}
