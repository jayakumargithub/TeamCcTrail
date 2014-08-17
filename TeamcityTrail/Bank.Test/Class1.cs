using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Bank.Test
{
    public class Class1
    {

        [Test]
        public void SomeTest()
        {
            var name = "Jayakumar";
            Assert.AreEqual("Jayakumar", name);
        }
    }
}
