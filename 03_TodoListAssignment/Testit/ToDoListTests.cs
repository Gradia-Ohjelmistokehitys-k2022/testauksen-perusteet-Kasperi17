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
            TodoTask addTask = new TodoTask("kullervo tanssii");
            
            
            

            //Act
            todoList.AddItemToList(addTask);
            
            
            //Assert
            Assert.AreEqual(1, todoList._TodoItems.Count);

            
        }
        [TestMethod]
        public void AddItemToList_TestAddTwoItemToList()
        {   //Arrange
            TodoList todoList = new TodoList();
            TodoTask addTask = new TodoTask("kullervo tanssii");
            TodoTask addTask1 = new TodoTask("milo menee vessaa");



            //Act
            todoList.AddItemToList(addTask);
            todoList.AddItemToList(addTask1);

            //Assert
            Assert.AreEqual(2, todoList._TodoItems.Count);


        }
        public void AddItemToList_ListIsEmpty()
        {   //Arrange
            TodoList todoList = new TodoList();
            TodoTask addTask = new TodoTask("kullervo tanssii");
            TodoTask addTask1 = new TodoTask("");
            



            //Act

           

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
        public void RemoveItemFromList_RemovesTwoItemsFromList()
        {
            // Arrange
            TodoList todoList = new TodoList();
            TodoTask task = new TodoTask("Ryöstä Jorma");
            TodoTask task2 = new TodoTask("Pelasta Matti");
            todoList.AddItemToList(task);
            todoList.AddItemToList(task2);

            // Act
            todoList.RemoveItemFromList(task);
            todoList.RemoveItemFromList(task2);

            // Assert
            Assert.AreEqual(0, todoList._TodoItems.Count);

        }
        [TestMethod]
        public void RemoveItemFromList_RemovesItemFromEmptyList()
        {
            // Arrange
            TodoList todoList = new TodoList();
            TodoTask task = new TodoTask("");
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
            //Assert.IsNull(todoList);
        }
        
        


    }
}