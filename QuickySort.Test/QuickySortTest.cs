using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickySortTesting;

namespace QuickySort.Test
{
    [TestClass]
    public class QuickySortTest
    {
        [TestMethod]
        public void SortArrayOfThree()
        {
            var array = Program.GenerateArray(3);
            Program.HoareSort(array);
            Assert.IsTrue(array[1] > array[0] && array[2]>array[1]);

        }

        [TestMethod]
        public void SortOfHundredEqualElements()
        {
            var array = new int[100];
            for (int i = 0; i < array.Length; i++)
                array[i] = 1;
            Program.HoareSort(array);
        
            for (int i = 0; i < array.Length; i++)
                Assert.AreEqual(array[i], 1);

        }
        [TestMethod]
        public void SortOfThousandRandovElements()
        {
            var array = Program.GenerateArray(1000);
            Program.HoareSort(array);
            var random = new Random(54);
            for (int i = 0; i < 10 ; i++)
            {
                var x = random.Next(1000);
                var y = random.Next(1000);
                while (x < y)
                {
                    x = random.Next(1000);
                    y = random.Next(1000);
                }
                Assert.IsTrue(array[x] >= array[y]);
                
            }
        }
        [TestMethod]
        public void SortOfEmptyArray()
        {
            var array = new int[] { };
            Program.HoareSort(array);

        }
        [TestMethod]
        public void SortOfBillionsElements()
        {
            var array = Program.GenerateArray(1500000000);
            Program.HoareSort(array);
            for (var i = 1; i < array.Length; i++)
                Assert.IsTrue(array[i - 1] < array[i]);
        }
    }
    
}
