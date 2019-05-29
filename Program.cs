using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROG8170_Assignment1;
using NUnit.Framework;

namespace PROG8170_Assignment1_Test
{
    [TestFixture]
    class PROG8170_Assignment1_Test
    {
        [Test]
        public void GetLength_Input25_Returns25()
        {

            //Arrange
            int length = 25;
            int width = 13;

            int expectedResult = length;

            Rectangle testRectangle = new Rectangle(length, width);

            //Act 
            double actualResult = testRectangle.GetLength();

            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetWidth_Input33_Returns33()
        {

            //Arrange
            int length = 13;
            int width = 40;

            int expectedResult = width;

            Rectangle testRectangle = new Rectangle(length, width);

            //Act 
            double actualResult = testRectangle.GetWidth();

            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }



        static void Main(string[] args)
        {

        }

    }
}
