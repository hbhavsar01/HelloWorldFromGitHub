using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorldFromGitHubTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string text = "Hello World!";

            Assert.AreEqual("Hello World!", text);
        }
    }
}
