using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace OOM_Task4
{
    [TestFixture]

    public class Test6
    {
        [Test]

        public void CannotCreateBookWithEmptyName2()
        {
            Assert.Catch(() =>
            {
                var test5 = new Videogame(null, "Jump'n'Run", 30);
            }
            );
        }
    }
}
