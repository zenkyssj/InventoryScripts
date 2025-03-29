using UnityEngine;

namespace Nocturna.Player.Inventory
{
    public abstract class BaseItem : ScriptableObject
    {
        public string ItemName;
        public string Description;
        //public abstract void Use(); // Metodo abstracto que sera sobreescrito por cada tipo de Item.
    }
}