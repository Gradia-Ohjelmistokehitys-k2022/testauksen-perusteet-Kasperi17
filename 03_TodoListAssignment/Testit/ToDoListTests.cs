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
            TodoTask addTask1 = new TodoTask("milo");
            
            

            //Act
            todoList.AddItemToList(addTask);
            todoList.AddItemToList(addTask1);
            
            //Assert
            Assert.AreEqual(2, todoList._TodoItems.Count);

            
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
           
        }
        [TestMethod]
        public void CompleteItem()
        {
            TodoList todoList = new TodoList();
            TodoTask task = new TodoTask("hakkaa Jorma");
            todoList.AddItemToList(task);

            // Act
            todoList.CompleteItem(task.Id);

            // Assert
            TodoTask completedTask = todoList._TodoItems.FirstOrDefault(t => t.Id == task.Id);
            Assert.IsNull(completedTask); 
        }
    }
}