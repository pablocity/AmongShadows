using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Entity {


    public Inventory inventory;
    public Item currentItem;

    public void Attack()
    {

        if (currentItem != null)
        {
            currentItem.UseItem();
        }
        else
        {
            Debug.Log("You have neither weapon nor item!");
        }
        
    }




    public override void Initialize()
    {
        inventory.Add(new Weapon("Sword", 10, false));
    }
}
