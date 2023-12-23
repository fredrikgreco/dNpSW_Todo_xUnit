using Microsoft.EntityFrameworkCore;
using Models_Todo;
using pNdSW_Todo.Repo;

namespace pNdSW_Todo_Tests
{
    public class TodoTestCreateNote
    {
/*        [Fact]
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
        }*/

        [Fact]
        public void Should_Return_Detailed_Todo()
        {

        }

        [Fact]
        public void Should_Add_Todo_To_Database()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<TodoContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;

            using (var context = new TodoContext(options))
            {
                var repository = new TodoRepo(context);

                // Act
                repository.AddTodo(
                    
                    new Todo 
                    {
                        Id = 1,
                        Title = "New",
                        Content = "Test Todo Content",
                        IsDone = true,
                        IsDeleted = false
                    });

                // Assert
                var addedTodo = context.Todos.Find(1);
                Assert.NotNull(addedTodo);
                Assert.Equal(1, addedTodo.Id);
                Assert.Equal("New", addedTodo.Title);
                Assert.Equal("Test Todo Content", addedTodo.Content);
                Assert.True(addedTodo.IsDone);
                Assert.False(addedTodo.IsDeleted);
            }
        }
    }
}
