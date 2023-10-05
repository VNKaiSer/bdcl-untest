using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestBDCL1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TC001()
        {
            UnitTestBDCL1.HamKT clsHamKT = new UnitTestBDCL1.HamKT();
            string act_Triangle = clsHamKT.Triangle(-1, 5, 5);//Kết quả thực a,b,c=3
            string exp_Triangle = ""; // kết quả mong đợi
            Assert.AreEqual(exp_Triangle, act_Triangle); // hàm so sánh
        }

        [TestMethod]
        public void TC002()
        {
            UnitTestBDCL1.HamKT clsHamKT = new UnitTestBDCL1.HamKT();
            string act_Triangle = clsHamKT.Triangle(5, -1, 5);
            string exp_Triangle = ""; // kết quả mong đợi
            Assert.AreEqual(exp_Triangle, act_Triangle); // hàm so sánh
        }

        [TestMethod]
        public void TestMethodTC3()
        {
            UnitTestBDCL1.HamKT clsHamKT = new UnitTestBDCL1.HamKT();
            string act_Triangle = clsHamKT.Triangle(3, 3, 1);
            string exp_Triangle = "Isosceles"; 
            Assert.AreEqual(exp_Triangle, act_Triangle); // hàm so sánh
        }



    }
}
