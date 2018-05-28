using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace OOM_Task4
{
    [TestFixture]

    public class Test9
    {
        [Test]

        public void NameIsNotTrue()
        {
            var test9 = new Videogame("Testagme", "Testgenre", 10);

            Assert.IsFalse(test9.Name == "Zelda");
        }
    }
}