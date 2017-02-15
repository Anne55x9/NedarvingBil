using Microsoft.VisualStudio.TestTools.UnitTesting;
using NedarvingBil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NedarvingBil.Tests
{
    [TestClass()]
    public class BenzinBilTests
    {
        //Test af halårligejerafgift benzinbil

        [TestMethod()]
        public void GetHalvÅrligEjerAfgift_Benzin_19kmL()
        {
            //arrange
            BenzinBil benzinbil = new BenzinBil("Klap", 10000, 2015, "FG66555", 19, 5);

            //act
            int afgift = benzinbil.HalvÅrligEjerafgift();

            //Assert
            Assert.AreEqual(1200, afgift);
        }


        [TestMethod()]
        public void GetHalvÅrligEjerAfgift_Benzin_20kmL()
        {
            //arrange
            BenzinBil benzinbil = new BenzinBil("Klap", 10000, 2015, "FG66555", 20, 5);

            //act
            int afgift = benzinbil.HalvÅrligEjerafgift();

            //Assert
            Assert.AreEqual(600, afgift);
        }

        [TestMethod()]
        public void GetHalvÅrligEjerAfgift_Benzin_28kmL()
        {
            //arrange
            BenzinBil benzinbil = new BenzinBil("Klap", 10000, 2015, "FG66555", 28, 5);

            //act
            int afgift = benzinbil.HalvÅrligEjerafgift();

            //Assert
            Assert.AreEqual(600, afgift);
        }

        [TestMethod()]
        public void GetHalvÅrligEjerAfgift_Benzin_29kmL()
        {
            //arrange
            BenzinBil benzinbil = new BenzinBil("Klap", 10000, 2015, "FG66555", 29, 5);

            //act
            int afgift = benzinbil.HalvÅrligEjerafgift();

            //Assert
            Assert.AreEqual(320, afgift);
        }

    }
}