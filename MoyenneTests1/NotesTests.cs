using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moyenne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moyenne.Tests
{
    [TestClass()]
    public class NotesTests
    {
        [TestMethod()]
        public void DeConvertionDecimaleTest()
        {
            Notes test = new Notes();
            //preparation
            decimal attendu = 9;
            decimal calculer = test.DeConvertionDecimale((decimal)5.9);
            Assert.AreEqual(attendu, calculer);
        }
    }
}