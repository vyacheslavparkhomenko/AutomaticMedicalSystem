using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutomaticMedicalSystem;
using System.Text.RegularExpressions;

namespace UnitTestProject_AMs
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Departments d = new Departments();
            int k = 64;
            int expected = d.max_id(ref k);
            Assert.AreEqual(67, expected);
        }

        [TestMethod]
        public void select_id_test()
        {
            Departments d = new Departments();
            int k = 64;
            int expected = d.select_id();
            Assert.AreEqual(69, expected);
        }

        [TestMethod]
        public void set_width_columns()
        {
            Departments d = new Departments();
            int expected = d.set_width_column();
            Assert.AreEqual(300, expected);
        }

        [TestMethod]
        public void datetime()
        {
            bool z=true;
            bool expected = true;
            string str = "31/02/2017";
            string pattern=@"/";
            string[] sub_str = Regex.Split(str, pattern);
           
            if (sub_str[0].CompareTo("31") <= 0 && sub_str[0].CompareTo("01") >= 0)
                z = true;
            else
                z = false;

            if (String.CompareOrdinal("00", sub_str[1]) < 0 && "13".CompareTo(sub_str[1])>=0)
                z &= true;
            else
                z &= false;
            if (Convert.ToInt32(sub_str[2])<0)
                z &= false;
            else
                z &= true;
            expected = z;
            Assert.AreEqual(expected, true);
        }
    }
}
