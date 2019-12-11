using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Zoo.lib;

namespace Zoo.test
{
    public class LionTest
    {
        [Fact]
        public void Declare_LionWithNameOnly_HasCorrectName()
        {
            // Arrange
            Lion lion;

            // Act
            var name = "A";
            lion =  new Lion(name);
            var actual = lion.Name;
            var expected = (name);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
