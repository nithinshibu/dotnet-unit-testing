using UnitTests.Units;

namespace UnitTests.Tests
{
    public class TodoListTests
    {
        [Fact]
        public void Add_SavesTodoItem()
        {
            //arrange

            var list = new TodoList();

            //act


            list.Add(new("Test Content"));

            //assert

            //Assert.Single(list.All); is an xUnit assertion used in a unit test to verify that a collection contains exactly one element.

            //Assert.Single:

            /*

            This method checks that a given collection has exactly one item.
            If the collection contains more than one item or is empty, the test will fail.
            list.All:

            In the context of the provided TodoList class, list.All is an IEnumerable<TodoItem> that exposes all the TodoItem objects in the _todoItems list.

            */

            var savedItem = Assert.Single(list.All);

            Assert.NotNull(savedItem);
            Assert.Equal("Test Content", savedItem.Content);

        }
    }
}
