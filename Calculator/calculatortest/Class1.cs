using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Calculator;

namespace calculatortest
{
    public class Class1
    {
        [TestFixture]
        class CalcTests
        {
            [Test]
            public void
                GetAddition_Input4point4and3point6_Returns8point0()
            {
                //Arrange
                double number1 = 4.4;
                double number2 = 3.6;
                double expectedResult = number1 + number2;
                Calc testCalc = new Calc(number1, number2);
                //Act
                double actualResult = testCalc.GetAddition();
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void
            GetAddition_Inputminus7point2and4point5_Returnsminus2point7()
            {
                //Arrange
                double number1 = -7.2;
                double number2 = 4.5;
                double expectedResult = number1 + number2;
                Calc testCalc = new Calc(number1, number2);
                //Act
                double actualResult = testCalc.GetAddition();
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void
            GetAddition_Input2point2and8point6_Returns11point8()
            {
                //Arrange
                double number1 = 2.2;
                double number2 = 9.6;
                double expectedResult = number1 + number2;
                Calc testCalc = new Calc(number1, number2);
                //Act
                double actualResult = testCalc.GetAddition();
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void
                GetSubtraction_Input5and4_Returnspoint4()
            {
                //Arrange
                double number1 = 5;
                double number2 = 4;
                double expectedResult = number1 - number2;
                Calc testCalc = new Calc(number1, number2);
                //Act
                double actualResult = testCalc.GetSubtraction();
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void
              GetSubtraction_Input2point4and1point2_Returns1point2()
            {
                //Arrange
                double number1 = 2.4;
                double number2 = 1.2;
                double expectedResult = number1 - number2;
                Calc testCalc = new Calc(number1, number2);
                //Act
                double actualResult = testCalc.GetSubtraction();
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void
              GetSubtraction_Input4point7and2point1_Returns3point3()
            {
                //Arrange
                double number1 = 4.7;
                double number2 = 1.2;
                double expectedResult = number1 - number2;
                Calc testCalc = new Calc(number1, number2);
                //Act
                double actualResult = testCalc.GetSubtraction();
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void
            GetMultipilication_Input4point4and3point3_Returns14point85()
            {
                //Arrange
                double number1 = 4.5;
                double number2 = 3.3;
                double expectedResult = number1 * number2;
                Calc testCalc = new Calc(number1, number2);
                //Act
                double actualResult = testCalc.GetMultiplication();
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }


            [Test]
            public void
        GetMultipilication_Input2point9and5point9_Returns17point11()
            {
                //Arrange
                double number1 = 2.9;
                double number2 = 5.9;
                double expectedResult = number1 * number2;
                Calc testCalc = new Calc(number1, number2);
                //Act
                double actualResult = testCalc.GetMultiplication();
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void
        GetMultipilication_Input9point8and4point3_Returns42point14()
            {
                //Arrange
                double number1 = 9.8;
                double number2 = 4.3;
                double expectedResult = number1 * number2;
                Calc testCalc = new Calc(number1, number2);
                //Act
                double actualResult = testCalc.GetMultiplication();
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void
    GetDivision_Input42point0and8point0_Returns7point0()
            {
                //Arrange
                double number1 = 56.0;
                double number2 = 8.0;
                double expectedResult = number1 / number2;
                Calc testCalc = new Calc(number1, number2);
                //Act
                double actualResult = testCalc.GetDivision();
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void
    GetDivision_Input81point0and9point0_Returns9point0()
            {
                //Arrange
                double number1 = 81.0;
                double number2 = 9.0;
                double expectedResult = number1 / number2;
                Calc testCalc = new Calc(number1, number2);
                //Act
                double actualResult = testCalc.GetDivision();
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void
    GetDivision_Input8point0and2point0_Returns4()
            {
                //Arrange
                double number1 = 8.0;
                double number2 = 2.0;
                double expectedResult = number1 / number2;
                Calc testCalc = new Calc(number1, number2);
                //Act
                double actualResult = testCalc.GetDivision();
                //Assert
                Assert.AreEqual(expectedResult, actualResult);

            }
        }
    }
}