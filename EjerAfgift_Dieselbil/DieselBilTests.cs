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
    public class DieselBilTests
    {
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
    }
}