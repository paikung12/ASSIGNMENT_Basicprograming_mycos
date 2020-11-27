using System;
using Classlibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Unit_test
{
 
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1_IsArmstrongNumber()
        {
            //Arrange
            Class1 class1 = new Class1();
            //Act
            // check for armstrong
            int x = 371;
            int result = class1.ArmstrongNumber(x);
            //Assert
            Assert.AreEqual(371, result);
        }
        [TestMethod]
        public void TestMethod1_IsStrongNumber()
        {
            //Arrange 
            Class1 class1 = new Class1();
            //Act
            int x = 145;
            int result = class1.StrongNumber(x);
            //Assert
            Assert.AreEqual(145, result);
        }
        [TestMethod]
        public void TestMethod1_NotStrongNumber()
        {
            //Arrange 
            Class1 class1 = new Class1();
            //Act
            int x = 123;
            int result = class1.StrongNumber(x);
            //Assert
            Assert.AreEqual(9, result);
        }

        [TestMethod]
        public void TestMethod1_RemoveVowels()
        {
            //Arrange 
            Class1 class1 = new Class1();
            //Act
            string text = "faceprep";
            string result = class1.RemoveVowels(text);
            //Assert
            Assert.AreEqual("fcprp", result);
        }

        [TestMethod]
        public void TestMethod1_RemoveParentheses()
        {
            //Arrange 
            Class1 class1 = new Class1();
            //Act
            string text = "x-(p+q)+(y-a)";
            string result = class1.RemoveParentheses(text);
            //Assert
            Assert.AreEqual("x-p+q+y-a", result);
        }
        [TestMethod]
        public  void ArrayRotation()
        {
            //Arrange
            Class1 class1 = new Class1();
            int[] arr = { 1, 3, 5, 7, 9, 11 };
            int[] sorted = { 3, 5, 7, 9, 11,1 };
            //Act 
            int[] result = class1.ArrayRotation(arr);
            //Assert
            Assert.AreEqual(sorted, result);
        }
        [TestMethod]
        public void print2Smallest()
        {
            //Arrange
            Class1 class1 = new Class1();
            int[] nums = { 2, 8, 10, 1, 6, 9 };

            //Act
            int num = class1.Thesecondsmallest(nums);

            //Assert
            Assert.AreEqual(2, num);
        }

    }

   
}


