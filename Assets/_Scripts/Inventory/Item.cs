namespace Inventory
{
	public class Item 
	{
        private ItemType itemType;

        public ItemType GetItemType()
        {
            return itemType;
        }

        public void SetItemType(ItemType itemType)
        {
            this.itemType = itemType;
        }
    }
}
