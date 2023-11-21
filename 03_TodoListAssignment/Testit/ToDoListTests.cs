using TestingTodoListApp;

namespace Testit
{
    [TestClass]
    public class ToDoListTests
    {
        [TestMethod]
        public void AddItemToList_TestAddItemToList()
        {   //Arrange
            TodoList todoList = new TodoList();
            TodoTask addTask = new TodoTask("kullervo");
            

            //Act
            todoList.AddItemToList(addTask);
            
            //Assert
            Assert.AreEqual(1, todoList._TodoItems.Count);
            
        }
        [TestMethod]
        public void RemoveItemFromList_RemovesItemFromList()
        {
            // Arrange
            TodoList todoList = new TodoList();
            TodoTask task = new TodoTask("Jorma");
            todoList.AddItemToList(task); 

            // Act
            todoList.RemoveItemFromList(task);

            // Assert
            Assert.AreEqual(0, todoList._TodoItems.Count); 
            Assert.AreEqual(0, todoList._taskCounter);    
           
        }
    }
}