using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Entity {


    public Inventory inventory;
    public Item currentItem;


    public override void Initialize()
    {
        inventory.Add(new Weapon("Sword", 10, false, 1.5f, true));
    }
}
