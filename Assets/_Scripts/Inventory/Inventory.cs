using System.Collections.Generic;

namespace Inventory
{
    public class Inventory : IInventory
    {

        public const int DEFAULT_CAPACITY = 10;

        private Dictionary<ItemType, Item> items = new Dictionary<ItemType, Item>();
        private int capacity = DEFAULT_CAPACITY;

        public Item GetItem(ItemType type)
        {
            if (!items.ContainsKey(type))
            {
                return null;
            }
            return items[type];
        }

        public bool AddItem(Item item)
        {
            if (IsFull() || items.ContainsKey(item.GetItemType()))
            {
                return false;
            }
            items[item.GetItemType()] = item;
            return true;
        }

        public bool RemoveItem(ItemType type)
        {
            if (!items.ContainsKey(type))
            {
                return false;
            }
            items.Remove(type);
            return true;
        }

        public bool RemoveItem(Item item)
        {
            return RemoveItem(item.GetItemType());
        }

        public bool IsEmpty()
        {
            return items.Count == 0;
        }

        public bool IsFull()
        {
            return items.Count == capacity;
        }

        public int GetCapacity()
        {
            return capacity;
        }

        public void SetCapacity(int capacity)
        {
            this.capacity = capacity;
        }

        public int GetNumItems()
        {
            return items.Count;
        }

        public void ViewInventory()
        {
            // TODO
        }
    }
}