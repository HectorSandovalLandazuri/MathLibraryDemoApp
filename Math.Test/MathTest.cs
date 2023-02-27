using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math.Test
{
    
    internal class MathTest
    {
        [Fact]
        public void Add()
        {
            DisplayMessages messages = new DisplayMessages();
            //Arrange
            string expected = "Good Morning Héctor";
            //Act
            string actual = messages.Greeting("Héctor", 2);
            //assert
            Assert.Equal(expected, actual);
        }

    }
}
