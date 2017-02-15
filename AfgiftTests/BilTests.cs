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

        //Næste step er at lave tests på benzinbiler på samme facon som for dieselbilen.





    }
}