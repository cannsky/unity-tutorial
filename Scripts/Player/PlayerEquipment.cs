using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerEquipment
{
    public enum SlotType { Armor, Weapon }

    [System.Serializable]
    public class PlayerEquipmentSlot
    {
        public SlotType slotType;
        public Item item;
    }

    public List<PlayerEquipmentSlot> slots;

    public GameObject weaponSlot;

    public void OnStart()
    {
        Equip(Player.Instance.playerInventory.slots[0].item);
    }

    public bool Equip(Item equipItem)
    {
        if (equipItem is Sword)
        {
            Debug.Log("asdasdasd");
            weaponSlot.transform.GetChild(0).GetChild(equipItem.index).gameObject.SetActive(true);
            foreach (PlayerEquipmentSlot playerEquipmentSlot in slots)
            {
                if(playerEquipmentSlot.slotType == SlotType.Weapon)
                {
                    playerEquipmentSlot.item = equipItem;
                }
            }
            return true;
        }
        else return false;
    }
}
