using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace OOM_Task4
{
    [TestFixture]

    public class Test3
    {
        [Test]

        public void NameIsWrong ()
        {
            var test3 = new Videogame("Testgame", "Action", 20);
            Assert.IsFalse(test3.Name == "Super Mario");
        }
    }
}
