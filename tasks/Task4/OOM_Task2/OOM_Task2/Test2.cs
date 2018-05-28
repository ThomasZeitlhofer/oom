using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace OOM_Task4
{
    [TestFixture]

    public class Test2
    {
        [Test]

        public void GenreIsSame()
        {
            var test2 = new Movie("Terminator", "Action", 20);
            Assert.IsTrue(test2.Genre == "Action");
        }
    }
}