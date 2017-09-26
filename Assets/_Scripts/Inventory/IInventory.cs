
namespace Inventory 
{
	public interface IInventory 
	{
		Item GetItem(ItemType type);
		bool AddItem(Item item);
		bool RemoveItem(ItemType type);
		bool RemoveItem(Item item);
		bool IsEmpty();
		bool IsFull();
		int GetCapacity();
        void SetCapacity(int capacity);
		int GetNumItems();
		void ViewInventory();
	}
}
