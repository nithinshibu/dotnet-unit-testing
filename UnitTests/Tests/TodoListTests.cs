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
            Assert.Equal(1, savedItem.Id);
            Assert.Equal("Test Content", savedItem.Content);
            Assert.False(savedItem.Complete);

        }

        //Different approach

        [Fact]
        public void TodoItemId_IncrementsEveryTimeWeAdd()
        {
            //arrange
            var list = new TodoList();

            //act
            list.Add(new("Test Content 1"));
            list.Add(new("Test Content 2"));

            //assert
            var items = list.All.ToArray();
            Assert.Equal(1, items[0].Id);  
            Assert.Equal(2, items[1].Id);  

        }

        [Fact]
        public void Complete_SetsTodoItemCompleteFlagToTrue()
        {
            //arrange
            var list = new TodoList();
            list.Add(new("Test Content 1"));


            //act

            list.Complete(1);

            //assert
           var completedItem = Assert.Single(list.All);
           Assert.NotNull(completedItem);
           Assert.Equal(1, completedItem.Id);
           Assert.Equal(true, completedItem?.Complete);


        }



    }
}
