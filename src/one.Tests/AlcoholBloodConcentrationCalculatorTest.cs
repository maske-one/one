using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using one.Shared;

namespace one.Tests
{
    [TestClass]
    public class AlcoholBloodConcentrationCalculationTest
    {
        [TestMethod]
        [DataRow(Genders.Male, 18, 180, 75,10,5, 0, 0.67)]
        [DataRow(Genders.Female, 18, 165, 60, 5, 5, 0, 0.5)]
        public void BasicCalculation(Genders gender, int age, double height, double weight, double deciliter, double percent, int fullness, double expectedResult)
        {
            // arrange
            var calculator = new AlcoholBloodConcentrationCalculation(gender,age,height,weight,deciliter,percent,fullness) ;

            // act
            var result = calculator.Result;

            // assert
            result.Should().BeApproximately(expectedResult, 0.1);
        }
    }

}
