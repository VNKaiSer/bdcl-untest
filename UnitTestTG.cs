using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestBDCL1
{
    [TestClass]
    public class UnitTestTG
    {
        [TestMethod]
        public void TCVP1()
        {
            UnitTestBDCL1.HamKT clsHamKT = new UnitTestBDCL1.HamKT();
            string act_Triangle = clsHamKT.Triangle(7, 4, 3);//Kết quả thực a,b,c=3
            string exp_Triangle = ""; // kết quả mong đợi
            Assert.AreEqual(exp_Triangle, act_Triangle); // hàm so sánh
        }

        [TestMethod]
        public void TCVP2()
        {
            UnitTestBDCL1.HamKT clsHamKT = new UnitTestBDCL1.HamKT();
            string act_Triangle = clsHamKT.Triangle(3, 4, 5);
            string exp_Triangle = "Scalene"; // kết quả mong đợi
            Assert.AreEqual(exp_Triangle, act_Triangle); // hàm so sánh
        }

        [TestMethod]
        public void VP3_1CanTaiA()
        {
            UnitTestBDCL1.HamKT clsHamKT = new UnitTestBDCL1.HamKT();
            string act_Triangle = clsHamKT.Triangle(6, 6, 5);
            string exp_Triangle = "Isosceles";
            Assert.AreEqual(exp_Triangle, act_Triangle); // hàm so sánh
        }
        [TestMethod]
        public void VP3_1CanTaiB()
        {
            UnitTestBDCL1.HamKT clsHamKT = new UnitTestBDCL1.HamKT();
            string act_Triangle = clsHamKT.Triangle(5, 6, 5);
            string exp_Triangle = "Isosceles";
            Assert.AreEqual(exp_Triangle, act_Triangle); // hàm so sánh
        }

        [TestMethod]
        public void VP3_1CanTaiC()
        {
            UnitTestBDCL1.HamKT clsHamKT = new UnitTestBDCL1.HamKT();
            string act_Triangle = clsHamKT.Triangle(5, 5, 6);
            string exp_Triangle = "Isosceles";
            Assert.AreEqual(exp_Triangle, act_Triangle); // hàm so sánh
        }

        [TestMethod]
        public void VP4()
        {
            UnitTestBDCL1.HamKT clsHamKT = new UnitTestBDCL1.HamKT();
            string act_Triangle = clsHamKT.Triangle(5, 5, 5);
            string exp_Triangle = "Equilateral";
            Assert.AreEqual(exp_Triangle, act_Triangle); // hàm so sánh
        }

        [TestMethod]
        public void IVPA1()
        {
            UnitTestBDCL1.HamKT clsHamKT = new UnitTestBDCL1.HamKT();
            string act_Triangle = clsHamKT.Triangle(-1, 4, 5);
            string exp_Triangle = "";
            Assert.AreEqual(exp_Triangle, act_Triangle); // hàm so sánh
        }

        [TestMethod]
        public void VPA1()
        {
            UnitTestBDCL1.HamKT clsHamKT = new UnitTestBDCL1.HamKT();
            string act_Triangle = clsHamKT.Triangle(1, 1, 1);
            string exp_Triangle = "Equilateral";
            Assert.AreEqual(exp_Triangle, act_Triangle); // hàm so sánh
        }

        [TestMethod]
        public void IVBA1()
        {
            UnitTestBDCL1.HamKT clsHamKT = new UnitTestBDCL1.HamKT();
            string act_Triangle = clsHamKT.Triangle(0, 4, 5);
            string exp_Triangle = "";
            Assert.AreEqual(exp_Triangle, act_Triangle); // hàm so sánh
        }

        [TestMethod]
        public void IVPBA1()
        {
            UnitTestBDCL1.HamKT clsHamKT = new UnitTestBDCL1.HamKT();
            string act_Triangle = clsHamKT.Triangle(3, -1, 5);
            string exp_Triangle = "";
            Assert.AreEqual(exp_Triangle, act_Triangle); // hàm so sánh
        }

        [TestMethod]
        public void IVPB1()
        {
            UnitTestBDCL1.HamKT clsHamKT = new UnitTestBDCL1.HamKT();
            string act_Triangle = clsHamKT.Triangle(3, -1, 5);
            string exp_Triangle = "";
            Assert.AreEqual(exp_Triangle, act_Triangle); // hàm so sánh
        }

        [TestMethod]
        public void VBB1()
        {
            UnitTestBDCL1.HamKT clsHamKT = new UnitTestBDCL1.HamKT();
            string act_Triangle = clsHamKT.Triangle(1, 1, 1);
            string exp_Triangle = "Equilateral";
            Assert.AreEqual(exp_Triangle, act_Triangle); // hàm so sánh
        }

        [TestMethod]
        public void IVBB1()
        {
            UnitTestBDCL1.HamKT clsHamKT = new UnitTestBDCL1.HamKT();
            string act_Triangle = clsHamKT.Triangle(3, 0, 5);
            string exp_Triangle = "";
            Assert.AreEqual(exp_Triangle, act_Triangle); // hàm so sánh
        }

        [TestMethod]
        public void IVPC1()
        {
            UnitTestBDCL1.HamKT clsHamKT = new UnitTestBDCL1.HamKT();
            string act_Triangle = clsHamKT.Triangle(3, 4, -1);
            string exp_Triangle = "";
            Assert.AreEqual(exp_Triangle, act_Triangle); // hàm so sánh
        }

        [TestMethod]
        public void IVBC1()
        {
            UnitTestBDCL1.HamKT clsHamKT = new UnitTestBDCL1.HamKT();
            string act_Triangle = clsHamKT.Triangle(3, 4, 0);
            string exp_Triangle = "";
            Assert.AreEqual(exp_Triangle, act_Triangle); // hàm so sánh
        }





    }
}
