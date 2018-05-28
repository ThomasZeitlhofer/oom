using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace OOM_Task4
{
    [TestFixture]

    public class Test4
    {
        [Test]

        public void PriceIsMinus()
        {
            Assert.Catch(() =>
                {
                var test4 = new Videogame("Super Mario", "Jump'n'Run", -30);
                }
            );
        }
    }
}
