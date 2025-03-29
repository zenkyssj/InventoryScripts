using UnityEngine;

namespace Nocturna.Player.Inventory
{
    [CreateAssetMenu(fileName = "New ImportantObjectItem", menuName = "Inventory/ImportantObjectItem")]
    public class ImportantObjectItem : BaseItem
    {
        public bool isBreakable;

    }
}