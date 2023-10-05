using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestBDCL1
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void VP1()
        {
            UnitTestBDCL1.CheckLeapYear clsLeapYear = new UnitTestBDCL1.CheckLeapYear();
            bool act_Triangle = clsLeapYear.IsLeapYear(1720);//Kết quả thực a,b,c=3
           // bool exp_Triangle = true; // kết quả mong đợi
            Assert.IsTrue(act_Triangle, "Sai roi ne"); // hàm so sánh
        }

        [TestMethod]
        public void VP2()
        {
            UnitTestBDCL1.CheckLeapYear clsLeapYear = new UnitTestBDCL1.CheckLeapYear();
            bool act_Triangle = clsLeapYear.IsLeapYear(1750);//Kết quả thực a,b,c=3
                                                             // bool exp_Triangle = true; // kết quả mong đợi
            Assert.IsFalse(act_Triangle, "Sai roi ne"); // hàm so sánh
        }

        [TestMethod]
        public void IVP1()
        {
            UnitTestBDCL1.CheckLeapYear clsLeapYear = new UnitTestBDCL1.CheckLeapYear();
            bool act_Triangle = clsLeapYear.IsLeapYear(1234);//Kết quả thực a,b,c=3
                                                             // bool exp_Triangle = true; // kết quả mong đợi
            Assert.IsFalse(act_Triangle, "Sai roi ne"); // hàm so sánh
        }

        [TestMethod]
        public void VB1()
        {
            UnitTestBDCL1.CheckLeapYear clsLeapYear = new UnitTestBDCL1.CheckLeapYear();
            bool act_Triangle = clsLeapYear.IsLeapYear(1582);//Kết quả thực a,b,c=3
                                                             // bool exp_Triangle = true; // kết quả mong đợi
            Assert.IsFalse(act_Triangle, "Sai roi ne"); // hàm so sánh
        }
        [TestMethod]
        public void VB2()
        {
            UnitTestBDCL1.CheckLeapYear clsLeapYear = new UnitTestBDCL1.CheckLeapYear();
            bool act_Triangle = clsLeapYear.IsLeapYear(1583);//Kết quả thực a,b,c=3
                                                             // bool exp_Triangle = true; // kết quả mong đợi
            Assert.IsFalse(act_Triangle, "Sai roi ne"); // hàm so sánh
        }
        [TestMethod]
        public void IVB()
        {
            UnitTestBDCL1.CheckLeapYear clsLeapYear = new UnitTestBDCL1.CheckLeapYear();
            bool act_Triangle = clsLeapYear.IsLeapYear(1281);//Kết quả thực a,b,c=3
                                                         // bool exp_Triangle = true; // kết quả mong đợi
            Assert.IsFalse(act_Triangle, "Sai roi ne"); // hàm so sánh
        }

    }
}
