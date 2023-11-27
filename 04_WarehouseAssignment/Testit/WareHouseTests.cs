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
        public void WareHouseSimulator()
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
        public void InStock()
        {
            // Arrange
            WareHouseClass wareHouse = new WareHouseClass();
            wareHouse.WareHouseSimulator();
            // Act
            var moi = wareHouse.InStock("Hat");
            // Assert
            Assert.IsTrue(moi);
        }
        [TestMethod]

    }
}