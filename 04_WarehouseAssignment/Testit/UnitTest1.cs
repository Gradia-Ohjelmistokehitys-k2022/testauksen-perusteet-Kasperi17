using WareHouse;
namespace Testit
{
    [TestClass]
    public class WareHouseTests
    {
        [TestMethod]
        public void WareHouseSimulator_1()
        {
            // Arrange
            WareHouseClass wareHouse = new WareHouseClass();

            // Act
            wareHouse.WareHouseSimulator();

            // Assert
            // Oletetaan, ett‰ varastossa pit‰isi olla tietty m‰‰r‰ alustavia tuotteita
            Assert.AreEqual(2, wareHouse.StockCount("Hat")); // Oletetaan, ett‰ Hat-tuotteita on 2
            Assert.AreEqual(3, wareHouse.StockCount("Shoes")); // Oletetaan, ett‰ Shoes-tuotteita on 3
            Assert.AreEqual(5, wareHouse.StockCount("Jacket")); // Oletetaan, ett‰ Jacket-tuotteita on 5
        }
    }
}