using CalculatorApi;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace CalculatorTesting
{
    [TestClass]
    public class UnitTest1
    {
        /*

        [TestMethod]
        public void Add_WhenCalled_LogsMessageAndSum()
        {
            // Arrange
            var diagnosticsMock = new Mock<IDiagnostics>();
            Calculator calculator = new Calculator(diagnosticsMock.Object);

            // Act
            int result = calculator.Add(5, 3);

            // Assert
            diagnosticsMock.Verify(d => d.Log("Adding 3 to 5"), Times.Once);
            Assert.AreEqual(8, result);
        }
        [TestMethod]
        public void Subtract_WhenCalled_LogsMessageAndSum()
        {
            // Arrange
            var diagnosticsMock = new Mock<IDiagnostics>();
            Calculator calculator = new Calculator(diagnosticsMock.Object);

            // Act
            int result = calculator.Subtract(10, 4);

            // Assert
            diagnosticsMock.Verify(d => d.Log("Subtracting 4 from 10"), Times.Once);
            Assert.AreEqual(6, result);
        }
        [TestMethod]
        public void Multiply_WhenCalled_LogsMessageAndSum()
        {
            // Arrange
            var diagnosticsMock = new Mock<IDiagnostics>();
            Calculator calculator = new Calculator(diagnosticsMock.Object);

            // Act
            int result = calculator.Multiply(3, 7);

            // Assert
            diagnosticsMock.Verify(d => d.Log("Multiplying 3 by 7"), Times.Once);
            Assert.AreEqual(21, result);
        }
        [TestMethod]
        public void Divide_WhenCalled_LogsMessageAndSum()
        {
            // Arrange
            var diagnosticsMock = new Mock<IDiagnostics>();
            Calculator calculator = new Calculator(diagnosticsMock.Object);

            // Act
            int result = calculator.Divide(20, 4);

            // Assert
            diagnosticsMock.Verify(d => d.Log("Dividing 20 by 4"), Times.Once);
            Assert.AreEqual(5, result);
        }

        */

        /*[TestMethod]
        public void TestAdd()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Add(5, 3);
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void TestSubtract()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Subtract(10, 4);
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void TestMultiply()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Multiply(3, 7);
            Assert.AreEqual(21, result);
        }

        [TestMethod]
        public void TestDivide()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Divide(15, 3);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivideByZero()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Divide(10, 0);
        }*/
    }
}
