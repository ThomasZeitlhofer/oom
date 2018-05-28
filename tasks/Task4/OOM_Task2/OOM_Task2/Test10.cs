using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace OOM_Task4
{
    [TestFixture]

    public class Test10
    {
        [Test]

        public void NameIsSame()
        {
            var test = new Movie("Star Wars", "Action", 10);
            Assert.IsTrue(test.Name == "Star Wars");
        }
    }
}
