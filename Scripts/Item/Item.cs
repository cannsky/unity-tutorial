using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : ScriptableObject
{
    [Header("Item Settings")]
    public int id;
    public int index;
    public string itemName;
    public string itemDescription;
    public Sprite itemIcon;
}
