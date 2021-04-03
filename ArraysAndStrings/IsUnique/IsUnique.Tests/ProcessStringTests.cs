using IsUnique.Console;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace IsUnique.Tests
{
    [TestClass]
    public class ProcessStringTests
    {
        [TestMethod]
        public void GivenAString_WhenAllCharUnique_ThenReturnTrue_()
        {
            // Arrange
            ProcessString processString = new ProcessString();
            var input = string.Empty;

            // Act
            var result = processString.HasDuplicates(input);

            // Assert
            Assert.IsTrue(result);

        }
    }
}
