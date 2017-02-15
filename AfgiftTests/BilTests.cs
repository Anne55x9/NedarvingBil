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

    public class BilTests
    {
        [TestMethod()]
        //[ExpectedException(typeof(ArgumentException))]


        public void GetRegistreringsAfgift_DieselBil2014_5000cost()
        {
            //arrange
            DieselBil dieselbil = new DieselBil("RobinBil", 5000, 2014, "AD71700", 40, false,5);

            //act
            int afgift = dieselbil.GetRegistreringsAfgift();

            //assert

            Assert.AreEqual(5250,afgift);
        }

        [TestMethod()]
        public void GetRegistreringsAfgift_DieselBil2014_80499cost()
        {
            //arrange
            DieselBil dieselbil = new DieselBil("BatmanBil",80499,2014,"HD04020", 35, false, 6);

            //act
            int afgift = dieselbil.GetRegistreringsAfgift();

            //assert

            Assert.AreEqual(84523,afgift);
        }

        [TestMethod()]
        public void GetRegistreringsAfgift_DieselBil2014_80500cost()
        {
            //arrange
            DieselBil dieselbil = new DieselBil("Gocar", 80500, 2014, "KD30090", 40, true, 7);

            //act
            int afgift = dieselbil.GetRegistreringsAfgift();

            //assert

            Assert.AreEqual(84525,afgift);
        } 

        [TestMethod()]
        public void GetRegistreringAfgift_DieselBil2014_80501cost()
        {
            //arrange 
            DieselBil dieselbil = new DieselBil("PiloCar", 80501, 2014, "IH40500", 30, false, 6);

            //act
            int afgift = dieselbil.GetRegistreringsAfgift();

            //assert
            Assert.AreEqual(84526,afgift);
        }

        [TestMethod()]
        public void GetRegistreringsAfgiftTest_DieselBil2014_100000cost()
        {
            //arrange
            DieselBil dieselbil = new DieselBil("Tesla", 100000, 2014, "DD77380", 60, true, 10);

            //act

            int afgift = dieselbil.GetRegistreringsAfgift();

            //assert

            Assert.AreEqual(119625, afgift);

            // Assert.Fail();
        }

        [TestMethod()]
        public void GetRegistreringsAfgiftTest_DieselBil2015_5000cost()
        {
            //arrange
            DieselBil dieselbil = new DieselBil("Tesla", 5000, 2015, "DD77380", 60, true, 10);

            //act

            int afgift = dieselbil.GetRegistreringsAfgift();

            //assert

            Assert.AreEqual(5250, afgift);

            // Assert.Fail();
        }

        [TestMethod()]
        public void GetRegistreringsAfgiftTest_DieselBil2015_81699cost()
        {
            //arrange
            DieselBil dieselbil = new DieselBil("Tesla", 81699, 2015, "DD77380", 60, true, 10);

            //act

            int afgift = dieselbil.GetRegistreringsAfgift();

            //assert

            Assert.AreEqual(85783, afgift);

            // Assert.Fail();
        }

        [TestMethod()]
        public void GetRegistreringsAfgiftTest_DieselBil2015_81700cost()
        {
            //arrange
            DieselBil dieselbil = new DieselBil("Tesla", 81700, 2015, "DD77380", 60, true, 10);

            //act

            int afgift = dieselbil.GetRegistreringsAfgift();

            //assert

            Assert.AreEqual(85785, afgift);
        }

        [TestMethod()]
        public void GetRegistreringsAfgiftTest_DieselBil2015_81701cost()
        {
            //arrange
            DieselBil dieselbil = new DieselBil("Tesla", 81701, 2015, "DD77380", 60, true, 10);

            //act

            int afgift = dieselbil.GetRegistreringsAfgift();

            //assert

            Assert.AreEqual(85786,afgift);
        }

        [TestMethod()]
        public void GetRegistreringsAfgiftTest_DieselBil2015_100000cost()
        {
            //arrange
            DieselBil dieselbil = new DieselBil("Tesla", 100000, 2015, "DD77380", 60, true, 10);

            //act

            int afgift = dieselbil.GetRegistreringsAfgift();

            //assert

            Assert.AreEqual(118725, afgift);

            // Assert.Fail();
        }

        //Næste step er at lave tests på benzinbiler på samme facon som for dieselbilen.


        //Test af Exception kast i registreringsafgift metoden.

        [TestMethod()]
        [ExpectedException(typeof(HalvÅrligEjerAfgiftException))]

        public void GetRegistreringsAfgift_DieselBil2015_0cost()
        {
            //arrange
            DieselBil dieselbil = new DieselBil("RobinBil", 0, 2015, "AD71700", 40, false, 5);

            //act
            int afgift = dieselbil.GetRegistreringsAfgift();

            //assert

           //Assert.AreEqual(0, afgift);
        }

        [TestMethod()]
        [ExpectedException(typeof(HalvÅrligEjerAfgiftException))]

        public void GetRegistreringsAfgift_DieselBil2010_5000cost()
        {
            //arrange
            DieselBil dieselbil = new DieselBil("RobinBil", 10000, 2010, "AD71700", 40, false, 5);

            //act
            int afgift = dieselbil.GetRegistreringsAfgift();

            //assert
            // Assert.AreEqual(5250, afgift);
        }



        //UnitTests af bilafgifter fra the year of LA(lasy assholls) 2017 på benzinbiler.

        [TestMethod()]

        public void GetRegistreringsAfgift_Benzin2017_100000()
        {
            //arrange 
            BenzinBil benzinbil = new BenzinBil("Hanoi", 100000, 2017, "DE55222", 10, 10);

            //act 
            int afgift = benzinbil.GetRegistreringsAfgift();

            //assert
            Assert.AreEqual(105000, afgift); 
        }

        [TestMethod()]

        public void GetRegistreringsAfgift_Benzin2017_106599()
        {
            //arrange 
            BenzinBil benzinbil = new BenzinBil("Hanoi", 106599, 2017, "DE55222", 10, 10);

            //act 
            int afgift = benzinbil.GetRegistreringsAfgift();

            //assert
            Assert.AreEqual(111928, afgift);
        }

        [TestMethod()]

        public void GetRegistreringsAfgift_Benzin2017_106600()
        {
            //arrange 
            BenzinBil benzinbil = new BenzinBil("Hanoi", 106600, 2017, "DE55222", 10, 10);

            //act 
            int afgift = benzinbil.GetRegistreringsAfgift();

            //assert
            Assert.AreEqual(111930, afgift);
        }

        [TestMethod()]

        public void GetRegistreringsAfgift_Benzin2017_106601()
        {
            //arrange 
            BenzinBil benzinbil = new BenzinBil("Hanoi", 106601, 2017, "DE55222", 10, 10);

            //act 
            int afgift = benzinbil.GetRegistreringsAfgift();

            //assert
            Assert.AreEqual(111931, afgift);
        }

        [TestMethod()]

        public void GetRegistreringsAfgift_Benzin2017_150000()
        {
            //arrange 
            BenzinBil benzinbil = new BenzinBil("Hanoi", 150000, 2017, "DE55222", 10, 10);

            //act 
            int afgift = benzinbil.GetRegistreringsAfgift();

            //assert
            Assert.AreEqual(177030, afgift);
        }

    }
}