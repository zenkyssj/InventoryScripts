using UnityEngine;

namespace Nocturna.Player.Inventory
{
    public class InventoryItem
    {

        public BaseItem _baseItem;
        public int _quantity;

        public InventoryItem(BaseItem newItem, int amount)
        {
            _baseItem = newItem;
            _quantity = amount;
        }
    }

}