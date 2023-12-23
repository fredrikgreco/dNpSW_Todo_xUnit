using Models_Todo;

namespace pNdSW_Todo_Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test_Create_Note()
        {
            // Arrange - Set up the test scenario
            int expectedId = 1;
            string expectedContent = "Sample Todo Content";

            // Act - Perform the action that should be tested
            Todo todo = new Todo
            {
                Id = expectedId,
                Content = expectedContent
            };

            // Assert - Verify the expected result
            Assert.Equal(expectedId, todo.Id);
            Assert.Equal(expectedContent, todo.Content);
        }
    }
}