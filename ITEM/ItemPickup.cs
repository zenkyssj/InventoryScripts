
using UnityEngine;

namespace Nocturna.Player.Inventory
{
    public class ItemPickup : MonoBehaviour
    {
        public BaseItem Item;       

        public void PickUp()
        {                        
            if(InventoryController.Instance == null)
            {
                Debug.LogError("InventoryController.Instance es NULL");
                return;
            }
            if (Item == null)
            {
                Debug.LogError("El Item es NULL en ItemPickup.cs");
                return;
            }

            InventoryController.Instance.AddItem(Item);          
            Destroy(gameObject);
        }

    }
}