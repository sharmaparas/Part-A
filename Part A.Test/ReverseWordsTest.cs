using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_A.Test
{
    public class ReverseWordsTest
    {
        [Fact]
        public void CheckReverseWordsFunction()
        {
            //Arrange
            var testString1 = "Cat and dog";
            //Act
            var result1 = Helper.ReverseWords(testString1);
            //Assert
            Assert.True(result1 == "taC dna god");
        }
    }
}
