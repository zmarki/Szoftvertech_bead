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
        public void esze_when1_return1()
        {
            //arrage
            int input = 1;
            //act
            int output = TDDesze.GetValue(input);
            //assert
            if (output > 0)
                Assert.Pass();
            else
                Assert.Fail();
        }
        [Test]
        public void esze_when2_return2()
        {
            //arrage
            int input = 95;
            //act
            int output = TDDesze.GetValue(input);
            //assert
            if (output <= 90)
            {
                Assert.Pass();
            }
            else
                Assert.Fail();
        }
    }
}
