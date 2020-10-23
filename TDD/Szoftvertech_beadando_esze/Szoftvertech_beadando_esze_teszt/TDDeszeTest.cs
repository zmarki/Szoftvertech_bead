using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szoftvertech_beadando_esze;

namespace Szoftvertech_beadando_esze_teszt
{
    [TestFixture]
    public class TDDeszeTest
    {
        [Test]
        public void nagyobb()
        {
            //arrage
            int input = 1;
            //act
            int output = TDDesze.GetValue(input);
            //assert
            if (output > 0)
                Assert.Pass();
            Assert.Fail();
         

        }
    }
}
       