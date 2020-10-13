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
            int input = 1;
            string output = TDDesze.GetValue(input);


        }
    }
}
