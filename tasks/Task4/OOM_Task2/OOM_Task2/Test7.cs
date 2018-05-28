using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace OOM_Task4
{
    [TestFixture]

    public class Test7
    {
        [Test]

        public void CanUpdatePrice()
        {
            var test7 = new Videogame("Testmovie", "Testgenre", 10);
            test7.SetPrice(20);

            Assert.IsTrue(test7.Price == 20);
        }
    }
}