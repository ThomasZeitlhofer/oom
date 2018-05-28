using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace OOM_Task4
{
    [TestFixture]

    public class Test5
    {
        [Test]

        public void CannotCreateBookWithEmptyName()
        {
            Assert.Catch(() =>
            {
                var test5 = new Videogame("", "Jump'n'Run", 30);
            }
            );
        }
    }
}