using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class InventoryManager : MonoBehaviour
{
    public List<Item> playerInventory = new List<Item>();



    public void AddItem(Item item)
    {
        playerInventory.Add(item);
    }


    public void RemoveItem(Item item)
    {
        playerInventory.Remove(item);
    }
}
