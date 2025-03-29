using UnityEngine;

namespace Nocturna.Player.Inventory
{
    [CreateAssetMenu(fileName = "New NoteItem", menuName = "Inventory/NoteItem")]
    public class NoteItem : BaseItem
    {
        [TextArea] public string NoteText;


    }
}