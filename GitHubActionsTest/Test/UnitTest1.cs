using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GitHubActionsTest;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Program.Main(new string[0]);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Program.Main(new string[] { "heeyy" });
        }
    }
}
