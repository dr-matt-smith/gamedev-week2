using NUnit.Framework;

namespace Inventory
{
    [TestFixture]
    internal class TestInventory
    {
        [Test]
        public void IsEmptyReturnsTrueWithNewInventory()
        {
            Inventory inventory = new Inventory();

            bool isEmpty = inventory.IsEmpty();

            Assert.IsTrue(isEmpty);
        }

        [Test]
        public void IsEmptyReturnsFalseWithFullInventory()
        {
            Inventory inventory = new Inventory();
            inventory.SetCapacity(1);
            Item item = new Item();
            item.SetItemType(ItemType.BLUE_KEY);
            inventory.AddItem(item);

            bool isEmpty = inventory.IsEmpty();

            Assert.IsFalse(isEmpty);
        }

        [Test]
        public void IsFullReturnsFalseWithNewInventory()
        {
            Inventory inventory = new Inventory();

            bool isFull = inventory.IsFull();

            Assert.IsFalse(isFull);
        }

        [Test]
        public void IsFullReturnsTrueWithFullInventory()
        {
            Inventory inventory = new Inventory();
            inventory.SetCapacity(1);
            Item item = new Item();
            item.SetItemType(ItemType.BLUE_KEY);
            inventory.AddItem(item);

            bool isFull = inventory.IsFull();

            Assert.IsTrue(isFull);
        }
    }
}
