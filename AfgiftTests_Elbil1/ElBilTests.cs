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
    public class ElBilTests
    {
        [TestMethod()]
        public void GetRegistreringsAfgiftTest_Elbil2014_5000cost()
        {
            //Arrange
            ElBil elbil = new ElBil("Hunk", 5000, 2014, "HJ88333", 6, 10);

            //Act
            int afgift = elbil.GetRegistreringsAfgift();

            //Assert
            Assert.AreEqual(1050,afgift);

            //Assert.Fail();
        }

        [TestMethod()]
        public void GetRegistreringsAfgiftTest_Elbil2014_80499cost()
        {
            //Arrange
            ElBil elbil = new ElBil("Hunk", 80499, 2014, "HJ88333", 6, 10);

            //Act
            int afgift = elbil.GetRegistreringsAfgift();

            //Assert
            Assert.AreEqual(16904, afgift);

            //Assert.Fail();
        }

        [TestMethod()]
        public void GetRegistreringsAfgiftTest_Elbil2014_80500cost()
        {
            //Arrange
            ElBil elbil = new ElBil("Hunk", 80500, 2014, "HJ88333", 6, 10);

            //Act
            int afgift = elbil.GetRegistreringsAfgift();

            //Assert
            Assert.AreEqual(16905, afgift);

            //Assert.Fail();
        }

        [TestMethod()]
        public void GetRegistreringsAfgiftTest_Elbil2014_80501cost()
        {
            //Arrange
            ElBil elbil = new ElBil("Hunk", 80501, 2014, "HJ88333", 6, 10);

            //Act
            int afgift = elbil.GetRegistreringsAfgift();

            //Assert
            Assert.AreEqual(16905, afgift);

            //Assert.Fail();
        }

        [TestMethod()]
        public void GetRegistreringsAfgiftTest_Elbil2014_100000cost()
        {
            //Arrange
            ElBil elbil = new ElBil("Hunk", 100000, 2014, "HJ88333", 6, 10);

            //Act
            int afgift = elbil.GetRegistreringsAfgift();

            //Assert
            Assert.AreEqual(23925, afgift);

            //Assert.Fail();
        }

            [TestMethod()]
            public void GetRegistreringsAfgiftTest_Elbil2015_5000cost()
            {
                //Arrange
                ElBil elbil = new ElBil("Hunk", 5000, 2015, "HJ88333", 6, 10);

                //Act
                int afgift = elbil.GetRegistreringsAfgift();

                //Assert
                Assert.AreEqual(1050, afgift);

                //Assert.Fail();
            }

            [TestMethod()]
            public void GetRegistreringsAfgiftTest_Elbil2015_81966cost()
            {
                //Arrange
                ElBil elbil = new ElBil("Hunk", 81699, 2015, "HJ88333", 6, 10);

                //Act
                int afgift = elbil.GetRegistreringsAfgift();

                //Assert
                Assert.AreEqual(17156, afgift);

                //Assert.Fail();
            }

            [TestMethod()]
            public void GetRegistreringsAfgiftTest_Elbil2015_81700cost()
            {
                //Arrange
                ElBil elbil = new ElBil("Hunk", 81700, 2015, "HJ88333", 6, 10);

                //Act
                int afgift = elbil.GetRegistreringsAfgift();

                //Assert
                Assert.AreEqual(17157, afgift);

                //Assert.Fail();
            }

            [TestMethod()]
            public void GetRegistreringsAfgiftTest_Elbil2015_81701cost()
            {
                //Arrange
                ElBil elbil = new ElBil("Hunk", 81701, 2015, "HJ88333", 6, 10);

                //Act
                int afgift = elbil.GetRegistreringsAfgift();

                //Assert
                Assert.AreEqual(17157, afgift);

                //Assert.Fail();
            }

            [TestMethod()]
            public void GetRegistreringsAfgiftTest_Elbil2015_100000cost()
            {
                //Arrange
                ElBil elbil = new ElBil("Hunk", 100000, 2015, "HJ88333", 6, 10);

                //Act
                int afgift = elbil.GetRegistreringsAfgift();

                //Assert
                Assert.AreEqual(23745, afgift);

                //Assert.Fail();
            }

        [TestMethod()]
        public void HalvÅrligEjerAfgift_Elbil_0()
        {
            //arrange 
            ElBil elbil = new ElBil("Hunk", 100000, 2015, "HJ88333", 6, 10);

            //act
            int afgift = elbil.HalvÅrligEjerafgift();

            Assert.AreEqual(0,afgift);
        }

        }
}