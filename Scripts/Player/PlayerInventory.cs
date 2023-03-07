using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerInventory
{
    [SerializeField] public int maxSlotSize = 25, lockedSlotSize = 20;

    [System.Serializable]
    public class PlayerInventorySlot
    {
        public Item item;
    }

    public List<PlayerInventorySlot> slots;
}
