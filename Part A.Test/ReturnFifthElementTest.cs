namespace Part_A.Test
{
    public class ReturnFifthElementTest
    {
        [Fact]
        public void CheckReturnFifthElementFunction()
        {
            //Arrange
            var baseTestlist = new List<int> { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            var testList1 = new LinkedList<int>(baseTestlist);
            baseTestlist.Add(12);
            baseTestlist.Add(13);
            var testList2 = new LinkedList<int>(baseTestlist);
            //Act
            var testResult1 = Helper.ReturnFifthElement(testList1);
            var testResult2 = Helper.ReturnFifthElement(testList2);
            //Assert
            Assert.True(testResult1 == 7);
            Assert.True(testResult2 == 9);
        }
        [Fact]
        public void CheckExceptionsForReturnFifthElement()
        {
            //Arrange
            var invalidList1 = new LinkedList<int>(new List<int> { 1, 2, 3 });
            //Act & Assert
            Assert.Throws<Exception>(() => Helper.ReturnFifthElement(invalidList1));
        }
    }
}