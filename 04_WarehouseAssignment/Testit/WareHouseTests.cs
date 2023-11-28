using System.Runtime.InteropServices;
using WareHouse;
namespace Testit
{
    [TestClass]
    public class WareHouseTests
    {
        [TestMethod]
        public void WareHouseSimulator_CreatesWareHouse_OfItems()
        {
            // Arrange
            WareHouseClass wareHouse = new WareHouseClass();

            // Act
            wareHouse.WareHouseSimulator();

            // Assert
            Assert.AreEqual(2, wareHouse.StockCount("Hat"));
            Assert.AreEqual(3, wareHouse.StockCount("Shoes"));
            Assert.AreEqual(5, wareHouse.StockCount("Jacket"));
        }
        [TestMethod]
        public void WareHouseSimulator_Check_If_WareHouse_IsNull()
        {
            WareHouseClass wareHouse = new WareHouseClass();

            wareHouse.WareHouseSimulator();

            Assert.IsNotNull(wareHouse);
        }

        [TestMethod]
        public void TakeFromStock_DecreaseItem_Amount()
        {
            // Arrange
            WareHouseClass wareHouse = new WareHouseClass();
            wareHouse.WareHouseSimulator();
            // Act
            wareHouse.TakeFromStock("Shoes", 2);

            // Assert
            Assert.AreEqual(1, wareHouse.StockCount("Shoes"));
        }
        [TestMethod]
        public void TakeFromStock_IfItemIs_Oversold_ThrowsException()
        {
            // Arrange
            WareHouseClass wareHouse = new WareHouseClass();
            wareHouse.WareHouseSimulator();

            // Assert 
            Assert.ThrowsException<Exception>(() => wareHouse.TakeFromStock("NonexistentItem", 1));
        }
        [TestMethod]
        public void TakeFromStock_DecreaseItem_AmountIfNegative_ThrowsException()
        {
            // Arrange
            WareHouseClass wareHouse = new WareHouseClass();
            wareHouse.WareHouseSimulator();

            // Act and Assert
            Assert.ThrowsException<Exception>(() => wareHouse.TakeFromStock("Shoes", 10));
        }
        [TestMethod]
        public void AddToStocks_Adds_ItemToStock()
        {
            // Arrange
            WareHouseClass wareHouse = new WareHouseClass();
            wareHouse.WareHouseSimulator();
            // Act
            wareHouse.AddToStocks("banaani", 2);
            //Assert
            Assert.AreEqual(2, wareHouse.StockCount("banaani"));
        }
        [TestMethod]
        public void AddSToStock_ChecksIf_wareHouse_IsNotNull()
        {
            // Arrange
            WareHouseClass wareHouse = new WareHouseClass();
            wareHouse.WareHouseSimulator();
            // Act
            wareHouse.AddToStocks("Banana", 2);
            //Assert
            Assert.IsNotNull(wareHouse);
        }
        [TestMethod]
        public void AddToStocks_IncreasesQuantity_WhenAddingSameItem()
        {
            // Arrange
            WareHouseClass wareHouse = new WareHouseClass();
            wareHouse.WareHouseSimulator();

            // Act
            wareHouse.AddToStocks("Hat", 3);  

            // Assert
            Assert.AreEqual(5, wareHouse.StockCount("Hat"));  
        }
        [TestMethod]
        public void InStock_Checks_If_ItemIs_InStock()
        {
            // Arrange
            WareHouseClass wareHouse = new WareHouseClass();
            wareHouse.WareHouseSimulator();
            // Act
            var tavarat = wareHouse.InStock("Hat");
            // Assert
            Assert.IsTrue(tavarat);
        }
        [TestMethod]
        public void InStocks_Checks_IfTwoItems_CanBeAt_Stock()
        {
            // Arrange
            WareHouseClass wareHouse = new WareHouseClass();
            wareHouse.WareHouseSimulator();
            // Act
            var tavara1 = wareHouse.InStock("Hat");
            var tavara2 = wareHouse.InStock("Jacket");
            // Assert
            Assert.IsTrue(tavara1);
            Assert.IsTrue(tavara2);
        }
        [TestMethod]
        public void Instock_FalseWhen_ItemIsNot_OnStock()
        {
            // Arrange
            WareHouseClass wareHouse = new WareHouseClass();
            wareHouse.WareHouseSimulator(); 

            // Act
            bool result = wareHouse.InStock("Gloves");  

            // Assert
            Assert.IsFalse(result, "Gloves are not in stock");

        }
        [TestMethod]
        public void StockCount_IncreaseItemAmount_OfItems()
        {
            // Arrange
            WareHouseClass wareHouse = new WareHouseClass();
            wareHouse.WareHouseSimulator();  
            wareHouse.AddToStocks("Hat", 5);

            // Act
            int count = wareHouse.StockCount("Hat");

            // Assert
            Assert.AreEqual(7, count, "Hats count should be 5");
        }
        [TestMethod]
        public void StockCount_Item_Exist()
        {
            // Arrange
            WareHouseClass wareHouse = new WareHouseClass();
            wareHouse.WareHouseSimulator();  

            // Act
            int count = wareHouse.StockCount("Shoes");

            // Assert
            Assert.AreEqual(3, count, "Shoes count should be 3");
        }
        [TestMethod]
        public void StockCount_Item_DoesNot_Exist()
        {
            // Arrange
            WareHouseClass wareHouse = new WareHouseClass();
            wareHouse.WareHouseSimulator(); 

            // Act
            int count = wareHouse.StockCount("Gloves");  

            // Assert
            Assert.AreEqual(0, count, "Gloves count should be 0");
        }
    }
}
