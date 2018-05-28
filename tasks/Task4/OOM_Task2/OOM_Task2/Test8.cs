using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace OOM_Task4
{
    [TestFixture]

    public class Test8
    {
        [Test]

        public void CannotUpdatePrice()
        {
            Assert.Catch(() =>
            {
                var test8 = new Videogame("Super Mario", "Jump'n'Run", 10);
                test8.SetPrice(-25);
            }
            );

        }
    }
}