using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Entity {


    public Inventory inventory;
    public Item currentItem;


    public void Initialize()
    {
        inventory = ScriptableObject.CreateInstance<Inventory>();
        inventory.Add(new Weapon("Sword", 10, false, 0.35f, true));
        currentItem = inventory.Choose(0);
    }
}
