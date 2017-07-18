using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : ScriptableObject
{
    public List<Item> items;

    public Inventory()
    {
        items = new List<Item>();
    }

    public void Add(Item itemToAdd)
    {
        items.Add(itemToAdd);
    }

    public void Remove(int itemId)
    {
        items.RemoveAt(itemId);
    }

    public Item Choose(int itemId)
    {
        return items[itemId];
    }
}
