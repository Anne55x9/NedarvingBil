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

        //Diesel 2014
        [TestMethod()]

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

        //Diesel 2015

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

       
        //Diesel 2017

        [TestMethod()]

        public void GetRegistreringsAfgift_Diesel2017_100000()
        {
            //arrange 
            DieselBil dieselbil = new DieselBil("Hanoi", 100000, 2017, "DE55222", 10, 10);

            //act 
            int afgift = dieselbil.GetRegistreringsAfgift();

            //assert
            Assert.AreEqual(105000, afgift);
        }

        [TestMethod()]

        public void GetRegistreringsAfgift_Diesel2017_106599()
        {
            //arrange 
            DieselBil dieselbil = new DieselBil("Hanoi", 106599, 2017, "DE55222", 10, 10);

            //act 
            int afgift = dieselbil.GetRegistreringsAfgift();

            //assert
            Assert.AreEqual(111928, afgift);
        }

        [TestMethod()]

        public void GetRegistreringsAfgift_Diesel2017_106600()
        {
            //arrange 
            DieselBil dieselbil = new DieselBil("Hanoi", 106600, 2017, "DE55222", 10, 10);

            //act 
            int afgift = dieselbil.GetRegistreringsAfgift();

            //assert
            Assert.AreEqual(111930, afgift);
        }

        [TestMethod()]

        public void GetRegistreringsAfgift_Diesel2017_106601()
        {
            //arrange 
            DieselBil dieselbil = new DieselBil("Hanoi", 106601, 2017, "DE55222", 10, 10);

            //act 
            int afgift = dieselbil.GetRegistreringsAfgift();

            //assert
            Assert.AreEqual(111931, afgift);
        }

        [TestMethod()]

        public void GetRegistreringsAfgift_Diesel2017_150000()
        {
            //arrange 
            DieselBil dieselbil = new DieselBil("Hanoi", 150000, 2017, "DE55222", 10, 10);

            //act 
            int afgift = dieselbil.GetRegistreringsAfgift();

            //assert
            Assert.AreEqual(177030, afgift);
        }

        //Næste step er at lave tests på benzinbiler på samme facon som for dieselbilen.

            //Benzin 2014

        [TestMethod()]

        public void GetRegistreringsAfgift_BenzinBil2014_5000cost()
        {
            //arrange
            BenzinBil benzinbil = new BenzinBil("RobinBil", 5000, 2014, "AD71700", 40, 5);

            //act
            int afgift = benzinbil.GetRegistreringsAfgift();

            //assert

            Assert.AreEqual(5250, afgift);
        }

        [TestMethod()]
        public void GetRegistreringsAfgift_BenzinBil2014_80499cost()
        {
            //arrange
            BenzinBil benzinbil = new BenzinBil("BatmanBil", 80499, 2014, "HD04020", 35, 6);

            //act
            int afgift = benzinbil.GetRegistreringsAfgift();

            //assert

            Assert.AreEqual(84523, afgift);
        }

        [TestMethod()]
        public void GetRegistreringsAfgift_BenzinBil2014_80500cost()
        {
            //arrange
            BenzinBil benzinbil = new BenzinBil("Gocar", 80500, 2014, "KD30090", 40, 7);

            //act
            int afgift = benzinbil.GetRegistreringsAfgift();

            //assert

            Assert.AreEqual(84525, afgift);
        }

        [TestMethod()]
        public void GetRegistreringAfgift_BenzinBil2014_80501cost()
        {
            //arrange 
            BenzinBil benzinbil = new BenzinBil("PiloCar", 80501, 2014, "IH40500", 30, 6);

            //act
            int afgift = benzinbil.GetRegistreringsAfgift();

            //assert
            Assert.AreEqual(84526, afgift);
        }

        [TestMethod()]
        public void GetRegistreringsAfgiftTest_BenzinBil2014_100000cost()
        {
            //arrange
            BenzinBil benzinbil = new BenzinBil("Tesla", 100000, 2014, "DD77380", 60, 10);

            //act

            int afgift = benzinbil.GetRegistreringsAfgift();

            //assert

            Assert.AreEqual(119625, afgift);

            // Assert.Fail();
        }

        //Benzin 2015

        [TestMethod()]
        public void GetRegistreringsAfgiftTest_BenzinBil2015_5000cost()
        {
            //arrange
            BenzinBil benzinbil = new BenzinBil("Tesla", 5000, 2015, "DD77380", 60, 10);

            //act

            int afgift = benzinbil.GetRegistreringsAfgift();

            //assert

            Assert.AreEqual(5250, afgift);

            // Assert.Fail();
        }

        [TestMethod()]
        public void GetRegistreringsAfgiftTest_BenzinBil2015_81699cost()
        {
            //arrange
            BenzinBil benzinbil = new BenzinBil("Tesla", 81699, 2015, "DD77380", 60, 10);

            //act

            int afgift = benzinbil.GetRegistreringsAfgift();

            //assert

            Assert.AreEqual(85783, afgift);

            // Assert.Fail();
        }

        [TestMethod()]
        public void GetRegistreringsAfgiftTest_BenzinBil2015_81700cost()
        {
            //arrange
            BenzinBil benzinbil = new BenzinBil("Tesla", 81700, 2015, "DD77380", 60, 10);

            //act

            int afgift = benzinbil.GetRegistreringsAfgift();

            //assert

            Assert.AreEqual(85785, afgift);
        }

        [TestMethod()]
        public void GetRegistreringsAfgiftTest_BenzinBil2015_81701cost()
        {
            //arrange
            BenzinBil benzinbil = new BenzinBil("Tesla", 81701, 2015, "DD77380", 60, 10);

            //act

            int afgift = benzinbil.GetRegistreringsAfgift();

            //assert

            Assert.AreEqual(85786, afgift);
        }

        [TestMethod()]
        public void GetRegistreringsAfgiftTest_BenzinBil2015_100000cost()
        {
            //arrange
            BenzinBil benzinbil = new BenzinBil("Tesla", 100000, 2015, "DD77380", 60, 10);

            //act

            int afgift = benzinbil.GetRegistreringsAfgift();

            //assert

            Assert.AreEqual(118725, afgift);

            // Assert.Fail();
        }



        //UnitTests af bilafgifter 2017 på benzinbiler.

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


        //Test af HalvårligEjerAfgift

        //Dieselbiler m. partikelfilter

        [TestMethod()]

        public void GetHalvårligEjerAfgift_DieselmP_14kmL()
        {
            //arrange 
            DieselBil dieselbil = new DieselBil("Hanoi", 150000, 2017, "DE55222", 14, 10);

            //act 
            int afgift = dieselbil.HalvÅrligEjerafgift();

            //assert
            Assert.AreEqual(2000, afgift);
        }

        [TestMethod()]

        public void GetHalvårligEjerAfgift_DieselmP_15kmL()
        {
            //arrange 
            DieselBil dieselbil = new DieselBil("Hanoi", 150000, 2017, "DE55222", 15, 10);

            //act 
            int afgift = dieselbil.HalvÅrligEjerafgift();

            //assert
            Assert.AreEqual(1000, afgift);
        }

        [TestMethod()]

        public void GetHalvårligEjerAfgift_DieselmP_16kmL()
        {
            //arrange 
            DieselBil dieselbil = new DieselBil("Hanoi", 150000, 2017, "DE55222", 16, 10);

            //act 
            int afgift = dieselbil.HalvÅrligEjerafgift();

            //assert
            Assert.AreEqual(1000, afgift);
        }

        [TestMethod()]

        public void GetHalvårligEjerAfgift_DieselmP_25kmL()
        {
            //arrange 
            DieselBil dieselbil = new DieselBil("Hanoi", 150000, 2017, "DE55222", 25, 10);

            //act 
            int afgift = dieselbil.HalvÅrligEjerafgift();

            //assert
            Assert.AreEqual(1000, afgift);
        }

        [TestMethod()]

        public void GetHalvårligEjerAfgift_DieselmP_26kmL()
        {
            //arrange 
            DieselBil dieselbil = new DieselBil("Hanoi", 150000, 2017, "DE55222", 26, 10);

            //act 
            int afgift = dieselbil.HalvÅrligEjerafgift();

            //assert
            Assert.AreEqual(350, afgift);
        }

        // dieselbil uden filter

        [TestMethod()]

        public void GetHalvårligEjerAfgift_DieselUP_14kmL()
        {
            //arrange 
            DieselBil dieselbil = new DieselBil("Hanoi", 150000, 2017, "DE55222", 14, false, 10);

            //act 
            int afgift = dieselbil.HalvÅrligEjerafgift();

            //assert
            Assert.AreEqual(2500, afgift);
        }

        [TestMethod()]

        public void GetHalvårligEjerAfgift_DieselUP_15kmL()
        {
            //arrange 
            DieselBil dieselbil = new DieselBil("Hanoi", 150000, 2017, "DE55222", 15, false, 10);

            //act 
            int afgift = dieselbil.HalvÅrligEjerafgift();

            //assert
            Assert.AreEqual(1500, afgift);
        }

        [TestMethod()]

        public void GetHalvårligEjerAfgift_DieselUP_16kmL()
        {
            //arrange 
            DieselBil dieselbil = new DieselBil("Hanoi", 150000, 2017, "DE55222", 16, false, 10);

            //act 
            int afgift = dieselbil.HalvÅrligEjerafgift();

            //assert
            Assert.AreEqual(1500, afgift);
        }

        [TestMethod()]

        public void GetHalvårligEjerAfgift_DieselUP_25kmL()
        {
            //arrange 
            DieselBil dieselbil = new DieselBil("Hanoi", 150000, 2017, "DE55222", 25, false, 10);

            //act 
            int afgift = dieselbil.HalvÅrligEjerafgift();

            //assert
            Assert.AreEqual(1500, afgift);
        }

        [TestMethod()]

        public void GetHalvårligEjerAfgift_DieselUP_26kmL()
        {
            //arrange 
            DieselBil dieselbil = new DieselBil("Hanoi", 150000, 2017, "DE55222", 26, false, 10);

            //act 
            int afgift = dieselbil.HalvÅrligEjerafgift();

            //assert
            Assert.AreEqual(850, afgift);
        }

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

    }
}