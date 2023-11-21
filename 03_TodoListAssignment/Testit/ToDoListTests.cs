using TestingTodoListApp;

namespace Testit
{
    [TestClass]
    public class ToDoListTests
    {
        [TestMethod]
        public void AddItemToList_AddItemToList()
        {   //Arrange
            TodoList todoList = new TodoList();
            TodoTask addTask = new TodoTask("kullervo");
            

            //Act
            todoList.AddItemToList(addTask);
            
            //Assert
            Assert.AreEqual(1, todoList._TodoItems.Count);
            Assert.AreEqual(1, addTask.Id); 
            Assert.AreEqual(1, todoList._taskCounter);
        }
    }
}