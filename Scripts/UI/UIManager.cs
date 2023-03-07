using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject itemPrefab;

    public void Start()
    {
        foreach(PlayerInventory.PlayerInventorySlot inventorySlot in Player.Instance.playerInventory.slots)
        {
            GameObject slotGameObject = Instantiate(itemPrefab, transform);
            slotGameObject.transform.GetChild(0).GetChild(0).GetComponent<Image>().sprite = inventorySlot.item.itemIcon;
        }
    }
}
