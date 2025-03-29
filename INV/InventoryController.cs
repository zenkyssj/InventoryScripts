using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

namespace Nocturna.Player.Inventory
{
    public class InventoryController : MonoBehaviour
    {
        private Dictionary<System.Type, List<BaseItem>> _inventory = new Dictionary<System.Type, List<BaseItem>>(); // Crea el diccionario que guarda los Items.

        public static InventoryController Instance { get; private set; }

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }

        public void AddItem(BaseItem newItem) // Funcion que agrega items al inventario.
        {
            System.Type itemType = newItem.GetType();

            if (!_inventory.ContainsKey(itemType))
            {
                _inventory[itemType] = new List<BaseItem>();
            }

            _inventory[itemType].Add(newItem);

            Debug.Log($"Objeto agregado al inventario: {newItem.name} ({itemType.Name})");
            Debug.Log($"Descripcion: {newItem.Description}");
           
        }

        public bool HasItem<T>() where T : BaseItem
        {
            System.Type itemType = typeof(T);

            return _inventory.ContainsKey(itemType) && _inventory[itemType].Count > 0;
        }

        public void RemoveItem(BaseItem item) // Funcion que elimina Items del inventario.
        {
            System.Type itemType = item.GetType();

            if(_inventory.ContainsKey(itemType) )
            {
                _inventory[itemType].Remove(item);
                if(_inventory[itemType].Count == 0)
                {
                    _inventory.Remove(itemType);
                }

                Debug.Log($"Objeto eliminado del inventario: {item.name}");
            }
        }

        public List<BaseItem> GetItemsByType<T>() where T : BaseItem // Funcion que obtiene los items por su tipo.
        {
            System.Type itemType = typeof(T);
            return _inventory.ContainsKey(itemType) ? _inventory[itemType] : new List<BaseItem>();
        }
    }
}