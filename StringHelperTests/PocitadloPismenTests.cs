using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringHelper.Tests
{
    [TestClass()]
    public class PocitadloPismenTests
    {
        [TestMethod()]
        public void IndexerTest()
        {
            PocitadloPismen pocitadlo = new PocitadloPismen();
            pocitadlo.Text = "Máma nemá ráda maso.";

            int expected = 3;
            int result = pocitadlo['a'];

            Assert.AreEqual(expected, result);
        }
    }
}